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
using DevExpress.XtraEditors.Controls;
using IP.Core.IPCommon;

namespace BKI_DichVuMatDat.CAI_DAT.DETAIL
{
    public partial class MA_MUC_LUONG_CD_DETAIL : MaterialSkin.Controls.MaterialForm
    {
        public MA_MUC_LUONG_CD_DETAIL()
        {
            InitializeComponent();
            load_data_to_sle_ma();
            Load_data_to_sle_muc();
        }

         DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        US_DM_THANG_LUONG_CD m_us = new US_DM_THANG_LUONG_CD();       
           
       
        private void load_data_to_sle_ma()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM CM_DM_TU_DIEN WHERE ID_LOAI_TU_DIEN=3");
            m_sle_ma.Properties.DataSource = v_ds.Tables[0];
            m_sle_ma.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
        }

        private void Load_data_to_sle_muc()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM CM_DM_TU_DIEN WHERE ID_LOAI_TU_DIEN=2");
            m_sle_muc.Properties.DataSource = v_ds.Tables[0];
            m_sle_muc.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
        }

        internal void dislay_for_insert()
        {
            this.ShowDialog();
        }

        internal void dislay_for_update(US.US_DM_THANG_LUONG_CD v_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us = v_us;
            us_to_form(v_us);
        }

        private void us_to_form(US_DM_THANG_LUONG_CD v_us)
        {
            m_sle_ma.EditValue = v_us.dcID_MA_LCD;
            m_sle_muc.EditValue = v_us.dcID_MUC_LCD;
            m_txt_so_tien.Text = v_us.dcSO_TIEN.ToString() ;
        }

        private void m_btn_xoa_luong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_sle_ma.EditValue == null || m_sle_muc.EditValue == null|| m_sle_ma.Text==""|| m_sle_muc.Text=="")
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
            m_us.dcID_MA_LCD = int.Parse(m_sle_ma.EditValue.ToString());
            m_us.dcID_MUC_LCD = int.Parse(m_sle_muc.EditValue.ToString());
            m_us.dcSO_TIEN = decimal.Parse(m_txt_so_tien.Text);

        }
    }
}
