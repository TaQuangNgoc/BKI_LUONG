namespace BKI_DichVuMatDat
{
    partial class LOGIN_DETAIL
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_txt_username = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.m_txt_password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(47, 99);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 18);
            this.label19.TabIndex = 71;
            this.label19.Text = "PASSWORD";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // m_btn_dangnhap
            // 
            this.m_btn_dangnhap.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.m_btn_dangnhap.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.m_btn_dangnhap.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btn_dangnhap.Appearance.ForeColor = System.Drawing.Color.White;
            this.m_btn_dangnhap.Appearance.Options.UseBackColor = true;
            this.m_btn_dangnhap.Appearance.Options.UseFont = true;
            this.m_btn_dangnhap.Appearance.Options.UseForeColor = true;
            this.m_btn_dangnhap.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m_btn_dangnhap.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_btn_dangnhap.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.m_btn_dangnhap.Location = new System.Drawing.Point(172, 0);
            this.m_btn_dangnhap.Name = "m_btn_dangnhap";
            this.m_btn_dangnhap.Size = new System.Drawing.Size(143, 52);
            this.m_btn_dangnhap.TabIndex = 15;
            this.m_btn_dangnhap.Text = "ĐĂNG NHẬP";
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
            this.m_btn_thoat.Location = new System.Drawing.Point(315, 0);
            this.m_btn_thoat.Name = "m_btn_thoat";
            this.m_btn_thoat.Size = new System.Drawing.Size(116, 52);
            this.m_btn_thoat.TabIndex = 29;
            this.m_btn_thoat.Text = "THOÁT";
            this.m_btn_thoat.Click += new System.EventHandler(this.m_btn_thoat_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(47, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 18);
            this.label15.TabIndex = 70;
            this.label15.Text = "USERNAME";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(232)))), ((int)(((byte)(190)))));
            this.panel2.Controls.Add(this.m_btn_dangnhap);
            this.panel2.Controls.Add(this.m_btn_thoat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 248);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 52);
            this.panel2.TabIndex = 69;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(107, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "THÔNG TIN ĐĂNG NHẬP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 70);
            this.panel1.TabIndex = 68;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // m_txt_username
            // 
            this.m_txt_username.Depth = 0;
            this.m_txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txt_username.Hint = "";
            this.m_txt_username.Location = new System.Drawing.Point(172, 38);
            this.m_txt_username.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_txt_username.Name = "m_txt_username";
            this.m_txt_username.PasswordChar = '\0';
            this.m_txt_username.SelectedText = "";
            this.m_txt_username.SelectionLength = 0;
            this.m_txt_username.SelectionStart = 0;
            this.m_txt_username.Size = new System.Drawing.Size(187, 23);
            this.m_txt_username.TabIndex = 77;
            this.m_txt_username.UseSystemPasswordChar = false;
            this.m_txt_username.TextChanged += new System.EventHandler(this.m_txt_username_TextChanged);
            // 
            // m_txt_password
            // 
            this.m_txt_password.Depth = 0;
            this.m_txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txt_password.Hint = "";
            this.m_txt_password.Location = new System.Drawing.Point(172, 94);
            this.m_txt_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_txt_password.Name = "m_txt_password";
            this.m_txt_password.PasswordChar = '\0';
            this.m_txt_password.SelectedText = "";
            this.m_txt_password.SelectionLength = 0;
            this.m_txt_password.SelectionStart = 0;
            this.m_txt_password.Size = new System.Drawing.Size(187, 23);
            this.m_txt_password.TabIndex = 78;
            this.m_txt_password.UseSystemPasswordChar = true;
            this.m_txt_password.TextChanged += new System.EventHandler(this.m_txt_password_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.m_txt_password);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.m_txt_username);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(431, 178);
            this.panel3.TabIndex = 70;
            // 
            // LOGIN_DETAIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(232)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(431, 300);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "LOGIN_DETAIL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN_DETAIL";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label19;
        private DevExpress.XtraEditors.SimpleButton m_btn_dangnhap;
        private DevExpress.XtraEditors.SimpleButton m_btn_thoat;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField m_txt_username;
        private MaterialSkin.Controls.MaterialSingleLineTextField m_txt_password;
        private System.Windows.Forms.Panel panel3;
    }
}