using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BKI_DichVuMatDat
{
    public partial class SO_NGAY_CONG_TIEU_CHUAN : Form
    {
        public SO_NGAY_CONG_TIEU_CHUAN()
        {
            InitializeComponent();
            enable_false_groups();
        }

        private void enable_false_groups()
        {
            m_group_cai_dat.Enabled = false;
            m_group_cau_hinh.Enabled = false;
        }

        private void text_box_format_numeric(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
               
            {
                e.Handled = true;
            }

          
        }

        private void m_btn_tiep_tuc_Click(object sender, EventArgs e)
        {
            if (m_txt_nam.Text != "")
            {
                m_group_cai_dat.Enabled = true;
                load_du_lieu_cai_dat();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập năm!");
            }
        }

        private void load_du_lieu_cai_dat()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.LayDuLieuSoNgayCongTieuChuan(v_ds,decimal.Parse(m_txt_nam.Text));
            if (v_ds.Tables[0].Rows.Count > 0)
            {
                if (v_ds.Tables[0].Rows[0]["ID_LOAI_NHAN_VIEN"].ToString() == "777")
                {
                    m_rd_mac_dinh.Checked = true;
                }
                else
                {
                    m_rd_tuy_chinh.Checked = true;
                }
            }
        }

        private void enable_groups()
        {
            m_group_cai_dat.Enabled = true;
            m_group_cau_hinh.Enabled = true;
        }

        private void SO_NGAY_CONG_TIEU_CHUAN_Load(object sender, EventArgs e)
        {
            group_cai_dat_follow_tuy_chinh();
        }

        private void group_cai_dat_follow_tuy_chinh()
        {
            if (m_rd_tuy_chinh.Checked == true)
                m_group_cau_hinh.Enabled = true;
            else
            {
                m_group_cau_hinh.Enabled = false;
            }
        }

        private void m_rd_tuy_chinh_CheckedChanged(object sender, EventArgs e)
        {
            group_cai_dat_follow_tuy_chinh();
        }

        private void m_btn_them_Click(object sender, EventArgs e)
        {
            if (m_txt_ten_loai_nhan_vien.Text != "")
            {
                DataTable dt= new DataTable();
                WinFormControls.Convert_gridcontrol_to_datatable(m_grv, dt);
               
            }
            else
            {
                MessageBox.Show("Vui lòng điền tên loại nhân viên!");
            }
        }
       
    }
}
