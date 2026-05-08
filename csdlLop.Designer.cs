namespace WindowsFormsApp1
{
    partial class csdlLop
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
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.btnThemLop = new System.Windows.Forms.Button();
            this.btnSuaLop = new System.Windows.Forms.Button();
            this.btnXoaLop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLop
            // 
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Location = new System.Drawing.Point(13, 13);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.RowHeadersWidth = 51;
            this.dgvLop.RowTemplate.Height = 24;
            this.dgvLop.Size = new System.Drawing.Size(775, 333);
            this.dgvLop.TabIndex = 0;
            // 
            // btnThemLop
            // 
            this.btnThemLop.Location = new System.Drawing.Point(55, 386);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(119, 39);
            this.btnThemLop.TabIndex = 1;
            this.btnThemLop.Text = "Thêm";
            this.btnThemLop.UseVisualStyleBackColor = true;
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // btnSuaLop
            // 
            this.btnSuaLop.Location = new System.Drawing.Point(343, 386);
            this.btnSuaLop.Name = "btnSuaLop";
            this.btnSuaLop.Size = new System.Drawing.Size(119, 39);
            this.btnSuaLop.TabIndex = 2;
            this.btnSuaLop.Text = "Sửa";
            this.btnSuaLop.UseVisualStyleBackColor = true;
            this.btnSuaLop.Click += new System.EventHandler(this.btnSuaLop_Click);
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.Location = new System.Drawing.Point(628, 386);
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.Size = new System.Drawing.Size(119, 39);
            this.btnXoaLop.TabIndex = 3;
            this.btnXoaLop.Text = "Xóa";
            this.btnXoaLop.UseVisualStyleBackColor = true;
            this.btnXoaLop.Click += new System.EventHandler(this.btnXoaLop_Click);
            // 
            // csdlLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXoaLop);
            this.Controls.Add(this.btnSuaLop);
            this.Controls.Add(this.btnThemLop);
            this.Controls.Add(this.dgvLop);
            this.Name = "csdlLop";
            this.Text = "csdlLop";
            this.Load += new System.EventHandler(this.csdlLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.Button btnThemLop;
        private System.Windows.Forms.Button btnSuaLop;
        private System.Windows.Forms.Button btnXoaLop;
    }
}