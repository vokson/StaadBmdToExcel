using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BMDtoExcel
{
    // Class to keep bytes of load and it's name
    class LoadForExport
    {
        public byte[] bytes = new byte[] {}; // Bytes
        public string name = ""; //Name
        public double frequency = 0; // Frequency, if it's mode
    }
}
