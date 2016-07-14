using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.US;
using IP.Core.IPCommon;

namespace BKI_DichVuMatDat.CAI_DAT
{
    public partial class NGAY_CONG_TIEU_CHUAN : Form
    {
        public NGAY_CONG_TIEU_CHUAN()
        {
            InitializeComponent();
            load_data_to_grid_loai_nhan_vien();
            format_form();
        }

        private void format_form()
        {
            tab_Control1.SizeMode = TabSizeMode.Fixed;
            tab_Control1.ItemSize = new Size(tab_Control1.Width / tab_Control1.TabCount, 40);
            tab_Control1.Appearance = TabAppearance.Buttons;
            m_btn_them.Visible = true;
            m_btn_sua.Visible = true;
            m_btn_xoa.Visible = true;
            m_btn_luu.Visible = false;
            m_group_cau_hinh.Visible = false;
        }

        private void load_data_to_grid_loai_nhan_vien()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM DM_LOAI_NHAN_VIEN");
            m_grc_loai_nv.DataSource = v_ds.Tables[0];
        }

        private void tab_Control1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab_Control1.SelectedTab.Name == "tab_so_ngay_cong_tieu_chuan")
            {
                m_btn_them.Visible = false;
                m_btn_sua.Visible = false;
                m_btn_xoa.Visible = false;
                m_btn_luu.Visible = true;
            }
            else
            {
                m_btn_them.Visible = true;
                m_btn_sua.Visible = true;
                m_btn_xoa.Visible = true;
                m_btn_luu.Visible = false;
            }
        }

        private void m_btn_tiep_tuc_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_txt_nam.Text != "")
                {
                    m_group_cau_hinh.Visible = true;
                    DataSet v_ds_loai_nv_tren_danh_muc = new DataSet();
                    v_ds_loai_nv_tren_danh_muc.Tables.Add(new DataTable());
                    DataSet v_ds_loai_nv_thuc_te_cua_nam = new DataSet();
                    v_ds_loai_nv_thuc_te_cua_nam.Tables.Add(new DataTable());
                    int so_luong_loai_nv_tren_danh_muc = get_so_luong_loai_nv_tren_danh_muc(v_ds_loai_nv_tren_danh_muc);
                    int so_luong_loai_nv_thuc_te_cua_nam = get_so_luong_loai_nv_thuc_te_cua_nam(v_ds_loai_nv_thuc_te_cua_nam);
                    if (so_luong_loai_nv_tren_danh_muc > so_luong_loai_nv_thuc_te_cua_nam)
                    {
                        DialogResult dialogResult = MessageBox.Show("Xuất hiện loại nhân viên mới chưa có trong danh sách hiện thời của năm "+ m_txt_nam.Text +". \n Bạn có muốn thêm những loại nhân viên mới này vào danh sách hiện có của năm "+ m_txt_nam.Text+", đồng thời thêm số ngày công tiêu chuẩn cho những loại mới này? ", "Thông báo", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            load_du_lieu_bo_sung_len_grid_loai_ngay_cong(v_ds_loai_nv_tren_danh_muc);
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            load_data_dung_len_grid_loai_ngay_cong();
                        }
                    }
                    else
                    {
                        load_data_dung_len_grid_loai_ngay_cong();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền năm trước khi tiếp tục!");
                }
            }
            catch (Exception v_e)
            {
                
                throw v_e;
            }
        }

        private void load_du_lieu_bo_sung_len_grid_loai_ngay_cong(DataSet v_ds_loai_nv_tren_danh_muc)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.LayDuLieuSoNgayCongTieuChuan(v_ds, decimal.Parse(m_txt_nam.Text));
            load_du_lieu_tuy_chinh_bo_sung(v_ds, v_ds_loai_nv_tren_danh_muc);
        }

        private void load_du_lieu_tuy_chinh_bo_sung(DataSet v_ds, DataSet v_ds_loai_nv_tren_danh_muc)
        {
            DataTable dt = new DataTable();
            khoi_tao_datatable(dt);
            // get_so_loai_nhan_vien();
            int so_luong = v_ds.Tables[0].Rows.Count / 12;

            for (int i = 0; i < so_luong; i++)
            {
                DataRow v_dr = dt.NewRow();
                v_dr[0] = v_ds.Tables[0].Rows[12 * i]["TEN"].ToString();
                v_dr[1] = v_ds.Tables[0].Rows[12 * i]["MA_LOAI_NHAN_VIEN"].ToString();
                v_dr[2] = v_ds.Tables[0].Rows[12 * i]["ID_LOAI_NHAN_VIEN"].ToString();
                v_dr[3] = v_ds.Tables[0].Rows[12 * i + 0]["SO_NGAY_LV_TIEU_CHUAN"].ToString();
                v_dr[4] = v_ds.Tables[0].Rows[12 * i + 1]["SO_NGAY_LV_TIEU_CHUAN"].ToString();
                v_dr[5] = v_ds.Tables[0].Rows[12 * i + 2]["SO_NGAY_LV_TIEU_CHUAN"].ToString();
                v_dr[6] = v_ds.Tables[0].Rows[12 * i + 3]["SO_NGAY_LV_TIEU_CHUAN"].ToString();
                v_dr[7] = v_ds.Tables[0].Rows[12 * i + 4]["SO_NGAY_LV_TIEU_CHUAN"].ToString();
                v_dr[8] = v_ds.Tables[0].Rows[12 * i + 5]["SO_NGAY_LV_TIEU_CHUAN"].ToString();
                v_dr[9] = v_ds.Tables[0].Rows[12 * i + 6]["SO_NGAY_LV_TIEU_CHUAN"].ToString();
                v_dr[10] = v_ds.Tables[0].Rows[12 * i + 7]["SO_NGAY_LV_TIEU_CHUAN"].ToString();
                v_dr[11] = v_ds.Tables[0].Rows[12 * i + 8]["SO_NGAY_LV_TIEU_CHUAN"].ToString();
                v_dr[12] = v_ds.Tables[0].Rows[12 * i + 9]["SO_NGAY_LV_TIEU_CHUAN"].ToString();
                v_dr[13] = v_ds.Tables[0].Rows[12 * i + 10]["SO_NGAY_LV_TIEU_CHUAN"].ToString();
                v_dr[14] = v_ds.Tables[0].Rows[12 * i + 11]["SO_NGAY_LV_TIEU_CHUAN"].ToString();
               
                dt.Rows.Add(v_dr);
            }
            //add thêm những loại nhân viên mới
            for (int i = 0; i < v_ds_loai_nv_tren_danh_muc.Tables[0].Rows.Count; i++)
            {
                String ma_nv = v_ds_loai_nv_tren_danh_muc.Tables[0].Rows[i]["MA_LOAI_NHAN_VIEN"].ToString();
                bool contains = dt.AsEnumerable().Any(row => ma_nv == row.Field<String>("MA_LOAI_NHAN_VIEN"));
                if (!contains)
                {
                    dt.Rows.Add(v_ds_loai_nv_tren_danh_muc.Tables[0].Rows[i]["MA_LOAI_NHAN_VIEN"].ToString() + " - " + v_ds_loai_nv_tren_danh_muc.Tables[0].Rows[i]["TEN_LOAI_NHAN_VIEN"].ToString(), v_ds_loai_nv_tren_danh_muc.Tables[0].Rows[i]["MA_LOAI_NHAN_VIEN"].ToString(), v_ds_loai_nv_tren_danh_muc.Tables[0].Rows[i]["ID"].ToString());
                }
            }
            m_grc.DataSource = dt;
        }


        private int get_so_luong_loai_nv_thuc_te_cua_nam(DataSet v_ds_loai_nv_thuc_te_cua_nam)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            v_us.FillDatasetWithQuery(v_ds_loai_nv_thuc_te_cua_nam, "SELECT DISTINCT ID_LOAI_NHAN_VIEN FROM GD_LOAI_NV_NGAY_LV_TIEU_CHUAN WHERE NAM=" + m_txt_nam.Text);
            return v_ds_loai_nv_thuc_te_cua_nam.Tables[0].Rows.Count;
        }

        private int get_so_luong_loai_nv_tren_danh_muc(DataSet v_ds_loai_nv_tren_danh_muc)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            v_us.FillDatasetWithQuery(v_ds_loai_nv_tren_danh_muc, "SELECT * FROM DM_LOAI_NHAN_VIEN");
            return v_ds_loai_nv_tren_danh_muc.Tables[0].Rows.Count;
        }

        private void load_data_dung_len_grid_loai_ngay_cong()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.LayDuLieuSoNgayCongTieuChuan(v_ds, decimal.Parse(m_txt_nam.Text));
            load_du_lieu_tuy_chinh(v_ds);
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
                v_dr[0] = v_ds.Tables[0].Rows[12 * i]["TEN"].ToString();
                v_dr[1] = v_ds.Tables[0].Rows[12 * i]["MA_LOAI_NHAN_VIEN"].ToString();
                v_dr[2] = v_ds.Tables[0].Rows[12 * i]["ID_LOAI_NHAN_VIEN"].ToString();
                v_dr[3] = v_ds.Tables[0].Rows[12 * i + 0]["SO_NGAY_LV_TIEU_CHUAN"].ToString();
                v_dr[4] = v_ds.Tables[0].Rows[12 * i + 1]["SO_NGAY_LV_TIEU_CHUAN"].ToString();
                v_dr[5] = v_ds.Tables[0].Rows[12 * i + 2]["SO_NGAY_LV_TIEU_CHUAN"].ToString();
                v_dr[6] = v_ds.Tables[0].Rows[12 * i + 3]["SO_NGAY_LV_TIEU_CHUAN"].ToString();
                v_dr[7] = v_ds.Tables[0].Rows[12 * i + 4]["SO_NGAY_LV_TIEU_CHUAN"].ToString();
                v_dr[8] = v_ds.Tables[0].Rows[12 * i + 5]["SO_NGAY_LV_TIEU_CHUAN"].ToString();
                v_dr[9] = v_ds.Tables[0].Rows[12 * i + 6]["SO_NGAY_LV_TIEU_CHUAN"].ToString();
                v_dr[10] = v_ds.Tables[0].Rows[12 * i + 7]["SO_NGAY_LV_TIEU_CHUAN"].ToString();
                v_dr[11] = v_ds.Tables[0].Rows[12 * i + 8]["SO_NGAY_LV_TIEU_CHUAN"].ToString();
                v_dr[12] = v_ds.Tables[0].Rows[12 * i + 9]["SO_NGAY_LV_TIEU_CHUAN"].ToString();
                v_dr[13] = v_ds.Tables[0].Rows[12 * i + 10]["SO_NGAY_LV_TIEU_CHUAN"].ToString();
                v_dr[14] = v_ds.Tables[0].Rows[12 * i + 11]["SO_NGAY_LV_TIEU_CHUAN"].ToString();
                dt.Rows.Add(v_dr);
            }
            m_grc.DataSource = dt;
        }

        private void khoi_tao_datatable(DataTable dt)
        {
            dt.Columns.Add("TEN", typeof(string));
            dt.Columns.Add("MA_LOAI_NHAN_VIEN", typeof(string));
            dt.Columns.Add("ID_LOAI_NHAN_VIEN", typeof(string));
            for (int i = 0; i < 12; i++)
            {
                dt.Columns.Add("THANG_" + (i + 1), typeof(string));
            }
           
            
        }


        private int get_so_luong_loai_nv_thuc_te_cua_nam()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "SELECT DISTINCT ID_LOAI_NHAN_VIEN FROM GD_LOAI_NV_NGAY_LV_TIEU_CHUAN WHERE NAM="+ m_txt_nam.Text);
            return v_ds.Tables[0].Rows.Count;
        }

        private int get_so_luong_loai_nv_tren_danh_muc()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM DM_LOAI_NHAN_VIEN");
            return v_ds.Tables[0].Rows.Count;
        }

        private void m_btn_luu_Click(object sender, EventArgs e)
        {
            if (check_du_lieu_is_ok())
            {
                cap_nhat_du_lieu();
            }
        }

        private void cap_nhat_du_lieu()
        {
            try
            {
                xoa_du_lieu_bang_gd_cu();
                them_du_lieu_cho_cac_loai_nv();
                MessageBox.Show("Lưu dữ liệu thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi hệ thống!");            
            }
           
            
        }

        private void them_du_lieu_cho_cac_loai_nv()
        {
            for (int i = 0; i < m_grv.DataRowCount; i++)
            {
                DataRow v_dr = m_grv.GetDataRow(i);
                var id_loai_nhan_vien = decimal.Parse(v_dr["ID_LOAI_NHAN_VIEN"].ToString());
                luu_so_ngay_cua_tung_loai(id_loai_nhan_vien, v_dr);
            }
        }

        private void luu_so_ngay_cua_tung_loai(decimal id_loai_nhan_vien, DataRow v_dr)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            v_us.UpdateSoNgayTieuChuanTuyChon(id_loai_nhan_vien, v_dr, decimal.Parse(m_txt_nam.Text));
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
            for (int i = 0; i < m_grv.RowCount; i++)
            {
                var v_dr = m_grv.GetDataRow(i);
                for (int j = 3; j < 15; j++)
                {
                    decimal result;
                    if (!decimal.TryParse(v_dr[j].ToString(), out result))
                    {
                        MessageBox.Show("Số ngày làm việc tiêu chuẩn phải là số. Vui lòng nhập chính xác thông tin!");
                        return false;
                    }
                }
            }
            return true;
        }

        private void m_btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (tab_Control1.SelectedTab.Name == "tab_danhmucloainhanvien")
                {
                    
                        DANH_MUC_LOAI_NHAN_VIEN_DETAIL v_f_danh_muc_loai_nhan_vien = new DANH_MUC_LOAI_NHAN_VIEN_DETAIL();
                        v_f_danh_muc_loai_nhan_vien.dislay_for_insert();
                        load_data_to_grid_loai_nhan_vien();
                }
                       
                }

            
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_btn_sua_Click(object sender, EventArgs e)
        {
            if (tab_Control1.SelectedTab.Name == "tab_danhmucloainhanvien")
            {
                var v_count_loai_nhan_vien= m_grv_loai_nv.SelectedRowsCount;
                if (v_count_loai_nhan_vien == 0)
                {
                    MessageBox.Show("Bạn phải chọn 1 sản phẩm mới có thể cập nhật!");
                }
                else if (v_count_loai_nhan_vien > 1)
                {
                    MessageBox.Show("Vui lòng chỉ lựa chọn 1 sản phẩm để cập nhật!");
                }
                else
                {
                    DataRow v_dr = m_grv_loai_nv.GetDataRow(m_grv_loai_nv.FocusedRowHandle);
                    US_DM_LOAI_NHAN_VIEN v_us = new US_DM_LOAI_NHAN_VIEN(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                    DANH_MUC_LOAI_NHAN_VIEN_DETAIL v_f = new DANH_MUC_LOAI_NHAN_VIEN_DETAIL();
                    v_f.dislay_for_update(v_us);
                    load_data_to_grid_loai_nhan_vien();
                }
            }
        }

        private void m_btn_xoa_Click(object sender, EventArgs e)
        {
            
            if (tab_Control1.SelectedTab.Name == "tab_danhmucloainhanvien")
            {

                DialogResult dialogresult = MessageBox.Show("bạn có chắc chắn muốn hoàn thành tác vụ này không?", "cảnh báo", MessageBoxButtons.YesNo);
                if (dialogresult == DialogResult.Yes)
                {
                    DataRow v_dr = m_grv_loai_nv.GetDataRow(m_grv_loai_nv.FocusedRowHandle);
                    decimal v_id = CIPConvert.ToDecimal(v_dr["ID"].ToString());
                    US_DM_LOAI_NHAN_VIEN v_us = new US_DM_LOAI_NHAN_VIEN(v_id);
                    v_us.Delete();
                    MessageBox.Show("Đã xóa thành công  " + v_dr["TEN_LOAI_NHAN_VIEN"] + " !");
                    load_data_to_grid_loai_nhan_vien();
                }
            }
        }


      
    }
}
