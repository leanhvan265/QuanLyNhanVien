namespace WindowsFormsApp1
{
    partial class frmMenu
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
            this.mnuChinh = new System.Windows.Forms.MenuStrip();
            this.mnuThemSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThemLop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLySinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.xemDanhSacshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemDanhSáchLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuChinh
            // 
            this.mnuChinh.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuChinh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThemSinhVien,
            this.mnuThemLop,
            this.mnuQuanLySinhVien,
            this.xemDanhSacshToolStripMenuItem,
            this.xemDanhSáchLớpToolStripMenuItem});
            this.mnuChinh.Location = new System.Drawing.Point(0, 0);
            this.mnuChinh.Name = "mnuChinh";
            this.mnuChinh.Size = new System.Drawing.Size(858, 28);
            this.mnuChinh.TabIndex = 1;
            this.mnuChinh.Text = "menuStrip1";
            // 
            // mnuThemSinhVien
            // 
            this.mnuThemSinhVien.Name = "mnuThemSinhVien";
            this.mnuThemSinhVien.Size = new System.Drawing.Size(121, 24);
            this.mnuThemSinhVien.Text = "Thêm sinh viên";
            this.mnuThemSinhVien.Click += new System.EventHandler(this.mnuThemSinhVien_Click);
            // 
            // mnuThemLop
            // 
            this.mnuThemLop.Name = "mnuThemLop";
            this.mnuThemLop.Size = new System.Drawing.Size(86, 24);
            this.mnuThemLop.Text = "Thêm lớp";
            this.mnuThemLop.Click += new System.EventHandler(this.mnuThemLop_Click);
            // 
            // mnuQuanLySinhVien
            // 
            this.mnuQuanLySinhVien.Name = "mnuQuanLySinhVien";
            this.mnuQuanLySinhVien.Size = new System.Drawing.Size(140, 24);
            this.mnuQuanLySinhVien.Text = "Quản Lý Sinh Viên";
            this.mnuQuanLySinhVien.Click += new System.EventHandler(this.mnuQuanLySinhVien_Click);
            // 
            // xemDanhSacshToolStripMenuItem
            // 
            this.xemDanhSacshToolStripMenuItem.Name = "xemDanhSacshToolStripMenuItem";
            this.xemDanhSacshToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.xemDanhSacshToolStripMenuItem.Text = "Xem Danh Sách SV";
            this.xemDanhSacshToolStripMenuItem.Click += new System.EventHandler(this.xemDanhSacshToolStripMenuItem_Click);
            // 
            // xemDanhSáchLớpToolStripMenuItem
            // 
            this.xemDanhSáchLớpToolStripMenuItem.Name = "xemDanhSáchLớpToolStripMenuItem";
            this.xemDanhSáchLớpToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.xemDanhSáchLớpToolStripMenuItem.Text = "Xem Danh Sách Lớp";
            this.xemDanhSáchLớpToolStripMenuItem.Click += new System.EventHandler(this.xemDanhSáchLớpToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 465);
            this.Controls.Add(this.mnuChinh);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuChinh;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenu";
            this.ShowIcon = false;
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.mnuChinh.ResumeLayout(false);
            this.mnuChinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuChinh;
        private System.Windows.Forms.ToolStripMenuItem mnuThemSinhVien;
        private System.Windows.Forms.ToolStripMenuItem mnuThemLop;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLySinhVien;
        private System.Windows.Forms.ToolStripMenuItem xemDanhSacshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemDanhSáchLớpToolStripMenuItem;
    }
}