using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IP.Core.IPCommon;
using BKI_DichVuMatDat.DS;
using BKI_DichVuMatDat.US;
using DevExpress.XtraEditors;

namespace BKI_DichVuMatDat.NghiepVu.ChamCongSanPham
{
    public partial class DANH_MUC_SAN_PHAM : MaterialSkin.Controls.MaterialForm
    {
        public DANH_MUC_SAN_PHAM()
        {
            InitializeComponent();
            tab_Control1.SizeMode = TabSizeMode.Fixed;
            tab_Control1.ItemSize = new Size(tab_Control1.Width / tab_Control1.TabCount, 40);
            tab_Control1.Appearance = TabAppearance.FlatButtons;
            load_du_lieu_vao_bang_danh_muc_sp();
            load_du_lieu_vao_bang_danh_muc_ti_le_lam_them();
            WinFormControls.formatGridView(m_grv_danh_muc_ti_le_lam_them);
            WinFormControls.formatGridView(m_grv_luong_ngay);
            WinFormControls.formatGridView(m_grv_san_pham);
        }

        private void load_du_lieu_vao_bang_danh_muc_ti_le_lam_them()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "DM_TI_LE_LAM_THEM_THEO_SAN_PHAM");
            m_grc_danh_muc_ti_le_lam_them.DataSource = v_ds.Tables[0];
        }

        private void load_du_lieu_vao_bang_danh_muc_sp()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "DM_SAN_PHAM");
            m_grc_san_pham.DataSource = v_ds.Tables[0];
        }

        private void m_btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                switch (tab_Control1.SelectedTab.Name)
                {
                    case "tab_danhmucsanpham":
                        DANH_MUC_SAN_PHAM_DETAIL v_f_danh_muc_san_pham = new DANH_MUC_SAN_PHAM_DETAIL();
                        v_f_danh_muc_san_pham.dislay_for_insert();
                        load_du_lieu_vao_bang_danh_muc_sp();
                        break;
                   /* case "tab_dongiasanpham":
                        LAM_THEM_GIO_DETAIL v_f_don_gia_san_pham = new LAM_THEM_GIO_DETAIL();
                        v_f_don_gia_san_pham.dislay_for_insert();
                        load_du_lieu_vao_bang_Lam_them_gio();
                        break;*/
                    case "tab_danhmuctilelamthem":
                        DANH_MUC_TI_LE_LAM_THEM_DETAIL v_f_danh_muc_ti_le_lam_them = new DANH_MUC_TI_LE_LAM_THEM_DETAIL();
                        v_f_danh_muc_ti_le_lam_them.dislay_for_insert();
                        load_du_lieu_vao_bang_danh_muc_ti_le_lam_them();
                        break;
                    
                    default:
                        break;
                }

            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
            
        }

        private void m_btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                switch (tab_Control1.SelectedTab.Name)
                {
                    case "tab_danhmucsanpham":
                        danh_muc_san_pham_update();
                        break;
                    /*case "tab_dongiasanpham":
                        dong_gia_san_pham_update();
                        break;*/
                    case "tab_danhmuctilelamthem":
                        danh_muc_ti_le_lam_them_update();
                        break;




                    default:
                        break;
                }
            }

            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void danh_muc_ti_le_lam_them_update()
        {
            
            var v_count = m_grv_danh_muc_ti_le_lam_them.SelectedRowsCount;
            if (v_count == 0)
            {
                XtraMessageBox.Show("Bạn phải chọn 1 sản phẩm mới có thể cập nhật!");
            }
            else if (v_count > 1)
            {
                XtraMessageBox.Show("Vui lòng chỉ lựa chọn 1 sản phẩm để cập nhật!");
            }
            else
            {
                DataRow v_dr = m_grv_danh_muc_ti_le_lam_them.GetDataRow(m_grv_danh_muc_ti_le_lam_them.FocusedRowHandle);
                US_DM_TI_LE_LAM_THEM_THEO_SAN_PHAM v_us = new US_DM_TI_LE_LAM_THEM_THEO_SAN_PHAM(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                DANH_MUC_TI_LE_LAM_THEM_DETAIL v_f = new DANH_MUC_TI_LE_LAM_THEM_DETAIL();
                v_f.dislay_for_update(v_us);
                load_du_lieu_vao_bang_danh_muc_ti_le_lam_them();
            }  
        }

          

       

private void danh_muc_san_pham_update()
{
    var v_count = m_grv_san_pham.SelectedRowsCount;
    if (v_count == 0)
    {
        XtraMessageBox.Show("Bạn phải chọn 1 sản phẩm mới có thể cập nhật!");
    }
    else if (v_count > 1)
    {
        XtraMessageBox.Show("Vui lòng chỉ lựa chọn 1 sản phẩm để cập nhật!");
    }
    else
    {
        DataRow v_dr = m_grv_san_pham.GetDataRow(m_grv_san_pham.FocusedRowHandle);
        US_DM_SAN_PHAM v_us = new US_DM_SAN_PHAM(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
        DANH_MUC_SAN_PHAM_DETAIL v_f = new DANH_MUC_SAN_PHAM_DETAIL();
        v_f.dislay_for_update(v_us);
        load_du_lieu_vao_bang_danh_muc_sp();
    }
}
        void m_btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                switch (tab_Control1.SelectedTab.Name)
                {
                    case "tab_danhmucsanpham":
                        danh_muc_san_pham_delete();
                        break;
                    /*case "tab_dongiasanpham":
                        dong_gia_san_pham_delete();
                        break;*/
                    case "tab_danhmuctilelamthem":
                        danh_muc_ti_le_lam_them_delete();
                        break;




                    default:
                        break;
                }
            }

            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
           
        }

        private void danh_muc_ti_le_lam_them_delete()
        {
            try
            {

                DialogResult dialogResult = XtraMessageBox.Show("Bạn có chắc chắn muốn thực hiện tác vụ này không?", "Cảnh báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DataRow v_dr = m_grv_danh_muc_ti_le_lam_them.GetDataRow(m_grv_danh_muc_ti_le_lam_them.FocusedRowHandle);
                    decimal v_id = CIPConvert.ToDecimal(v_dr["ID"].ToString());
                    US_DM_TI_LE_LAM_THEM_THEO_SAN_PHAM v_us = new US_DM_TI_LE_LAM_THEM_THEO_SAN_PHAM(v_id);
                    v_us.Delete();
                    XtraMessageBox.Show("Đã xóa thành công  " + v_dr["TEN_LOAI_LAM_THEM"] + " !");
                    load_du_lieu_vao_bang_danh_muc_ti_le_lam_them();
                }
                
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Đã tồn tại ngày chấm công chứa mã ngày công này! ");
            }

        }

        private void danh_muc_san_pham_delete()
        {

            DialogResult dialogResult = XtraMessageBox.Show("Bạn có chắc chắn muốn thực hiện tác vụ này không?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataRow v_dr = m_grv_san_pham.GetDataRow(m_grv_san_pham.FocusedRowHandle);
                decimal v_id = CIPConvert.ToDecimal(v_dr["ID"].ToString());
                US_DM_SAN_PHAM v_us = new US_DM_SAN_PHAM(v_id);
                v_us.Delete();
                XtraMessageBox.Show("Đã xóa thành công sản phẩm " + v_dr["TEN_SAN_PHAM"] + " !");
                load_du_lieu_vao_bang_danh_muc_sp();
            }
                
        }

     
    }
}
