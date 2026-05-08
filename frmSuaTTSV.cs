using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmSuaTTSV : Form
    {
        private DataSet ds;
        private DataRow row;

        string chuoiKetNoi = @"Data Source=.\MSSQLSERVER01;Initial Catalog=QuanLySinhVien;Integrated Security=True";

        //private string maSV;
        //private string tenSV;
        //private string ngaySinh;
        //private string gioiTinh;
        //private string lop;

        //public frmSuaTTSV(string maSV, string tenSV, string ngaySinh, string gioiTinh, string maLop)
        //{
        //    InitializeComponent();
        //    this.maSV = maSV;
        //    this.tenSV = tenSV;
        //    this.ngaySinh = ngaySinh;
        //    this.gioiTinh = gioiTinh;
        //    this.lop = maLop;
        //}

        public frmSuaTTSV(DataSet ds, DataRow row)
        {
            InitializeComponent();
            this.ds = ds;
            this.row = row;
        }

        private void frmSuaTTSV_Load(object sender, EventArgs e)
        {
            cboLop.Items.Clear();
            cboLop.DataSource = ds.Tables["LOPHOC"];
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
            cboLop.SelectedIndex = -1;

            txtMa.Text = row["MaSV"].ToString();
            txtTen.Text = row["TenSV"].ToString();
            if (row["GioiTinh"].ToString() == "Nam") rdoNam.Checked = true;
            else rdoNam.Checked = false;
            dtpNgaySinh.Text = row["NgaySinh"].ToString();
            cboLop.SelectedValue = row["MaLop"].ToString();

            //txtMa.Text = maSV;
            //Data lop = new Data();
            //cboLop.DataSource = lop.data("SELECT * FROM LOPHOC");
            //cboLop.DisplayMember = "tenLop";
            //cboLop.ValueMember = "maLop";
            //cboLop.SelectedIndex = -1;

            //txtMa.Text = maSV;
            //txtTen.Text = tenSV;
            //if (gioiTinh == "Nam") rdoNam.Checked = true;
            //else rdoNu.Checked = true;
            //dtpNgaySinh.Text = ngaySinh;
            //cboLop.SelectedValue = lop;

        }

        private void btnLuuTT_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables["SINHVIEN"].Rows.Find(txtMa.Text);
            if (row != null)
            {
                row["TenSV"] = txtTen.Text;
                row["NgaySinh"] = dtpNgaySinh.Value;
                if (rdoNam.Checked) row["GioiTinh"] = "Nam";
                else row["GioiTinh"] = "Nữ";
                row["MaLop"] = cboLop.SelectedValue;
            }
            MessageBox.Show("Đã sửa thành công");
            this.Close();
        }

    }
}
