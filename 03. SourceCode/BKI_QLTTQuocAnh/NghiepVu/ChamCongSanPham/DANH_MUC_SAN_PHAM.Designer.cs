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
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.m_grc_san_pham = new DevExpress.XtraGrid.GridControl();
            this.m_grv_san_pham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_btn_sua = new DevExpress.XtraEditors.SimpleButton();
            this.m_btn_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.m_btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.tab_Control1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_san_pham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_san_pham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.tab_Control1.Size = new System.Drawing.Size(1046, 282);
            this.tab_Control1.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.White;
            this.tabPage5.Controls.Add(this.m_grc_san_pham);
            this.tabPage5.Location = new System.Drawing.Point(4, 27);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1038, 251);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "DANH MỤC SẢN PHẨM";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.White;
            this.tabPage6.Controls.Add(this.gridControl1);
            this.tabPage6.Location = new System.Drawing.Point(4, 27);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1038, 251);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "ĐƠN GIÁ SẢN PHẨM";
            // 
            // m_grc_san_pham
            // 
            this.m_grc_san_pham.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_san_pham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_san_pham.Location = new System.Drawing.Point(3, 3);
            this.m_grc_san_pham.MainView = this.m_grv_san_pham;
            this.m_grc_san_pham.Name = "m_grc_san_pham";
            this.m_grc_san_pham.Size = new System.Drawing.Size(1032, 245);
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
            this.m_grv_san_pham.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã SẢN PHẨM";
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
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1032, 245);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Mã ngày công";
            this.gridColumn5.FieldName = "MA_NGAY_CONG";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Tên ngày công";
            this.gridColumn6.FieldName = "TEN_NGAY_CONG";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "% LNS";
            this.gridColumn7.FieldName = "TI_LE_LNS";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "%LCD";
            this.gridColumn8.FieldName = "TI_LE_LCD";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(214)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 53);
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
            this.panel2.Location = new System.Drawing.Point(0, 335);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1046, 53);
            this.panel2.TabIndex = 8;
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
            this.m_btn_sua.Location = new System.Drawing.Point(787, 0);
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
            this.m_btn_xoa.Location = new System.Drawing.Point(930, 0);
            this.m_btn_xoa.Name = "m_btn_xoa";
            this.m_btn_xoa.Size = new System.Drawing.Size(116, 53);
            this.m_btn_xoa.TabIndex = 29;
            this.m_btn_xoa.Text = "XÓA";
            this.m_btn_xoa.Click += new System.EventHandler(this.m_btn_xoa_Click);
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
            this.m_btn_them.Location = new System.Drawing.Point(644, 0);
            this.m_btn_them.Name = "m_btn_them";
            this.m_btn_them.Size = new System.Drawing.Size(143, 53);
            this.m_btn_them.TabIndex = 30;
            this.m_btn_them.Text = "THÊM";
            this.m_btn_them.Click += new System.EventHandler(this.m_btn_them_Click);
            // 
            // DANH_MUC_SAN_PHAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 388);
            this.Controls.Add(this.tab_Control1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DANH_MUC_SAN_PHAM";
            this.Text = "DANH_MUC_SAN_PHAM";
            this.tab_Control1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_san_pham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_san_pham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton m_btn_sua;
        private DevExpress.XtraEditors.SimpleButton m_btn_them;
        private DevExpress.XtraEditors.SimpleButton m_btn_xoa;
    }
}