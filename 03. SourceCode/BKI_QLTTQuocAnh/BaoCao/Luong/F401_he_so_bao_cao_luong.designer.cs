using System.Drawing;
namespace BKI_DichVuMatDat.BaoCao
{
    partial class F401_he_so_bao_cao_luong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F401_he_so_bao_cao_luong));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition3 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition4 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition5 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition6 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition7 = new DevExpress.XtraGrid.StyleFormatCondition();
            
            
            this.img_DVMD = new DevExpress.Utils.ImageCollection(this.components);
            
            
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMA_NV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO_DEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDA_CHAM_CONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCO_LNS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCO_LUONG_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI_DONG_DOAN_PHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI_DONG_BAO_HIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSO_LUONG_PHU_THUOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_gd_tham_so_bang_luong_thang = new DevExpress.XtraGrid.GridControl();
            this.pRGETTHAMSOBANGLUONGBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            
            this.m_grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMA_NV1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO_DEM1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDA_CHAM_CONG1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCO_LNS1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCO_LUONG_CD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI_DONG_DOAN_PHI1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI_DONG_BAO_HIEM1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSO_LUONG_PHU_THUOC1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.m_txt_nam = new MaterialSkin.Controls.MaterialSingleLineTextField(Color.White);
            this.m_txt_thang = new MaterialSkin.Controls.MaterialSingleLineTextField(Color.White);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            
            
            ((System.ComponentModel.ISupportInitialize)(this.img_DVMD)).BeginInit();
            
            
            ((System.ComponentModel.ISupportInitialize)(this.m_gd_tham_so_bang_luong_thang)).BeginInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // img_DVMD
            // 
            this.img_DVMD.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("img_DVMD.ImageStream")));
            this.img_DVMD.Images.SetKeyName(0, "Excel-icon.png");
            this.img_DVMD.Images.SetKeyName(1, "excel-xls-icon.png");
            this.img_DVMD.Images.SetKeyName(2, "exit-16.ico");
            this.img_DVMD.Images.SetKeyName(3, "image.png");
            this.img_DVMD.Images.SetKeyName(4, "Microsoft Excel.png");
            this.img_DVMD.Images.SetKeyName(5, "calculator.png");
            this.img_DVMD.Images.SetKeyName(6, "diskette.png");
            this.img_DVMD.Images.SetKeyName(7, "file_add.png");
            this.img_DVMD.Images.SetKeyName(8, "file_delete.png");
            this.img_DVMD.Images.SetKeyName(9, "file_edit.png");
            this.img_DVMD.Images.SetKeyName(10, "file_search.png");
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            // 
            // colMA_NV
            // 
            this.colMA_NV.FieldName = "MA_NV";
            this.colMA_NV.Name = "colMA_NV";
            this.colMA_NV.Visible = true;
            this.colMA_NV.VisibleIndex = 0;
            // 
            // colHO_DEM
            // 
            this.colHO_DEM.FieldName = "HO_DEM";
            this.colHO_DEM.Name = "colHO_DEM";
            this.colHO_DEM.Visible = true;
            this.colHO_DEM.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colDA_CHAM_CONG
            // 
            this.colDA_CHAM_CONG.FieldName = "DA_CHAM_CONG";
            this.colDA_CHAM_CONG.Name = "colDA_CHAM_CONG";
            this.colDA_CHAM_CONG.OptionsColumn.ReadOnly = true;
            this.colDA_CHAM_CONG.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "DA_CHAM_CONG", "{0:n0}")});
            this.colDA_CHAM_CONG.Visible = true;
            this.colDA_CHAM_CONG.VisibleIndex = 3;
            // 
            // colCO_LNS
            // 
            this.colCO_LNS.FieldName = "CO_LNS";
            this.colCO_LNS.Name = "colCO_LNS";
            this.colCO_LNS.OptionsColumn.ReadOnly = true;
            this.colCO_LNS.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "CO_LNS", "{0:n0}")});
            this.colCO_LNS.Visible = true;
            this.colCO_LNS.VisibleIndex = 4;
            // 
            // colCO_LUONG_CD
            // 
            this.colCO_LUONG_CD.FieldName = "CO_LUONG_CD";
            this.colCO_LUONG_CD.Name = "colCO_LUONG_CD";
            this.colCO_LUONG_CD.OptionsColumn.ReadOnly = true;
            this.colCO_LUONG_CD.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "CO_LUONG_CD", "{0:n0}")});
            this.colCO_LUONG_CD.Visible = true;
            this.colCO_LUONG_CD.VisibleIndex = 5;
            // 
            // colPHAI_DONG_DOAN_PHI
            // 
            this.colPHAI_DONG_DOAN_PHI.FieldName = "PHAI_DONG_DOAN_PHI";
            this.colPHAI_DONG_DOAN_PHI.Name = "colPHAI_DONG_DOAN_PHI";
            this.colPHAI_DONG_DOAN_PHI.OptionsColumn.ReadOnly = true;
            this.colPHAI_DONG_DOAN_PHI.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "PHAI_DONG_DOAN_PHI", "{0:n0}")});
            this.colPHAI_DONG_DOAN_PHI.Visible = true;
            this.colPHAI_DONG_DOAN_PHI.VisibleIndex = 6;
            // 
            // colPHAI_DONG_BAO_HIEM
            // 
            this.colPHAI_DONG_BAO_HIEM.FieldName = "PHAI_DONG_BAO_HIEM";
            this.colPHAI_DONG_BAO_HIEM.Name = "colPHAI_DONG_BAO_HIEM";
            this.colPHAI_DONG_BAO_HIEM.OptionsColumn.ReadOnly = true;
            this.colPHAI_DONG_BAO_HIEM.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "PHAI_DONG_BAO_HIEM", "{0:n0}")});
            this.colPHAI_DONG_BAO_HIEM.Visible = true;
            this.colPHAI_DONG_BAO_HIEM.VisibleIndex = 7;
            // 
            // colSO_LUONG_PHU_THUOC
            // 
            this.colSO_LUONG_PHU_THUOC.FieldName = "SO_LUONG_PHU_THUOC";
            this.colSO_LUONG_PHU_THUOC.Name = "colSO_LUONG_PHU_THUOC";
            this.colSO_LUONG_PHU_THUOC.OptionsColumn.ReadOnly = true;
            this.colSO_LUONG_PHU_THUOC.Visible = true;
            this.colSO_LUONG_PHU_THUOC.VisibleIndex = 8;
            // 
            // m_gd_tham_so_bang_luong_thang
            // 
            this.m_gd_tham_so_bang_luong_thang.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_gd_tham_so_bang_luong_thang.DataSource = this.pRGETTHAMSOBANGLUONGBindingSource2;
            this.m_gd_tham_so_bang_luong_thang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_gd_tham_so_bang_luong_thang.Location = new System.Drawing.Point(0, 57);
            this.m_gd_tham_so_bang_luong_thang.MainView = this.m_grv;
            this.m_gd_tham_so_bang_luong_thang.Name = "m_gd_tham_so_bang_luong_thang";
            this.m_gd_tham_so_bang_luong_thang.Size = new System.Drawing.Size(1154, 501);
            this.m_gd_tham_so_bang_luong_thang.TabIndex = 2;
            this.m_gd_tham_so_bang_luong_thang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv});
            // 
            // m_grv
            // 
            this.m_grv.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(187)))), ((int)(((byte)(102)))));
            this.m_grv.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(187)))), ((int)(((byte)(102)))));
            this.m_grv.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_grv.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.m_grv.Appearance.FocusedRow.Options.UseBackColor = true;
            this.m_grv.Appearance.FocusedRow.Options.UseFont = true;
            this.m_grv.Appearance.FocusedRow.Options.UseForeColor = true;
            this.m_grv.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.m_grv.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.m_grv.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.m_grv.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_grv.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White;
            this.m_grv.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.m_grv.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.m_grv.Appearance.HeaderPanel.Options.UseFont = true;
            this.m_grv.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.m_grv.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.m_grv.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.m_grv.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(187)))), ((int)(((byte)(102)))));
            this.m_grv.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(187)))), ((int)(((byte)(102)))));
            this.m_grv.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.m_grv.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.m_grv.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.m_grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colMA_NV1,
            this.colHO_DEM1,
            this.colTEN1,
            this.colDA_CHAM_CONG1,
            this.colCO_LNS1,
            this.colCO_LUONG_CD1,
            this.colPHAI_DONG_DOAN_PHI1,
            this.colPHAI_DONG_BAO_HIEM1,
            this.colSO_LUONG_PHU_THUOC1});
            this.m_grv.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2,
            styleFormatCondition3,
            styleFormatCondition4,
            styleFormatCondition5,
            styleFormatCondition6,
            styleFormatCondition7});
            this.m_grv.GridControl = this.m_gd_tham_so_bang_luong_thang;
            this.m_grv.Name = "m_grv";
            this.m_grv.OptionsBehavior.Editable = false;
            this.m_grv.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.m_grv.OptionsBehavior.ReadOnly = true;
            this.m_grv.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.m_grv.OptionsView.ColumnAutoWidth = false;
            this.m_grv.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.m_grv.OptionsView.ShowFooter = true;
            this.m_grv.OptionsView.ShowGroupPanel = false;
            this.m_grv.PaintStyleName = "Web";
            // 
            // colID1
            // 
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            this.colID1.OptionsColumn.ReadOnly = true;
            // 
            // colMA_NV1
            // 
            this.colMA_NV1.Caption = "Mã nhân viên";
            this.colMA_NV1.FieldName = "MA_NV";
            this.colMA_NV1.Name = "colMA_NV1";
            this.colMA_NV1.Visible = true;
            this.colMA_NV1.VisibleIndex = 0;
            // 
            // colHO_DEM1
            // 
            this.colHO_DEM1.Caption = "Họ đệm";
            this.colHO_DEM1.FieldName = "HO_DEM";
            this.colHO_DEM1.Name = "colHO_DEM1";
            this.colHO_DEM1.Visible = true;
            this.colHO_DEM1.VisibleIndex = 1;
            // 
            // colTEN1
            // 
            this.colTEN1.Caption = "Tên";
            this.colTEN1.FieldName = "TEN";
            this.colTEN1.Name = "colTEN1";
            this.colTEN1.Visible = true;
            this.colTEN1.VisibleIndex = 2;
            // 
            // colDA_CHAM_CONG1
            // 
            this.colDA_CHAM_CONG1.Caption = "Đã chấm công";
            this.colDA_CHAM_CONG1.FieldName = "DA_CHAM_CONG";
            this.colDA_CHAM_CONG1.Name = "colDA_CHAM_CONG1";
            this.colDA_CHAM_CONG1.OptionsColumn.ReadOnly = true;
            this.colDA_CHAM_CONG1.Visible = true;
            this.colDA_CHAM_CONG1.VisibleIndex = 3;
            // 
            // colCO_LNS1
            // 
            this.colCO_LNS1.Caption = "Có LNS";
            this.colCO_LNS1.FieldName = "CO_LNS";
            this.colCO_LNS1.Name = "colCO_LNS1";
            this.colCO_LNS1.OptionsColumn.ReadOnly = true;
            this.colCO_LNS1.Visible = true;
            this.colCO_LNS1.VisibleIndex = 4;
            // 
            // colCO_LUONG_CD1
            // 
            this.colCO_LUONG_CD1.Caption = "Có Lương đóng bảo hiểm";
            this.colCO_LUONG_CD1.FieldName = "CO_LUONG_CD";
            this.colCO_LUONG_CD1.Name = "colCO_LUONG_CD1";
            this.colCO_LUONG_CD1.OptionsColumn.ReadOnly = true;
            this.colCO_LUONG_CD1.Visible = true;
            this.colCO_LUONG_CD1.VisibleIndex = 5;
            // 
            // colPHAI_DONG_DOAN_PHI1
            // 
            this.colPHAI_DONG_DOAN_PHI1.Caption = "Phải đóng Đoàn phí ";
            this.colPHAI_DONG_DOAN_PHI1.FieldName = "PHAI_DONG_DOAN_PHI";
            this.colPHAI_DONG_DOAN_PHI1.Name = "colPHAI_DONG_DOAN_PHI1";
            this.colPHAI_DONG_DOAN_PHI1.OptionsColumn.ReadOnly = true;
            this.colPHAI_DONG_DOAN_PHI1.Visible = true;
            this.colPHAI_DONG_DOAN_PHI1.VisibleIndex = 6;
            // 
            // colPHAI_DONG_BAO_HIEM1
            // 
            this.colPHAI_DONG_BAO_HIEM1.Caption = "Phải đóng BHXH";
            this.colPHAI_DONG_BAO_HIEM1.FieldName = "PHAI_DONG_BAO_HIEM";
            this.colPHAI_DONG_BAO_HIEM1.Name = "colPHAI_DONG_BAO_HIEM1";
            this.colPHAI_DONG_BAO_HIEM1.OptionsColumn.ReadOnly = true;
            this.colPHAI_DONG_BAO_HIEM1.Visible = true;
            this.colPHAI_DONG_BAO_HIEM1.VisibleIndex = 7;
            // 
            // colSO_LUONG_PHU_THUOC1
            // 
            this.colSO_LUONG_PHU_THUOC1.Caption = "Số lượng phụ thuộc";
            this.colSO_LUONG_PHU_THUOC1.FieldName = "SO_LUONG_PHU_THUOC";
            this.colSO_LUONG_PHU_THUOC1.Name = "colSO_LUONG_PHU_THUOC1";
            this.colSO_LUONG_PHU_THUOC1.OptionsColumn.ReadOnly = true;
            this.colSO_LUONG_PHU_THUOC1.Visible = true;
            this.colSO_LUONG_PHU_THUOC1.VisibleIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.panel3.Controls.Add(this.m_txt_nam);
            this.panel3.Controls.Add(this.m_txt_thang);
            this.panel3.Controls.Add(this.labelControl1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1154, 57);
            this.panel3.TabIndex = 16;
            // 
            // m_txt_nam
            // 
            this.m_txt_nam.Depth = 0;
            this.m_txt_nam.ForeColor = System.Drawing.Color.White;
            this.m_txt_nam.Hint = "";
            this.m_txt_nam.Location = new System.Drawing.Point(561, 16);
            this.m_txt_nam.MaxLength = 32767;
            this.m_txt_nam.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_txt_nam.Name = "m_txt_nam";
            this.m_txt_nam.PasswordChar = '\0';
            this.m_txt_nam.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m_txt_nam.SelectedText = "";
            this.m_txt_nam.SelectionLength = 0;
            this.m_txt_nam.SelectionStart = 0;
            this.m_txt_nam.Size = new System.Drawing.Size(100, 23);
            this.m_txt_nam.TabIndex = 20;
            this.m_txt_nam.TabStop = false;
            this.m_txt_nam.UseSystemPasswordChar = false;
            // 
            // m_txt_thang
            // 
            this.m_txt_thang.Depth = 0;
            this.m_txt_thang.ForeColor = System.Drawing.Color.White;
            this.m_txt_thang.Hint = "";
            this.m_txt_thang.Location = new System.Drawing.Point(460, 16);
            this.m_txt_thang.MaxLength = 32767;
            this.m_txt_thang.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_txt_thang.Name = "m_txt_thang";
            this.m_txt_thang.PasswordChar = '\0';
            this.m_txt_thang.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m_txt_thang.SelectedText = "";
            this.m_txt_thang.SelectionLength = 0;
            this.m_txt_thang.SelectionStart = 0;
            this.m_txt_thang.Size = new System.Drawing.Size(84, 23);
            this.m_txt_thang.TabIndex = 19;
            this.m_txt_thang.TabStop = false;
            this.m_txt_thang.UseSystemPasswordChar = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Location = new System.Drawing.Point(548, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(6, 25);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(40, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "RÀ SOÁT DỮ LIỆU NHÂN VIÊN TRONG THÁNG \r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(232)))), ((int)(((byte)(190)))));
            this.panel2.Controls.Add(this.m_btn_thoat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 558);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1154, 53);
            this.panel2.TabIndex = 17;
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
            this.m_btn_thoat.Location = new System.Drawing.Point(1038, 0);
            this.m_btn_thoat.Name = "m_btn_thoat";
            this.m_btn_thoat.Size = new System.Drawing.Size(116, 53);
            this.m_btn_thoat.TabIndex = 30;
            this.m_btn_thoat.Text = "Thoát";
            this.m_btn_thoat.Click += new System.EventHandler(this.m_btn_thoat_Click);
            // 
            // F401_he_so_bao_cao_luong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 611);
            this.Controls.Add(this.m_gd_tham_so_bang_luong_thang);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "F401_he_so_bao_cao_luong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F401 - Rà soát dữ liệu nhân viên trong tháng để tính lương";
            
            ((System.ComponentModel.ISupportInitialize)(this.img_DVMD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_gd_tham_so_bang_luong_thang)).EndInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.m_grv)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.ImageCollection img_DVMD;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_NV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO_DEM;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDA_CHAM_CONG;
        private DevExpress.XtraGrid.Columns.GridColumn colCO_LNS;
        private DevExpress.XtraGrid.Columns.GridColumn colCO_LUONG_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI_DONG_DOAN_PHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI_DONG_BAO_HIEM;
        private DevExpress.XtraGrid.Columns.GridColumn colSO_LUONG_PHU_THUOC;
        private DevExpress.XtraGrid.GridControl m_gd_tham_so_bang_luong_thang;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton m_btn_thoat;
        private System.Windows.Forms.BindingSource pRGETTHAMSOBANGLUONGBindingSource2;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_NV1;
        private DevExpress.XtraGrid.Columns.GridColumn colHO_DEM1;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN1;
        private DevExpress.XtraGrid.Columns.GridColumn colDA_CHAM_CONG1;
        private DevExpress.XtraGrid.Columns.GridColumn colCO_LNS1;
        private DevExpress.XtraGrid.Columns.GridColumn colCO_LUONG_CD1;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI_DONG_DOAN_PHI1;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI_DONG_BAO_HIEM1;
        private DevExpress.XtraGrid.Columns.GridColumn colSO_LUONG_PHU_THUOC1;
        private MaterialSkin.Controls.MaterialSingleLineTextField m_txt_nam;
        private MaterialSkin.Controls.MaterialSingleLineTextField m_txt_thang;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}