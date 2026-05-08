using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class Data
    {
        string chuoiKetNoi = @"Data Source=.\MSSQLSERVER01;Initial Catalog=QuanLySinhVien;Integrated Security=True";

        public DataTable data(string sql)
        {
            SqlConnection ketNoi = new SqlConnection(chuoiKetNoi);
            ketNoi.Open();
            SqlCommand thucHien = new SqlCommand(sql, ketNoi);
            SqlDataReader docDuLieu = thucHien.ExecuteReader();
            DataTable bangSinhVien = new DataTable();
            bangSinhVien.Load(docDuLieu);
            ketNoi.Close();
            return bangSinhVien;
        }
    }
}
