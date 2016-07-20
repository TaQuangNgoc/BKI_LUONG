using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BKI_DichVuMatDat.CONFIRM
{
    public partial class confirm_cac_loai_tien_khac : MaterialSkin.Controls.MaterialForm
    {
        public confirm_cac_loai_tien_khac()
        {
            InitializeComponent();
            radioGroup.SelectedIndex = 0;
        }

        internal NghiepVu.CAC_LOAI_TIEN_KHAC.ENUM_CONFIRM_XOA_DU_LIEU_CU Display()
        {
            this.ShowDialog();
            if (Convert.ToDecimal(radioGroup.EditValue) == 1)
                return NghiepVu.CAC_LOAI_TIEN_KHAC.ENUM_CONFIRM_XOA_DU_LIEU_CU.KHONG_XOA_CU;
            else
            {
                return NghiepVu.CAC_LOAI_TIEN_KHAC.ENUM_CONFIRM_XOA_DU_LIEU_CU.XOA_CU;
            }
        }

        private void m_cmd_confirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
