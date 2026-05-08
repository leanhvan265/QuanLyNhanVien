using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class csdlLop : Form
    {
        

        public csdlLop()
        {
            InitializeComponent();
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            frmThemLop themLop = new frmThemLop();
            themLop.ShowDialog();
            Data data = new Data();
            dgvLop.DataSource = data.data("SELECT * FROM LOPHOC");
        }

        private void csdlLop_Load(object sender, EventArgs e)
        {
            Data data = new Data();
            dgvLop.DataSource = data.data("SELECT * FROM LOPHOC");
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            //frmSuaTTSV frm = new frmSuaTTSV();
            //frm.ShowDialog();

        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            
        }
    }
}
