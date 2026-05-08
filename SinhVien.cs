using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class SinhVien
    {
        public string maSinhVien { get; set; }
        public string tenSinhVien { get; set; }
        public string gioiTinh { get; set; }
        public string maLop { get; set; }

        public SinhVien()
        {
            this.maSinhVien = "";
            this.tenSinhVien = "";
            this.gioiTinh = "";
            this.maLop = "";
        }

        public SinhVien(string maSinhVien, string tenSinhVien, string gioiTinh, string maLop)
        {
            this.maSinhVien = maSinhVien;
            this.tenSinhVien = tenSinhVien;
            this.gioiTinh = gioiTinh;
            this.maLop = maLop;
        }
    }
}
