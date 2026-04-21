using System;
using System.Collections.Generic;
using System.Text;

namespace DoanhNghiep_Group04.Model
{
    internal class BaoHiem
    {
        public int ma_baohiem { set; get; }
        public string ma_employee { set; get; }
        public string loai_baohiem { set; get; }
        public string so_baohiem { set; get; }
        public double muc_dong { set; get; }
        public double ty_le_dong { set; get; }
        public DateTime start_date { set; get; }
        public DateTime end_date { set; get; }
        public bool trang_thai { set; get; }
        public string noi_cap { set; get; }
        public string ghi_chu { set; get; }
        public string path_anh { set; get; }

    }
}
