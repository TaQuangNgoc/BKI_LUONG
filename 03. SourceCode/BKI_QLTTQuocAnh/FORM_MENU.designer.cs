namespace BKI_DichVuMatDat
{
    partial class FORM_MENU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_MENU));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.m_cmd_exit = new DevExpress.XtraEditors.SimpleButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_img_list = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 451);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel5.Controls.Add(this.m_cmd_exit);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 404);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(253, 47);
            this.panel5.TabIndex = 0;
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.m_cmd_exit.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.m_cmd_exit.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.m_cmd_exit.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.m_cmd_exit.Appearance.Options.UseBackColor = true;
            this.m_cmd_exit.Appearance.Options.UseBorderColor = true;
            this.m_cmd_exit.Appearance.Options.UseForeColor = true;
            this.m_cmd_exit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_exit.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_exit.Image")));
            this.m_cmd_exit.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.m_cmd_exit.Location = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(49, 47);
            this.m_cmd_exit.TabIndex = 0;
            this.m_cmd_exit.ToolTip = "Thoát khỏi phần mềm tính lương";
            this.m_cmd_exit.Click += new System.EventHandler(this.m_cmd_exit_Click);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.treeView1.Location = new System.Drawing.Point(0, 90);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(253, 361);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.Click += new System.EventHandler(this.treeView1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(253, 38);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 52);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHẦN MỀM QUẢN LÝ LƯƠNG";
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(253, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 451);
            this.panel2.TabIndex = 1;
            // 
            // m_img_list
            // 
            this.m_img_list.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("m_img_list.ImageStream")));
            this.m_img_list.TransparentColor = System.Drawing.Color.Transparent;
            this.m_img_list.Images.SetKeyName(0, "4-select.jpg");
            this.m_img_list.Images.SetKeyName(1, "seo-report.png");
            this.m_img_list.Images.SetKeyName(2, "employees.png");
            this.m_img_list.Images.SetKeyName(3, "1-baocao.jpg");
            this.m_img_list.Images.SetKeyName(4, "2-caidat.jpg");
            this.m_img_list.Images.SetKeyName(5, "3-nhaplieu.jpg");
            this.m_img_list.Images.SetKeyName(6, "4-selected.jpg");
            this.m_img_list.Images.SetKeyName(7, "3-1-nhaplieu.jpg");
            // 
            // FORM_MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(685, 451);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FORM_MENU";
            this.Text = "Phần mềm tính lương - BKM";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TreeView treeView1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_exit;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ImageList m_img_list;

    }
}

