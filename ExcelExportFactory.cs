using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BMDtoExcel
{
    class ExcelExportFactory
    {
        public bool[] sections; // Sections of element
        public int[] elementNumbers; // Numbers of elements
        public List<LoadForExport> loads = new List<LoadForExport> { }; // Collection of loads to be exported
        private int loadsCount; // Cout of loads before start application of combination rules
        public List<CombinationRule> rules = new List<CombinationRule> { }; // Collection of combination rules to be applied

        private Excel.Workbook xlWorkBook; // Workbook
        private Excel.Worksheet xlWorkSheet; // Worksheet
        private Excel.Application xlApp; // Application
        object misValue;

        // Excel Constructor
        public ExcelExportFactory()
        {
            //Prepare Excel
            this.xlApp = new Microsoft.Office.Interop.Excel.Application();
            
            if (this.xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }
            //Prepare misValue
            this.misValue = System.Reflection.Missing.Value;
            this.xlWorkBook = this.xlApp.Workbooks.Add(this.misValue);

            //Delete empty worksheet
            //this.xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            //this.xlWorkSheet.Delete();
        }

        // Save load to excel file
        public void saveToExcelFile(string path)
        {
            if (this.sections.Length < 13)
            {
                MessageBox.Show("Section format is NOT correct !!!");
                return;
            }

            if (this.loads.Count == 0)
            {
                MessageBox.Show("Load List is empty !!!");
                return;
            }

            this.loadsCount = this.loads.Count;

            // Make additional loads from rules
            foreach (CombinationRule rule in this.rules)
            {
                this.applyCombinationRule(rule);
            }

            // Add worksheets
            foreach (LoadForExport load in this.loads)
            {
                this.addWorksheet(load);
            }


            // Write to file
           
            this.xlWorkBook.SaveAs(path, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
                Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

            this.xlWorkBook.Close(true, misValue, misValue);
            this.xlApp.Quit();

            releaseObject(this.xlWorkSheet);
            releaseObject(this.xlWorkBook);
            releaseObject(this.xlApp);

        }

        // Make loads for export from combination rules
        private void applyCombinationRule(CombinationRule rule)
        {
            //Prepare new load
            LoadForExport combinedLoad = new LoadForExport();

            combinedLoad.name = rule.name;
            // Take bytes' count from 1st load
            combinedLoad.bytes = new byte[this.loads[0].bytes.Length];

            // Combine byte by byte
            for (int i=0; i < combinedLoad.bytes.Length; i += 4)
            {
                // Combine only necessary sections in members
                if (this.sections[(int)((i % (13 * 4 * 6)) / (6 * 4))] == true)
                {

                    // Prepare array with values
                    float[] arrayValues = new float[this.loadsCount];
                    // Prepare array with frequencies
                    double[] arrayFrequencies = new double[this.loadsCount];

                    // Fill array
                    for (int k = 0; k < this.loadsCount; k++)
                    {
                        //Read 4 bytes
                        arrayValues[k] = BitConverter.ToSingle(this.loads[k].bytes, i);

                        //Get frequency
                        arrayFrequencies[k] = this.loads[k].frequency;

                    }



                    //Combine array
                    float result = (float)rule.combine(arrayValues, arrayFrequencies);

                    //Write value to combined load
                    Array.Copy(BitConverter.GetBytes(result), 0, combinedLoad.bytes, i, 4);
                }
            }

            // Add combined load
            this.loads.Add(combinedLoad);
        }

        // Add worksheet to workbook
        private void addWorksheet(LoadForExport load)
        {
            //Add Worksheet
            var xlSheets = this.xlWorkBook.Sheets as Excel.Sheets;
            this.xlWorkSheet = (Excel.Worksheet)this.xlWorkBook.Worksheets.Add(xlSheets[1], Type.Missing, Type.Missing, Type.Missing);
            this.xlWorkSheet.Name = load.name;

            // Write Units
            xlWorkSheet.Cells[1, 4] = "KN";
            xlWorkSheet.Cells[1, 5] = "KN";
            xlWorkSheet.Cells[1, 6] = "KN";
            xlWorkSheet.Cells[1, 7] = "KN*m";
            xlWorkSheet.Cells[1, 8] = "KN*m";
            xlWorkSheet.Cells[1, 9] = "KN*m";
            // Write Head Titles
            xlWorkSheet.Cells[2, 1] = "LOAD";
            xlWorkSheet.Cells[2, 2] = "MEMBER";
            xlWorkSheet.Cells[2, 3] = "SECTION";
            xlWorkSheet.Cells[2, 4] = "AXIAL";
            xlWorkSheet.Cells[2, 5] = "SHEAR-Y";
            xlWorkSheet.Cells[2, 6] = "SHEAR-Z";
            xlWorkSheet.Cells[2, 7] = "TORSION";
            xlWorkSheet.Cells[2, 8] = "MOM-Y";
            xlWorkSheet.Cells[2, 9] = "MOM-Z";

            int rowIndex = 3;
            // Export
            for (int elementNumber = 0; elementNumber < this.elementNumbers.Length; elementNumber++)
            {
                for (int sectionNumber = 0; sectionNumber < 13; sectionNumber++)
                {
                    if (this.sections[sectionNumber] == true)
                    {
                        // Prepare string
                        xlWorkSheet.Cells[rowIndex, 1] = load.name;
                        xlWorkSheet.Cells[rowIndex, 2] = this.elementNumbers[elementNumber];
                        xlWorkSheet.Cells[rowIndex, 3] = sectionNumber + 1;

                        //Read all internal loads
                        for (int i = 0; i < 6; i++)
                        {
                            int offset = (elementNumber * 13 * 6 * 4) + (sectionNumber * 6 * 4) + (i * 4);

                            // Read 4 bytes in new array
                            byte[] valueArray = new byte[4];
                            Array.Copy(load.bytes, offset, valueArray, 0, 4);

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
                            xlWorkSheet.Cells[rowIndex, 4 + i] = value;

                        }
                        //Next row
                        rowIndex++;
                    }
                }
            }

            // Number format 
            xlWorkSheet.Range["A3", "C" + rowIndex].NumberFormat = "0";
            xlWorkSheet.Range["D3", "I" + rowIndex].NumberFormat = "0,000";
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
