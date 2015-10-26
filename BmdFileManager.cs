using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace BMDtoExcel
{

    class BmdFileManager
    {
        private byte[] bmdFileBytes = new byte[] { }; /* Array with bytes of BMD File*/
        private List<byte[]> loadBytes = new List<byte[]> { }; /* Array to divide bytes by Loads */

        private int loadCount = 0; /*Count of Loads*/

        public void readBmdFile(string path) /*Read BMD file*/
        {
            if (String.Compare(path, "") == 0)
            {
                MessageBox.Show("No BMD File Name !!!");
            }
            else
            {
                bmdFileBytes = File.ReadAllBytes(path);
            }

        }

        /*Get count of bytes in uploaded BMD file*/
        public int getBytesCount()
        {
            return this.bmdFileBytes.Length;
        }

        // Calculate count of loads in BMD file = bmdBytesCount/ (4 * 6 * 13 * beamMemberCount)
        // Result must be NOT decimal number
        // 4 - 4 bytes in FLOAT type
        // 6 - count of internal forces (FX, FY, FZ, MX, MY, MZ)
        // 13 - count of section in one beam
        public int calculateLoadCount(int beamMemberCount)
        {
            if (beamMemberCount == 0)
            {
                return 0;
            }

            int loadCount = this.getBytesCount() / (4 * 6 * 13 * beamMemberCount);

            //Check if loadCount is really Integer
            if (4 * 6 * 13 * loadCount * beamMemberCount == this.getBytesCount())
            {
                this.loadCount = loadCount;
                this.divideBytesByLoads();
                return loadCount;
            }
            else
            {
                MessageBox.Show("Error in BMD file !!!");
                return 0;
            }

        }

        // Check if load number correct or not
        public bool validateLoadNumber(int number)
        {
            if (number < 0 || (number + 1) > this.loadCount)
            {
                MessageBox.Show("Load number "+ number.ToString() +" is NOT correct !!!");
                return false;
            } else
            {
                return true;
            }

        }

        // Divide array of Bytes into array of array by Loads
        private void divideBytesByLoads()
        {
            if (this.loadCount == 0)
            {
                return;
            }

            // Clean array
            this.loadBytes.Clear();

            // Calculate how many bytes related to one load
            int bytesInLoad = this.getBytesCount() / this.loadCount;

            for (int i = 0; i < this.loadCount; i++)
            {
                byte[] newLoad = new byte[bytesInLoad];
                Array.Copy(this.bmdFileBytes, i * bytesInLoad, newLoad, 0, bytesInLoad);

                this.loadBytes.Add(newLoad);
            }

        }

        // Get bytes only for particular load
        public byte[] getBytesForLoad(int number)
        {
            if (!validateLoadNumber(number))
            {
                return new byte[] { };
            }

            return this.loadBytes[number];
        }

        // Save load to text file
        public void saveLoadToTextFile(int loadNumber, bool[] sections, int[] elementNumbers)
        {
            if (loadNumber > this.loadCount)
            {
                MessageBox.Show("Load Number > Count of Loads !!!");
                return;
            }

            if (sections.Length < 13)
            {
                MessageBox.Show("Section format is NOT correct !!!");
                return;
            }

            // Divide Loads Bytes
            this.divideBytesByLoads();

            // Prepare array of lines
            List<string> outText = new List<string> { };

            // Export
            for (int elementNumber = 0; elementNumber < elementNumbers.Length; elementNumber++)
            {
                for (int sectionNumber = 0; sectionNumber < 13; sectionNumber++)
                {
                    if (sections[sectionNumber] == true)
                    {
                        // Prepare string
                        string line = Convert.ToString(loadNumber) + "  " +
                                      Convert.ToString(elementNumbers[elementNumber]) + "  " +
                                      Convert.ToString(sectionNumber + 1) + "  ";

                        //Read all internal loads
                        for (int i = 0; i < 6; i++)
                        {
                            int offset = (elementNumber * 13 * 6 * 4) + (sectionNumber * 6 * 4) + (i * 4);

                            // Read 4 bytes in new array
                            byte[] valueArray = new byte[4];
                            Array.Copy(this.loadBytes[loadNumber - 1], offset, valueArray, 0, 4);

                            //Convert array to float
                            float value = BitConverter.ToSingle(valueArray, 0);

                            //Convert from lbs to KN
                            value = (float)(value * Preferences.ratioLbsToNewton);

                            // If it's moment convert from Inch to Meter additionally
                            if (i >= 3)
                            {
                                value = (float)(value * Preferences.ratioInchToMeter);
                            }

                            //Add value to string
                            line += value.ToString("0.000") + "  ";
                        }

                        //Add line to array
                        outText.Add(line);

                    }
                }
            }

            // Write text to file
            File.WriteAllLines("Load" + loadNumber.ToString() + ".txt", outText.ToArray());

        }

        
    }
}
