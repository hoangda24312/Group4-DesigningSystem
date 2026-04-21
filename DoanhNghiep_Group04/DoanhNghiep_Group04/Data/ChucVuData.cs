using DoanhNghiep_Group04.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoanhNghiep_Group04.Data
{
    internal class ChucVuData
    {
        public List<ChucVu> GetDanhSachChucVu()
        {
            List<ChucVu> danh_sach = new List<ChucVu> { };
            using(MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = @"Select * from ChucVu";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    var reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        ChucVu cv = new ChucVu();
                        cv.ma_chucvu = reader["ma_chucvu"].ToString();
                        cv.ten_chucvu = reader["ten_chucvu"].ToString();
                        danh_sach.Add(cv);
                    }

                }
            }
            return danh_sach;
        }
    }
}
