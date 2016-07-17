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
   
    public partial class NHAN_VIEN_KHONG_CHAM_CONG_THANG : Form
    {
        public decimal m_thang;
        public decimal m_nam;
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
                m_grv.Columns[i].Width = 120;
            }
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
            this.ShowDialog();
        }

        private void m_btn_luu_Click(object sender, EventArgs e)
        {
            msg003_hien_thi_danh_sach msg = new msg003_hien_thi_danh_sach();
            msg.Display("THÔNG BÁO","", "Phần mềm sẽ xóa dữ liệu cũ của những người không được tính lương trong tháng "+m_thang+"/"+ m_nam+", đồng thời  lưu lại thông tin bạn vừa chọn!");
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

        private void m_btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
