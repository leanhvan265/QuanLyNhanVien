namespace WindowsFormsApp1
{
    partial class csdlLopGianTiep
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
            this.btnXoaLopGT = new System.Windows.Forms.Button();
            this.btnSuaLopGT = new System.Windows.Forms.Button();
            this.btnThemLopGT = new System.Windows.Forms.Button();
            this.dgvLopGT = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopGT)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoaLopGT
            // 
            this.btnXoaLopGT.Location = new System.Drawing.Point(628, 392);
            this.btnXoaLopGT.Name = "btnXoaLopGT";
            this.btnXoaLopGT.Size = new System.Drawing.Size(119, 39);
            this.btnXoaLopGT.TabIndex = 7;
            this.btnXoaLopGT.Text = "Xóa";
            this.btnXoaLopGT.UseVisualStyleBackColor = true;
            this.btnXoaLopGT.Click += new System.EventHandler(this.btnXoaLopGT_Click);
            // 
            // btnSuaLopGT
            // 
            this.btnSuaLopGT.Location = new System.Drawing.Point(343, 392);
            this.btnSuaLopGT.Name = "btnSuaLopGT";
            this.btnSuaLopGT.Size = new System.Drawing.Size(119, 39);
            this.btnSuaLopGT.TabIndex = 6;
            this.btnSuaLopGT.Text = "Sửa";
            this.btnSuaLopGT.UseVisualStyleBackColor = true;
            this.btnSuaLopGT.Click += new System.EventHandler(this.btnSuaLopGT_Click);
            // 
            // btnThemLopGT
            // 
            this.btnThemLopGT.Location = new System.Drawing.Point(55, 392);
            this.btnThemLopGT.Name = "btnThemLopGT";
            this.btnThemLopGT.Size = new System.Drawing.Size(119, 39);
            this.btnThemLopGT.TabIndex = 5;
            this.btnThemLopGT.Text = "Thêm";
            this.btnThemLopGT.UseVisualStyleBackColor = true;
            this.btnThemLopGT.Click += new System.EventHandler(this.btnThemLopGT_Click);
            // 
            // dgvLopGT
            // 
            this.dgvLopGT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopGT.Location = new System.Drawing.Point(13, 19);
            this.dgvLopGT.Name = "dgvLopGT";
            this.dgvLopGT.RowHeadersWidth = 51;
            this.dgvLopGT.RowTemplate.Height = 24;
            this.dgvLopGT.Size = new System.Drawing.Size(775, 333);
            this.dgvLopGT.TabIndex = 4;
            // 
            // csdlLopGianTiep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXoaLopGT);
            this.Controls.Add(this.btnSuaLopGT);
            this.Controls.Add(this.btnThemLopGT);
            this.Controls.Add(this.dgvLopGT);
            this.Name = "csdlLopGianTiep";
            this.Text = "csdlLopGianTiep";
            this.Load += new System.EventHandler(this.csdlLopGianTiep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopGT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXoaLopGT;
        private System.Windows.Forms.Button btnSuaLopGT;
        private System.Windows.Forms.Button btnThemLopGT;
        private System.Windows.Forms.DataGridView dgvLopGT;
    }
}