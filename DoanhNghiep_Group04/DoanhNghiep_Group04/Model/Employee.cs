using System;
using System.Collections.Generic;
using System.Text;

namespace DoanhNghiep_Group04.Model
{
    internal class Employee
    {
        public string ma_employee { get; set; }
        public string ten_employee { get; set; }
        public DateTime ngay_sinh { get; set; }
        public string dia_chi { get; set; }
        public int ma_baohiem { get; set; }
        public string ma_phongban { get; set; }
        public int ma_hopdong { get; set; }
        public bool trang_thai { get; set; }
        public string ma_chucvu { get; set; }
        public string path_anh { get; set; }
    }
}
