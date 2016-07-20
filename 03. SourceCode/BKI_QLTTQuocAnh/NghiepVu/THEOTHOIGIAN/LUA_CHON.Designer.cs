namespace BKI_DichVuMatDat.NghiepVu.THEOTHOIGIAN
{
    partial class LUA_CHON
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_rd_load_them = new MaterialSkin.Controls.MaterialRadioButton();
            this.m_rd_load_dung = new MaterialSkin.Controls.MaterialRadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_btn_luu = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.m_rd_load_them);
            this.groupBox1.Controls.Add(this.m_rd_load_dung);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn 1 trong các options sau";
            // 
            // m_rd_load_them
            // 
            this.m_rd_load_them.AutoSize = true;
            this.m_rd_load_them.Location = new System.Drawing.Point(33, 65);
            this.m_rd_load_them.Name = "m_rd_load_them";
            this.m_rd_load_them.Size = new System.Drawing.Size(663, 58);
            this.m_rd_load_them.TabIndex = 1;
            this.m_rd_load_them.TabStop = true;
            this.m_rd_load_them.Text = "\r\nLoad dữ liệu từ file lên, danh sách chấm công được bổ sung thêm những người cũn" +
    "g có hình thức\r\n chấm công này nhưng không có tên trong file, để có thể chỉnh sử" +
    "a trực tiếp trên màn hình.";
            this.m_rd_load_them.UseVisualStyleBackColor = true;
            // 
            // m_rd_load_dung
            // 
            this.m_rd_load_dung.AutoSize = true;
            this.m_rd_load_dung.Location = new System.Drawing.Point(33, 37);
            this.m_rd_load_dung.Name = "m_rd_load_dung";
            this.m_rd_load_dung.Size = new System.Drawing.Size(192, 22);
            this.m_rd_load_dung.TabIndex = 0;
            this.m_rd_load_dung.TabStop = true;
            this.m_rd_load_dung.Text = "Chỉ load dữ liệu từ file lên.";
            this.m_rd_load_dung.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.m_btn_luu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(748, 53);
            this.panel2.TabIndex = 35;
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
            this.m_btn_luu.Location = new System.Drawing.Point(605, 0);
            this.m_btn_luu.Name = "m_btn_luu";
            this.m_btn_luu.Size = new System.Drawing.Size(143, 53);
            this.m_btn_luu.TabIndex = 15;
            this.m_btn_luu.Text = "TIẾP TỤC";
            this.m_btn_luu.Click += new System.EventHandler(this.m_btn_luu_Click);
            // 
            // LUA_CHON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(748, 201);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LUA_CHON";
            this.Text = "LUA_CHON";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRadioButton m_rd_load_them;
        private MaterialSkin.Controls.MaterialRadioButton m_rd_load_dung;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton m_btn_luu;
    }
}