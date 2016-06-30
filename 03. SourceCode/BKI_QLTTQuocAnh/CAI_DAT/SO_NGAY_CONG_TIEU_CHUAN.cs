using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BKI_DichVuMatDat.US;
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
                    m_txt_ngay_mac_dinh.Text = v_ds.Tables[0].Rows[0]["SO_NGAY_LV_TIEU_CHUAN"].ToString();
                }
                else
                {
                    m_rd_tuy_chinh.Checked = true;
                    load_du_lieu_tuy_chinh(v_ds);
                }
            }
            else
            {
                m_rd_mac_dinh.Checked = true;
            }
            textbox_follow_rd_mac_dinh();
            group_cai_dat_follow_tuy_chinh();
        }

        private void load_du_lieu_tuy_chinh(DataSet v_ds)
        {
            DataTable dt = new DataTable();
            khoi_tao_datatable(dt);
           // get_so_loai_nhan_vien();
            int so_luong = v_ds.Tables[0].Rows.Count / 12;
         
            for (int i = 0; i < so_luong; i++)
            {
                DataRow v_dr = dt.NewRow();
                v_dr[0]= v_ds.Tables[0].Rows[12*i]["TEN"].ToString();
                v_dr[1]= v_ds.Tables[0].Rows[12*i+0]["SO_NGAY_LV_TIEU_CHUAN"].ToString();
                v_dr[2]= v_ds.Tables[0].Rows[12*i+1]["SO_NGAY_LV_TIEU_CHUAN"].ToString();
                v_dr[3]= v_ds.Tables[0].Rows[12*i+2]["SO_NGAY_LV_TIEU_CHUAN"].ToString();
                v_dr[4]= v_ds.Tables[0].Rows[12*i+3]["SO_NGAY_LV_TIEU_CHUAN"].ToString();
                v_dr[5]=  v_ds.Tables[0].Rows[12*i+4]["SO_NGAY_LV_TIEU_CHUAN"].ToString();
                v_dr[6]=  v_ds.Tables[0].Rows[12*i+5]["SO_NGAY_LV_TIEU_CHUAN"].ToString();
                v_dr[7]=  v_ds.Tables[0].Rows[12*i+6]["SO_NGAY_LV_TIEU_CHUAN"].ToString();
                v_dr[8]=  v_ds.Tables[0].Rows[12*i+7]["SO_NGAY_LV_TIEU_CHUAN"].ToString();
                v_dr[9]=  v_ds.Tables[0].Rows[12*i+8]["SO_NGAY_LV_TIEU_CHUAN"].ToString();
                v_dr[10]= v_ds.Tables[0].Rows[12*i+9]["SO_NGAY_LV_TIEU_CHUAN"].ToString();
                v_dr[11]= v_ds.Tables[0].Rows[12*i+10]["SO_NGAY_LV_TIEU_CHUAN"].ToString();
                v_dr[12] = v_ds.Tables[0].Rows[12 * i + 11]["SO_NGAY_LV_TIEU_CHUAN"].ToString();
                dt.Rows.Add(v_dr);                                     
            }
            m_grc.DataSource = dt;
        }

        private void khoi_tao_datatable(DataTable dt)
        {
            dt.Columns.Add("TEN", typeof(string));
            for (int i = 0; i < 12; i++)
            {
                dt.Columns.Add("THANG_"+(i+1), typeof(string));
            }     
        }

     
        private void get_so_loai_nhan_vien()
        {
            throw new NotImplementedException();
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

        private void textbox_follow_rd_mac_dinh()
        {
            if (m_rd_mac_dinh.Checked == true)
                m_txt_ngay_mac_dinh.Enabled = true;
            else
            {
                m_txt_ngay_mac_dinh.Enabled = false;
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
                dt.Rows.Add(m_txt_ten_loai_nhan_vien.Text);
                m_grc.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Vui lòng điền tên loại nhân viên!");
            }
        }

        private void m_rd_mac_dinh_CheckedChanged(object sender, EventArgs e)
        {

            if (m_rd_mac_dinh.Checked == true)
                m_txt_ngay_mac_dinh.Enabled = true;
            else
            {
                m_txt_ngay_mac_dinh.Enabled = false;
            }
        }

        private void m_grv_Click(object sender, EventArgs e)
        {
            DataRow v_dr = m_grv.GetDataRow(m_grv.FocusedRowHandle);         
                m_txt_ten_loai_nhan_vien.Text = v_dr["TEN"].ToString();           
        }

        private void m_btn_xoa_Click(object sender, EventArgs e)
        {
            DataRow v_dr = m_grv.GetDataRow(m_grv.FocusedRowHandle);
            v_dr.Delete();
            m_txt_ten_loai_nhan_vien.Text = "";
        }

        private void m_btn_luu_Click(object sender, EventArgs e)
        {
            if(check_du_lieu_is_ok())
            {
                xoa_du_lieu_bang_gd_cu();
                xoa_du_lieu_cac_hinh_thuc_tuy_chon_cu_neu_co();
                if (m_rd_mac_dinh.Checked==true)
                {           
                    them_du_lieu_cho_ngay_mac_dinh();
                    
                }
                else
                {
                    them_du_lieu_cho_cac_loai_nv_tuy_chon();
                }
            }
        }

        private void them_du_lieu_cho_cac_loai_nv_tuy_chon()
        {
            luu_cac_loai_nv_tuy_chon();
        }

        private void luu_cac_loai_nv_tuy_chon()
        {
            for (int i = 0; i < m_grv.DataRowCount; i++)
            {
                DataRow v_dr= m_grv.GetDataRow(i);
                US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
                v_us.dcID_LOAI_TU_DIEN = 21;
                v_us.strMA_TU_DIEN = "LOAI_" + (i + 1);
                v_us.strTEN = v_dr["TEN"].ToString();
                v_us.strTEN_NGAN = "LOAI_" + (i + 1);
                v_us.Insert();
                luu_so_ngay_cua_tung_loai(v_us.dcID, v_dr);
            }
        }

        private void luu_so_ngay_cua_tung_loai(decimal id_loai_ngay_cong, DataRow v_dr)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            v_us.UpdateSoNgayTieuChuanTuyChon(id_loai_ngay_cong, v_dr, decimal.Parse(m_txt_nam.Text));
        }

        private void xoa_du_lieu_cac_hinh_thuc_tuy_chon_cu_neu_co()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "DELETE FROM CM_DM_TU_DIEN WHERE ID_LOAI_TU_DIEN=21 AND ID!=21");
        }

        private void them_du_lieu_cho_ngay_mac_dinh()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.InsertSoNgayCongTieuChuanChoMacDinh(decimal.Parse(m_txt_nam.Text),decimal.Parse(m_txt_ngay_mac_dinh.Text));
        }

        private void xoa_du_lieu_bang_gd_cu()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "DELETE FROM GD_LOAI_NV_NGAY_LV_TIEU_CHUAN WHERE NAM=" + m_txt_nam.Text);
        }

        private bool check_du_lieu_is_ok()
        {
            return true;
        }

        
       
    }
}
