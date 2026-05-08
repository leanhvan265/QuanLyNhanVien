namespace WindowsFormsApp1
{
    partial class frmSuaTTSV
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
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.btnLuuTT = new System.Windows.Forms.Button();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(50, 248);
            this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(101, 23);
            this.lblNgaySinh.TabIndex = 25;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(206, 245);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(148, 30);
            this.dtpNgaySinh.TabIndex = 24;
            this.dtpNgaySinh.Value = new System.DateTime(2026, 4, 28, 0, 0, 0, 0);
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(52, 305);
            this.lblLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(51, 23);
            this.lblLop.TabIndex = 17;
            this.lblLop.Text = "Lớp:";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(50, 199);
            this.lblGioiTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(91, 23);
            this.lblGioiTinh.TabIndex = 16;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(50, 150);
            this.lblTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(129, 23);
            this.lblTen.TabIndex = 15;
            this.lblTen.Text = "Tên sinh viên:";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(50, 95);
            this.lblMa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(124, 23);
            this.lblMa.TabIndex = 14;
            this.lblMa.Text = "Mã sinh viên:";
            // 
            // btnLuuTT
            // 
            this.btnLuuTT.Location = new System.Drawing.Point(185, 367);
            this.btnLuuTT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuuTT.Name = "btnLuuTT";
            this.btnLuuTT.Size = new System.Drawing.Size(103, 43);
            this.btnLuuTT.TabIndex = 23;
            this.btnLuuTT.Text = "Lưu";
            this.btnLuuTT.UseVisualStyleBackColor = true;
            this.btnLuuTT.Click += new System.EventHandler(this.btnLuuTT_Click);
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(206, 302);
            this.cboLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(211, 31);
            this.cboLop.TabIndex = 22;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(204, 146);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(211, 30);
            this.txtTen.TabIndex = 19;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(310, 199);
            this.rdoNu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(57, 27);
            this.rdoNu.TabIndex = 21;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(217, 197);
            this.rdoNam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(71, 27);
            this.rdoNam.TabIndex = 20;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // txtMa
            // 
            this.txtMa.Enabled = false;
            this.txtMa.Location = new System.Drawing.Point(204, 92);
            this.txtMa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(163, 30);
            this.txtMa.TabIndex = 18;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(69, 27);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(331, 29);
            this.lblTieuDe.TabIndex = 13;
            this.lblTieuDe.Text = "SỬA THÔNG TIN SINH VIÊN";
            // 
            // frmSuaTTSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 449);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.lblLop);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.btnLuuTT);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.rdoNu);
            this.Controls.Add(this.rdoNam);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSuaTTSV";
            this.Text = "frmSuaTTSV";
            this.Load += new System.EventHandler(this.frmSuaTTSV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Button btnLuuTT;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label lblTieuDe;
    }
}