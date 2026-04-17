using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using DoanhNghiep_Group04.Model;
using MySql.Data.MySqlClient;
using Mysqlx;

namespace DoanhNghiep_Group04.Data
{
    internal class EmployeeData
    {
        public void AddEmployee(Employee e)
        {
            using(MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = @"Insert into Employee (ma_employee,ten_employee,ngay_sinh,dia_chi,ma_baohiem,ma_phongban,ma_hopdong,trang_thai,ma_chucvu,path_anh)" +
                    "values (@id,@ten,@ngay,@dia,@ma_baohiem,@ma_phongban,@ma_hopdong,@trang_thai,@ma_chucvu,@path_anh)";
                using(MySqlCommand cmd = new MySqlCommand(query,conn))
                {
                    cmd.Parameters.AddWithValue("@id", e.ma_employee);
                    cmd.Parameters.AddWithValue("@ten", e.ten_employee);
                    cmd.Parameters.AddWithValue("@ngay", e.ngay_sinh);
                    cmd.Parameters.AddWithValue("@dia", e.dia_chi);
                    cmd.Parameters.AddWithValue("@ma_baohiem", e.ma_baohiem);
                    cmd.Parameters.AddWithValue("@ma_phongban", e.ma_phongban);
                    cmd.Parameters.AddWithValue("@ma_hopdong", e.ma_hopdong);
                    cmd.Parameters.AddWithValue("@trang_thai", e.trang_thai);
                    cmd.Parameters.AddWithValue("@ma_chucvu", e.ma_chucvu);
                    cmd.Parameters.AddWithValue("@path_anh", e.path_anh);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static Employee GetEmployee(string id)
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "Select * from Employee where ma_employee = @id";
                using(MySqlCommand cmd = new MySqlCommand(query,conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    var reader = cmd.ExecuteReader(); // thuc thi select

                    //gan du lieu tu database vao employee
                    if(reader.Read())
                    {
                        Employee e = new Employee();
                        e.ma_employee = reader["ma_employee"].ToString();
                        e.ten_employee = reader["ten_employee"].ToString();
                        e.ngay_sinh = Convert.ToDateTime(reader["ngay_sinh"]);
                        e.dia_chi = reader["dia_chi"].ToString();
                        e.ma_baohiem = Convert.ToInt32(reader["ma_baohiem"]);
                        e.ma_phongban = reader["ma_phongban"].ToString();
                        e.ma_hopdong = Convert.ToInt32(reader["ma_hopdong"]);
                        e.trang_thai = Convert.ToBoolean(reader["trang_thai"]);
                        e.ma_chucvu = reader["ma_chucvu"].ToString();
                        e.path_anh = reader["path_anh"].ToString();
                        return e;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }


        public static void DeleteEmployee(string id)
        {
            using(MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = @"Delete from Employee where ma_employee = @id";
                using(MySqlCommand cmd = new MySqlCommand(query,conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateEmployee(Employee e,Employee e_manager)
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                using (MySqlTransaction tran = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. UPDATE Employee
                        string updateQuery = @"UPDATE Employee SET 
                ten_employee = @ten,
                ngay_sinh = @ngay,
                dia_chi = @dia,
                ma_baohiem = @ma_baohiem,
                ma_phongban = @ma_phongban,
                ma_hopdong = @ma_hopdong,
                trang_thai = @trang_thai,
                ma_chucvu = @ma_chucvu,
                path_anh = @path_anh
                WHERE ma_employee = @id";

                        MySqlCommand cmd = new MySqlCommand(updateQuery, conn, tran);

                        cmd.Parameters.AddWithValue("@id", e.ma_employee);
                        cmd.Parameters.AddWithValue("@ten", e.ten_employee);
                        cmd.Parameters.AddWithValue("@ngay", e.ngay_sinh);
                        cmd.Parameters.AddWithValue("@dia", e.dia_chi);
                        cmd.Parameters.AddWithValue("@ma_baohiem", e.ma_baohiem);
                        cmd.Parameters.AddWithValue("@ma_phongban", e.ma_phongban);
                        cmd.Parameters.AddWithValue("@ma_hopdong", e.ma_hopdong);
                        cmd.Parameters.AddWithValue("@trang_thai", e.trang_thai);
                        cmd.Parameters.AddWithValue("@ma_chucvu", e.ma_chucvu);
                        cmd.Parameters.AddWithValue("@path_anh", e.path_anh);

                        cmd.ExecuteNonQuery();

                        string logQuery = @"INSERT INTO Log (ma_employee, hanhdong, entity, ma_entity, thoi_gian)
                                VALUES (@id, @hanhdong, @entity, @ma_entity, NOW())";

                        MySqlCommand logCmd = new MySqlCommand(logQuery, conn, tran);

                        logCmd.Parameters.AddWithValue("@hanhdong", "Update");
                        logCmd.Parameters.AddWithValue("@id", e_manager.ma_employee);
                        logCmd.Parameters.AddWithValue("@entity", "Employee");
                        logCmd.Parameters.AddWithValue("ma_entity", e.ma_employee);

                        logCmd.ExecuteNonQuery();

                        // 3. COMMIT
                        tran.Commit();
                    }
                    catch (Exception)
                    {
                        // 4. ROLLBACK if error
                        tran.Rollback();
                        throw;
                    }
                }
            }

        }
    }
