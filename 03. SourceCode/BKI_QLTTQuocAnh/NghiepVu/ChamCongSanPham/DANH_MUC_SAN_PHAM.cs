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

namespace BKI_DichVuMatDat.NghiepVu.ChamCongSanPham
{
    public partial class DANH_MUC_SAN_PHAM : Form
    {
        public DANH_MUC_SAN_PHAM()
        {
            InitializeComponent();
            tab_Control1.SizeMode = TabSizeMode.Fixed;
            tab_Control1.ItemSize = new Size(tab_Control1.Width / tab_Control1.TabCount, 40);
            tab_Control1.Appearance = TabAppearance.FlatButtons;
            load_du_lieu_vao_bang_danh_muc_sp();
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
                DANH_MUC_SAN_PHAM_DETAIL v_f = new DANH_MUC_SAN_PHAM_DETAIL();
                v_f.dislay_for_insert();
                load_du_lieu_vao_bang_danh_muc_sp();
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
                var v_count = m_grv_san_pham.SelectedRowsCount;
                if (v_count == 0)
                {
                    MessageBox.Show("Bạn phải chọn 1 sản phẩm mới có thể cập nhật!");
                }
                else if (v_count > 1)
                {
                    MessageBox.Show("Vui lòng chỉ lựa chọn 1 sản phẩm để cập nhật!");
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
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
               
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thực hiện tác vụ này không?", "Cảnh báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        DataRow v_dr = m_grv_san_pham.GetDataRow(m_grv_san_pham.FocusedRowHandle);
                        decimal v_id = CIPConvert.ToDecimal(v_dr["ID"].ToString());
                        US_DM_SAN_PHAM v_us = new US_DM_SAN_PHAM(v_id);
                        v_us.Delete();
                        MessageBox.Show("Đã xóa thành công sản phẩm " + v_dr["TEN_SAN_PHAM"] + " !");
                        load_du_lieu_vao_bang_danh_muc_sp();
                    }
                

            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

     
    }
}
