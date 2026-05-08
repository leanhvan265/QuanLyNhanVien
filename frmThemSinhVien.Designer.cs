namespace WindowsFormsApp1
{
    partial class frmThemSinhVien
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblMa = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(49, 29);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(346, 29);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "NHẬP THÔNG TIN SINH VIÊN";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(209, 77);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(186, 30);
            this.txtMa.TabIndex = 5;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(209, 168);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(71, 27);
            this.rdoNam.TabIndex = 7;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(306, 168);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(57, 27);
            this.rdoNu.TabIndex = 8;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(209, 122);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(186, 30);
            this.txtTen.TabIndex = 6;
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(209, 264);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(186, 31);
            this.cboLop.TabIndex = 9;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(181, 328);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 30);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(79, 80);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(124, 23);
            this.lblMa.TabIndex = 1;
            this.lblMa.Text = "Mã sinh viên:";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(79, 125);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(129, 23);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Tên sinh viên:";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(79, 168);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(91, 23);
            this.lblGioiTinh.TabIndex = 3;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(79, 264);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(51, 23);
            this.lblLop.TabIndex = 4;
            this.lblLop.Text = "Lớp:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(209, 214);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(186, 30);
            this.dtpNgaySinh.TabIndex = 11;
            this.dtpNgaySinh.Value = new System.DateTime(2026, 4, 28, 0, 0, 0, 0);
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(78, 217);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(101, 23);
            this.lblNgaySinh.TabIndex = 12;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // frmThemSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 395);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.lblLop);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.rdoNu);
            this.Controls.Add(this.rdoNam);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThemSinhVien";
            this.ShowIcon = false;
            this.Text = "Thêm sinh viên";
            this.Load += new System.EventHandler(this.frmThemSinhVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblNgaySinh;
    }
}

