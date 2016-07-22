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

namespace BKI_DichVuMatDat.NghiepVu.THEOTHOIGIAN
{
    public partial class CHAM_CONG_LAM_THEM_DA_NHAP : Form
    {
        public CHAM_CONG_LAM_THEM_DA_NHAP()
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
            v_us.FillDatasetWithTableName(v_ds, "DM_TI_LE_LAM_THEM");
            m_sle_loai_lam_them.Properties.DataSource = v_ds.Tables[0];
            m_sle_loai_lam_them.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            m_sle_loai_lam_them.Enabled = false;
        }

        internal void Display(decimal thang, decimal nam, decimal id_loai_lam_them)
        {

            m_txt_nam.Text = nam.ToString();
            m_txt_thang.Text = thang.ToString();
            load_data_to_pivot_grid(thang, nam, id_loai_lam_them);
            m_sle_loai_lam_them.EditValue = int.Parse(id_loai_lam_them.ToString());
            this.ShowDialog();
        }

        private void load_data_to_pivot_grid(decimal thang, decimal nam, decimal id_loai_lam_them)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetLoadChamCongLamThem(v_ds, thang, nam, id_loai_lam_them);
            pivotGridControl1.DataSource = v_ds.Tables[0];
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
           
        }

        private void m_btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
