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
    public partial class csdlLopGianTiep : Form
    {
        public csdlLopGianTiep()
        {
            InitializeComponent();
        }

        string chuoiKetNoi = @"Data Source=.\MSSQLSERVER01;Initial Catalog=QuanLySinhVien;Integrated Security=True";
        DataSet ds = new DataSet();
        SqlDataAdapter adapterLop, adapterSinhVien;

        private void btnThemLopGT_Click(object sender, EventArgs e)
        {
            frmThemSinhVien frm = new frmThemSinhVien(ds);
            frm.ShowDialog();

            SqlConnection ketNoi = new SqlConnection(chuoiKetNoi);
            adapterSinhVien.SelectCommand.Connection = ketNoi;
            new SqlCommandBuilder(adapterSinhVien);
            adapterSinhVien.Update(ds, "SINHVIEN");
        }

        private void btnSuaLopGT_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables["SINHVIEN"].Rows.Find(dgvLopGT.CurrentRow.Cells["MaSV"].Value);

            frmSuaTTSV frm = new frmSuaTTSV(ds, row);
            frm.ShowDialog();

            SqlConnection ketNoi = new SqlConnection(chuoiKetNoi);
            adapterSinhVien.SelectCommand.Connection = ketNoi;
            new SqlCommandBuilder(adapterSinhVien);
            adapterSinhVien.Update(ds, "SINHVIEN");

        }

        private void btnXoaLopGT_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables["SINHVIEN"].Rows.Find(dgvLopGT.CurrentRow.Cells["MaSV"].Value);

            if(row != null) {
                row.Delete();
                MessageBox.Show("Đã xóa thành công");
            }

            SqlConnection ketNoi = new SqlConnection(chuoiKetNoi);
            adapterSinhVien.SelectCommand.Connection = ketNoi;
            new SqlCommandBuilder(adapterSinhVien);
            adapterSinhVien.Update(ds, "SINHVIEN");

        }

        private void csdlLopGianTiep_Load(object sender, EventArgs e)
        {
            SqlConnection ketNoi = new SqlConnection(chuoiKetNoi);
            adapterLop = new SqlDataAdapter("SELECT * FROM LOPHOC", ketNoi);
            adapterLop.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            new SqlCommandBuilder(adapterLop);
           
            adapterSinhVien = new SqlDataAdapter("SELECT * FROM SINHVIEN", ketNoi);
            adapterSinhVien.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            new SqlCommandBuilder(adapterSinhVien);
            adapterSinhVien.Fill(ds, "SINHVIEN");

            if(!ds.Relations.Contains("FK_Lop_SV"))
            {
                DataRelation rel = new DataRelation("FK_Lop_SV",
                     ds.Tables["LOPHOC"].Columns["MaLop"],
                     ds.Tables["SINHVIEN"].Columns["MaLop"]);
                ds.Relations.Add(rel);
            }
            dgvLopGT.DataSource = ds.Tables["SINHVIEN"];

        }
    }
}
