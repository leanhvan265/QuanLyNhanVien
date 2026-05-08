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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void mnuThemSinhVien_Click(object sender, EventArgs e)
        {
            frmThemSinhVien frm = new frmThemSinhVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuThemLop_Click(object sender, EventArgs e)
        {
            frmThemLop frm = new frmThemLop();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuQuanLySinhVien_Click(object sender, EventArgs e)
        {
            frmQuanLySinhVien frm = new frmQuanLySinhVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void xemDanhSacshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            csdlView frm = new csdlView();
            frm.MdiParent = this;
            frm.Show();
        }

        private void xemDanhSáchLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            csdlLopGianTiep frm = new csdlLopGianTiep();
            frm.MdiParent = this;   
            frm.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
