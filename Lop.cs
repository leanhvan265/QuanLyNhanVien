using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class Lop
    {
        public string maLop { get; set; }
        public string tenLop { get; set; }

        public Lop()
        {
            this.maLop = "";
            this.tenLop = "";
        }

        public Lop(string maLop, string tenLop)
        {
            this.maLop = maLop;
            this.tenLop = tenLop;
        }
    }
}
