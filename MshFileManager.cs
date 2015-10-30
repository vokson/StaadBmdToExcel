using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BMDtoExcel
{
    class NodeDisplacement
    {
        public int nodeNumber; /* Number of node */
        public double[] displacements = new double[6] { 0, 0, 0, 0, 0, 0 }; /* Displacements */
    }

    class MshFileManager
    {
        /*
        *** MSH FILE FORMAT ***

        4 bytes (INT) - ????
        4 bytes (INT) - Count of mode shapes
        4 bytes (INT) - Count of nodes

        *** 1st block ***

        Each element in each mode, started from 1st mode all nodes, 2nd mode all nodes..
        4 bytes (INT) - Node number
        8 bytes (DOUBLE) - X-TRANS
        8 bytes (DOUBLE) - Y-TRANS
        8 bytes (DOUBLE) - Z-TRANS
        8 bytes (DOUBLE) - X-ROTAN
        8 bytes (DOUBLE) - Y-ROTAN
        8 bytes (DOUBLE) - Z-ROTAN

        *** 2nd block ***

        Each mode shape
         4 bytes (INT) - ????
         8 bytes (DOUBLE) - Frequency, Hz
         8 bytes (DOUBLE) - X mass participation factor, %
         8 bytes (DOUBLE) - Y mass participation factor, %
         8 bytes (DOUBLE) - Z mass participation factor, %
         8 bytes (DOUBLE) - ????
         8 bytes (DOUBLE) - ????
        */

        private byte[] mshFileBytes = new byte[] { }; /* Array with bytes of MSH File*/
        private NodeDisplacement[][] modeShapes = new NodeDisplacement[][] { }; /* Array Node displacements for all mode shapes*/
        private double[] modeFrequeincy = new double[] { }; /* Array with frequencies of modes */
        private double[][] modeParticipation = new double[][] { }; /* Array with mode participation factors */

        private int nodeCount = 0; /* Count of nodes */
        private int modeCount = 0; /* Count of modes */

        
        public void readMshFile(string path) /*Read MSH file*/
        {
            if (String.Compare(path, "") == 0)
            {
                MessageBox.Show("No MSH File Name !!!");
            }
            else
            {
                this.mshFileBytes = File.ReadAllBytes(path);
                this.readModeCount();
                this.readNodeCount();
                this.readBlock1();
                this.readBlock2();
            }
        }

        /* Read count of modes */
        private void readModeCount()
        {
            this.modeCount = BitConverter.ToInt32(this.mshFileBytes, 4);
        }

        /* Read count of nodes */
        private void readNodeCount ()
        {
            this.nodeCount = BitConverter.ToInt32(this.mshFileBytes, 8);
        }

        /* Read mode shapes */
        private void readBlock1()
        {
            // Resize array
            Array.Resize(ref this.modeShapes, this.modeCount);

            int offset = 20;
            for (int modeNumber = 0; modeNumber < this.modeCount; modeNumber++)
            {
                //Resize array
                Array.Resize(ref this.modeShapes[modeNumber], this.nodeCount);

                // Get each node in each mode shape
                for (int nodeNumber = 0; nodeNumber < this.nodeCount; nodeNumber++)
                {
                    NodeDisplacement node = new NodeDisplacement();

                    // Get node number
                    node.nodeNumber = BitConverter.ToInt32(this.mshFileBytes, offset);
                    offset += 4;

                    // Get Displacements
                    for (int i=0; i<6; i++)
                    {
                        node.displacements[i] = BitConverter.ToDouble(this.mshFileBytes, offset);
                        offset += 8;
                    }

                    //Add node to array
                    this.modeShapes[modeNumber][nodeNumber] = node;
                }
            }
           
        }

        /* Read frequeincies, participation factors */
        private void readBlock2()
        {
            // Resize array
            Array.Resize(ref this.modeFrequeincy, this.modeCount);
            Array.Resize(ref this.modeParticipation, this.modeCount);

            int offsetBlock2 = 20 + this.modeCount*this.nodeCount*(4+6*8);
            for (int modeNumber = 0; modeNumber < this.modeCount; modeNumber++)
            {
                int offset = offsetBlock2 + (4 + 6 * 8) * modeNumber + 4;

                // Get frequency
                this.modeFrequeincy[modeNumber] = BitConverter.ToDouble(this.mshFileBytes, offset);
                offset += 8;

                //Resize participation array
                Array.Resize(ref this.modeParticipation[modeNumber], 3);

                // Get participation factors
                for (int i = 0; i < 3; i++)
                {
                   this.modeParticipation[modeNumber][i] = BitConverter.ToDouble(this.mshFileBytes, offset);
                   offset += 8;
                }
            }

        }

        /* Get Mode Count */
        public int getModeCount ()
        {
            return this.modeCount;
        }

        /* Get Node Count */
        public int getNodeCount()
        {
            return this.nodeCount;
        }

        /* Get Mode frequency */
        public double getFrequency(int modeNumber)
        {
            if (validateModeNumber(modeNumber))
            {
                return this.modeFrequeincy[modeNumber];
            } else {
                return 0;
            }
        }

        /* Get Frequencies */
        public double[] getFrequencies()
        {
            return this.modeFrequeincy;
        }

        // Check if mode number correct or not
        public bool validateModeNumber(int number)
        {
            if (number < 0 || (number + 1) > this.modeCount)
            {
                MessageBox.Show("Mode number " + number.ToString() + " is NOT correct !!!");
                return false;
            }
            else
            {
                return true;
            }

        }

    }
}
