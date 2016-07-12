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
    public partial class PHU_CAP_DETAIL : Form
    {
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        US_DM_PHU_CAP m_us = new US_DM_PHU_CAP();
        public PHU_CAP_DETAIL()
        {
            InitializeComponent();
            fill_combobox_loai_tien_phu_cap();
            m_rd_ti_le.Checked = true;
        }
        
        private void fill_combobox_loai_tien_phu_cap()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM CM_DM_TU_DIEN WHERE ID_LOAI_TU_DIEN=20");
            m_cb_cua_tien.DataSource = v_ds.Tables[0];
            m_cb_cua_tien.ValueMember = "ID";
            m_cb_cua_tien.DisplayMember = "TEN";
        }

        internal void dislay_for_insert()
        {
            this.ShowDialog();
        }

        internal void dislay_for_update(US.US_DM_PHU_CAP v_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us = v_us;
            us_to_form(v_us);
            this.ShowDialog();
        }

        private void us_to_form(US_DM_PHU_CAP v_us)
        {
            
        }

        private void m_btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (!is_check_not_ok())
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
            m_us.strTEN_PHU_CAP = m_txt_ten_phucap.Text;
            m_us.strDOI_TUONG_HUONG_PHU_CAP = m_txt_doi_tuong_huong.Text;
            if(m_rd_so_tien.Checked==true)
            {
                m_us.dcSO_TIEN = Convert.ToDecimal(m_txt_so_tien.Text);
                m_us.dcTI_LE = 0;
                m_us.dcID_TIEN_TI_LE_PHU_CAP = 774;
            }
            else
            {
                m_us.dcTI_LE = Convert.ToDecimal(m_txt_ti_le.Text);
                m_us.dcID_TIEN_TI_LE_PHU_CAP = Convert.ToDecimal(m_cb_cua_tien.SelectedValue);
            }       
            if (m_checkb_duocgiamtruthue.Checked == true) m_us.strGIAM_TRU_THUE_YN = "Y";
            else m_us.strGIAM_TRU_THUE_YN = "N";
            if (m_checkb_phuthuoc_songaydilam.Checked== true) m_us.strPHU_THUOC_SO_NGAY_DI_LAM_YN="Y";
            else m_us.strPHU_THUOC_SO_NGAY_DI_LAM_YN = "N";

            if (m_checkb_tinhvaokhoanphaidong_bhxh.Checked == true) m_us.strDONG_BAO_HIEM_YN = "Y";
            else m_us.strDONG_BAO_HIEM_YN = "N";
       
            
            
           
        }

        private bool is_check_not_ok()
        {
            return true;
        }

        private void m_rd_ti_le_CheckedChanged(object sender, EventArgs e)
        {
            if(m_rd_ti_le.Checked==false)
            {
                m_cb_cua_tien.Enabled = false;
                m_txt_ti_le.Enabled= false;

            }
            else
            {
                m_cb_cua_tien.Enabled = true;
                m_txt_ti_le.Enabled = true;

            }
            

        }

        private void m_rd_so_tien_CheckedChanged(object sender, EventArgs e)
        {
            if (m_rd_so_tien.Checked == false) m_txt_so_tien.Enabled = false;
            else m_txt_so_tien.Enabled = true;
        }
        private void text_box_format_numeric(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // only allow one decimal point

        }

        private void m_btn_xoa_luong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
