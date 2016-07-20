namespace BKI_DichVuMatDat.NghiepVu
{
    partial class THONG_TIN_BO_SUNG_CAC_KHOAN_TIEN_KHAC
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.m_btn_luu = new DevExpress.XtraEditors.SimpleButton();
            this.m_cb_dong_bao_hiem = new DevExpress.XtraEditors.CheckEdit();
            this.m_cb_giam_tru_thue = new DevExpress.XtraEditors.CheckEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_cb_dong_bao_hiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_cb_giam_tru_thue.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "Các khoản tiền này";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.m_btn_luu);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 195);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(498, 39);
            this.panelControl1.TabIndex = 41;
            // 
            // m_btn_luu
            // 
            this.m_btn_luu.Appearance.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btn_luu.Appearance.Options.UseFont = true;
            this.m_btn_luu.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_btn_luu.Location = new System.Drawing.Point(395, 2);
            this.m_btn_luu.Name = "m_btn_luu";
            this.m_btn_luu.Size = new System.Drawing.Size(101, 35);
            this.m_btn_luu.TabIndex = 0;
            this.m_btn_luu.Text = "Xác nhận";
            this.m_btn_luu.Click += new System.EventHandler(this.m_btn_luu_Click);
            // 
            // m_cb_dong_bao_hiem
            // 
            this.m_cb_dong_bao_hiem.Location = new System.Drawing.Point(40, 97);
            this.m_cb_dong_bao_hiem.Name = "m_cb_dong_bao_hiem";
            this.m_cb_dong_bao_hiem.Properties.Appearance.Font = new System.Drawing.Font("Roboto Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cb_dong_bao_hiem.Properties.Appearance.Options.UseFont = true;
            this.m_cb_dong_bao_hiem.Properties.Caption = "Phải đóng bảo hiểm xã hội";
            this.m_cb_dong_bao_hiem.Size = new System.Drawing.Size(206, 22);
            this.m_cb_dong_bao_hiem.TabIndex = 42;
            // 
            // m_cb_giam_tru_thue
            // 
            this.m_cb_giam_tru_thue.Location = new System.Drawing.Point(40, 142);
            this.m_cb_giam_tru_thue.Name = "m_cb_giam_tru_thue";
            this.m_cb_giam_tru_thue.Properties.Appearance.Font = new System.Drawing.Font("Roboto Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cb_giam_tru_thue.Properties.Appearance.Options.UseFont = true;
            this.m_cb_giam_tru_thue.Properties.Caption = "Được giảm trừ thuế";
            this.m_cb_giam_tru_thue.Size = new System.Drawing.Size(206, 22);
            this.m_cb_giam_tru_thue.TabIndex = 42;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.m_cb_giam_tru_thue);
            this.panel1.Controls.Add(this.panelControl1);
            this.panel1.Controls.Add(this.m_cb_dong_bao_hiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 236);
            this.panel1.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(498, 38);
            this.label2.TabIndex = 43;
            this.label2.Text = "Lựa chọn các options( nếu phù hợp)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // THONG_TIN_BO_SUNG_CAC_KHOAN_TIEN_KHAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 236);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "THONG_TIN_BO_SUNG_CAC_KHOAN_TIEN_KHAC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "THONG_TIN_BO_SUNG_CAC_KHOAN_TIEN_KHAC";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_cb_dong_bao_hiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_cb_giam_tru_thue.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton m_btn_luu;
        private DevExpress.XtraEditors.CheckEdit m_cb_dong_bao_hiem;
        private DevExpress.XtraEditors.CheckEdit m_cb_giam_tru_thue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}