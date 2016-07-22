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

namespace BKI_DichVuMatDat.NghiepVu.ThongTinNhanVien
{
    public partial class SEARCH_NHAN_VIEN : MaterialSkin.Controls.MaterialForm
    {
        decimal m_open_form_thong_tin=-1;
        decimal m_id_nhan_vien = -1;
        public SEARCH_NHAN_VIEN()
        {
            InitializeComponent();
            fill_data_to_sle();
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
                this.m_open_form_thong_tin = 1;
                this.m_id_nhan_vien = decimal.Parse(m_sle_nhan_vien.EditValue.ToString());
                this.Close();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Vui lòng chọn nhân viên để có thể sửa thông tin nhân viên!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
            }
            
        }

        internal void Show_for_search(ref decimal m_open_form_thong_tin, ref decimal m_id_nhan_vien)
        {
            this.ShowDialog();
            m_open_form_thong_tin = this.m_open_form_thong_tin;
            m_id_nhan_vien = this.m_id_nhan_vien;
        }

        private void m_btn_xoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
