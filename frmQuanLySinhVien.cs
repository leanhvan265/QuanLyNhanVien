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
    public partial class frmQuanLySinhVien : Form
    {
        public frmQuanLySinhVien()
        {
            InitializeComponent();
        }

        private void frmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            trvDanhSachLop.Nodes.Clear();
            foreach (Lop lop in DanhSachLop.danhSach)
            {
                TreeNode node_lop = new TreeNode();
                node_lop.Tag = lop;
                node_lop.Text = lop.tenLop;
                trvDanhSachLop.Nodes.Add(node_lop);
                foreach (SinhVien sv in DanhSachSinhVien.danhSach)
                {
                    if (sv.maLop == lop.maLop)
                    {
                        TreeNode node_sinhvien = new TreeNode();
                        node_sinhvien.Tag = sv;
                        node_sinhvien.Text = sv.tenSinhVien;
                        node_lop.Nodes.Add(node_sinhvien);
                    }
                }
            }

            //lstDanhSachSinhVien.Items.Clear();
            //if (trvDanhSachLop.SelectedNode != null && trvDanhSachLop.SelectedNode.Tag is Lop)
            //{
            //    Lop lop = (Lop)trvDanhSachLop.SelectedNode.Tag;
            //    foreach (SinhVien sv in DanhSachSinhVien.danhSach)
            //    {
            //        if (sv.maLop == lop.maLop)
            //        {
            //            ListViewItem item_sinhvien = new ListViewItem();
            //            item_sinhvien.Tag = sv;
            //            item_sinhvien.Text = sv.maSinhVien;
            //            item_sinhvien.SubItems.Add(sv.tenSinhVien);
            //            item_sinhvien.SubItems.Add(sv.maLop);
            //            lstDanhSachSinhVien.Items.Add(item_sinhvien);
            //        }
            //    }
            //}

        

        //ListViewItem item = new ListViewItem();
        //    item.Tag = "CD243168";
        //    item.SubItems.Add("Lê Anh Văn");
        //    item.SubItems.Add("LTMT3 K16");
        //    lstDanhSachSinhVien.Items.Add(item);

        }

        private void trvDanhSachLop_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lstDanhSachSinhVien.Items.Clear();
            if (trvDanhSachLop.SelectedNode != null && trvDanhSachLop.SelectedNode.Tag is Lop)
            {
                Lop lop = (Lop)trvDanhSachLop.SelectedNode.Tag;
                foreach (SinhVien sv in DanhSachSinhVien.danhSach)
                {
                    if (sv.maLop == lop.maLop)
                    {
                        ListViewItem item_sinhvien = new ListViewItem();
                        item_sinhvien.Tag = sv;
                        item_sinhvien.Text = sv.maSinhVien;
                        item_sinhvien.SubItems.Add(sv.tenSinhVien);
                        item_sinhvien.SubItems.Add(sv.maLop);
                        lstDanhSachSinhVien.Items.Add(item_sinhvien);
                    }
                }
            }
        }
    }
}
