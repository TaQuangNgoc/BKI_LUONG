﻿using IP.Core.IPCommon;
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
using BKI_DichVuMatDat.DS;
using DevExpress.XtraEditors;
using MaterialSkin;
using MaterialSkin.Controls;


namespace BKI_DichVuMatDat.CAI_DAT.DETAIL
{
    public partial class LOAI_NGAY_CONG_DETAIL : MaterialSkin.Controls.MaterialForm
    {
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        US_DM_LOAI_NGAY_CONG m_us = new US_DM_LOAI_NGAY_CONG();

        public LOAI_NGAY_CONG_DETAIL()
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
                if ( m_txt_ten_ngay_cong.Text == "" || m_txt_lns_loai_ngay_cong.Text == "" || m_txt_lcd_loai_ngay_cong.Text == "")
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
                        catch (Exception )
                        {
                          //  MessageBox.Show("Đã tồn tại mã sản phẩm này. Vui lòng kiểm tra lại thông tin!");
                            XtraMessageBox.Show("mã loại ngày công đã tồn tại. Bạn vui lòng nhập lại thông tin!");
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
            m_us.strMA_NGAY_CONG = m_txt_ma_ngay_cong.Text;
            m_us.strTEN_NGAY_CONG = m_txt_ten_ngay_cong.Text;
            m_us.dcTI_LE_LCD = System.Convert.ToDecimal(m_txt_lcd_loai_ngay_cong.Text);
            m_us.dcTI_LE_LNS = Convert.ToDecimal(m_txt_lns_loai_ngay_cong.Text);

        }

        private void m_btn_xoa_luong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal void dislay_for_update(US_DM_LOAI_NGAY_CONG v_us)
        {

            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us = v_us;
            us_to_form(v_us);
            this.ShowDialog();
        }

        private void us_to_form(US_DM_LOAI_NGAY_CONG v_us)
        {
            m_txt_ma_ngay_cong.Text =v_us.strMA_NGAY_CONG;
            m_txt_ten_ngay_cong.Text = v_us.strTEN_NGAY_CONG;
            m_txt_lcd_loai_ngay_cong.Text = v_us.dcTI_LE_LCD.ToString();
            m_txt_lns_loai_ngay_cong.Text = v_us.dcTI_LE_LNS.ToString();
        }

        private void text_box_format_numeric(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        
    }
}

