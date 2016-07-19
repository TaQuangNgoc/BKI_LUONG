using BKI_DichVuMatDat.US;
using DevExpress.XtraEditors;
using IP.Core.IPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BKI_DichVuMatDat.CAI_DAT.DETAIL
{
    public partial class DANG_NHAP_HE_THONG_DETAIL : Form
    {
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        US_HT_USER m_us = new US_HT_USER();
        public DANG_NHAP_HE_THONG_DETAIL()
        {
            InitializeComponent();
        }

        private void m_btn_dangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_txt_username.Text==""|| m_txt_password.Text=="")
                {
                    XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }
                else
                {
                    form_to_us();
                    if (m_e_form_mode == DataEntryFormMode.InsertDataState)
                    {
                        try
                        {
                            m_us.Insert();
                            XtraMessageBox.Show("Lưu thành công!");
                            this.Close();
                        }
                        catch (Exception)
                        {
                            //  MessageBox.Show("Đã tồn tại mã sản phẩm này. Vui lòng kiểm tra lại thông tin!");
                            XtraMessageBox.Show("mã bảo hiểm đã tồn tại. Bạn vui lòng nhập lại thông tin!");

                        }

                    }
                    if (m_e_form_mode == DataEntryFormMode.UpdateDataState)
                    {
                        try
                        {
                            m_us.Update();
                            XtraMessageBox.Show("Lưu thành công!");
                            this.Close();
                        }
                        catch (Exception)
                        {
                            XtraMessageBox.Show("Đã tồn tại mã sản phẩm này. Vui lòng kiểm tra lại thông tin!");
                        }
                    }
                }
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void form_to_us()
        {
           m_us.strUSERNAME= m_txt_username.Text;
            m_us.strPASSWORD= m_txt_password.Text;
        }

        private void m_btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal void dislay_for_insert()
        {
            this.ShowDialog();
        }

        internal void dislay_for_update(US_HT_USER v_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us = v_us;
            us_to_form(v_us);
            this.ShowDialog(); 
        }

        private void us_to_form(US_HT_USER v_us)
        {
            m_txt_username.Text = v_us.strUSERNAME;
            m_txt_password.Text = v_us.strPASSWORD;
        }
    }
}
