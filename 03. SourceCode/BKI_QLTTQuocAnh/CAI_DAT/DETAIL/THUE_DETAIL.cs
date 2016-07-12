using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS;
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
    public partial class THUE_DETAIL : Form
    {
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        US_DM_THUE m_us = new US_DM_THUE();
        public THUE_DETAIL()
        {
            InitializeComponent();
        }

        internal void dislay_for_insert()
        {
            this.ShowDialog();
        }

        private void m_btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_txt_chanduoi.Text==""|| m_txt_chantren.Text==""|| m_txt_ti_le.Text==""|| m_txt_bu_tru.Text=="")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }
                else
                {
                    form_to_us();
                    if (m_e_form_mode == DataEntryFormMode.InsertDataState)
                    {
                        try
                        {
                            m_us.Insert();
                            MessageBox.Show("Lưu thành công!");
                            this.Close();
                        }
                        catch (Exception v_e)
                        {
                            //  MessageBox.Show("Đã tồn tại mã sản phẩm này. Vui lòng kiểm tra lại thông tin!");
                            throw v_e;

                        }

                    }
                    if (m_e_form_mode == DataEntryFormMode.UpdateDataState)
                    {
                        try
                        {
                            m_us.Update();
                            MessageBox.Show("Lưu thành công!");
                            this.Close();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Đã tồn tại mã sản phẩm này. Vui lòng kiểm tra lại thông tin!");
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
            m_us.dcCHAN_DUOI =Convert.ToDecimal(m_txt_chanduoi.Text);
            m_us.dcCHAN_TREN = Convert.ToDecimal(m_txt_chantren.Text);
            m_us.dcTI_LE = Convert.ToDecimal(m_txt_ti_le.Text);
            m_us.dcBU_TRU = Convert.ToDecimal(m_txt_bu_tru.Text);

        }
        private void text_box_format_numeric(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // only allow one decimal point

        }

        internal void dislay_for_update(US_DM_THUE v_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us = v_us;
            us_to_form(v_us);
            this.ShowDialog();
        }

        private void us_to_form(US_DM_THUE v_us)
        {
            m_txt_chanduoi.Text = v_us.dcCHAN_DUOI.ToString();
            m_txt_chantren.Text = v_us.dcCHAN_TREN.ToString();
            m_txt_ti_le.Text = v_us.dcTI_LE.ToString();
            m_txt_bu_tru.Text = v_us.dcBU_TRU.ToString();
        }

        private void m_btn_xoa_luong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
