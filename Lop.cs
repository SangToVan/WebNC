using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_Data
{
    public class Lop
    {
        public int malop { get; set; }
        public string tenlop { get; set; }

        public Lop()
        {

        }

        public Lop(int malop, string tenlop)
        {
            this.malop = malop;
            this.tenlop = tenlop;
        }
    }
}