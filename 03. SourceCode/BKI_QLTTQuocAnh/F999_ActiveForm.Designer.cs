namespace BKI_DichVuMatDat
{
    partial class F999_ActiveForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnTrial = new System.Windows.Forms.Panel();
            this.pnLicense = new System.Windows.Forms.Panel();
            this.cmdActiveLicense = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtLicense = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCompanyLicense = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbCompany = new MaterialSkin.Controls.MaterialLabel();
            this.cmdActiveTrial = new MaterialSkin.Controls.MaterialRaisedButton();
            this.phone = new MaterialSkin.Controls.MaterialLabel();
            this.company = new MaterialSkin.Controls.MaterialLabel();
            this.email = new MaterialSkin.Controls.MaterialLabel();
            this.txtPhone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCompany = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel3 = new System.Windows.Forms.Panel();
            this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.panel1.SuspendLayout();
            this.pnTrial.SuspendLayout();
            this.pnLicense.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pnTrial);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 332);
            this.panel1.TabIndex = 0;
            // 
            // pnTrial
            // 
            this.pnTrial.Controls.Add(this.pnLicense);
            this.pnTrial.Controls.Add(this.cmdActiveTrial);
            this.pnTrial.Controls.Add(this.phone);
            this.pnTrial.Controls.Add(this.company);
            this.pnTrial.Controls.Add(this.email);
            this.pnTrial.Controls.Add(this.txtPhone);
            this.pnTrial.Controls.Add(this.txtCompany);
            this.pnTrial.Controls.Add(this.txtEmail);
            this.pnTrial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTrial.Location = new System.Drawing.Point(191, 0);
            this.pnTrial.Name = "pnTrial";
            this.pnTrial.Size = new System.Drawing.Size(384, 332);
            this.pnTrial.TabIndex = 1;
            // 
            // pnLicense
            // 
            this.pnLicense.Controls.Add(this.cmdActiveLicense);
            this.pnLicense.Controls.Add(this.txtLicense);
            this.pnLicense.Controls.Add(this.materialLabel2);
            this.pnLicense.Controls.Add(this.txtCompanyLicense);
            this.pnLicense.Controls.Add(this.lbCompany);
            this.pnLicense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLicense.Location = new System.Drawing.Point(0, 0);
            this.pnLicense.Name = "pnLicense";
            this.pnLicense.Size = new System.Drawing.Size(384, 332);
            this.pnLicense.TabIndex = 3;
            this.pnLicense.Visible = false;
            // 
            // cmdActiveLicense
            // 
            this.cmdActiveLicense.Depth = 0;
            this.cmdActiveLicense.Location = new System.Drawing.Point(286, 292);
            this.cmdActiveLicense.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdActiveLicense.Name = "cmdActiveLicense";
            this.cmdActiveLicense.Primary = true;
            this.cmdActiveLicense.Size = new System.Drawing.Size(95, 37);
            this.cmdActiveLicense.TabIndex = 202;
            this.cmdActiveLicense.Text = "OK";
            this.cmdActiveLicense.UseVisualStyleBackColor = true;
            this.cmdActiveLicense.Click += new System.EventHandler(this.cmdActiveLicense_Click);
            // 
            // txtLicense
            // 
            this.txtLicense.Depth = 0;
            this.txtLicense.Hint = "";
            this.txtLicense.Location = new System.Drawing.Point(41, 185);
            this.txtLicense.MaxLength = 32767;
            this.txtLicense.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.PasswordChar = '\0';
            this.txtLicense.SelectedText = "";
            this.txtLicense.SelectionLength = 0;
            this.txtLicense.SelectionStart = 0;
            this.txtLicense.Size = new System.Drawing.Size(293, 23);
            this.txtLicense.TabIndex = 201;
            this.txtLicense.TabStop = false;
            this.txtLicense.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(37, 144);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(33, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Key";
            // 
            // txtCompanyLicense
            // 
            this.txtCompanyLicense.Depth = 0;
            this.txtCompanyLicense.Hint = "";
            this.txtCompanyLicense.Location = new System.Drawing.Point(41, 89);
            this.txtCompanyLicense.MaxLength = 32767;
            this.txtCompanyLicense.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCompanyLicense.Name = "txtCompanyLicense";
            this.txtCompanyLicense.PasswordChar = '\0';
            this.txtCompanyLicense.SelectedText = "";
            this.txtCompanyLicense.SelectionLength = 0;
            this.txtCompanyLicense.SelectionStart = 0;
            this.txtCompanyLicense.Size = new System.Drawing.Size(293, 23);
            this.txtCompanyLicense.TabIndex = 200;
            this.txtCompanyLicense.TabStop = false;
            this.txtCompanyLicense.UseSystemPasswordChar = false;
            // 
            // lbCompany
            // 
            this.lbCompany.AutoSize = true;
            this.lbCompany.Depth = 0;
            this.lbCompany.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbCompany.Location = new System.Drawing.Point(37, 48);
            this.lbCompany.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbCompany.Name = "lbCompany";
            this.lbCompany.Size = new System.Drawing.Size(60, 19);
            this.lbCompany.TabIndex = 0;
            this.lbCompany.Text = "Công ty";
            // 
            // cmdActiveTrial
            // 
            this.cmdActiveTrial.Depth = 0;
            this.cmdActiveTrial.Location = new System.Drawing.Point(277, 279);
            this.cmdActiveTrial.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdActiveTrial.Name = "cmdActiveTrial";
            this.cmdActiveTrial.Primary = true;
            this.cmdActiveTrial.Size = new System.Drawing.Size(104, 50);
            this.cmdActiveTrial.TabIndex = 103;
            this.cmdActiveTrial.Text = "OK";
            this.cmdActiveTrial.UseVisualStyleBackColor = true;
            this.cmdActiveTrial.Click += new System.EventHandler(this.cmdActiveTrial_Click);
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Depth = 0;
            this.phone.Font = new System.Drawing.Font("Roboto", 11F);
            this.phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.phone.Location = new System.Drawing.Point(37, 198);
            this.phone.MouseState = MaterialSkin.MouseState.HOVER;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(98, 19);
            this.phone.TabIndex = 1;
            this.phone.Text = "Số điện thoại";
            // 
            // company
            // 
            this.company.AutoSize = true;
            this.company.Depth = 0;
            this.company.Font = new System.Drawing.Font("Roboto", 11F);
            this.company.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.company.Location = new System.Drawing.Point(37, 121);
            this.company.MouseState = MaterialSkin.MouseState.HOVER;
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(60, 19);
            this.company.TabIndex = 1;
            this.company.Text = "Công ty";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Depth = 0;
            this.email.Font = new System.Drawing.Font("Roboto", 11F);
            this.email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.email.Location = new System.Drawing.Point(37, 42);
            this.email.MouseState = MaterialSkin.MouseState.HOVER;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(47, 19);
            this.email.TabIndex = 1;
            this.email.Text = "Email";
            // 
            // txtPhone
            // 
            this.txtPhone.Depth = 0;
            this.txtPhone.Hint = "";
            this.txtPhone.Location = new System.Drawing.Point(41, 233);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.Size = new System.Drawing.Size(305, 23);
            this.txtPhone.TabIndex = 102;
            this.txtPhone.TabStop = false;
            this.txtPhone.UseSystemPasswordChar = false;
            // 
            // txtCompany
            // 
            this.txtCompany.Depth = 0;
            this.txtCompany.Hint = "";
            this.txtCompany.Location = new System.Drawing.Point(41, 156);
            this.txtCompany.MaxLength = 32767;
            this.txtCompany.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.PasswordChar = '\0';
            this.txtCompany.SelectedText = "";
            this.txtCompany.SelectionLength = 0;
            this.txtCompany.SelectionStart = 0;
            this.txtCompany.Size = new System.Drawing.Size(305, 23);
            this.txtCompany.TabIndex = 101;
            this.txtCompany.TabStop = false;
            this.txtCompany.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "";
            this.txtEmail.Location = new System.Drawing.Point(41, 77);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(305, 23);
            this.txtEmail.TabIndex = 100;
            this.txtEmail.TabStop = false;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.materialRadioButton1);
            this.panel3.Controls.Add(this.materialRadioButton2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(191, 332);
            this.panel3.TabIndex = 2;
            // 
            // materialRadioButton1
            // 
            this.materialRadioButton1.AutoSize = true;
            this.materialRadioButton1.Checked = true;
            this.materialRadioButton1.Depth = 0;
            this.materialRadioButton1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton1.Location = new System.Drawing.Point(16, 37);
            this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton1.Name = "materialRadioButton1";
            this.materialRadioButton1.Ripple = true;
            this.materialRadioButton1.Size = new System.Drawing.Size(145, 30);
            this.materialRadioButton1.TabIndex = 0;
            this.materialRadioButton1.TabStop = true;
            this.materialRadioButton1.Text = "Kích hoạt dùng thử";
            this.materialRadioButton1.UseVisualStyleBackColor = true;
            this.materialRadioButton1.CheckedChanged += new System.EventHandler(this.materialRadioButton1_CheckedChanged);
            // 
            // materialRadioButton2
            // 
            this.materialRadioButton2.AutoSize = true;
            this.materialRadioButton2.Depth = 0;
            this.materialRadioButton2.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton2.Location = new System.Drawing.Point(16, 89);
            this.materialRadioButton2.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton2.Name = "materialRadioButton2";
            this.materialRadioButton2.Ripple = true;
            this.materialRadioButton2.Size = new System.Drawing.Size(154, 30);
            this.materialRadioButton2.TabIndex = 0;
            this.materialRadioButton2.Text = "Kích hoạt bản quyền";
            this.materialRadioButton2.UseVisualStyleBackColor = true;
            // 
            // F999_ActiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 357);
            this.Controls.Add(this.panel1);
            this.Name = "F999_ActiveForm";
            this.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.Text = "F999_ActiveForm";
            this.panel1.ResumeLayout(false);
            this.pnTrial.ResumeLayout(false);
            this.pnTrial.PerformLayout();
            this.pnLicense.ResumeLayout(false);
            this.pnLicense.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private System.Windows.Forms.Panel pnTrial;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialRaisedButton cmdActiveTrial;
        private MaterialSkin.Controls.MaterialLabel phone;
        private MaterialSkin.Controls.MaterialLabel company;
        private MaterialSkin.Controls.MaterialLabel email;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPhone;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCompany;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private System.Windows.Forms.Panel pnLicense;
        private MaterialSkin.Controls.MaterialRaisedButton cmdActiveLicense;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLicense;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCompanyLicense;
        private MaterialSkin.Controls.MaterialLabel lbCompany;
    }
}