namespace BKI_DichVuMatDat.BaoCao.Luong
{
    partial class BANG_LUONG
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_grc = new DevExpress.XtraGrid.GridControl();
            this.m_grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.m_dat_chon_thang = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.m_lbl_trang_thai_cham_cong = new DevExpress.XtraEditors.LabelControl();
            this.m_bgwk = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.m_cmd_nhap_cham_cong = new DevExpress.XtraEditors.SimpleButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.m_txt_hien_thi = new DevExpress.XtraEditors.SimpleButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_chon_thang.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_chon_thang.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_grc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(836, 260);
            this.panel2.TabIndex = 14;
            // 
            // m_grc
            // 
            this.m_grc.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc.Location = new System.Drawing.Point(0, 0);
            this.m_grc.MainView = this.m_grv;
            this.m_grc.Name = "m_grc";
            this.m_grc.Size = new System.Drawing.Size(836, 260);
            this.m_grc.TabIndex = 0;
            this.m_grc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv});
            // 
            // m_grv
            // 
            this.m_grv.GridControl = this.m_grc;
            this.m_grv.Name = "m_grv";
            this.m_grv.OptionsBehavior.Editable = false;
            this.m_grv.OptionsFind.AllowFindPanel = false;
            this.m_grv.OptionsFind.AlwaysVisible = true;
            this.m_grv.OptionsView.ColumnAutoWidth = false;
            this.m_grv.OptionsView.ShowFooter = true;
            this.m_grv.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.m_dat_chon_thang);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.m_lbl_trang_thai_cham_cong);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(280, 70);
            this.panelControl1.TabIndex = 1;
            // 
            // m_dat_chon_thang
            // 
            this.m_dat_chon_thang.EditValue = null;
            this.m_dat_chon_thang.Location = new System.Drawing.Point(90, 15);
            this.m_dat_chon_thang.Name = "m_dat_chon_thang";
            this.m_dat_chon_thang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_dat_chon_thang.Properties.Appearance.ForeColor = System.Drawing.Color.Green;
            this.m_dat_chon_thang.Properties.Appearance.Options.UseFont = true;
            this.m_dat_chon_thang.Properties.Appearance.Options.UseForeColor = true;
            this.m_dat_chon_thang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_chon_thang.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_chon_thang.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.m_dat_chon_thang.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.m_dat_chon_thang.Properties.Mask.EditMask = "MM/yyyy";
            this.m_dat_chon_thang.Size = new System.Drawing.Size(127, 24);
            this.m_dat_chon_thang.TabIndex = 21;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(28, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 18);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Tháng";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(28, 20);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(0, 13);
            this.labelControl2.TabIndex = 19;
            // 
            // m_lbl_trang_thai_cham_cong
            // 
            this.m_lbl_trang_thai_cham_cong.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_trang_thai_cham_cong.Appearance.ForeColor = System.Drawing.Color.ForestGreen;
            this.m_lbl_trang_thai_cham_cong.Location = new System.Drawing.Point(27, 50);
            this.m_lbl_trang_thai_cham_cong.Name = "m_lbl_trang_thai_cham_cong";
            this.m_lbl_trang_thai_cham_cong.Size = new System.Drawing.Size(0, 14);
            this.m_lbl_trang_thai_cham_cong.TabIndex = 3;
            // 
            // m_bgwk
            // 
            this.m_bgwk.WorkerReportsProgress = true;
            this.m_bgwk.WorkerSupportsCancellation = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(214)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 53);
            this.panel1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(199, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "BẢNG LƯƠNG THÁNG\r\n";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.m_cmd_nhap_cham_cong);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 383);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(836, 53);
            this.panel3.TabIndex = 17;
            // 
            // m_cmd_nhap_cham_cong
            // 
            this.m_cmd_nhap_cham_cong.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(214)))));
            this.m_cmd_nhap_cham_cong.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(214)))));
            this.m_cmd_nhap_cham_cong.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_nhap_cham_cong.Appearance.ForeColor = System.Drawing.Color.White;
            this.m_cmd_nhap_cham_cong.Appearance.Options.UseBackColor = true;
            this.m_cmd_nhap_cham_cong.Appearance.Options.UseFont = true;
            this.m_cmd_nhap_cham_cong.Appearance.Options.UseForeColor = true;
            this.m_cmd_nhap_cham_cong.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m_cmd_nhap_cham_cong.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_nhap_cham_cong.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.m_cmd_nhap_cham_cong.Location = new System.Drawing.Point(626, 0);
            this.m_cmd_nhap_cham_cong.Name = "m_cmd_nhap_cham_cong";
            this.m_cmd_nhap_cham_cong.Size = new System.Drawing.Size(210, 53);
            this.m_cmd_nhap_cham_cong.TabIndex = 15;
            this.m_cmd_nhap_cham_cong.Text = "LƯU CHẤM CÔNG";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.m_txt_hien_thi);
            this.panel7.Controls.Add(this.panelControl1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 53);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(836, 70);
            this.panel7.TabIndex = 15;
            // 
            // m_txt_hien_thi
            // 
            this.m_txt_hien_thi.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(214)))));
            this.m_txt_hien_thi.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(214)))));
            this.m_txt_hien_thi.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txt_hien_thi.Appearance.ForeColor = System.Drawing.Color.White;
            this.m_txt_hien_thi.Appearance.Options.UseBackColor = true;
            this.m_txt_hien_thi.Appearance.Options.UseFont = true;
            this.m_txt_hien_thi.Appearance.Options.UseForeColor = true;
            this.m_txt_hien_thi.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m_txt_hien_thi.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.m_txt_hien_thi.Location = new System.Drawing.Point(286, 6);
            this.m_txt_hien_thi.Name = "m_txt_hien_thi";
            this.m_txt_hien_thi.Size = new System.Drawing.Size(210, 47);
            this.m_txt_hien_thi.TabIndex = 16;
            this.m_txt_hien_thi.Text = "HIỂN THỊ";
            this.m_txt_hien_thi.Click += new System.EventHandler(this.m_txt_hien_thi_Click);
            // 
            // BANG_LUONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 436);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Name = "BANG_LUONG";
            this.Text = "BANG_LUONG";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_chon_thang.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_chon_thang.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl m_grc;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.DateEdit m_dat_chon_thang;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl m_lbl_trang_thai_cham_cong;
        private System.ComponentModel.BackgroundWorker m_bgwk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton m_cmd_nhap_cham_cong;
        private System.Windows.Forms.Panel panel7;
        private DevExpress.XtraEditors.SimpleButton m_txt_hien_thi;
    }
}