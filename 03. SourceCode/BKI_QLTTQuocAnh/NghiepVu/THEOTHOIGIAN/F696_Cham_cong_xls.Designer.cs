namespace BKI_DichVuMatDat.NghiepVu
{
    partial class F696_Cham_cong_xls
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
            this.m_pn = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.m_prb = new DevExpress.XtraEditors.ProgressBarControl();
            this.m_grc = new DevExpress.XtraGrid.GridControl();
            this.m_grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.m_bgwk = new System.ComponentModel.BackgroundWorker();
            this.panel7 = new System.Windows.Forms.Panel();
            this.m_btn_hien_thi = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_mo_file_mau = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_chon_du_lieu = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.m_dat_chon_thang = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.m_lbl_trang_thai_cham_cong = new DevExpress.XtraEditors.LabelControl();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::BKI_DichVuMatDat.BaoCao.F_wait_form), true, true);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.m_cmd_nhap_cham_cong = new DevExpress.XtraEditors.SimpleButton();
            this.panel2.SuspendLayout();
            this.m_pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_prb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_chon_thang.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_chon_thang.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_pn);
            this.panel2.Controls.Add(this.m_grc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 260);
            this.panel2.TabIndex = 1;
            // 
            // m_pn
            // 
            this.m_pn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.m_pn.Controls.Add(this.label1);
            this.m_pn.Controls.Add(this.m_prb);
            this.m_pn.Location = new System.Drawing.Point(111, 142);
            this.m_pn.Name = "m_pn";
            this.m_pn.Padding = new System.Windows.Forms.Padding(10);
            this.m_pn.Size = new System.Drawing.Size(618, 68);
            this.m_pn.TabIndex = 3;
            this.m_pn.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đang lưu dữ liệu. Vui lòng chờ trong giây lát...";
            // 
            // m_prb
            // 
            this.m_prb.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_prb.Location = new System.Drawing.Point(10, 10);
            this.m_prb.Name = "m_prb";
            this.m_prb.Properties.DisplayFormat.FormatString = "00";
            this.m_prb.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.m_prb.ShowProgressInTaskBar = true;
            this.m_prb.Size = new System.Drawing.Size(598, 30);
            this.m_prb.TabIndex = 2;
            this.m_prb.Visible = false;
            // 
            // m_grc
            // 
            this.m_grc.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc.Location = new System.Drawing.Point(0, 0);
            this.m_grc.MainView = this.m_grv;
            this.m_grc.Name = "m_grc";
            this.m_grc.Size = new System.Drawing.Size(1034, 260);
            this.m_grc.TabIndex = 0;
            this.m_grc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv});
            // 
            // m_grv
            // 
            this.m_grv.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(187)))), ((int)(((byte)(102)))));
            this.m_grv.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(187)))), ((int)(((byte)(102)))));
            this.m_grv.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_grv.Appearance.FocusedRow.Options.UseBackColor = true;
            this.m_grv.Appearance.FocusedRow.Options.UseFont = true;
            this.m_grv.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.m_grv.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.m_grv.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.m_grv.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_grv.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White;
            this.m_grv.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.m_grv.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.m_grv.Appearance.HeaderPanel.Options.UseFont = true;
            this.m_grv.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.m_grv.GridControl = this.m_grc;
            this.m_grv.Name = "m_grv";
            this.m_grv.OptionsBehavior.Editable = false;
            this.m_grv.OptionsView.ColumnAutoWidth = false;
            this.m_grv.OptionsView.ShowFooter = true;
            this.m_grv.OptionsView.ShowGroupPanel = false;
            this.m_grv.PaintStyleName = "Web";
            // 
            // m_bgwk
            // 
            this.m_bgwk.WorkerReportsProgress = true;
            this.m_bgwk.WorkerSupportsCancellation = true;
            this.m_bgwk.DoWork += new System.ComponentModel.DoWorkEventHandler(this.m_bgwk_DoWork);
            this.m_bgwk.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.m_bgwk_ProgressChanged);
            this.m_bgwk.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.m_bgwk_RunWorkerCompleted);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(232)))), ((int)(((byte)(190)))));
            this.panel7.Controls.Add(this.m_btn_hien_thi);
            this.panel7.Controls.Add(this.m_cmd_mo_file_mau);
            this.panel7.Controls.Add(this.m_cmd_chon_du_lieu);
            this.panel7.Controls.Add(this.panelControl1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 53);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1034, 70);
            this.panel7.TabIndex = 3;
            // 
            // m_btn_hien_thi
            // 
            this.m_btn_hien_thi.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.m_btn_hien_thi.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.m_btn_hien_thi.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btn_hien_thi.Appearance.ForeColor = System.Drawing.Color.White;
            this.m_btn_hien_thi.Appearance.Options.UseBackColor = true;
            this.m_btn_hien_thi.Appearance.Options.UseFont = true;
            this.m_btn_hien_thi.Appearance.Options.UseForeColor = true;
            this.m_btn_hien_thi.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m_btn_hien_thi.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.m_btn_hien_thi.Location = new System.Drawing.Point(295, 6);
            this.m_btn_hien_thi.Name = "m_btn_hien_thi";
            this.m_btn_hien_thi.Size = new System.Drawing.Size(208, 50);
            this.m_btn_hien_thi.TabIndex = 34;
            this.m_btn_hien_thi.Text = "Hiển thị dữ liệu đã nhập\r\n";
            this.m_btn_hien_thi.Click += new System.EventHandler(this.m_btn_hien_thi_Click);
            // 
            // m_cmd_mo_file_mau
            // 
            this.m_cmd_mo_file_mau.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.m_cmd_mo_file_mau.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.m_cmd_mo_file_mau.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_mo_file_mau.Appearance.ForeColor = System.Drawing.Color.White;
            this.m_cmd_mo_file_mau.Appearance.Options.UseBackColor = true;
            this.m_cmd_mo_file_mau.Appearance.Options.UseFont = true;
            this.m_cmd_mo_file_mau.Appearance.Options.UseForeColor = true;
            this.m_cmd_mo_file_mau.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m_cmd_mo_file_mau.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.m_cmd_mo_file_mau.Location = new System.Drawing.Point(747, 6);
            this.m_cmd_mo_file_mau.Name = "m_cmd_mo_file_mau";
            this.m_cmd_mo_file_mau.Size = new System.Drawing.Size(236, 50);
            this.m_cmd_mo_file_mau.TabIndex = 31;
            this.m_cmd_mo_file_mau.Text = "Tải file Excel mẫu";
            this.m_cmd_mo_file_mau.Click += new System.EventHandler(this.m_cmd_mo_file_mau_Click);
            // 
            // m_cmd_chon_du_lieu
            // 
            this.m_cmd_chon_du_lieu.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(199)))), ((int)(((byte)(4)))));
            this.m_cmd_chon_du_lieu.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(199)))), ((int)(((byte)(4)))));
            this.m_cmd_chon_du_lieu.Appearance.BorderColor = System.Drawing.Color.White;
            this.m_cmd_chon_du_lieu.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_chon_du_lieu.Appearance.ForeColor = System.Drawing.Color.Black;
            this.m_cmd_chon_du_lieu.Appearance.Options.UseBackColor = true;
            this.m_cmd_chon_du_lieu.Appearance.Options.UseBorderColor = true;
            this.m_cmd_chon_du_lieu.Appearance.Options.UseFont = true;
            this.m_cmd_chon_du_lieu.Appearance.Options.UseForeColor = true;
            this.m_cmd_chon_du_lieu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m_cmd_chon_du_lieu.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.m_cmd_chon_du_lieu.Location = new System.Drawing.Point(499, 6);
            this.m_cmd_chon_du_lieu.Name = "m_cmd_chon_du_lieu";
            this.m_cmd_chon_du_lieu.Padding = new System.Windows.Forms.Padding(4);
            this.m_cmd_chon_du_lieu.Size = new System.Drawing.Size(251, 50);
            this.m_cmd_chon_du_lieu.TabIndex = 32;
            this.m_cmd_chon_du_lieu.Text = "Up dữ liệu chấm công";
            this.m_cmd_chon_du_lieu.Click += new System.EventHandler(this.m_cmd_chon_du_lieu_Click);
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
            this.m_dat_chon_thang.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.m_dat_chon_thang.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m_dat_chon_thang.Size = new System.Drawing.Size(127, 24);
            this.m_dat_chon_thang.TabIndex = 21;
            this.m_dat_chon_thang.EditValueChanged += new System.EventHandler(this.m_dat_chon_thang_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(28, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 18);
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
            this.m_lbl_trang_thai_cham_cong.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_trang_thai_cham_cong.Appearance.ForeColor = System.Drawing.Color.ForestGreen;
            this.m_lbl_trang_thai_cham_cong.Location = new System.Drawing.Point(27, 50);
            this.m_lbl_trang_thai_cham_cong.Name = "m_lbl_trang_thai_cham_cong";
            this.m_lbl_trang_thai_cham_cong.Size = new System.Drawing.Size(0, 15);
            this.m_lbl_trang_thai_cham_cong.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 53);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(199, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CHẤM CÔNG THEO THỜI GIAN BẰNG EXCEL";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(232)))), ((int)(((byte)(190)))));
            this.panel3.Controls.Add(this.m_cmd_nhap_cham_cong);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 383);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1034, 53);
            this.panel3.TabIndex = 9;
            // 
            // m_cmd_nhap_cham_cong
            // 
            this.m_cmd_nhap_cham_cong.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.m_cmd_nhap_cham_cong.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.m_cmd_nhap_cham_cong.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_nhap_cham_cong.Appearance.ForeColor = System.Drawing.Color.White;
            this.m_cmd_nhap_cham_cong.Appearance.Options.UseBackColor = true;
            this.m_cmd_nhap_cham_cong.Appearance.Options.UseFont = true;
            this.m_cmd_nhap_cham_cong.Appearance.Options.UseForeColor = true;
            this.m_cmd_nhap_cham_cong.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m_cmd_nhap_cham_cong.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_nhap_cham_cong.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.m_cmd_nhap_cham_cong.Location = new System.Drawing.Point(824, 0);
            this.m_cmd_nhap_cham_cong.Name = "m_cmd_nhap_cham_cong";
            this.m_cmd_nhap_cham_cong.Size = new System.Drawing.Size(210, 53);
            this.m_cmd_nhap_cham_cong.TabIndex = 15;
            this.m_cmd_nhap_cham_cong.Text = "Lưu chấm công";
            this.m_cmd_nhap_cham_cong.Click += new System.EventHandler(this.m_cmd_nhap_cham_cong_Click);
            // 
            // F696_Cham_cong_xls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1034, 436);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "F696_Cham_cong_xls";
            this.Text = "F696 - Chấm công từ excel";
            this.panel2.ResumeLayout(false);
            this.m_pn.ResumeLayout(false);
            this.m_pn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_prb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_chon_thang.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_chon_thang.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl m_grc;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv;
        private System.ComponentModel.BackgroundWorker m_bgwk;
        private System.Windows.Forms.Panel m_pn;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ProgressBarControl m_prb;
        private System.Windows.Forms.Panel panel7;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl m_lbl_trang_thai_cham_cong;
        private DevExpress.XtraEditors.DateEdit m_dat_chon_thang;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton m_cmd_mo_file_mau;
        private DevExpress.XtraEditors.SimpleButton m_cmd_chon_du_lieu;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton m_cmd_nhap_cham_cong;
        private DevExpress.XtraEditors.SimpleButton m_btn_hien_thi;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}