using BKI_DichVuMatDat.CAI_DAT.DETAIL;
using BKI_DichVuMatDat.US;
using BKI_DichVuMatDat.DS;
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
using DevExpress.XtraEditors;

namespace BKI_DichVuMatDat.CAI_DAT
{
    public partial class DANG_NHAP_HE_THONG : Form
    {
        public DANG_NHAP_HE_THONG()
        {
            InitializeComponent();
            load_du_lieu_vao_bang_dang_nhap_he_thong();
        }

        private void load_du_lieu_vao_bang_dang_nhap_he_thong()
        {

            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "HT_USER");
            m_grc_dang_nhap_he_thong.DataSource = v_ds.Tables[0];
        }

        private void m_btn_them_Click(object sender, EventArgs e)
        {
            DANG_NHAP_HE_THONG_DETAIL v_f = new DANG_NHAP_HE_THONG_DETAIL();
            v_f.dislay_for_insert();
            load_du_lieu_vao_bang_dang_nhap_he_thong();
        }

        private void m_btn_sua_Click(object sender, EventArgs e)
        {
            var v_count = m_grv_dang_nhap_he_thong.SelectedRowsCount;
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
                DataRow v_dr = m_grv_dang_nhap_he_thong.GetDataRow(m_grv_dang_nhap_he_thong.FocusedRowHandle);
                US_HT_USER v_us = new US_HT_USER(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                DANG_NHAP_HE_THONG_DETAIL v_f = new DANG_NHAP_HE_THONG_DETAIL();
                v_f.dislay_for_update(v_us);
                load_du_lieu_vao_bang_dang_nhap_he_thong();
            }
        }

        private void m_btn_xoa_Click(object sender, EventArgs e)
        {
            
            
                DialogResult dialogresult = MessageBox.Show("bạn có chắc chắn muốn hoàn thành tác vụ này không?", "cảnh báo", MessageBoxButtons.YesNo);
                if (dialogresult == DialogResult.Yes)
                {
                    DataRow v_dr = m_grv_dang_nhap_he_thong.GetDataRow(m_grv_dang_nhap_he_thong.FocusedRowHandle);
                    decimal v_id = CIPConvert.ToDecimal(v_dr["ID"].ToString());
                    US_HT_USER v_us = new US_HT_USER(v_id);
                    v_us.Delete();
                    MessageBox.Show("Đã xóa thành công !");
                    load_du_lieu_vao_bang_dang_nhap_he_thong();
                }
            }
            
        }
    }

