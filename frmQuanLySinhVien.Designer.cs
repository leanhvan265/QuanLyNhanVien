namespace WindowsFormsApp1
{
    partial class frmQuanLySinhVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.trvDanhSachLop = new System.Windows.Forms.TreeView();
            this.lstDanhSachSinhVien = new System.Windows.Forms.ListView();
            this.maSinhVien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenSinhVien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // trvDanhSachLop
            // 
            this.trvDanhSachLop.Location = new System.Drawing.Point(16, 12);
            this.trvDanhSachLop.Name = "trvDanhSachLop";
            this.trvDanhSachLop.Size = new System.Drawing.Size(166, 323);
            this.trvDanhSachLop.TabIndex = 0;
            this.trvDanhSachLop.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvDanhSachLop_AfterSelect);
            // 
            // lstDanhSachSinhVien
            // 
            this.lstDanhSachSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maSinhVien,
            this.tenSinhVien,
            this.lop});
            this.lstDanhSachSinhVien.FullRowSelect = true;
            this.lstDanhSachSinhVien.GridLines = true;
            this.lstDanhSachSinhVien.HideSelection = false;
            this.lstDanhSachSinhVien.Location = new System.Drawing.Point(203, 11);
            this.lstDanhSachSinhVien.Name = "lstDanhSachSinhVien";
            this.lstDanhSachSinhVien.Size = new System.Drawing.Size(586, 435);
            this.lstDanhSachSinhVien.TabIndex = 1;
            this.lstDanhSachSinhVien.UseCompatibleStateImageBehavior = false;
            this.lstDanhSachSinhVien.View = System.Windows.Forms.View.Details;
            // 
            // maSinhVien
            // 
            this.maSinhVien.Text = "Mã Sinh Viên";
            this.maSinhVien.Width = 156;
            // 
            // tenSinhVien
            // 
            this.tenSinhVien.Text = "Tên Sinh Viên";
            this.tenSinhVien.Width = 148;
            // 
            // lop
            // 
            this.lop.Text = "Lớp";
            this.lop.Width = 107;
            // 
            // frmQuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 476);
            this.Controls.Add(this.lstDanhSachSinhVien);
            this.Controls.Add(this.trvDanhSachLop);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLySinhVien";
            this.Text = "frmQuanLySinhVien";
            this.Load += new System.EventHandler(this.frmQuanLySinhVien_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvDanhSachLop;
        private System.Windows.Forms.ListView lstDanhSachSinhVien;
        private System.Windows.Forms.ColumnHeader maSinhVien;
        private System.Windows.Forms.ColumnHeader tenSinhVien;
        private System.Windows.Forms.ColumnHeader lop;
    }
}