using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BMDtoExcel
{
    class Preferences
    {
        // Path
       public static string stdFilePath = "";
       public static string bmdFilePath = "";
       public static string mshFilePath = "";
       public static string fileName = "";

        // Flags
        /*Will be frequencies used for combination or not? */
        public static bool isFrequencyUsed = false;

        // Objects
       public static StdFileManager stdFileManager = new StdFileManager();
       public static BmdFileManager bmdFileManager = new BmdFileManager();
       public static MshFileManager mshFileManager = new MshFileManager();
       public static FloatSearch floatSearchManager = new FloatSearch();

        // Regular expression for correct symbols
       private static Regex rxDigits = new Regex(@"[-,\d]+");

        //Conversion ratios
       public const double ratioLbsToNewton = 4.44822162825;
       public const double ratioInchToMeter = 0.0254;

        // Provide name of file witout path
        public static void setFileName (string path)
        {
            string[] array = path.Split(new Char[] {'\\'});
            string result = array[array.Length - 1];

            int pos = result.IndexOf('.');
            Preferences.fileName = result.Substring(0, pos);
        }

        //Convert string to load array
        // Input format "1, 2, 10-15,40,36-37"
        // isArrayIndex = true - substract 1 from load number
        public static int[] convertStringToLoadArray(string s, bool isArrayIndex = true)
        {
            // Set offset
            int offset;
            if (isArrayIndex) { offset = -1; } else { offset = 0; }

            //Prepare result array
            List<int> result = new List<int> { };

            // Delete all symbols except 0-9, ",", "-"
            s = cleanString(s);

            // Explode string
            string[] commaArray = s.Split(new char[] { ',' });

            for (int i=0; i < commaArray.Length; i++)
            {
                
                if (!string.IsNullOrEmpty(commaArray[i]))
                {
                    //Check if there is '-'
                    int minusPos = commaArray[i].IndexOf('-');
                    if (minusPos == -1)
                    {
                        // Substract number, if index of array
                        result.Add(Convert.ToInt32(commaArray[i])+offset);
                    } else
                    {
                        int beg, end;

                        bool success1 = Int32.TryParse(commaArray[i].Substring(0, minusPos), out beg);
                        bool success2 = Int32.TryParse(commaArray[i].Substring(minusPos+1), out end);

                        //Check if success
                        if (!success1 || !success2)
                        {
                            MessageBox.Show("Load list is NOT correct !!!");
                            return new int[] { };
                        }

                        for (int k=beg; k <= end; k++)
                        {
                            // Substract number, if index of array
                            result.Add(k+offset);
                        }
                    }
                }
            }

            return result.ToArray();

        }

        // Clean string from not necessary symbols
        private static string cleanString(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;
            StringBuilder sb = new StringBuilder();
            for (Match m = rxDigits.Match(s); m.Success; m = m.NextMatch())
            {
                sb.Append(m.Value);
            }
            string cleaned = sb.ToString();
            return cleaned;
        }

    }
}
