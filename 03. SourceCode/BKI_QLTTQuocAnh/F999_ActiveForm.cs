using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BKI_DichVuMatDat
{
    public partial class F999_ActiveForm : MaterialSkin.Controls.MaterialForm
    {
        public F999_ActiveForm()
        {
            InitializeComponent();
        }

        private void cmdActiveTrial_Click(object sender, EventArgs e)
        {
            try
            {
                LicenseManagerService.LicenseManagerSoapClient v_lmsc = new LicenseManagerService.LicenseManagerSoapClient();
                if (v_lmsc.checkMacTrial(WinFormControls.getMac()))
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Bạn đã hết quyền dùng thử!!!");
                }
                else
                {
                    var v_result = v_lmsc.activeTrial(WinFormControls.getMac(), txtCompany.Text, txtEmail.Text, txtPhone.Text);
                    if (v_result)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Bạn đã kích hoạt quyền dùng thử. Bạn được dùng thử đến ngày " + DateTime.Now.Date.AddDays(30).ToString("dd/MM/yyy"));
                        this.Hide();
                        Form1 v_f = new Form1();
                        v_f.ShowDialog();
                    }
                    else
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Bạn đã hết quyền dùng thử!!!");
                    }
                }
            }
            catch (Exception v_e)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(v_e.Message);
            }
        }

        private void cmdActiveLicense_Click(object sender, EventArgs e)
        {
            try
            {
                LicenseManagerService.LicenseManagerSoapClient v_lmsc = new LicenseManagerService.LicenseManagerSoapClient();
                var v_result = v_lmsc.activeKey(WinFormControls.getMac(), txtCompanyLicense.Text, txtLicense.Text);
                if (v_result)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Bạn đã kích hoạt thành công bản quyền phần mềm ISalary.\nXin cảm ơn.");
                    this.Hide();
                    Form1 v_f = new Form1();
                    v_f.ShowDialog();
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Bạn phải nhập đúng key đã được cung cấp để kích hoạt bản quyền phần mềm ISalary");
                }
            }
            catch (Exception v_e)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(v_e.Message);
            }
        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialRadioButton1.Checked)
            {
                pnLicense.Visible = false;
            }
            else
            {
                pnLicense.Visible = true;
            }
        }

        internal void showFormForActiveKey()
        {
            LicenseManagerService.LicenseManagerSoapClient v_lmsc = new LicenseManagerService.LicenseManagerSoapClient();
            if (v_lmsc.checkKey(WinFormControls.getMac()))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn đang sử dụng phần mềm ISalary bản quyền. Xin cảm ơn.");
            }
            else
            {
                materialRadioButton1.Checked = false;
                materialRadioButton1.Enabled = false;
                materialRadioButton2.Checked = true;
                pnLicense.Visible = true;
                this.ShowDialog();
            }
        }
    }
}
