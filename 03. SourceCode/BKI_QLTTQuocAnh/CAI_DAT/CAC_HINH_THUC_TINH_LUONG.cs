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
    public partial class CAC_HINH_THUC_TINH_LUONG : Form
    {
        public CAC_HINH_THUC_TINH_LUONG()
        {
            InitializeComponent();
            load_cac_hinh_thuc_tinh_luong_cua_cong_ty();
        }

        private void load_cac_hinh_thuc_tinh_luong_cua_cong_ty()
        {

            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            //LAY RA TẤT CẢ CÁC HÌNH THỨC TÍNH LƯƠNG, INSERT CHO NHÂN VIÊN , cho trạng thái CO_YN là N
            DataSet v_ds_hinh_thuc_tinh_luong = new DataSet();
            v_ds_hinh_thuc_tinh_luong.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds_hinh_thuc_tinh_luong, "SELECT ID_HINH_THUC AS ID FROM GD_CONG_TY_HINH_THUC_TINH_LUONG WHERE CO_YN='Y'");

            active_hinh_thuc(v_ds_hinh_thuc_tinh_luong);
        }

        private void active_hinh_thuc(DataSet v_ds_hinh_thuc_tinh_luong)
        {

            for (int i = 0; i < v_ds_hinh_thuc_tinh_luong.Tables[0].Rows.Count; i++)
            {
                if (decimal.Parse(v_ds_hinh_thuc_tinh_luong.Tables[0].Rows[i]["ID"].ToString()) == 1)
                {
                    m_cb_luong_theo_thoi_gian.Checked = true;
                }
                if (decimal.Parse(v_ds_hinh_thuc_tinh_luong.Tables[0].Rows[i]["ID"].ToString()) == 2)
                {
                    m_cb_luong_ngay.Checked = true;
                }
                if (decimal.Parse(v_ds_hinh_thuc_tinh_luong.Tables[0].Rows[i]["ID"].ToString()) == 3)
                {
                    m_cb_luong_theo_san_pham.Checked = true;
                }
                if (decimal.Parse(v_ds_hinh_thuc_tinh_luong.Tables[0].Rows[i]["ID"].ToString()) == 4)
                {
                    m_cb_luong_khoan.Checked = true;
                }

            }
        }

        private void m_btn_luu_Click(object sender, EventArgs e)
        {
            luu_cac_hinh_thuc_duoc_tick();
        }

        private void luu_cac_hinh_thuc_duoc_tick()
        {
            List<decimal> ListActive = new List<decimal>();
            if (m_cb_luong_theo_thoi_gian.Checked == true)
                ListActive.Add(1);
            if (m_cb_luong_ngay.Checked == true)
                ListActive.Add(2);
            if (m_cb_luong_theo_san_pham.Checked == true)
                ListActive.Add(3);
            if (m_cb_luong_khoan.Checked == true)
                ListActive.Add(4);
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            v_us.non_active_hinh_thuc_tinh_luong_cua_cong_ty();
            if (ListActive.Count > 0)
            {
                for (int i = 0; i < ListActive.Count; i++)
                {

                    v_us.active_hinh_thuc_tinh_luong_cho_cong_ty(ListActive[i]);
                }
                MessageBox.Show("Lưu thành công thông tin về các hình thức tính lương cho công ty!");
            }
            else
            {
                MessageBox.Show("Bạn phải lựa chọn ít nhất 1 trong các hình thức tính lương cho công ty!");
            }
        }
    }
}
