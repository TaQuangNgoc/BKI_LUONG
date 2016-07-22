namespace BKI_DichVuMatDat.NghiepVu.THEOTHOIGIAN
{
    partial class CHAM_CONG_LAM_THEM_DA_NHAP
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_txt_nam = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.m_txt_thang = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.colNgayChamCong = new DevExpress.XtraPivotGrid.PivotGridField();
            this.rowMaNV = new DevExpress.XtraPivotGrid.PivotGridField();
            this.DataSoGioLamThem = new DevExpress.XtraPivotGrid.PivotGridField();
            this.panel3 = new System.Windows.Forms.Panel();
            this.m_btn_luu = new DevExpress.XtraEditors.SimpleButton();
            this.m_btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.m_sle_loai_lam_them = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_loai_lam_them.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.panel2.Controls.Add(this.m_sle_loai_lam_them);
            this.panel2.Controls.Add(this.labelControl4);
            this.panel2.Controls.Add(this.m_txt_nam);
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Controls.Add(this.m_txt_thang);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 85);
            this.panel2.TabIndex = 68;
            // 
            // m_txt_nam
            // 
            this.m_txt_nam.Depth = 0;
            this.m_txt_nam.ForeColor = System.Drawing.Color.White;
            this.m_txt_nam.Hint = "";
            this.m_txt_nam.Location = new System.Drawing.Point(470, 8);
            this.m_txt_nam.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_txt_nam.Name = "m_txt_nam";
            this.m_txt_nam.PasswordChar = '\0';
            this.m_txt_nam.SelectedText = "";
            this.m_txt_nam.SelectionLength = 0;
            this.m_txt_nam.SelectionStart = 0;
            this.m_txt_nam.Size = new System.Drawing.Size(100, 23);
            this.m_txt_nam.TabIndex = 19;
            this.m_txt_nam.Text = "NAM";
            this.m_txt_nam.UseSystemPasswordChar = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelControl1.Location = new System.Drawing.Point(440, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(6, 25);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "/";
            // 
            // m_txt_thang
            // 
            this.m_txt_thang.Depth = 0;
            this.m_txt_thang.ForeColor = System.Drawing.Color.White;
            this.m_txt_thang.Hint = "";
            this.m_txt_thang.Location = new System.Drawing.Point(350, 8);
            this.m_txt_thang.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_txt_thang.Name = "m_txt_thang";
            this.m_txt_thang.PasswordChar = '\0';
            this.m_txt_thang.SelectedText = "";
            this.m_txt_thang.SelectionLength = 0;
            this.m_txt_thang.SelectionStart = 0;
            this.m_txt_thang.Size = new System.Drawing.Size(84, 23);
            this.m_txt_thang.TabIndex = 3;
            this.m_txt_thang.Text = "THANG";
            this.m_txt_thang.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "BẢNG CHẤM CÔNG LÀM THÊM THÁNG";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(232)))), ((int)(((byte)(190)))));
            this.panel1.Controls.Add(this.pivotGridControl1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 375);
            this.panel1.TabIndex = 2;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Appearance.ColumnHeaderArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.pivotGridControl1.Appearance.ColumnHeaderArea.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.pivotGridControl1.Appearance.ColumnHeaderArea.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.pivotGridControl1.Appearance.ColumnHeaderArea.Options.UseBackColor = true;
            this.pivotGridControl1.Appearance.ColumnHeaderArea.Options.UseFont = true;
            this.pivotGridControl1.Appearance.FieldHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.pivotGridControl1.Appearance.FieldHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.pivotGridControl1.Appearance.FieldHeader.Options.UseBackColor = true;
            this.pivotGridControl1.Appearance.HeaderArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.pivotGridControl1.Appearance.HeaderArea.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.pivotGridControl1.Appearance.HeaderArea.Options.UseBackColor = true;
            this.pivotGridControl1.Appearance.Lines.BackColor = System.Drawing.Color.LightGray;
            this.pivotGridControl1.Appearance.Lines.BackColor2 = System.Drawing.Color.LightGray;
            this.pivotGridControl1.Appearance.Lines.Options.UseBackColor = true;
            this.pivotGridControl1.Appearance.RowHeaderArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.pivotGridControl1.Appearance.RowHeaderArea.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.pivotGridControl1.Appearance.RowHeaderArea.Options.UseBackColor = true;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.colNgayChamCong,
            this.rowMaNV,
            this.DataSoGioLamThem});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 85);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(803, 237);
            this.pivotGridControl1.TabIndex = 70;
            // 
            // colNgayChamCong
            // 
            this.colNgayChamCong.Appearance.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.colNgayChamCong.Appearance.Header.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.colNgayChamCong.Appearance.Header.Options.UseBackColor = true;
            this.colNgayChamCong.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.colNgayChamCong.AreaIndex = 0;
            this.colNgayChamCong.Caption = "Ngày chấm công";
            this.colNgayChamCong.CellFormat.FormatString = "dd/MM/yyyy";
            this.colNgayChamCong.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayChamCong.FieldName = "NGAY_CHAM_CONG";
            this.colNgayChamCong.Name = "colNgayChamCong";
            this.colNgayChamCong.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.False;
            this.colNgayChamCong.Options.OLAPUseNonEmpty = false;
            this.colNgayChamCong.Options.ShowGrandTotal = false;
            this.colNgayChamCong.Options.ShowTotals = false;
            this.colNgayChamCong.ValueFormat.FormatString = "dd/MM/yyyy";
            this.colNgayChamCong.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            // 
            // rowMaNV
            // 
            this.rowMaNV.Appearance.Cell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.rowMaNV.Appearance.Cell.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.rowMaNV.Appearance.Cell.Options.UseBackColor = true;
            this.rowMaNV.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.rowMaNV.AreaIndex = 0;
            this.rowMaNV.Caption = "Mã nhân viên";
            this.rowMaNV.FieldName = "MA_NV";
            this.rowMaNV.MinWidth = 100;
            this.rowMaNV.Name = "rowMaNV";
            this.rowMaNV.Width = 251;
            // 
            // DataSoGioLamThem
            // 
            this.DataSoGioLamThem.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.DataSoGioLamThem.AreaIndex = 0;
            this.DataSoGioLamThem.Caption = "Số giờ làm thêm";
            this.DataSoGioLamThem.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DataSoGioLamThem.FieldName = "SO_GIO_LAM_THEM";
            this.DataSoGioLamThem.Name = "DataSoGioLamThem";
            this.DataSoGioLamThem.Options.ShowGrandTotal = false;
            this.DataSoGioLamThem.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max;
            this.DataSoGioLamThem.Width = 300;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(232)))), ((int)(((byte)(190)))));
            this.panel3.Controls.Add(this.m_btn_luu);
            this.panel3.Controls.Add(this.m_btn_thoat);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 322);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(803, 53);
            this.panel3.TabIndex = 69;
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
            this.m_btn_luu.Location = new System.Drawing.Point(541, 0);
            this.m_btn_luu.Name = "m_btn_luu";
            this.m_btn_luu.Size = new System.Drawing.Size(143, 53);
            this.m_btn_luu.TabIndex = 4;
            this.m_btn_luu.Text = "LƯU";
            this.m_btn_luu.Visible = false;
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
            this.m_btn_thoat.Location = new System.Drawing.Point(684, 0);
            this.m_btn_thoat.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.m_btn_thoat.Name = "m_btn_thoat";
            this.m_btn_thoat.Size = new System.Drawing.Size(119, 53);
            this.m_btn_thoat.TabIndex = 5;
            this.m_btn_thoat.Text = "THOÁT";
            this.m_btn_thoat.Click += new System.EventHandler(this.m_btn_thoat_Click);
            // 
            // m_sle_loai_lam_them
            // 
            this.m_sle_loai_lam_them.EditValue = "";
            this.m_sle_loai_lam_them.Location = new System.Drawing.Point(231, 51);
            this.m_sle_loai_lam_them.Name = "m_sle_loai_lam_them";
            this.m_sle_loai_lam_them.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_sle_loai_lam_them.Properties.Appearance.Options.UseFont = true;
            this.m_sle_loai_lam_them.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_sle_loai_lam_them.Properties.DisplayMember = "TEN_LOAI_LAM_THEM";
            this.m_sle_loai_lam_them.Properties.ValueMember = "ID";
            this.m_sle_loai_lam_them.Properties.View = this.searchLookUpEdit1View;
            this.m_sle_loai_lam_them.Size = new System.Drawing.Size(263, 24);
            this.m_sle_loai_lam_them.TabIndex = 26;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(16, 54);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(93, 18);
            this.labelControl4.TabIndex = 25;
            this.labelControl4.Text = "Loại làm thêm";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "MÃ LOẠI LÀM THÊM";
            this.gridColumn1.FieldName = "MA_LAM_THEM";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "TÊN LOẠI LÀM THÊM";
            this.gridColumn2.FieldName = "TEN_LOAI_LAM_THEM";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "HỆ SỐ NHÂN LƯƠNG NĂNG SUẤT";
            this.gridColumn3.FieldName = "TI_LE";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "ID";
            this.gridColumn4.FieldName = "ID";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // CHAM_CONG_LAM_THEM_DA_NHAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 375);
            this.Controls.Add(this.panel1);
            this.Name = "CHAM_CONG_LAM_THEM_DA_NHAP";
            this.Text = "CHAM_CONG_LAM_THEM_DA_NHAP";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_loai_lam_them.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField m_txt_nam;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private MaterialSkin.Controls.MaterialSingleLineTextField m_txt_thang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField colNgayChamCong;
        private DevExpress.XtraPivotGrid.PivotGridField rowMaNV;
        private DevExpress.XtraPivotGrid.PivotGridField DataSoGioLamThem;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton m_btn_luu;
        private DevExpress.XtraEditors.SimpleButton m_btn_thoat;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraEditors.SearchLookUpEdit m_sle_loai_lam_them;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}