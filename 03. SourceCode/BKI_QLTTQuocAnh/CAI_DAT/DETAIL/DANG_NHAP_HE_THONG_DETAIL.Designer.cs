namespace BKI_DichVuMatDat.CAI_DAT.DETAIL
{
    partial class DANG_NHAP_HE_THONG_DETAIL
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
            this.components = new System.ComponentModel.Container();
            this.label19 = new System.Windows.Forms.Label();
            this.m_btn_dangnhap = new DevExpress.XtraEditors.SimpleButton();
            this.m_btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.m_txt_password = new System.Windows.Forms.TextBox();
            this.m_txt_username = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(23, 158);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 18);
            this.label19.TabIndex = 82;
            this.label19.Text = "PASSWORD";
            // 
            // m_btn_dangnhap
            // 
            this.m_btn_dangnhap.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(214)))));
            this.m_btn_dangnhap.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(214)))));
            this.m_btn_dangnhap.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btn_dangnhap.Appearance.ForeColor = System.Drawing.Color.White;
            this.m_btn_dangnhap.Appearance.Options.UseBackColor = true;
            this.m_btn_dangnhap.Appearance.Options.UseFont = true;
            this.m_btn_dangnhap.Appearance.Options.UseForeColor = true;
            this.m_btn_dangnhap.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m_btn_dangnhap.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_btn_dangnhap.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.m_btn_dangnhap.Location = new System.Drawing.Point(171, 0);
            this.m_btn_dangnhap.Name = "m_btn_dangnhap";
            this.m_btn_dangnhap.Size = new System.Drawing.Size(143, 53);
            this.m_btn_dangnhap.TabIndex = 15;
            this.m_btn_dangnhap.Text = "LƯU";
            this.m_btn_dangnhap.Click += new System.EventHandler(this.m_btn_dangnhap_Click);
            // 
            // m_btn_thoat
            // 
            this.m_btn_thoat.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.m_btn_thoat.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.m_btn_thoat.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btn_thoat.Appearance.ForeColor = System.Drawing.Color.Black;
            this.m_btn_thoat.Appearance.Options.UseBackColor = true;
            this.m_btn_thoat.Appearance.Options.UseFont = true;
            this.m_btn_thoat.Appearance.Options.UseForeColor = true;
            this.m_btn_thoat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m_btn_thoat.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_btn_thoat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.m_btn_thoat.Location = new System.Drawing.Point(314, 0);
            this.m_btn_thoat.Name = "m_btn_thoat";
            this.m_btn_thoat.Size = new System.Drawing.Size(116, 53);
            this.m_btn_thoat.TabIndex = 29;
            this.m_btn_thoat.Text = "THOÁT";
            this.m_btn_thoat.Click += new System.EventHandler(this.m_btn_thoat_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(23, 110);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 18);
            this.label15.TabIndex = 81;
            this.label15.Text = "USERNAME";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.m_btn_dangnhap);
            this.panel2.Controls.Add(this.m_btn_thoat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 251);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 53);
            this.panel2.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(107, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "THÔNG TIN ĐĂNG NHẬP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // m_txt_password
            // 
            this.m_txt_password.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txt_password.Location = new System.Drawing.Point(156, 150);
            this.m_txt_password.Name = "m_txt_password";
            this.m_txt_password.Size = new System.Drawing.Size(187, 26);
            this.m_txt_password.TabIndex = 84;
            // 
            // m_txt_username
            // 
            this.m_txt_username.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txt_username.Location = new System.Drawing.Point(156, 102);
            this.m_txt_username.Name = "m_txt_username";
            this.m_txt_username.Size = new System.Drawing.Size(187, 26);
            this.m_txt_username.TabIndex = 83;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(214)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 53);
            this.panel1.TabIndex = 79;
            // 
            // DANG_NHAP_HE_THONG_DETAIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 304);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.m_txt_password);
            this.Controls.Add(this.m_txt_username);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DANG_NHAP_HE_THONG_DETAIL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANG_NHAP_HE_THONG_DETAIL";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label19;
        private DevExpress.XtraEditors.SimpleButton m_btn_dangnhap;
        private DevExpress.XtraEditors.SimpleButton m_btn_thoat;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_txt_password;
        private System.Windows.Forms.TextBox m_txt_username;
        private System.Windows.Forms.Panel panel1;
    }
}