namespace BKI_DichVuMatDat.CAI_DAT
{
    partial class DANG_NHAP_HE_THONG
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_grc_dang_nhap_he_thong = new DevExpress.XtraGrid.GridControl();
            this.m_grv_dang_nhap_he_thong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.USERNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PASSWORD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.m_btn_sua = new DevExpress.XtraEditors.SimpleButton();
            this.m_btn_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dang_nhap_he_thong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dang_nhap_he_thong)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_grc_dang_nhap_he_thong);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 415);
            this.panel1.TabIndex = 0;
            // 
            // m_grc_dang_nhap_he_thong
            // 
            this.m_grc_dang_nhap_he_thong.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_dang_nhap_he_thong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_dang_nhap_he_thong.Location = new System.Drawing.Point(0, 53);
            this.m_grc_dang_nhap_he_thong.MainView = this.m_grv_dang_nhap_he_thong;
            this.m_grc_dang_nhap_he_thong.Name = "m_grc_dang_nhap_he_thong";
            this.m_grc_dang_nhap_he_thong.Size = new System.Drawing.Size(709, 309);
            this.m_grc_dang_nhap_he_thong.TabIndex = 16;
            this.m_grc_dang_nhap_he_thong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_dang_nhap_he_thong});
            // 
            // m_grv_dang_nhap_he_thong
            // 
            this.m_grv_dang_nhap_he_thong.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_grv_dang_nhap_he_thong.Appearance.HeaderPanel.Options.UseFont = true;
            this.m_grv_dang_nhap_he_thong.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_grv_dang_nhap_he_thong.Appearance.Row.Options.UseFont = true;
            this.m_grv_dang_nhap_he_thong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.USERNAME,
            this.PASSWORD});
            this.m_grv_dang_nhap_he_thong.GridControl = this.m_grc_dang_nhap_he_thong;
            this.m_grv_dang_nhap_he_thong.Name = "m_grv_dang_nhap_he_thong";
            this.m_grv_dang_nhap_he_thong.OptionsView.ShowGroupPanel = false;
            // 
            // USERNAME
            // 
            this.USERNAME.Caption = "USERNAME";
            this.USERNAME.FieldName = "USERNAME";
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.Visible = true;
            this.USERNAME.VisibleIndex = 0;
            // 
            // PASSWORD
            // 
            this.PASSWORD.Caption = "PASSWORD";
            this.PASSWORD.FieldName = "PASSWORD";
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.Visible = true;
            this.PASSWORD.VisibleIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.m_btn_them);
            this.panel2.Controls.Add(this.m_btn_sua);
            this.panel2.Controls.Add(this.m_btn_xoa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 362);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(709, 53);
            this.panel2.TabIndex = 15;
            // 
            // m_btn_them
            // 
            this.m_btn_them.Appearance.BackColor = System.Drawing.Color.Maroon;
            this.m_btn_them.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.m_btn_them.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btn_them.Appearance.ForeColor = System.Drawing.Color.White;
            this.m_btn_them.Appearance.Options.UseBackColor = true;
            this.m_btn_them.Appearance.Options.UseFont = true;
            this.m_btn_them.Appearance.Options.UseForeColor = true;
            this.m_btn_them.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m_btn_them.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_btn_them.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.m_btn_them.Location = new System.Drawing.Point(307, 0);
            this.m_btn_them.Name = "m_btn_them";
            this.m_btn_them.Size = new System.Drawing.Size(143, 53);
            this.m_btn_them.TabIndex = 30;
            this.m_btn_them.Text = "THÊM";
            this.m_btn_them.Click += new System.EventHandler(this.m_btn_them_Click);
            // 
            // m_btn_sua
            // 
            this.m_btn_sua.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.m_btn_sua.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.m_btn_sua.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btn_sua.Appearance.ForeColor = System.Drawing.Color.White;
            this.m_btn_sua.Appearance.Options.UseBackColor = true;
            this.m_btn_sua.Appearance.Options.UseFont = true;
            this.m_btn_sua.Appearance.Options.UseForeColor = true;
            this.m_btn_sua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m_btn_sua.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_btn_sua.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.m_btn_sua.Location = new System.Drawing.Point(450, 0);
            this.m_btn_sua.Name = "m_btn_sua";
            this.m_btn_sua.Size = new System.Drawing.Size(143, 53);
            this.m_btn_sua.TabIndex = 15;
            this.m_btn_sua.Text = "SỬA";
            this.m_btn_sua.Click += new System.EventHandler(this.m_btn_sua_Click);
            // 
            // m_btn_xoa
            // 
            this.m_btn_xoa.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.m_btn_xoa.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.m_btn_xoa.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btn_xoa.Appearance.ForeColor = System.Drawing.Color.Black;
            this.m_btn_xoa.Appearance.Options.UseBackColor = true;
            this.m_btn_xoa.Appearance.Options.UseFont = true;
            this.m_btn_xoa.Appearance.Options.UseForeColor = true;
            this.m_btn_xoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m_btn_xoa.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_btn_xoa.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.m_btn_xoa.Location = new System.Drawing.Point(593, 0);
            this.m_btn_xoa.Name = "m_btn_xoa";
            this.m_btn_xoa.Size = new System.Drawing.Size(116, 53);
            this.m_btn_xoa.TabIndex = 29;
            this.m_btn_xoa.Text = "XÓA";
            this.m_btn_xoa.Click += new System.EventHandler(this.m_btn_xoa_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(709, 53);
            this.panel3.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(124, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "QUẢN LÝ DANH SÁCH USER";
            // 
            // DANG_NHAP_HE_THONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 415);
            this.Controls.Add(this.panel1);
            this.Name = "DANG_NHAP_HE_THONG";
            this.Text = "DANG_NHAP_HE_THONG";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dang_nhap_he_thong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dang_nhap_he_thong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl m_grc_dang_nhap_he_thong;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_dang_nhap_he_thong;
        private DevExpress.XtraGrid.Columns.GridColumn USERNAME;
        private DevExpress.XtraGrid.Columns.GridColumn PASSWORD;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton m_btn_them;
        private DevExpress.XtraEditors.SimpleButton m_btn_sua;
        private DevExpress.XtraEditors.SimpleButton m_btn_xoa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;


    }
}