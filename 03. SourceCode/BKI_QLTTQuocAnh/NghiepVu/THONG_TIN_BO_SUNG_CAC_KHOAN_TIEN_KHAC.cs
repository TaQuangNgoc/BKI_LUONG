using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BKI_DichVuMatDat.NghiepVu
{
    public partial class THONG_TIN_BO_SUNG_CAC_KHOAN_TIEN_KHAC : MaterialSkin.Controls.MaterialForm
    {
        public THONG_TIN_BO_SUNG_CAC_KHOAN_TIEN_KHAC()
        {
            InitializeComponent();
        }

        private void m_btn_luu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal void displayForBoSungThongTin(ref bool phai_dong_bao_hiem, bool giam_tru_thue)
        {
            this.ShowDialog();
            if (m_cb_dong_bao_hiem.Checked == true)
            {
                phai_dong_bao_hiem = true;
            }
            if (m_cb_giam_tru_thue.Checked==true)
            {
                giam_tru_thue = true;
            }
        }
    }
}
