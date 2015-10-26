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
            stdFileNameLabel.Text = Preferences.fileName + ".std";
            bmdFileNameLabel.Text = Preferences.fileName + ".bmd";

            int beamCount = Preferences.stdFileManager.getBeamMembersCount();
            beamMemberCountLabel.Text = Convert.ToString(beamCount);

            bmdBytesCountLabel.Text = Convert.ToString(Preferences.bmdFileManager.getBytesCount());

            loadCountLabel.Text = Convert.ToString(Preferences.bmdFileManager.calculateLoadCount(beamCount));
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

            int[] loadList = Preferences.convertStringToLoadArray(loadListTextBox.Text);
            foreach (int loadNumber in loadList)
            {
                if (Preferences.bmdFileManager.validateLoadNumber(loadNumber))
                {
                    LoadForExport load = new LoadForExport();
                    load.bytes = Preferences.bmdFileManager.getBytesForLoad(loadNumber);
                    load.name = (loadNumber + 1 + loadNumberUpDown.Value).ToString();

                    factory.loads.Add(load);
                }
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

            if (UzCheсkBox.Checked)
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
    }
}
