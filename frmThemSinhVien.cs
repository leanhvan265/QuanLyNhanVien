using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmThemSinhVien : Form
    {
        private DataSet ds;

        public frmThemSinhVien()
        {
            InitializeComponent();
        }

        public frmThemSinhVien(DataSet ds)
        {
            InitializeComponent();
            this.ds = ds;
        }
        
        private void frmThemSinhVien_Load(object sender, EventArgs e)
        {
            cboLop.Items.Clear();
            cboLop.DataSource = ds.Tables["LOPHOC"];
            cboLop.DisplayMember = "tenLop";
            cboLop.ValueMember = "maLop";
            cboLop.SelectedIndex = -1;
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
                if (cboLop.SelectedIndex != -1 & cboLop.SelectedItem != null)
                {
                    DataRow row = ds.Tables["SINHVIEN"].NewRow();
                    row["MaSV"] = txtMa.Text;
                    row["TenSV"] = txtTen.Text;
                    row["NgaySinh"] = dtpNgaySinh.Value.Date;
                    if (rdoNam.Checked) row["GioiTinh"] = "Nam";
                    else row["GioiTinh"] = "Nữ";
                    row["MaLop"] = cboLop.SelectedValue.ToString();
                    ds.Tables["SINHVIEN"].Rows.Add(row);
                    MessageBox.Show("Đã thêm sinh viên thành công");
                    this.Close();



                //string chuoiKetNoi = @"Data Source=.\MSSQLSERVER01;Initial Catalog=QuanLySinhVien;Integrated Security=True";
                //SqlConnection ketNoi = new SqlConnection(chuoiKetNoi);
                //ketNoi.Open();
                //string sql = "INSERT INTO SINHVIEN (MaSV, TenSV, NgaySinh, GioiTinh, MaLop) VALUES (@MaSV, @TenSV, @NgaySinh, @GioiTinh, @MaLop)";
                //SqlCommand thucHien = new SqlCommand(sql, ketNoi);
                //thucHien.Parameters.AddWithValue("@MaSV", txtMa.Text);      
                //thucHien.Parameters.AddWithValue("@TenSV", txtTen.Text); 
                //thucHien.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value); 
                //if (rdoNam.Checked)
                //    thucHien.Parameters.AddWithValue("@GioiTinh", rdoNam.Text);
                //else
                //    thucHien.Parameters.AddWithValue("@GioiTinh", rdoNu.Text);
                //thucHien.Parameters.AddWithValue("@MaLop", cboLop.SelectedValue.ToString());
                //int result = thucHien.ExecuteNonQuery();
                //if (result > 0)
                //    MessageBox.Show("Đã thêm sinh viên thành công");
                //ketNoi.Close();
                //this.Close();
            }
        }

        
    }
}
