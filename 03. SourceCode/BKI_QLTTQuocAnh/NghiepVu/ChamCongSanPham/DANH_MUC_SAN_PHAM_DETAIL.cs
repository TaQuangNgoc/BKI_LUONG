using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IP.Core.IPCommon;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.US;

namespace BKI_DichVuMatDat.NghiepVu.ChamCongSanPham
{
    public partial class DANH_MUC_SAN_PHAM_DETAIL : Form
    {
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        US_DM_SAN_PHAM m_us = new US_DM_SAN_PHAM();
        public DANH_MUC_SAN_PHAM_DETAIL()
        {
            InitializeComponent();
        }

        internal void dislay_for_insert()
        {
            this.ShowDialog();
        }

        internal void dislay_for_update(US_DM_SAN_PHAM v_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us = v_us;
            us_to_form(v_us);
            this.ShowDialog();
        }

        private void us_to_form(US_DM_SAN_PHAM v_us)
        {
            m_txt_ma_san_pham.Text = v_us.strMA_SAN_PHAM;
            m_txt_ten_san_pham.Text = v_us.strTEN_SAN_PHAM;
        }

        private void form_to_us()
        {
            m_us.strMA_SAN_PHAM = m_txt_ma_san_pham.Text;
            m_us.strTEN_SAN_PHAM = m_txt_ten_san_pham.Text;
        }

        private void m_btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_txt_ma_san_pham.Text == "" || m_txt_ten_san_pham.Text == "")
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
                        catch (Exception)
                        {
                            MessageBox.Show("Đã tồn tại mã sản phẩm này. Vui lòng kiểm tra lại thông tin!");

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

        private void m_btn_xoa_luong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
