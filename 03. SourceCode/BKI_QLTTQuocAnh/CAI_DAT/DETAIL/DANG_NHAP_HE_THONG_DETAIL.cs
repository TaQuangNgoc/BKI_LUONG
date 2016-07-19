using BKI_DichVuMatDat.US;
using DevExpress.XtraEditors;
using IP.Core.IPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BKI_DichVuMatDat.CAI_DAT.DETAIL
{
    public partial class DANG_NHAP_HE_THONG_DETAIL : Form
    {
        ToolTip m_tooltip_username = new ToolTip();
        ToolTip m_tooltip_password = new ToolTip();
        ToolTip m_tooltip_password_confirm = new ToolTip();
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
                if (m_txt_username.Text.Trim() == "")
                {

                   WinFormControls.setTooltip(m_tooltip_username, m_txt_username, ToolTipIcon.Error, "Thông báo", "Bạn phải nhập \"Tên đăng nhập\"");
                    return;

                    XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin!");

                }

                if (m_txt_password.Text=="")
                {
                    WinFormControls.setTooltip(m_tooltip_password, m_txt_password, ToolTipIcon.Error, "Thông báo", "Bạn phải nhập \"Mật khẩu\"");
                    return;
                }

                if (m_txt_password.Text != m_txt_password_confirm.Text)
                {
                    WinFormControls.setTooltip(m_tooltip_password_confirm, m_txt_password_confirm, ToolTipIcon.Error, "Thông báo", "Xác nhận mật khẩu chưa đúng!");
                    return;
                }
                
                {
                    m_tooltip_username.Hide(m_txt_username);
                    m_tooltip_password.Hide(m_txt_password);
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

       

        private void changeColor(Color color, DevExpress.XtraEditors.TextEdit textbox)
        {
            Graphics g = CreateGraphics();
            System.Drawing.Rectangle rect = textbox.DisplayRectangle;
            rect.Inflate(1, 3);
            System.Windows.Forms.ControlPaint.DrawBorder(g, rect, color, ButtonBorderStyle.Solid);
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

        private void m_txt_username_Leave(object sender, EventArgs e)
        {
            
            if (m_txt_username.Text == "")
            {
                WinFormControls.setTooltip(m_tooltip_username, m_txt_username, ToolTipIcon.Error, "Thông báo", "Bạn phải nhập \"Tên đăng nhập\"");
            }
            else
            {
                m_tooltip_username.Hide(m_txt_username);
            }
        }

        private void m_txt_password_Leave(object sender, EventArgs e)
        {
            if (m_txt_password.Text == "")
            {
                WinFormControls.setTooltip(m_tooltip_password, m_txt_password, ToolTipIcon.Error, "Thông báo", "Bạn phải nhập \"Mật khẩu\"");
            }
            else
            {
                m_tooltip_password.Hide(m_txt_password);
            }
        }

        private void m_txt_password_confirm_Leave(object sender, EventArgs e)
        {
            if (m_txt_password.Text != m_txt_password_confirm.Text)
            {
                WinFormControls.setTooltip(m_tooltip_password_confirm, m_txt_password_confirm, ToolTipIcon.Error, "Thông báo", "Xác nhận mật khẩu chưa đúng!");
            }
            else
            {
                m_tooltip_password_confirm.Hide(m_txt_password_confirm);
            }
        }
    }
}
