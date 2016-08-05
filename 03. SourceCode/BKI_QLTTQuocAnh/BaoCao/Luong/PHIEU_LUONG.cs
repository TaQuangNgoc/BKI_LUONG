using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace BKI_DichVuMatDat.BaoCao.Luong
{
    public partial class PHIEU_LUONG : Form
    {
        public PHIEU_LUONG()
        {
            InitializeComponent();
        }

        private void PHIEU_LUONG_Load(object sender, EventArgs e)
        {
            try
            {
                fill_data_to_sle();
                m_dat_thang.EditValue = DateTime.Now;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void fill_data_to_sle()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetWithTableName(v_ds, "V_MA_TEN_NHAN_VIEN");
            m_sle_nhan_vien.Properties.DataSource = v_ds.Tables[0];
            m_sle_nhan_vien.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
        }

        private void m_btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if( m_sle_nhan_vien.EditValue==null||m_dat_thang.EditValue==null|| m_sle_nhan_vien.Text==""|| m_dat_thang.Text=="")
                {
                    XtraMessageBox.Show("Vui lòng chọn nhân viên và ngày tháng để xem phiếu lương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
                    DataSet v_ds = new DataSet();
                    v_ds.Tables.Add(new DataTable());
                    v_us.FillDatasetLuong1NV(v_ds,decimal.Parse(m_sle_nhan_vien.EditValue.ToString()),laythang(),laynam());
                    if (v_ds.Tables[0].Rows.Count == 0)
                    {
                        XtraMessageBox.Show("Tháng + " +laythang()+"/"+laynam()+" chưa được tính lương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        us_to_form(v_ds.Tables[0].Rows[0],laythang(),laynam());
                    }
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void us_to_form(DataRow dataRow, decimal thang, decimal nam)
        {

            XtraReport1 v_f = new XtraReport1();
            v_f.Display(dataRow, thang,nam);
        }

      
        private decimal laythang()
        {
            return decimal.Parse(m_dat_thang.DateTime.Month.ToString());
        }

        private decimal laynam()
        {
            return decimal.Parse(m_dat_thang.DateTime.Year.ToString());
        }

    }
}
