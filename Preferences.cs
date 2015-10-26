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
       public static string stdFilePath = "";
       public static string bmdFilePath = "";
       public static string fileName = "";
       public static StdFileManager stdFileManager = new StdFileManager();
       public static BmdFileManager bmdFileManager = new BmdFileManager();

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
        public static int[] convertStringToLoadArray(string s)
        {
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
                        // Substract number-1
                        result.Add(Convert.ToInt32(commaArray[i])-1);
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
                            // Substract number-1
                            result.Add(k-1);
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
