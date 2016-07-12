using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BKI_DichVuMatDat.CAI_DAT
{
    public partial class NGAY_CONG_TIEU_CHUAN : Form
    {
        public NGAY_CONG_TIEU_CHUAN()
        {
            InitializeComponent();
            none_active_grid_and_button_tuy_chinh();
            load_loai_nv_cho_radio();
        }

        private void load_loai_nv_cho_radio()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM DM_THAM_SO WHERE ID=19");
            if ( decimal.Parse(v_ds.Tables[0].Rows[0]["SO_TIEN"].ToString())==1)
            {
                m_rd_mac_dinh.Checked = true;
            }
            else
            {
                m_rd_tuy_chinh.Checked = true;
            }
        }

        private void none_active_grid_and_button_tuy_chinh()
        {
            m_grc_loai_nv.Visible = false;
            panel_button.Visible = false;
        }

        private void m_rd_tuy_chinh_CheckedChanged(object sender, EventArgs e)
        {
            if (m_rd_tuy_chinh.Checked == true)
            {
                active_grid_and_button_tuy_chinh();
                load_data_to_grid();
            }
            else
            {
                none_active_grid_and_button_tuy_chinh();
            }
        }

        private void load_data_to_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds,"SELECT * FROM CM_DM_TU_DIEN WHERE ID_LOAI_TU_DIEN=21 AND ID!=777");
            m_grc_loai_nv.DataSource = v_ds.Tables[0];
        }

        private void active_grid_and_button_tuy_chinh()
        {
            m_grc_loai_nv.Visible = true;
            panel_button.Visible = true;
        }

        private void tab_Control1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
