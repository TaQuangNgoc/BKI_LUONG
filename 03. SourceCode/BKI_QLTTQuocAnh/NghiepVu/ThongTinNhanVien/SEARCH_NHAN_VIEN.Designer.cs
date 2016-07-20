namespace BKI_DichVuMatDat.NghiepVu.ThongTinNhanVien
{
    partial class SEARCH_NHAN_VIEN
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
            this.label16 = new System.Windows.Forms.Label();
            this.m_sle_nhan_vien = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_btn_luu = new DevExpress.XtraEditors.SimpleButton();
            this.m_btn_xoa = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_nhan_vien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Roboto Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(22, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 18);
            this.label16.TabIndex = 1;
            this.label16.Text = "Nhân viên";
            // 
            // m_sle_nhan_vien
            // 
            this.m_sle_nhan_vien.EditValue = "CHỌN NHÂN VIÊN";
            this.m_sle_nhan_vien.Location = new System.Drawing.Point(117, 51);
            this.m_sle_nhan_vien.Name = "m_sle_nhan_vien";
            this.m_sle_nhan_vien.Properties.Appearance.Font = new System.Drawing.Font("Roboto Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_sle_nhan_vien.Properties.Appearance.Options.UseFont = true;
            this.m_sle_nhan_vien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_sle_nhan_vien.Properties.DisplayMember = "HO_TEN_NHAN_VIEN";
            this.m_sle_nhan_vien.Properties.ValueMember = "ID";
            this.m_sle_nhan_vien.Properties.View = this.searchLookUpEdit1View;
            this.m_sle_nhan_vien.Size = new System.Drawing.Size(283, 24);
            this.m_sle_nhan_vien.TabIndex = 0;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "MÃ NHÂN VIÊN";
            this.gridColumn2.FieldName = "MA_NV";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "HỌ TÊN NHÂN VIÊN";
            this.gridColumn3.FieldName = "HO_TEN_NHAN_VIEN";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.m_btn_luu);
            this.panel2.Controls.Add(this.m_btn_xoa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 53);
            this.panel2.TabIndex = 34;
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
            this.m_btn_luu.Location = new System.Drawing.Point(205, 0);
            this.m_btn_luu.Name = "m_btn_luu";
            this.m_btn_luu.Size = new System.Drawing.Size(143, 53);
            this.m_btn_luu.TabIndex = 15;
            this.m_btn_luu.Text = "TIẾP TỤC";
            this.m_btn_luu.Click += new System.EventHandler(this.m_btn_luu_Click);
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
            this.m_btn_xoa.Location = new System.Drawing.Point(348, 0);
            this.m_btn_xoa.Name = "m_btn_xoa";
            this.m_btn_xoa.Size = new System.Drawing.Size(116, 53);
            this.m_btn_xoa.TabIndex = 29;
            this.m_btn_xoa.Text = "THOÁT";
            this.m_btn_xoa.Click += new System.EventHandler(this.m_btn_xoa_Click);
            // 
            // SEARCH_NHAN_VIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(464, 187);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.m_sle_nhan_vien);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SEARCH_NHAN_VIEN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHỌN NHÂN VIÊN";
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_nhan_vien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit m_sle_nhan_vien;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.Label label16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton m_btn_luu;
        private DevExpress.XtraEditors.SimpleButton m_btn_xoa;
    }
}