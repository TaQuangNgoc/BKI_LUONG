using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using BKI_DichVuMatDat.CAI_DAT.DETAIL;
using IP.Core.IPCommon;
using DevExpress.XtraEditors;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.US;

namespace BKI_DichVuMatDat.NghiepVu.THEOTHOIGIAN
{
    public partial class MA_MUC_LUONG : Form
    {
        public MA_MUC_LUONG()
        {
            InitializeComponent();
            fill_data_to_sle();
            fill_data_to_sle_muc();
           
            WinFormControls.formatGridView(m_grv_ma);
            WinFormControls.formatGridView(m_grv_muc);
            WinFormControls.formatGridView(m_grv_ma_muc);
            WinFormControls.formatGridView(m_grv_ma_muc_lcd);
        }

        private void fill_data_to_sle_muc()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM CM_DM_LOAI_TD WHERE ID IN(2,4)");
            m_sle_loai_muc.Properties.DataSource = v_ds.Tables[0];
            m_sle_loai_muc.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
        }

       
        private void fill_data_to_sle()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM CM_DM_LOAI_TD WHERE ID IN(1,3)");
            m_sle_luong.Properties.DataSource = v_ds.Tables[0];
            m_sle_luong.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
        }

        private void fill_data_to_grid_ma(int ma_loai_luong)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM CM_DM_TU_DIEN WHERE ID_LOAI_TU_DIEN="+ ma_loai_luong);
            m_grc_ma.DataSource = v_ds.Tables[0];
        }

        private void fill_data_to_grid_muc(int id_loai_muc)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM CM_DM_TU_DIEN WHERE ID_LOAI_TU_DIEN="+ id_loai_muc);
            m_grc_muc.DataSource = v_ds.Tables[0];
        }


        private void MA_MUC_LUONG_Load(object sender, EventArgs e)
        {
           // fill_data_to_grid_ma();
            m_sle_luong.EditValueChanged += m_sle_luong_EditValueChanged;
            m_sle_loai_muc.EditValueChanged += m_sle_loai_muc_EditValueChanged;
           // fill_data_to_grid_ma_muc(760);
           // fill_data_to_grid_ma_muc(761);
          //  fill_data_to_grid_muc(int.Parse(m_sle_loai_muc.EditValue.ToString()));

        }

        private void m_sle_luong_EditValueChanged(object sender, EventArgs e)
        {
            fill_data_to_grid_ma(int.Parse(m_sle_luong.EditValue.ToString()));
        }

      

        private void fill_data_to_grid_ma_muc(int id_loai_luong)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            if(id_loai_luong==760)
            {
                v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM V_DM_THANG_LUONG_NS");
                 m_grc_ma_muc.DataSource = v_ds.Tables[0];
            }
            else
            {
                  v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM V_DM_THANG_LUONG_CD");
                  m_grc_ma_muc_lcd.DataSource = v_ds.Tables[0];
            }
        }


        private void m_cmd_them_Click(object sender, EventArgs e)
        {
            try
            {
                switch (tab_Control1.SelectedTab.Name)
                {
                    case "tab_danhmucma":
                      MA_LUONG_DETAIL v_f_ma= new MA_LUONG_DETAIL();
                        v_f_ma.dislay_for_insert(int.Parse(m_sle_luong.EditValue.ToString()));
                        fill_data_to_grid_ma(int.Parse(m_sle_luong.EditValue.ToString()));
                        break;

                    case "tab_danhmucmuc":
                      MUC_LUONG_DETAIL v_f_muc= new MUC_LUONG_DETAIL();
                      v_f_muc.dislay_for_insert(int.Parse(m_sle_loai_muc.EditValue.ToString()));
                        fill_data_to_grid_muc(int.Parse(m_sle_loai_muc.EditValue.ToString()));
                        break;

                    case "tab_sotien":
                        MA_MUC_DETAIL v_f_so_tien = new MA_MUC_DETAIL();
                        v_f_so_tien.dislay_for_insert();
                        fill_data_to_grid_ma_muc(760);
                        break;

                    case "tab_sotienmamuclcd":
                        MA_MUC_LUONG_CD_DETAIL v_f_so_tien_lcd = new MA_MUC_LUONG_CD_DETAIL();
                        v_f_so_tien_lcd.dislay_for_insert();
                        fill_data_to_grid_ma_muc(761);
                        break;
                    
                    default:
                        break;
                }
                
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_sua_Click(object sender, EventArgs e)
        {
              try
            {
                switch (tab_Control1.SelectedTab.Name)
                {
                    case "tab_danhmucma":
                        danh_muc_ma_update();
                        break;

                        case "tab_danhmucmuc":
                        danh_muc_muc_update();
                        break;

                        case "tab_sotien":
                        so_tien_update();
                        break;

                        case "tab_sotienmamuclcd":
                        so_tien_ma_muc_lcd_update();
                        break;
                    default:
                        break;
                }
            }

            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void so_tien_ma_muc_lcd_update()
        {
            var v_count_ma_muc = m_grv_ma_muc_lcd.SelectedRowsCount;
            if (v_count_ma_muc == 0)
            {
                XtraMessageBox.Show("Bạn phải chọn 1 loại mã - mức mới có thể cập nhật!");
            }
            else if (v_count_ma_muc > 1)
            {
                XtraMessageBox.Show("Vui lòng chỉ lựa chọn 1 mã - mức để cập nhật!");
            }
            else
            {
                DataRow v_dr = m_grv_ma_muc_lcd.GetDataRow(m_grv_ma_muc_lcd.FocusedRowHandle);
                var v_us = new US_DM_THANG_LUONG_CD(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                var v_f = new MA_MUC_LUONG_CD_DETAIL();
                v_f.dislay_for_update(v_us);

                fill_data_to_grid_ma_muc(761);
            }
        }

        private void so_tien_update()
        {
            var v_count_ma_muc = m_grv_ma_muc.SelectedRowsCount;
            if (v_count_ma_muc == 0)
            {
                XtraMessageBox.Show("Bạn phải chọn 1 loại mã - mức mới có thể cập nhật!");
            }
            else if (v_count_ma_muc > 1)
            {
                XtraMessageBox.Show("Vui lòng chỉ lựa chọn 1 mã - mức để cập nhật!");
            }
            else
            {
                DataRow v_dr = m_grv_ma_muc.GetDataRow(m_grv_ma_muc.FocusedRowHandle);             
                    var v_us = new US_DM_THANG_LUONG_NS(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                    var v_f = new MA_MUC_DETAIL();
                    v_f.dislay_for_update(v_us);
               
                fill_data_to_grid_ma_muc(760);
            }
        }

        private void danh_muc_muc_update()
        {
 	          var v_count_muc = m_grv_muc.SelectedRowsCount;
            if (v_count_muc == 0)
            {
                XtraMessageBox.Show("Bạn phải chọn 1 mức mới có thể cập nhật!");
            }
            else if (v_count_muc > 1)
            {
                XtraMessageBox.Show("Vui lòng chỉ lựa chọn 1 mức để cập nhật!");
            }
            else
            {
                DataRow v_dr = m_grv_muc.GetDataRow(m_grv_muc.FocusedRowHandle);
                var v_us = new US_CM_DM_TU_DIEN(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                var  v_f = new MUC_LUONG_DETAIL();
                v_f.dislay_for_update(v_us, int.Parse(m_sle_loai_muc.EditValue.ToString()));
                fill_data_to_grid_muc(int.Parse(m_sle_loai_muc.EditValue.ToString()));
            }
        }

        private void danh_muc_ma_update()
        {
 	          var v_count_ma = m_grv_ma.SelectedRowsCount;
            if (v_count_ma == 0)
            {
                XtraMessageBox.Show("Bạn phải chọn 1 mã mới có thể cập nhật!");
            }
            else if (v_count_ma > 1)
            {
                XtraMessageBox.Show("Vui lòng chỉ lựa chọn 1 mã để cập nhật!");
            }
            else
            {
                DataRow v_dr = m_grv_ma.GetDataRow(m_grv_ma.FocusedRowHandle);
                var v_us = new US_CM_DM_TU_DIEN(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                var  v_f = new MA_LUONG_DETAIL();
                v_f.dislay_for_update(v_us,int.Parse(m_sle_luong.EditValue.ToString()));
                  fill_data_to_grid_ma(int.Parse(m_sle_luong.EditValue.ToString()));
            }
        }

        private void m_sle_loai_muc_EditValueChanged(object sender, EventArgs e)
        {
            fill_data_to_grid_muc(int.Parse(m_sle_loai_muc.EditValue.ToString()));
        }



    }
}
