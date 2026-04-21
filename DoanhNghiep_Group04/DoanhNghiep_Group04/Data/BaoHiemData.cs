using System;
using System.Collections.Generic;
using System.Text;
using DoanhNghiep_Group04.Model;
using MySql.Data.MySqlClient;

namespace DoanhNghiep_Group04.Data
{
    internal class BaoHiemData
    {
        public void CreateBaoHiem(BaoHiem bh, Employee e)
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                using (MySqlTransaction trann = conn.BeginTransaction())
                {
                    try
                    {
                        string query = @"Insert into BaoHiem (ma_employee,loai_baohiem,so_baohiem,muc_dong,ty_le_dong,start_date,end_date,trang_thai,
                        noi_cap,ghi_chu,path_anh)
                        VALUES(@id_e,@loai,@so,@muc,@ty,@start,@end,@status,@noi,@ghi,@path)";
                        MySqlCommand cmd = new MySqlCommand(query, conn, trann);

                        cmd.Parameters.AddWithValue("@id_e", bh.ma_employee);
                        cmd.Parameters.AddWithValue("@loai", bh.loai_baohiem);
                        cmd.Parameters.AddWithValue("@so", bh.so_baohiem);
                        cmd.Parameters.AddWithValue("@muc", bh.muc_dong);
                        cmd.Parameters.AddWithValue("@ty", bh.ty_le_dong);
                        cmd.Parameters.AddWithValue("@start", bh.start_date);
                        cmd.Parameters.AddWithValue("@end", bh.end_date);
                        cmd.Parameters.AddWithValue("@status", bh.trang_thai);
                        cmd.Parameters.AddWithValue("@noi", bh.noi_cap);
                        cmd.Parameters.AddWithValue("@ghi", bh.ghi_chu);
                        cmd.Parameters.AddWithValue("@path", bh.path_anh);

                        int id = Convert.ToInt32(cmd.ExecuteScalar());

                        string log_query = @"INSERT INTO Log (ma_employee, hanhdong, entity, ma_entity, thoi_gian)
                                VALUES (@id, @hanhdong, @entity, @ma_entity, NOW())";
                        MySqlCommand log_cmd = new MySqlCommand(log_query, conn, trann);
                        log_cmd.Parameters.AddWithValue("@hanhdong", "Insert");
                        log_cmd.Parameters.AddWithValue("@id", e.ma_employee);
                        log_cmd.Parameters.AddWithValue("@entity", "BaoHiem");
                        log_cmd.Parameters.AddWithValue("ma_entity", id);

                        log_cmd.ExecuteNonQuery();

                        trann.Commit();

                    }
                    catch (Exception)
                    {
                        trann.Rollback();
                        throw new Exception("Loi database");
                    }
                }
            }
        }


        public void UpdateBaoHiem(BaoHiem bh)
        {

        }
    }
}
