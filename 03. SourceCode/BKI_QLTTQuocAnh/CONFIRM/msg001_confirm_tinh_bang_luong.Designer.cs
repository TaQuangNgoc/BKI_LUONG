namespace BKI_DichVuMatDat.CONFIRM
{
    partial class msg001_confirm_tinh_bang_luong
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
            if(disposing && (components != null))
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
            this.m_cmd_confirm = new DevExpress.XtraEditors.SimpleButton();
            this.radioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_cmd_confirm
            // 
            this.m_cmd_confirm.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.m_cmd_confirm.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.m_cmd_confirm.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_confirm.Appearance.ForeColor = System.Drawing.Color.White;
            this.m_cmd_confirm.Appearance.Options.UseBackColor = true;
            this.m_cmd_confirm.Appearance.Options.UseFont = true;
            this.m_cmd_confirm.Appearance.Options.UseForeColor = true;
            this.m_cmd_confirm.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m_cmd_confirm.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_confirm.Location = new System.Drawing.Point(229, 0);
            this.m_cmd_confirm.Name = "m_cmd_confirm";
            this.m_cmd_confirm.Size = new System.Drawing.Size(156, 39);
            this.m_cmd_confirm.TabIndex = 0;
            this.m_cmd_confirm.Text = "Xác nhận";
            this.m_cmd_confirm.Click += new System.EventHandler(this.m_cmd_confirm_Click);
            // 
            // radioGroup
            // 
            this.radioGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioGroup.EditValue = ((short)(2));
            this.radioGroup.Location = new System.Drawing.Point(0, 66);
            this.radioGroup.Name = "radioGroup";
            this.radioGroup.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(232)))), ((int)(((byte)(190)))));
            this.radioGroup.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroup.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroup.Properties.Appearance.Options.UseFont = true;
            this.radioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "Tính dữ liệu lương tất cả nhân viên"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(2)), "Tính dữ liệu lương các nhân viên chưa có trong bảng lương phần mềm")});
            this.radioGroup.Size = new System.Drawing.Size(501, 94);
            this.radioGroup.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(160)))), ((int)(((byte)(67)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 62);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bảng lương trong phần mềm đã có dữ liệu. Bạn chọn cách tính lương nhé" +
    "! (Lưu ý việc tính này chưa lưu dữ liệu vào phần mềm)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(501, 66);
            this.panelControl2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(232)))), ((int)(((byte)(190)))));
            this.panel1.Controls.Add(this.m_cmd_confirm);
            this.panel1.Controls.Add(this.m_btn_thoat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 39);
            this.panel1.TabIndex = 6;
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
            this.m_btn_thoat.Location = new System.Drawing.Point(385, 0);
            this.m_btn_thoat.Name = "m_btn_thoat";
            this.m_btn_thoat.Size = new System.Drawing.Size(116, 39);
            this.m_btn_thoat.TabIndex = 31;
            this.m_btn_thoat.Text = "Thoát";
            this.m_btn_thoat.Click += new System.EventHandler(this.m_btn_thoat_Click);
            // 
            // msg001_confirm_tinh_bang_luong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 199);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioGroup);
            this.Controls.Add(this.panelControl2);
            this.Name = "msg001_confirm_tinh_bang_luong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Msg001 - Xác nhận cách tính bảng lương";
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton m_cmd_confirm;
        private DevExpress.XtraEditors.RadioGroup radioGroup;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton m_btn_thoat;
    }
}