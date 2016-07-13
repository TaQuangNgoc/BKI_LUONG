using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BKI_DichVuMatDat.BaoCao.Luong
{
    public partial class BANG_LUONG : Form
    {
        public BANG_LUONG()
        {
            InitializeComponent();
        }

        private void m_txt_hien_thi_Click(object sender, EventArgs e)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.LoadBangLuongThang(v_ds,decimal.Parse(m_dat_chon_thang.DateTime.Month.ToString()),decimal.Parse(m_dat_chon_thang.DateTime.Year.ToString()));
            m_grc.DataSource = v_ds.Tables[0];
        }

       
    }
}
