using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;

namespace BKI_DichVuMatDat.NghiepVu.THEOTHOIGIAN
{
    public partial class CHAM_CONG_DA_NHAP : MaterialSkin.Controls.MaterialForm
    {
        public CHAM_CONG_DA_NHAP()
        {
            InitializeComponent();
            
        }

        private void load_data_to_pivot_grid(decimal thang, decimal nam)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetLoadChamCong(v_ds, thang, nam);
            pivotGridControl1.DataSource = v_ds.Tables[0];
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
           
           
        }

       

        internal void Display(decimal thang, decimal nam)
        {
            m_txt_nam.Text = nam.ToString();
            m_txt_thang.Text = thang.ToString();
            load_data_to_pivot_grid(thang,nam);
            this.ShowDialog();
        }

        private void m_btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

