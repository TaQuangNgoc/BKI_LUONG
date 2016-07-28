using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BKI_DichVuMatDat.CONFIRM;
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS;
using DevExpress.XtraEditors;

namespace BKI_DichVuMatDat.BaoCao.Luong
{
   
    public partial class NHAN_VIEN_KHONG_CHAM_CONG_THANG : MaterialSkin.Controls.MaterialForm
    {
        public decimal m_thang;
        public decimal m_nam;
        DataTable m_dt_danh_sach_nv_duoc_cham_cong_thang_cu = new DataTable();
        public NHAN_VIEN_KHONG_CHAM_CONG_THANG()
        {
            InitializeComponent();
            format_grid_columns_width();
            WinFormControls.make_stt_indicator(m_grv);
        }

        private void format_grid_columns_width()
        {
            for (int i = 0; i < m_grv.Columns.Count; i++)
            {
                m_grv.Columns[i].Width = 130;
            }
            m_grv.ColumnPanelRowHeight = 35;
            m_grv.RowHeight = 30;
        }

        internal void hienThiDanhSach(decimal thang, decimal nam)
        {
            m_thang= thang;
            m_nam= nam;
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.LoadDanhSachNhanVienKhongDuocTinhLuong(v_ds, thang, nam);
            m_grc.DataSource = v_ds.Tables[0];
            lay_danh_sach_id_nv_duoc_cham_cong(v_ds);
            this.ShowDialog();
        }

        private void lay_danh_sach_id_nv_duoc_cham_cong(DataSet v_ds)
        {
            m_dt_danh_sach_nv_duoc_cham_cong_thang_cu.Columns.Add("ID", typeof(string));
            for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
            {
        
                if ((Boolean)v_ds.Tables[0].Rows[i]["KHONG_CHAM_LUONG_THANG"] == false)
                {
                    m_dt_danh_sach_nv_duoc_cham_cong_thang_cu.Rows.Add(v_ds.Tables[0].Rows[i]["ID_NHAN_VIEN"].ToString());
                }
            }
        }

      
        private void m_btn_luu_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Phần mềm sẽ xóa dữ liệu cũ của những người không được tính lương trong tháng "+m_thang+"/"+ m_nam+", đồng thời  lưu lại thông tin bạn vừa chọn!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            xoa_thong_tin_cu(m_thang,m_nam);
            luu_thong_tin();
        }

        private void xoa_thong_tin_cu(decimal m_thang, decimal m_nam)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "DELETE FROM GD_KHONG_CHAM_LUONG_THANG WHERE THANG=" + m_thang + " AND NAM=" + m_nam);
        }

        private void luu_thong_tin()
        {
            for (int i = 0; i < m_grv.RowCount; i++)
            {
                DataRow v_dr = m_grv.GetDataRow(i);
                //nếu hiện tại ko dc chấm lương, mà trc kia dc chấm lương, thì xóa bản ghi trong rpt_luong
                if ((Boolean)v_dr["KHONG_CHAM_LUONG_THANG"] == true
                    && m_dt_danh_sach_nv_duoc_cham_cong_thang_cu.AsEnumerable().Any(row => v_dr["ID_NHAN_VIEN"].ToString() == row.Field<String>("ID")))
                {
                    xoa_thong_tin_rpt_luong_cua_nhan_vien(v_dr["ID_NHAN_VIEN"].ToString());
                }
                //ghi mới
                if ((Boolean)v_dr["KHONG_CHAM_LUONG_THANG"] == true)
                {
                    US_GD_KHONG_CHAM_LUONG_THANG v_us = new US_GD_KHONG_CHAM_LUONG_THANG();
                    v_us.dcID_NHAN_VIEN = decimal.Parse(v_dr["ID_NHAN_VIEN"].ToString());
                    v_us.dcTHANG = m_thang;
                    v_us.dcNAM = m_nam;
                    v_us.Insert();
                }
            }
            XtraMessageBox.Show("Lưu thành công!");
        }

        private void xoa_thong_tin_rpt_luong_cua_nhan_vien(string id_nhan_vien)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "DELETE FROM RPT_LUONG WHERE THANG=" + m_thang + " AND NAM=" + m_nam + " AND ID_NHAN_VIEN=" + id_nhan_vien);
        }

        private void m_btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
