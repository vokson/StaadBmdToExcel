using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace BMDtoExcel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string fileName in files)
            {
                string extension = fileName.Substring(fileName.Length - 4);

                if (String.Compare(extension, ".std") == 0)
                {
                    Preferences.stdFilePath = fileName;
                    Preferences.stdFileManager.readStdFile(Preferences.stdFilePath);
                    // Set filename
                    Preferences.setFileName(Preferences.stdFilePath);
                    //Read
                    Preferences.stdFileManager.getBeamMembers();
                }

                if (String.Compare(extension, ".bmd") == 0)
                {
                    Preferences.bmdFilePath = fileName;
                    Preferences.bmdFileManager.readBmdFile(Preferences.bmdFilePath);
                    // Set filename
                    Preferences.setFileName(Preferences.bmdFilePath);
                }

                if (String.Compare(extension, ".msh") == 0)
                {
                    Preferences.mshFilePath = fileName;
                    Preferences.mshFileManager.readMshFile(Preferences.mshFilePath);
                    // Set filename
                    Preferences.setFileName(Preferences.mshFilePath);
                }
            }

            refreshAllValues();
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;

        }

        // Refresh all statuc values in all labels, ..
        private void refreshAllValues()
        {
            stdFileNameLabel.Text = Path.GetFileName(Preferences.stdFilePath);
            bmdFileNameLabel.Text = Path.GetFileName(Preferences.bmdFilePath);
            mshFileNameLabel.Text = Path.GetFileName(Preferences.mshFilePath);

            //STD
            int beamCount = Preferences.stdFileManager.getBeamMembersCount();
            beamMemberCountLabel.Text = Convert.ToString(beamCount);
            loadCountLabel.Text = Convert.ToString(Preferences.bmdFileManager.calculateLoadCount(beamCount));

            //BMD
            bmdBytesCountLabel.Text = Convert.ToString(Preferences.bmdFileManager.getBytesCount());

            //MSH
            mshModeCountLabel.Text = Convert.ToString(Preferences.mshFileManager.getModeCount());
            mshNodeCountLabel.Text = Convert.ToString(Preferences.mshFileManager.getNodeCount());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool[] sections = new bool[13] { false, false, false, false, false, false, false, false, false, false, false, false, false };

            //Prepare sections array
            foreach (Control c in this.Controls)
            {
                if (c is CheckBox)
                {
                    if (c.Name.Contains("sectionCheckBox"))
                    {
                            CheckBox checkBox = (CheckBox)c;
                            // Take sectionNumber from name of CheckBox
                            int sectionNumber = Convert.ToInt32(checkBox.Name.Substring(15));
                            // Update array
                            sections[sectionNumber - 1] = checkBox.Checked;
                    }
                }
            }

            // Prepare export factory
            ExcelExportFactory factory = new ExcelExportFactory();
            factory.sections = sections;
            factory.elementNumbers = Preferences.stdFileManager.getBeamNumberList();

            //Get list of loads
            int[] xlsLoadList = Preferences.convertStringToLoadArray(xlsLoadListTextBox.Text, false);
            int[] bmdLoadList = Preferences.convertStringToLoadArray(bmdLoadListTextBox.Text);
            int[] mshLoadList = Preferences.convertStringToLoadArray(mshModeListTextBox.Text);
            int loadCount = bmdLoadList.Count();

            // Set Frequency Flag
            if (mshLoadList.Count() != 0)
            {
                Preferences.isFrequencyUsed = true;
            }

            // Check correspondance of lists
                if (xlsLoadList.Count() != loadCount)
            {
                MessageBox.Show("Wrong Load List !!!");
                return;
            }
            if (Preferences.isFrequencyUsed && mshLoadList.Count() !=loadCount)
            {
                MessageBox.Show("Wrong Mode List !!!");
                return;
            }

            // Validate load numbers
            for (int i = 0; i < loadCount; i++)
            {
                if (!Preferences.bmdFileManager.validateLoadNumber(i)) {
                    return;
                }
            }

            if (Preferences.isFrequencyUsed) {
                for (int i = 0; i < loadCount; i++)
                {
                    if (!Preferences.mshFileManager.validateModeNumber(i))
                    {
                        return;
                    }
                }
            }


            // Prepare loads for 
            for (int i = 0; i < loadCount; i++) 
            {
                LoadForExport load = new LoadForExport();
                /**/
                load.bytes = Preferences.bmdFileManager.getBytesForLoad(bmdLoadList[i]);
                load.name = xlsLoadList[i].ToString();
                load.frequency = Preferences.mshFileManager.getFrequency(mshLoadList[i]);

                factory.loads.Add(load);
            }

            // Add combination rules
            if (srssCheckBox.Checked)
            {
                factory.rules.Add(new SRSSCombinationRule());
            }

            if (multiSrssCheckBox.Checked)
            {
                factory.rules.Add(new multiSRSSCombinationRule());
            }

            if (uzCheсkBox.Checked)
            {
                factory.rules.Add(new UZCombinationRule());
            }

            if (modulusUzCheckBox.Checked)
            {
                factory.rules.Add(new UZModulusCombinationRule());
            }

            factory.saveToExcelFile(Directory.GetCurrentDirectory() + "\\" + Preferences.fileName + ".xls");
            factory = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(Directory.GetCurrentDirectory() + "\\"+ "Files_For_Search");

            //Prepare array for search
            double[] array = new double[] { 1.079, 1.166, 1.362, 1.772, 2.348, 2.349, 2.391, 2.394, 2.459 };
            //double[] array = new double[] { 0.92654, 0.858, 0.73413, 0.73397, 0.56422, 0.42590, 0.42579, 0.41819, 0.41774, 0.40662 };
            double precision = 0.001;

            Preferences.floatSearchManager.clearReport();
            foreach (string path in fileEntries)
            {
                Preferences.floatSearchManager.searchFile(path, array, precision);
            }

            Preferences.floatSearchManager.writeReportToFile(Directory.GetCurrentDirectory() + "\\log.txt");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            byte[] bytes = File.ReadAllBytes(Directory.GetCurrentDirectory() + "\\" + "Files_For_Search" + "\\" +
                "Simple Piperack SRSS ABS CQC ASCE.msh");

            int n1 = BitConverter.ToInt32(bytes, 0);
            int n2 = BitConverter.ToInt32(bytes, 4);
            int n3 = BitConverter.ToInt32(bytes, 8);

            MessageBox.Show("1 - " + n1.ToString() + "\n" +
                            "2 - " + n2.ToString() + "\n" +
                            "3 - " + n3.ToString());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            byte[] bytes = File.ReadAllBytes(Directory.GetCurrentDirectory() + "\\" + "Files_For_Search" + "\\" +
                "1.txt");

            int offset = 0;
            List<string> text = new List<string> { };

            for (int i=0; i < 40; i++)
            {
                string s = "";

                int intNum = BitConverter.ToInt32(bytes, offset);
                s += intNum.ToString() + "  ";
                offset += 4;

                for (int j=0; j<6; j++)
                {
                    double doubleNum = BitConverter.ToDouble(bytes, offset);
                    s += string.Format("{0:0.000}", doubleNum) + "  ";
                    offset += 8;
                }

                s += "\n";
                text.Add(s);
            }

            System.IO.File.WriteAllLines(Directory.GetCurrentDirectory() + "\\1.log.txt", text.ToArray());
        }

        private void mshModeListTextBox_TextChanged(object sender, EventArgs e)
        {
            bool flag = true;

            if (mshModeListTextBox.Text == "")
            {
                flag = false;
            }

            sp14CheckBox.Enabled = flag;
            absCheckBox.Enabled = flag;
            cqcCheckBox.Enabled = flag;
            asceCheckBox.Enabled = flag;

        }
    }
}
