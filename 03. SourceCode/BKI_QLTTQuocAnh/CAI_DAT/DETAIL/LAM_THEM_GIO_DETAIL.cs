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
    public partial class LAM_THEM_GIO_DETAIL : Form
    {

        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        US_DM_TI_LE_LAM_THEM m_us = new US_DM_TI_LE_LAM_THEM();
        public LAM_THEM_GIO_DETAIL()
        {
            InitializeComponent();
        }

        private void LAM_THEM_GIO_DETAIL_Load(object sender, EventArgs e)
        {

        }

        internal void dislay_for_insert()
        {
            this.ShowDialog();
        }

        private void m_btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_txt_ma_loai_lamthem.Text=="" || m_txt_ten_loai_lamthem.Text==""|| m_txt_lns.Text=="")
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
            m_us.strMA_LAM_THEM = m_txt_ma_loai_lamthem.Text;
            m_us.strTEN_LOAI_LAM_THEM = m_txt_ten_loai_lamthem.Text;
            m_us.dcTI_LE = Convert.ToDecimal(m_txt_lns.Text);
        }



        internal void dislay_for_update(US_DM_TI_LE_LAM_THEM v_us)
        {

            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us = v_us;
            us_to_form(v_us);
            this.ShowDialog();
        }

        private void us_to_form(US_DM_TI_LE_LAM_THEM v_us)
        {
            m_txt_ma_loai_lamthem.Text = v_us.strMA_LAM_THEM;
            m_txt_ten_loai_lamthem.Text = v_us.strTEN_LOAI_LAM_THEM;
            m_txt_lns.Text = v_us.dcTI_LE.ToString();
        }
    }
}
