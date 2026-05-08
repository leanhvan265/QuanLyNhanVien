using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class csdlView : Form
    {

        string chuoiKetNoi = @"Data Source=.\MSSQLSERVER01;Initial Catalog=QuanLySinhVien;Integrated Security=True";
        //Data data = new Data();

        public csdlView()
        {
            InitializeComponent();
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            frmThemSinhVien themSinhVien = new frmThemSinhVien();
            themSinhVien.ShowDialog();
        }

        private void csdlView_Load(object sender, EventArgs e)
        {
            Data data = new Data();
            dgvViewBang.DataSource = data.data("SELECT * FROM SINHVIEN");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvViewBang.CurrentRow != null)
            {
                string maSinhVien = dgvViewBang.CurrentRow.Cells["MaSV"].Value.ToString();
                SqlConnection ketNoi = new SqlConnection(chuoiKetNoi);
                string sql = $"DELETE FROM SINHVIEN WHERE MaSV = @MaSV";
                ketNoi.Open();
                SqlCommand thucHien = new SqlCommand(sql, ketNoi);
                thucHien.Parameters.AddWithValue("@MaSV", maSinhVien);
                int ketQua = thucHien.ExecuteNonQuery();
                if (ketQua > 0)
                    MessageBox.Show("Đã xóa sinh viên thành công");
                else MessageBox.Show("Xóa sinh viên thất bại");
                ketNoi.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvViewBang.CurrentRow != null)
            {
                string maSV = dgvViewBang.CurrentRow.Cells["MaSV"].Value.ToString();
                string tenSV = dgvViewBang.CurrentRow.Cells["TenSV"].Value.ToString();
                string ngaySinh = dgvViewBang.CurrentRow.Cells["NgaySinh"].Value.ToString();
                string gioiTinh = dgvViewBang.CurrentRow.Cells["GioiTinh"].Value.ToString();
                string maLop = dgvViewBang.CurrentRow.Cells["MaLop"].Value.ToString();
                frmSuaTTSV frm = new frmSuaTTSV(maSV, tenSV, ngaySinh, gioiTinh, maLop);
                frm.ShowDialog();
            }

        }
    }
}
