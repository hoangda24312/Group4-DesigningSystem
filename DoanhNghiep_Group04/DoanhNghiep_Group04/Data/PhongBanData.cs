using System;
using System.Collections.Generic;
using System.Text;
using DoanhNghiep_Group04.Model;
using MySql.Data.MySqlClient;

namespace DoanhNghiep_Group04.Data
{
    internal class PhongBanData
    {
        public void CreatePhongBan(PhongBan pb, Employee e)
        {
            using(MySqlConnection conn = Database.GetConnection())
            {
                conn.Open(); //open database connection
                using (MySqlTransaction trann = conn.BeginTransaction())
                {
                    try
                    {
                        string query = @"Insert into ma_phongban, ten_phongban, sdt, ma_manager,trang_thai
                    VALUES (@id_pb,@ten,@sdt,@id_e, @status)";
                        MySqlCommand cmd = new MySqlCommand(query, conn, trann);
                        cmd.Parameters.AddWithValue("@id_pb", pb.ma_phongban);
                        cmd.Parameters.AddWithValue("@ten", pb.ten_phongban);
                        cmd.Parameters.AddWithValue("@sdt", pb.sdt);
                        cmd.Parameters.AddWithValue("@id_e", pb.ma_manager);
                        cmd.Parameters.AddWithValue("@status", pb.trang_thai);
                        cmd.ExecuteNonQuery();

                        string log_query = @"INSERT INTO Log (ma_employee, hanhdong, entity, ma_entity, thoi_gian)
                    VALUES (@id, @hanhdong, @entity, @ma_entity, NOW())";
                        MySqlCommand log_cmd = new MySqlCommand(log_query, conn, trann);
                        log_cmd.Parameters.AddWithValue("@hanhdong", "Insert");
                        log_cmd.Parameters.AddWithValue("@id", e.ma_employee);
                        log_cmd.Parameters.AddWithValue("@entity", "PhongBan");
                        log_cmd.Parameters.AddWithValue("ma_entity", pb.ma_phongban);

                        log_cmd.ExecuteNonQuery();

                        trann.Commit();
                    }
                    catch(Exception)
                    {
                        trann.Rollback();
                        throw new Exception("Loi du lieu");
                    }
                }
            }
        }





        public void UpdatePhongBan(PhongBan pb, Employee e)
        {
            using(MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                using(MySqlTransaction trann = conn.BeginTransaction())
                {
                    try
                    {
                        string query = @"Update PhongBan set
                        ten_phongban = @ten, sdt = @sdt, ma_manager = @id_e, trang_thai = @status";
                        MySqlCommand cmd = new MySqlCommand(query, conn, trann);
                        cmd.Parameters.AddWithValue("@ten", pb.ten_phongban);
                        cmd.Parameters.AddWithValue("@sdt", pb.sdt);
                        cmd.Parameters.AddWithValue("@id_e", pb.ma_manager);
                        cmd.Parameters.AddWithValue("@status", pb.trang_thai);
                        cmd.ExecuteNonQuery();

                        string log_query = @"INSERT INTO Log (ma_employee, hanhdong, entity, ma_entity, thoi_gian)
                    VALUES (@id, @hanhdong, @entity, @ma_entity, NOW())";
                        MySqlCommand log_cmd = new MySqlCommand(log_query, conn, trann);
                        log_cmd.Parameters.AddWithValue("@hanhdong", "Update");
                        log_cmd.Parameters.AddWithValue("@id", e.ma_employee);
                        log_cmd.Parameters.AddWithValue("@entity", "PhongBan");
                        log_cmd.Parameters.AddWithValue("ma_entity", pb.ma_phongban);
                        log_cmd.ExecuteNonQuery();

                        trann.Commit();

                    }
                    catch(Exception)
                    {
                        trann.Rollback();
                        throw new Exception("Loi du lieu");
                    }
                }
            }

        }


        public static List<PhongBan> GetDanhSach(string ma_phongban)
        {
            List<PhongBan> danh_sach = new List<PhongBan>();
            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = @"Select * from
                PhongBan where ma_phongban = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", ma_phongban);
                    var reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        PhongBan pb = new PhongBan();
                        pb.ma_phongban = ma_phongban;
                        pb.ten_phongban = reader["ten_phongban"].ToString();
                        pb.ma_manager = reader["ma_manager"].ToString();
                        pb.trang_thai = Convert.ToBoolean(reader["trang_thai"]);
                        danh_sach.Add(pb);
                    }
                }
            }
            return danh_sach;
        }











    }
}
