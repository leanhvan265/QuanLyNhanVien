using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmThemLop : Form
    {
        public frmThemLop()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maLop = txtMa.Text;
            string tenLop = txtTen.Text;

            string sql = $"INSERT INTO LOPHOC (MaLop, TenLop) VALUES " +
                $"('{maLop}', '{tenLop}')";

            Data themlop = new Data();
            int ketQua = themlop.data(sql).Rows.Count;

            if (ketQua > 0)
            {
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
        }

        private void frmThemLop_Load(object sender, EventArgs e)
        {
            
        }
    }
}
