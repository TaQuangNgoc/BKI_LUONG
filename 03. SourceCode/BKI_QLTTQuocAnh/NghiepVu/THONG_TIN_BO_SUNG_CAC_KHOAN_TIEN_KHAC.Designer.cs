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
            this.m_btn_luu = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_cb_dong_bao_hiem = new System.Windows.Forms.CheckBox();
            this.m_cb_giam_tru_thue = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_btn_luu
            // 
            this.m_btn_luu.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(214)))));
            this.m_btn_luu.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(214)))));
            this.m_btn_luu.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btn_luu.Appearance.ForeColor = System.Drawing.Color.White;
            this.m_btn_luu.Appearance.Options.UseBackColor = true;
            this.m_btn_luu.Appearance.Options.UseFont = true;
            this.m_btn_luu.Appearance.Options.UseForeColor = true;
            this.m_btn_luu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m_btn_luu.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_btn_luu.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.m_btn_luu.Location = new System.Drawing.Point(403, 0);
            this.m_btn_luu.Name = "m_btn_luu";
            this.m_btn_luu.Size = new System.Drawing.Size(143, 53);
            this.m_btn_luu.TabIndex = 15;
            this.m_btn_luu.Text = "TIẾP TỤC";
            this.m_btn_luu.Click += new System.EventHandler(this.m_btn_luu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.m_btn_luu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(546, 53);
            this.panel2.TabIndex = 37;
            // 
            // m_cb_dong_bao_hiem
            // 
            this.m_cb_dong_bao_hiem.AutoSize = true;
            this.m_cb_dong_bao_hiem.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cb_dong_bao_hiem.Location = new System.Drawing.Point(41, 67);
            this.m_cb_dong_bao_hiem.Name = "m_cb_dong_bao_hiem";
            this.m_cb_dong_bao_hiem.Size = new System.Drawing.Size(200, 22);
            this.m_cb_dong_bao_hiem.TabIndex = 38;
            this.m_cb_dong_bao_hiem.Text = "Phải đóng bảo hiểm xã hội";
            this.m_cb_dong_bao_hiem.UseVisualStyleBackColor = true;
            // 
            // m_cb_giam_tru_thue
            // 
            this.m_cb_giam_tru_thue.AutoSize = true;
            this.m_cb_giam_tru_thue.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cb_giam_tru_thue.Location = new System.Drawing.Point(41, 108);
            this.m_cb_giam_tru_thue.Name = "m_cb_giam_tru_thue";
            this.m_cb_giam_tru_thue.Size = new System.Drawing.Size(155, 22);
            this.m_cb_giam_tru_thue.TabIndex = 39;
            this.m_cb_giam_tru_thue.Text = "Được giảm trừ thuế";
            this.m_cb_giam_tru_thue.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "Các khoản tiền này";
            // 
            // THONG_TIN_BO_SUNG_CAC_KHOAN_TIEN_KHAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 212);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_cb_giam_tru_thue);
            this.Controls.Add(this.m_cb_dong_bao_hiem);
            this.Controls.Add(this.panel2);
            this.Name = "THONG_TIN_BO_SUNG_CAC_KHOAN_TIEN_KHAC";
            this.Text = "THONG_TIN_BO_SUNG_CAC_KHOAN_TIEN_KHAC";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton m_btn_luu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox m_cb_dong_bao_hiem;
        private System.Windows.Forms.CheckBox m_cb_giam_tru_thue;
        private System.Windows.Forms.Label label1;
    }
}