using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Test_Data
{
    public class DataUtil
    {
        SqlConnection con;

        public DataUtil()
        {
            string sqlcon = @"Data Source=Sang-PC\SQLEXPRESS;Initial Catalog=sinhviendb;Integrated Security=True";
            con = new SqlConnection(sqlcon);
        }

        public List<SinhVien> dsSinhVien()
        {
            List<SinhVien> ds = new List<SinhVien>();
            string sql = "SELECT * FROM sinhvien";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                SinhVien s = new SinhVien();
                s.masv = (int)rd["masv"];
                s.hoten = (string)rd["hoten"];
                s.diachi = (string)rd["diachi"];
                s.dienthoai = (string)rd["dienthoai"];
                s.malop = (int)rd["malop"];
                ds.Add(s);
            }
            con.Close();
            return ds;
        }

        public List<Lop> dsLop()
        {
            List<Lop> ds = new List<Lop>();
            string sql = "SELECT * FROM lophoc";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                Lop lop = new Lop();
                lop.malop = (int)rd["malop"];
                lop.tenlop = (string)rd["tenlop"];
                ds.Add(lop);
            }

            con.Close();
            return ds;
        }

        public void AddSV(SinhVien s)
        {
            con.Open();
            string sql = "INSERT INTO sinhvien(hoten, diachi, dienthoai, malop) VALUES(@ht, @dc, @dt, @malop)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("ht", s.hoten);
            cmd.Parameters.AddWithValue("dc", s.diachi);
            cmd.Parameters.AddWithValue("dt", s.dienthoai);
            cmd.Parameters.AddWithValue("malop", s.malop);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void DelSV(int masv)
        {
            con.Open();
            String sql = "DELETE FROM sinhvien WHERE masv = @masv";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("masv", masv);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public SinhVien showSV(int masv)
        {
            SinhVien s = null;
            string sql = "SELECT * FROM sinhvien WHERE masv=@masv";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("masv", masv);

            SqlDataReader rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                s = new SinhVien();
                s.masv = (int)rd["masv"];
                s.hoten = (string)rd["hoten"];
                s.diachi = (string)rd["diachi"];
                s.dienthoai = (string)rd["dienthoai"];
                s.malop = (int)rd["malop"];
            }
            con.Close();
            return s;
        }

        public void EditSV(SinhVien s)
        {
            con.Open();
            string sql = "UPDATE sinhvien SET hoten=@ht, diachi=@dc, dienthoai=@dt, malop=@malop WHERE masv=@masv";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("ht", s.hoten);
            cmd.Parameters.AddWithValue("dc", s.diachi);
            cmd.Parameters.AddWithValue("dt", s.dienthoai);
            cmd.Parameters.AddWithValue("malop", s.malop);
            cmd.Parameters.AddWithValue("masv", s.masv);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}