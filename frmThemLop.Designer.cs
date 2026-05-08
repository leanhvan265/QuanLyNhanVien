namespace WindowsFormsApp1
{
    partial class frmThemLop
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
            this.lblTen = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(70, 123);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(83, 23);
            this.lblTen.TabIndex = 13;
            this.lblTen.Text = "Tên lớp:";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(70, 82);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(78, 23);
            this.lblMa.TabIndex = 12;
            this.lblMa.Text = "Mã lớp:";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(147, 160);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 30);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(150, 119);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(152, 30);
            this.txtTen.TabIndex = 15;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(150, 78);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(152, 30);
            this.txtMa.TabIndex = 14;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(48, 37);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(277, 29);
            this.lblTieuDe.TabIndex = 11;
            this.lblTieuDe.Text = "NHẬP THÔNG TIN LỚP";
            // 
            // frmThemLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 248);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThemLop";
            this.ShowIcon = false;
            this.Text = "Thêm lớp";
            this.Load += new System.EventHandler(this.frmThemLop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label lblTieuDe;
    }
}