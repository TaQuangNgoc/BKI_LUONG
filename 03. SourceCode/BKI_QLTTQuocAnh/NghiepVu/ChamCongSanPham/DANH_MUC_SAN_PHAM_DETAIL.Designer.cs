namespace BKI_DichVuMatDat.NghiepVu.ChamCongSanPham
{
    partial class DANH_MUC_SAN_PHAM_DETAIL
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
            this.m_txt_ten_san_pham = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.m_txt_ma_san_pham = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_btn_luu = new DevExpress.XtraEditors.SimpleButton();
            this.m_btn_xoa_luong = new DevExpress.XtraEditors.SimpleButton();
            
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_txt_ten_san_pham
            // 
            this.m_txt_ten_san_pham.Location = new System.Drawing.Point(166, 162);
            this.m_txt_ten_san_pham.Name = "m_txt_ten_san_pham";
            
            this.m_txt_ten_san_pham.Size = new System.Drawing.Size(319, 26);
            this.m_txt_ten_san_pham.TabIndex = 29;
            // 
            // m_txt_ma_san_pham
            // 
            this.m_txt_ma_san_pham.Location = new System.Drawing.Point(166, 99);
            this.m_txt_ma_san_pham.Name = "m_txt_ma_san_pham";
            
            this.m_txt_ma_san_pham.Size = new System.Drawing.Size(319, 26);
            this.m_txt_ma_san_pham.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mã sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tên sản phẩm";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 53);
            this.panel1.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(45, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "THÔNG TIN CHI TIẾT SẢN PHẨM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.m_btn_luu);
            this.panel2.Controls.Add(this.m_btn_xoa_luong);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 262);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 53);
            this.panel2.TabIndex = 33;
            // 
            // m_btn_luu
            // 
            this.m_btn_luu.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.m_btn_luu.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.m_btn_luu.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btn_luu.Appearance.ForeColor = System.Drawing.Color.White;
            this.m_btn_luu.Appearance.Options.UseBackColor = true;
            this.m_btn_luu.Appearance.Options.UseFont = true;
            this.m_btn_luu.Appearance.Options.UseForeColor = true;
            this.m_btn_luu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m_btn_luu.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_btn_luu.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.m_btn_luu.Location = new System.Drawing.Point(342, 0);
            this.m_btn_luu.Name = "m_btn_luu";
            this.m_btn_luu.Size = new System.Drawing.Size(143, 53);
            this.m_btn_luu.TabIndex = 15;
            this.m_btn_luu.Text = "LƯU";
            this.m_btn_luu.Click += new System.EventHandler(this.m_btn_luu_Click);
            // 
            // m_btn_xoa_luong
            // 
            this.m_btn_xoa_luong.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.m_btn_xoa_luong.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.m_btn_xoa_luong.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btn_xoa_luong.Appearance.ForeColor = System.Drawing.Color.Black;
            this.m_btn_xoa_luong.Appearance.Options.UseBackColor = true;
            this.m_btn_xoa_luong.Appearance.Options.UseFont = true;
            this.m_btn_xoa_luong.Appearance.Options.UseForeColor = true;
            this.m_btn_xoa_luong.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m_btn_xoa_luong.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_btn_xoa_luong.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.m_btn_xoa_luong.Location = new System.Drawing.Point(485, 0);
            this.m_btn_xoa_luong.Name = "m_btn_xoa_luong";
            this.m_btn_xoa_luong.Size = new System.Drawing.Size(116, 53);
            this.m_btn_xoa_luong.TabIndex = 29;
            this.m_btn_xoa_luong.Text = "THOÁT";
            this.m_btn_xoa_luong.Click += new System.EventHandler(this.m_btn_xoa_luong_Click);
            // 
            // DANH_MUC_SAN_PHAM_DETAIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 315);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_txt_ten_san_pham);
            this.Controls.Add(this.m_txt_ma_san_pham);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DANH_MUC_SAN_PHAM_DETAIL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH_MUC_SAN_PHAM_DETAIL";
            
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField m_txt_ten_san_pham;
        private MaterialSkin.Controls.MaterialSingleLineTextField m_txt_ma_san_pham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton m_btn_luu;
        private DevExpress.XtraEditors.SimpleButton m_btn_xoa_luong;

    }
}