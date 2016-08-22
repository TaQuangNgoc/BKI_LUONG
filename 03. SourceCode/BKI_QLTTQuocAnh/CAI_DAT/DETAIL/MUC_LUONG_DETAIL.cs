using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BKI_DichVuMatDat.US;
using DevExpress.XtraEditors;
using IP.Core.IPCommon;

namespace BKI_DichVuMatDat.CAI_DAT.DETAIL
{
    public partial class MUC_LUONG_DETAIL : MaterialSkin.Controls.MaterialForm
    {
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        US_CM_DM_TU_DIEN m_us = new US_CM_DM_TU_DIEN();
        public MUC_LUONG_DETAIL()
        {
            InitializeComponent();
        }

        internal void dislay_for_insert()
        {
            this.ShowDialog();
        }

        internal void dislay_for_update(US.US_CM_DM_TU_DIEN v_us)
        {
            
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us = v_us;
            us_to_form(v_us);
        }

        private void us_to_form(US_CM_DM_TU_DIEN v_us)
        {
            m_txt_muc_luong.Text = v_us.strMA_TU_DIEN;
            m_txt_ten_muc_luong.Text = v_us.strTEN;
        }

        private void m_btn_xoa_luong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_txt_muc_luong.Text == "" || m_txt_ten_muc_luong.Text == "")
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
                            XtraMessageBox.Show("Mã mức lương đã tồn tại. Bạn vui lòng nhập lại thông tin!");
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
                            XtraMessageBox.Show("Đã tồn tại mã mức lương này. Vui lòng kiểm tra lại thông tin!");
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
            m_us.strMA_TU_DIEN = m_txt_muc_luong.Text;
            m_us.strTEN = m_txt_ten_muc_luong.Text;
            m_us.strTEN_NGAN = m_txt_ten_muc_luong.Text;
            m_us.dcID_LOAI_TU_DIEN = 2;

        }

      
    }
}
