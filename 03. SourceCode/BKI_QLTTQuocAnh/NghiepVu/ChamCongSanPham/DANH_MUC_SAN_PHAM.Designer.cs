namespace BKI_DichVuMatDat.NghiepVu.ChamCongSanPham
{
    partial class DANH_MUC_SAN_PHAM
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
            this.cM_DM_TU_DIENTableAdapter1 = new IP.Core.IPData.DS_CM_DM_TU_DIENTableAdapters.CM_DM_TU_DIENTableAdapter();
            this.tab_Control1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.m_grc_san_pham = new DevExpress.XtraGrid.GridControl();
            this.m_grv_san_pham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.m_grc_luong_ngay = new DevExpress.XtraGrid.GridControl();
            this.m_grv_luong_ngay = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.m_txt_so_tien_luong_ngay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.m_sle_nhan_vien = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label24 = new System.Windows.Forms.Label();
            this.m_btn_sua_luong_ngay = new DevExpress.XtraEditors.SimpleButton();
            this.m_dtp_tu_ngay_luong_ngay = new System.Windows.Forms.DateTimePicker();
            this.m_btn_them_luong_ngay = new DevExpress.XtraEditors.SimpleButton();
            this.m_btn_xoa_luong_ngay = new DevExpress.XtraEditors.SimpleButton();
            this.m_dtp_den_ngay_luong_ngay = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.m_btn_sua = new DevExpress.XtraEditors.SimpleButton();
            this.m_btn_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.tab_Control1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_san_pham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_san_pham)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_luong_ngay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_luong_ngay)).BeginInit();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_nhan_vien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cM_DM_TU_DIENTableAdapter1
            // 
            this.cM_DM_TU_DIENTableAdapter1.ClearBeforeFill = true;
            // 
            // tab_Control1
            // 
            this.tab_Control1.Controls.Add(this.tabPage5);
            this.tab_Control1.Controls.Add(this.tabPage6);
            this.tab_Control1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_Control1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Control1.Location = new System.Drawing.Point(0, 53);
            this.tab_Control1.Name = "tab_Control1";
            this.tab_Control1.SelectedIndex = 0;
            this.tab_Control1.Size = new System.Drawing.Size(923, 456);
            this.tab_Control1.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.White;
            this.tabPage5.Controls.Add(this.m_grc_san_pham);
            this.tabPage5.Location = new System.Drawing.Point(4, 27);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(915, 425);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "DANH MỤC SẢN PHẨM";
            // 
            // m_grc_san_pham
            // 
            this.m_grc_san_pham.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_san_pham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_san_pham.Location = new System.Drawing.Point(3, 3);
            this.m_grc_san_pham.MainView = this.m_grv_san_pham;
            this.m_grc_san_pham.Name = "m_grc_san_pham";
            this.m_grc_san_pham.Size = new System.Drawing.Size(909, 419);
            this.m_grc_san_pham.TabIndex = 4;
            this.m_grc_san_pham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_san_pham});
            // 
            // m_grv_san_pham
            // 
            this.m_grv_san_pham.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_grv_san_pham.Appearance.HeaderPanel.Options.UseFont = true;
            this.m_grv_san_pham.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_grv_san_pham.Appearance.Row.Options.UseFont = true;
            this.m_grv_san_pham.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.m_grv_san_pham.GridControl = this.m_grc_san_pham;
            this.m_grv_san_pham.Name = "m_grv_san_pham";
            this.m_grv_san_pham.OptionsFind.AlwaysVisible = true;
            this.m_grv_san_pham.OptionsFind.FindDelay = 100;
            this.m_grv_san_pham.OptionsFind.FindNullPrompt = "Nhập từ khóa để tìm kiếm...";
            this.m_grv_san_pham.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.m_grv_san_pham.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "MÃ SẢN PHẨM";
            this.gridColumn1.FieldName = "MA_SAN_PHAM";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "TÊN SẢN PHẨM";
            this.gridColumn2.FieldName = "TEN_SAN_PHAM";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.White;
            this.tabPage6.Controls.Add(this.m_grc_luong_ngay);
            this.tabPage6.Controls.Add(this.panel12);
            this.tabPage6.Location = new System.Drawing.Point(4, 27);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1038, 425);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "ĐƠN GIÁ SẢN PHẨM";
            // 
            // m_grc_luong_ngay
            // 
            this.m_grc_luong_ngay.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_luong_ngay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_luong_ngay.Location = new System.Drawing.Point(610, 3);
            this.m_grc_luong_ngay.MainView = this.m_grv_luong_ngay;
            this.m_grc_luong_ngay.Name = "m_grc_luong_ngay";
            this.m_grc_luong_ngay.Size = new System.Drawing.Size(425, 419);
            this.m_grc_luong_ngay.TabIndex = 18;
            this.m_grc_luong_ngay.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_luong_ngay});
            // 
            // m_grv_luong_ngay
            // 
            this.m_grv_luong_ngay.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14});
            this.m_grv_luong_ngay.GridControl = this.m_grc_luong_ngay;
            this.m_grv_luong_ngay.Name = "m_grv_luong_ngay";
            this.m_grv_luong_ngay.OptionsBehavior.Editable = false;
            this.m_grv_luong_ngay.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "MÃ SẢN PHẨM";
            this.gridColumn6.FieldName = "MA_SAN_PHAM";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "TÊN SẢN PHẨM";
            this.gridColumn7.FieldName = "TEN_SAN_PHAM";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 4;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "SỐ TIỀN";
            this.gridColumn12.DisplayFormat.FormatString = "n0";
            this.gridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn12.FieldName = "SO_TIEN";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 0;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "TỪ NGÀY";
            this.gridColumn13.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gridColumn13.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn13.FieldName = "TU_NGAY";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 1;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "ĐẾN NGÀY";
            this.gridColumn14.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gridColumn14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn14.FieldName = "DEN_NGAY";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 2;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label17);
            this.panel12.Controls.Add(this.m_txt_so_tien_luong_ngay);
            this.panel12.Controls.Add(this.label1);
            this.panel12.Controls.Add(this.label16);
            this.panel12.Controls.Add(this.label22);
            this.panel12.Controls.Add(this.m_sle_nhan_vien);
            this.panel12.Controls.Add(this.label24);
            this.panel12.Controls.Add(this.m_btn_sua_luong_ngay);
            this.panel12.Controls.Add(this.m_dtp_tu_ngay_luong_ngay);
            this.panel12.Controls.Add(this.m_btn_them_luong_ngay);
            this.panel12.Controls.Add(this.m_btn_xoa_luong_ngay);
            this.panel12.Controls.Add(this.m_dtp_den_ngay_luong_ngay);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(3, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(607, 419);
            this.panel12.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(384, 89);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 18);
            this.label17.TabIndex = 32;
            this.label17.Text = "VND";
            // 
            // m_txt_so_tien_luong_ngay
            // 
            this.m_txt_so_tien_luong_ngay.Location = new System.Drawing.Point(156, 86);
            this.m_txt_so_tien_luong_ngay.Name = "m_txt_so_tien_luong_ngay";
            this.m_txt_so_tien_luong_ngay.Size = new System.Drawing.Size(200, 26);
            this.m_txt_so_tien_luong_ngay.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số tiền";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(41, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 18);
            this.label16.TabIndex = 0;
            this.label16.Text = "Sản phẩm";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(42, 151);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(64, 18);
            this.label22.TabIndex = 0;
            this.label22.Text = "Từ ngày";
            // 
            // m_sle_nhan_vien
            // 
            this.m_sle_nhan_vien.EditValue = "CHỌN NHÂN VIÊN";
            this.m_sle_nhan_vien.Location = new System.Drawing.Point(156, 32);
            this.m_sle_nhan_vien.Name = "m_sle_nhan_vien";
            this.m_sle_nhan_vien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_sle_nhan_vien.Properties.Appearance.Options.UseFont = true;
            this.m_sle_nhan_vien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_sle_nhan_vien.Properties.DisplayMember = "HO_TEN_NHAN_VIEN";
            this.m_sle_nhan_vien.Properties.ValueMember = "ID";
            this.m_sle_nhan_vien.Properties.View = this.searchLookUpEdit1View;
            this.m_sle_nhan_vien.Size = new System.Drawing.Size(265, 24);
            this.m_sle_nhan_vien.TabIndex = 30;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "ID";
            this.gridColumn3.FieldName = "ID";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "MÃ NHÂN VIÊN";
            this.gridColumn4.FieldName = "MA_NV";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "HỌ TÊN NHÂN VIÊN";
            this.gridColumn5.FieldName = "HO_TEN_NHAN_VIEN";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(350, 151);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(71, 18);
            this.label24.TabIndex = 0;
            this.label24.Text = "Đến ngày";
            // 
            // m_btn_sua_luong_ngay
            // 
            this.m_btn_sua_luong_ngay.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(214)))));
            this.m_btn_sua_luong_ngay.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(214)))));
            this.m_btn_sua_luong_ngay.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btn_sua_luong_ngay.Appearance.ForeColor = System.Drawing.Color.White;
            this.m_btn_sua_luong_ngay.Appearance.Options.UseBackColor = true;
            this.m_btn_sua_luong_ngay.Appearance.Options.UseFont = true;
            this.m_btn_sua_luong_ngay.Appearance.Options.UseForeColor = true;
            this.m_btn_sua_luong_ngay.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m_btn_sua_luong_ngay.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.m_btn_sua_luong_ngay.Location = new System.Drawing.Point(267, 223);
            this.m_btn_sua_luong_ngay.Name = "m_btn_sua_luong_ngay";
            this.m_btn_sua_luong_ngay.Size = new System.Drawing.Size(89, 43);
            this.m_btn_sua_luong_ngay.TabIndex = 29;
            this.m_btn_sua_luong_ngay.Text = "Sửa";
            // 
            // m_dtp_tu_ngay_luong_ngay
            // 
            this.m_dtp_tu_ngay_luong_ngay.CustomFormat = "MM/dd/yyyy";
            this.m_dtp_tu_ngay_luong_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dtp_tu_ngay_luong_ngay.Location = new System.Drawing.Point(155, 151);
            this.m_dtp_tu_ngay_luong_ngay.Name = "m_dtp_tu_ngay_luong_ngay";
            this.m_dtp_tu_ngay_luong_ngay.Size = new System.Drawing.Size(153, 26);
            this.m_dtp_tu_ngay_luong_ngay.TabIndex = 13;
            // 
            // m_btn_them_luong_ngay
            // 
            this.m_btn_them_luong_ngay.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(214)))));
            this.m_btn_them_luong_ngay.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(214)))));
            this.m_btn_them_luong_ngay.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btn_them_luong_ngay.Appearance.ForeColor = System.Drawing.Color.White;
            this.m_btn_them_luong_ngay.Appearance.Options.UseBackColor = true;
            this.m_btn_them_luong_ngay.Appearance.Options.UseFont = true;
            this.m_btn_them_luong_ngay.Appearance.Options.UseForeColor = true;
            this.m_btn_them_luong_ngay.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m_btn_them_luong_ngay.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.m_btn_them_luong_ngay.Location = new System.Drawing.Point(155, 223);
            this.m_btn_them_luong_ngay.Name = "m_btn_them_luong_ngay";
            this.m_btn_them_luong_ngay.Size = new System.Drawing.Size(89, 43);
            this.m_btn_them_luong_ngay.TabIndex = 27;
            this.m_btn_them_luong_ngay.Text = "Thêm";
            // 
            // m_btn_xoa_luong_ngay
            // 
            this.m_btn_xoa_luong_ngay.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.m_btn_xoa_luong_ngay.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.m_btn_xoa_luong_ngay.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btn_xoa_luong_ngay.Appearance.ForeColor = System.Drawing.Color.Black;
            this.m_btn_xoa_luong_ngay.Appearance.Options.UseBackColor = true;
            this.m_btn_xoa_luong_ngay.Appearance.Options.UseFont = true;
            this.m_btn_xoa_luong_ngay.Appearance.Options.UseForeColor = true;
            this.m_btn_xoa_luong_ngay.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m_btn_xoa_luong_ngay.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.m_btn_xoa_luong_ngay.Location = new System.Drawing.Point(379, 223);
            this.m_btn_xoa_luong_ngay.Name = "m_btn_xoa_luong_ngay";
            this.m_btn_xoa_luong_ngay.Size = new System.Drawing.Size(86, 43);
            this.m_btn_xoa_luong_ngay.TabIndex = 28;
            this.m_btn_xoa_luong_ngay.Text = "Xóa";
            // 
            // m_dtp_den_ngay_luong_ngay
            // 
            this.m_dtp_den_ngay_luong_ngay.CustomFormat = "MM/dd/yyyy";
            this.m_dtp_den_ngay_luong_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dtp_den_ngay_luong_ngay.Location = new System.Drawing.Point(446, 151);
            this.m_dtp_den_ngay_luong_ngay.Name = "m_dtp_den_ngay_luong_ngay";
            this.m_dtp_den_ngay_luong_ngay.ShowCheckBox = true;
            this.m_dtp_den_ngay_luong_ngay.Size = new System.Drawing.Size(155, 26);
            this.m_dtp_den_ngay_luong_ngay.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(214)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 53);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(199, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "THÔNG TIN SẢN PHẨM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.m_btn_them);
            this.panel2.Controls.Add(this.m_btn_sua);
            this.panel2.Controls.Add(this.m_btn_xoa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 509);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(923, 53);
            this.panel2.TabIndex = 8;
            // 
            // m_btn_them
            // 
            this.m_btn_them.Appearance.BackColor = System.Drawing.Color.Maroon;
            this.m_btn_them.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(214)))));
            this.m_btn_them.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btn_them.Appearance.ForeColor = System.Drawing.Color.White;
            this.m_btn_them.Appearance.Options.UseBackColor = true;
            this.m_btn_them.Appearance.Options.UseFont = true;
            this.m_btn_them.Appearance.Options.UseForeColor = true;
            this.m_btn_them.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m_btn_them.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_btn_them.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.m_btn_them.Location = new System.Drawing.Point(521, 0);
            this.m_btn_them.Name = "m_btn_them";
            this.m_btn_them.Size = new System.Drawing.Size(143, 53);
            this.m_btn_them.TabIndex = 30;
            this.m_btn_them.Text = "THÊM";
            this.m_btn_them.Click += new System.EventHandler(this.m_btn_them_Click);
            // 
            // m_btn_sua
            // 
            this.m_btn_sua.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(214)))));
            this.m_btn_sua.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(214)))));
            this.m_btn_sua.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btn_sua.Appearance.ForeColor = System.Drawing.Color.White;
            this.m_btn_sua.Appearance.Options.UseBackColor = true;
            this.m_btn_sua.Appearance.Options.UseFont = true;
            this.m_btn_sua.Appearance.Options.UseForeColor = true;
            this.m_btn_sua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m_btn_sua.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_btn_sua.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.m_btn_sua.Location = new System.Drawing.Point(664, 0);
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
            this.m_btn_xoa.Location = new System.Drawing.Point(807, 0);
            this.m_btn_xoa.Name = "m_btn_xoa";
            this.m_btn_xoa.Size = new System.Drawing.Size(116, 53);
            this.m_btn_xoa.TabIndex = 29;
            this.m_btn_xoa.Text = "XÓA";
            this.m_btn_xoa.Click += new System.EventHandler(this.m_btn_xoa_Click);
            // 
            // DANH_MUC_SAN_PHAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 562);
            this.Controls.Add(this.tab_Control1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DANH_MUC_SAN_PHAM";
            this.Text = "DANH_MUC_SAN_PHAM";
            this.tab_Control1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_san_pham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_san_pham)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_luong_ngay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_luong_ngay)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_nhan_vien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private IP.Core.IPData.DS_CM_DM_TU_DIENTableAdapters.CM_DM_TU_DIENTableAdapter cM_DM_TU_DIENTableAdapter1;
        private System.Windows.Forms.TabControl tab_Control1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private DevExpress.XtraGrid.GridControl m_grc_san_pham;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_san_pham;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton m_btn_sua;
        private DevExpress.XtraEditors.SimpleButton m_btn_them;
        private DevExpress.XtraEditors.SimpleButton m_btn_xoa;
        private DevExpress.XtraGrid.GridControl m_grc_luong_ngay;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_luong_ngay;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private System.Windows.Forms.Panel panel12;
        private DevExpress.XtraEditors.SimpleButton m_btn_sua_luong_ngay;
        private DevExpress.XtraEditors.SimpleButton m_btn_xoa_luong_ngay;
        private DevExpress.XtraEditors.SimpleButton m_btn_them_luong_ngay;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DateTimePicker m_dtp_tu_ngay_luong_ngay;
        private System.Windows.Forms.DateTimePicker m_dtp_den_ngay_luong_ngay;
        private DevExpress.XtraEditors.SearchLookUpEdit m_sle_nhan_vien;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private System.Windows.Forms.TextBox m_txt_so_tien_luong_ngay;
        private System.Windows.Forms.Label label17;
    }
}