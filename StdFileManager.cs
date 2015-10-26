using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BMDtoExcel
{
    // Class to store Beam Elements
    class BeamElement
    {
        public int number; /*Element Number*/
        public int node1; /*Number of 1st node*/
        public int node2; /*Number of 2nd node*/
    };

    class StdFileManager
    {
        private List<BeamElement> beamElements = new List<BeamElement>(); /*Array with Beam Elements*/
        private string[] stdFileLines = new string[] { }; /* Array with rows of STD File*/

        public void readStdFile(string path) /*Read STD file*/
        {
            if (String.Compare(path, "") == 0)
            {
                MessageBox.Show("No STD File Name !!!");
            } else {
                stdFileLines = System.IO.File.ReadAllLines(@path);
            }

        }

        /*Get count of Beam Members*/
        public int getBeamMembersCount() 
        {
            return beamElements.Count;
        }

        public void getBeamMembers() /*Find Beam Members return count of Beam Members*/
        {
            //Check if stdFileLines isn't NULL
            if (stdFileLines.Length == 0)
            {
                return;
            }

            List<BeamElement> beamArray = new List<BeamElement>(); /*Array for new members */

            List<string> linesWithMembers = new List<string>(); /*Array for lines with beam elements*/
            bool isInsideMemberIncidences = false;

            // Take lines with members only
            foreach (string line in stdFileLines)
            {
                // If find not decimal value, close input
                if (isInsideMemberIncidences == true &&
                       (line[0] < '0' || line[0] > '9'))
                {
                    isInsideMemberIncidences = false;
                }

                // Add line to list
                if (isInsideMemberIncidences == true)
                {
                    linesWithMembers.Add(line);
                }

                // If find MEMBER INCIDENCES, open input
                if (isInsideMemberIncidences == false &&
                    String.Compare(line.Trim(new Char[] { ' ' }), "MEMBER INCIDENCES") == 0)
                {
                    isInsideMemberIncidences = true;
                }

            }

            // Search taken lines
            foreach (string line in linesWithMembers)
            {
                //Explode string to elements
                // Format "28 18 2; 29 4 1; 30 4 3; 31 3 2; 32 1 2;"
                string[] beamsStr = line.Split(new Char[] { ';' });

                //Delete last empty element if empty
                if (beamsStr[beamsStr.Length - 1] == "")
                {
                    Array.Resize(ref beamsStr, beamsStr.Length - 1);
                }

                // Search inside each member
                foreach (string beamStr in beamsStr)
                {
                    string trimmedBeamStr = beamStr.Trim(new Char[] { ' ' }); ;
                    string[] values = trimmedBeamStr.Split(new Char[] { ' ' });

                    //Apply properties
                    BeamElement beam = new BeamElement();
                    beam.number = Convert.ToInt32(values[0]);
                    beam.node1 = Convert.ToInt32(values[1]);
                    beam.node2 = Convert.ToInt32(values[2]);

                    beamArray.Add(beam);
                }

            }

            //Sort Array by Member Number
            this.beamElements = beamArray.OrderBy(x => x.number).ToList();

        }

        // Provides array  of number of beam elements
        public int[] getBeamNumberList()
        {
            int[] beamNumberList = new int[this.beamElements.Count];

            int i = 0;
            foreach (BeamElement beam in this.beamElements)
            {
                beamNumberList[i] = beam.number;
                i++;
            }

            return beamNumberList;
        }

       

    }    
}
