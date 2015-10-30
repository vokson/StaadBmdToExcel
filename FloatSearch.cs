using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BMDtoExcel
{
    class FloatSearch
    {
        private byte[] bytes = new byte[] { }; /* Array with bytes of File*/
        private List<string> report = new List<string> { }; /* Array of strings in report */

        /*Search FLOAT in files*/
        public void searchFile(string path, double[] values, double precision)
        {
            this.bytes = File.ReadAllBytes(path);
            
            //Read all file
            for (int pos=0; pos < (bytes.Count()-4); pos++)
            {
                //Read 4 bytes
                float number = BitConverter.ToSingle(this.bytes, pos);

                //Check if number == value
                foreach (double value in values)
                {
                    if (Math.Abs(number - value) <= precision)
                    {
                        //Add to report
                        this.addToReport(path, value, pos);
                    }
                }
            }
        }

        /* Add report string */
        private void addToReport(string path, double value, int pos)
        {
            // Prepare string
            string s = "VALUE=" + value.ToString() + "  POS=" + pos.ToString()+ "   " + path;

            // Add to report
            this.report.Add(s);
        }

        /* Write report to file */
        public void writeReportToFile (string path)
        {
            System.IO.File.WriteAllLines(path, this.report.ToArray());
        }

        /* Clear report */
        public void clearReport()
        {
            this.report.Clear();
        }
    }
}
