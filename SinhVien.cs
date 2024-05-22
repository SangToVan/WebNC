using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_Data
{
    public class SinhVien
    {
        public int masv { get; set; }
        public string hoten { get; set; }
        public string diachi { get; set; }
        public string dienthoai { get; set; }
        public int malop { get; set; }

        public SinhVien()
        {

        }

        public SinhVien(string hoten, string diachi, string dienthoai, int malop)
        {
            this.hoten = hoten;
            this.diachi = diachi;
            this.dienthoai = dienthoai;
            this.malop = malop;
        }
    }
}