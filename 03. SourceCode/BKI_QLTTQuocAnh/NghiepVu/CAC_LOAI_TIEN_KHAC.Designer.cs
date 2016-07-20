namespace BKI_DichVuMatDat.NghiepVu
{
    partial class CAC_LOAI_TIEN_KHAC
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
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_lbl = new DevExpress.XtraEditors.LabelControl();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.m_btn_hien_thi = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_mo_file_mau = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_chon_du_lieu = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.m_sle_loai_tien = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.m_dat_chon_thang = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.m_bgwk = new System.ComponentModel.BackgroundWorker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.m_cmd_nhap_cham_cong = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::BKI_DichVuMatDat.BaoCao.F_wait_form), true, true);
            this.m_btn_xoa_dong = new DevExpress.XtraEditors.SimpleButton();
            this.panel2.SuspendLayout();
            this.m_pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_prb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_loai_tien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_chon_thang.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_chon_thang.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_pn);
            this.panel2.Controls.Add(this.m_grc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1174, 244);
            this.panel2.TabIndex = 14;
            // 
            // m_pn
            // 
            this.m_pn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.m_pn.Controls.Add(this.label1);
            this.m_pn.Controls.Add(this.m_prb);
            this.m_pn.Location = new System.Drawing.Point(243, 94);
            this.m_pn.Name = "m_pn";
            this.m_pn.Padding = new System.Windows.Forms.Padding(10);
            this.m_pn.Size = new System.Drawing.Size(618, 68);
            this.m_pn.TabIndex = 3;
            this.m_pn.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 18);
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
            this.m_grc.Size = new System.Drawing.Size(1174, 244);
            this.m_grc.TabIndex = 0;
            this.m_grc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv});
            // 
            // m_grv
            // 
            this.m_grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn5,
            this.gridColumn8,
            this.gridColumn6});
            this.m_grv.GridControl = this.m_grc;
            this.m_grv.Name = "m_grv";
            this.m_grv.OptionsBehavior.Editable = false;
            this.m_grv.OptionsFind.AllowFindPanel = false;
            this.m_grv.OptionsFind.AlwaysVisible = true;
            this.m_grv.OptionsView.ColumnAutoWidth = false;
            this.m_grv.OptionsView.ShowFooter = true;
            this.m_grv.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "MÃ NHÂN VIÊN";
            this.gridColumn1.FieldName = "MA_NV";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "HỌ ĐỆM";
            this.gridColumn3.FieldName = "HO_DEM";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "TÊN";
            this.gridColumn5.FieldName = "TEN";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "SỐ TIỀN";
            this.gridColumn8.FieldName = "SO_TIEN";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "NGÀY NHẬP";
            this.gridColumn6.FieldName = "NGAY_NHAP";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // m_lbl
            // 
            this.m_lbl.Appearance.Font = new System.Drawing.Font("Roboto Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl.Location = new System.Drawing.Point(25, 15);
            this.m_lbl.Name = "m_lbl";
            this.m_lbl.Size = new System.Drawing.Size(86, 18);
            this.m_lbl.TabIndex = 20;
            this.m_lbl.Text = "Chọn loại tiền\r\n";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "ID";
            this.gridColumn4.FieldName = "ID";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "TÊN LOẠI TIỀN";
            this.gridColumn2.FieldName = "TEN";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.m_btn_hien_thi);
            this.panel7.Controls.Add(this.m_cmd_mo_file_mau);
            this.panel7.Controls.Add(this.m_cmd_chon_du_lieu);
            this.panel7.Controls.Add(this.panelControl1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 53);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1174, 91);
            this.panel7.TabIndex = 15;
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
            this.m_btn_hien_thi.Location = new System.Drawing.Point(436, 15);
            this.m_btn_hien_thi.Name = "m_btn_hien_thi";
            this.m_btn_hien_thi.Size = new System.Drawing.Size(208, 60);
            this.m_btn_hien_thi.TabIndex = 33;
            this.m_btn_hien_thi.Text = "Hiển thị dữ liệu đã nhập\r\n";
            this.m_btn_hien_thi.Click += new System.EventHandler(this.m_btn_hien_thi_Click);
            // 
            // m_cmd_mo_file_mau
            // 
            this.m_cmd_mo_file_mau.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.m_cmd_mo_file_mau.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.m_cmd_mo_file_mau.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_mo_file_mau.Appearance.ForeColor = System.Drawing.Color.Black;
            this.m_cmd_mo_file_mau.Appearance.Options.UseBackColor = true;
            this.m_cmd_mo_file_mau.Appearance.Options.UseFont = true;
            this.m_cmd_mo_file_mau.Appearance.Options.UseForeColor = true;
            this.m_cmd_mo_file_mau.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m_cmd_mo_file_mau.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.m_cmd_mo_file_mau.Location = new System.Drawing.Point(838, 15);
            this.m_cmd_mo_file_mau.Name = "m_cmd_mo_file_mau";
            this.m_cmd_mo_file_mau.Size = new System.Drawing.Size(165, 60);
            this.m_cmd_mo_file_mau.TabIndex = 31;
            this.m_cmd_mo_file_mau.Text = "Tải file excel mẫu\r\n";
            // 
            // m_cmd_chon_du_lieu
            // 
            this.m_cmd_chon_du_lieu.Appearance.BackColor = System.Drawing.Color.Maroon;
            this.m_cmd_chon_du_lieu.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.m_cmd_chon_du_lieu.Appearance.BorderColor = System.Drawing.Color.White;
            this.m_cmd_chon_du_lieu.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_chon_du_lieu.Appearance.ForeColor = System.Drawing.Color.White;
            this.m_cmd_chon_du_lieu.Appearance.Options.UseBackColor = true;
            this.m_cmd_chon_du_lieu.Appearance.Options.UseBorderColor = true;
            this.m_cmd_chon_du_lieu.Appearance.Options.UseFont = true;
            this.m_cmd_chon_du_lieu.Appearance.Options.UseForeColor = true;
            this.m_cmd_chon_du_lieu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m_cmd_chon_du_lieu.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.m_cmd_chon_du_lieu.Location = new System.Drawing.Point(640, 15);
            this.m_cmd_chon_du_lieu.Name = "m_cmd_chon_du_lieu";
            this.m_cmd_chon_du_lieu.Padding = new System.Windows.Forms.Padding(4);
            this.m_cmd_chon_du_lieu.Size = new System.Drawing.Size(202, 60);
            this.m_cmd_chon_du_lieu.TabIndex = 32;
            this.m_cmd_chon_du_lieu.Text = "up dữ liệu mới\r\n";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.m_sle_loai_tien);
            this.panelControl1.Controls.Add(this.m_dat_chon_thang);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.m_lbl);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(430, 91);
            this.panelControl1.TabIndex = 1;
            // 
            // m_sle_loai_tien
            // 
            this.m_sle_loai_tien.EditValue = "";
            this.m_sle_loai_tien.Location = new System.Drawing.Point(138, 12);
            this.m_sle_loai_tien.Name = "m_sle_loai_tien";
            this.m_sle_loai_tien.Properties.Appearance.Font = new System.Drawing.Font("Roboto Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_sle_loai_tien.Properties.Appearance.Options.UseFont = true;
            this.m_sle_loai_tien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_sle_loai_tien.Properties.DisplayMember = "TEN";
            this.m_sle_loai_tien.Properties.ValueMember = "ID";
            this.m_sle_loai_tien.Properties.View = this.searchLookUpEdit1View;
            this.m_sle_loai_tien.Size = new System.Drawing.Size(263, 24);
            this.m_sle_loai_tien.TabIndex = 24;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn4});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // m_dat_chon_thang
            // 
            this.m_dat_chon_thang.EditValue = null;
            this.m_dat_chon_thang.Location = new System.Drawing.Point(138, 51);
            this.m_dat_chon_thang.Name = "m_dat_chon_thang";
            this.m_dat_chon_thang.Properties.Appearance.Font = new System.Drawing.Font("Roboto Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Roboto Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(25, 57);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 18);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Tháng";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(25, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(0, 13);
            this.labelControl2.TabIndex = 19;
            // 
            // m_bgwk
            // 
            this.m_bgwk.WorkerReportsProgress = true;
            this.m_bgwk.WorkerSupportsCancellation = true;
            this.m_bgwk.DoWork += new System.ComponentModel.DoWorkEventHandler(this.m_bgwk_DoWork);
            this.m_bgwk.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.m_bgwk_ProgressChanged);
            this.m_bgwk.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.m_bgwk_RunWorkerCompleted);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.m_btn_xoa_dong);
            this.panel3.Controls.Add(this.m_cmd_nhap_cham_cong);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 388);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1174, 53);
            this.panel3.TabIndex = 17;
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
            this.m_cmd_nhap_cham_cong.Location = new System.Drawing.Point(964, 0);
            this.m_cmd_nhap_cham_cong.Name = "m_cmd_nhap_cham_cong";
            this.m_cmd_nhap_cham_cong.Size = new System.Drawing.Size(210, 53);
            this.m_cmd_nhap_cham_cong.TabIndex = 15;
            this.m_cmd_nhap_cham_cong.Text = "Lưu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(199, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "NHẬP CÁC LOẠI TIỀN KHÁC BẰNG EXCEL";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1174, 53);
            this.panel1.TabIndex = 16;
            // 
            // m_btn_xoa_dong
            // 
            this.m_btn_xoa_dong.Appearance.BackColor = System.Drawing.Color.Maroon;
            this.m_btn_xoa_dong.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.m_btn_xoa_dong.Appearance.BorderColor = System.Drawing.Color.White;
            this.m_btn_xoa_dong.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btn_xoa_dong.Appearance.ForeColor = System.Drawing.Color.White;
            this.m_btn_xoa_dong.Appearance.Options.UseBackColor = true;
            this.m_btn_xoa_dong.Appearance.Options.UseBorderColor = true;
            this.m_btn_xoa_dong.Appearance.Options.UseFont = true;
            this.m_btn_xoa_dong.Appearance.Options.UseForeColor = true;
            this.m_btn_xoa_dong.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m_btn_xoa_dong.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_btn_xoa_dong.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.m_btn_xoa_dong.Location = new System.Drawing.Point(762, 0);
            this.m_btn_xoa_dong.Name = "m_btn_xoa_dong";
            this.m_btn_xoa_dong.Padding = new System.Windows.Forms.Padding(4);
            this.m_btn_xoa_dong.Size = new System.Drawing.Size(202, 53);
            this.m_btn_xoa_dong.TabIndex = 33;
            this.m_btn_xoa_dong.Text = "Xóa dòng\r\n";
            this.m_btn_xoa_dong.Click += new System.EventHandler(this.m_btn_xoa_dong_Click);
            // 
            // CAC_LOAI_TIEN_KHAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 441);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "CAC_LOAI_TIEN_KHAC";
            this.Text = "CAC_LOAI_TIEN_KHAC";
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
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_loai_tien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_chon_thang.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_chon_thang.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel m_pn;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ProgressBarControl m_prb;
        private DevExpress.XtraGrid.GridControl m_grc;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv;
        private DevExpress.XtraEditors.LabelControl m_lbl;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.Panel panel7;
        private DevExpress.XtraEditors.SimpleButton m_cmd_mo_file_mau;
        private DevExpress.XtraEditors.SimpleButton m_cmd_chon_du_lieu;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit m_sle_loai_tien;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.DateEdit m_dat_chon_thang;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.ComponentModel.BackgroundWorker m_bgwk;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton m_cmd_nhap_cham_cong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton m_btn_hien_thi;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.SimpleButton m_btn_xoa_dong;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;

    }
}