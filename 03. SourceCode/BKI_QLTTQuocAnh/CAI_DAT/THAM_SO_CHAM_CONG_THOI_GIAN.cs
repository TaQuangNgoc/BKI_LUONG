using BKI_DichVuMatDat.CAI_DAT.DETAIL;
using BKI_DichVuMatDat.US;
using IP.Core.IPCommon;
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
    public partial class THAM_SO_CHAM_CONG_THOI_GIAN : Form
    {
        public THAM_SO_CHAM_CONG_THOI_GIAN()
        {
            InitializeComponent();
            tab_Control1.SizeMode = TabSizeMode.Fixed;
            tab_Control1.ItemSize = new Size(tab_Control1.Width / tab_Control1.TabCount, 40);
            load_du_lieu_vao_bang_loai_ngay_cong();
            load_du_lieu_vao_bang_Lam_them_gio();
            load_du_lieu_vao_bang_phu_cap();
           
            load_du_lieu_vao_bang_bao_hiem();
            load_du_lieu_vao_bang_thue();


           // tabControl1.Appearance = TabAppearance.FlatButtons;
        }


        private void load_du_lieu_vao_bang_bao_hiem()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "DM_BAO_HIEM");
            m_grc_bao_hiem.DataSource = v_ds.Tables[0];
        }

        private void load_du_lieu_vao_bang_phu_cap()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_DM_PHU_CAP");
           m_grc_loai_phu_cap.DataSource = v_ds.Tables[0];
        }
        private void load_du_lieu_vao_bang_thue()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "DM_THUE");
            m_grc_thue.DataSource = v_ds.Tables[0];
        }

        private void load_du_lieu_vao_bang_Lam_them_gio()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "DM_TI_LE_LAM_THEM");
            m_grc_loai_lam_them_gio.DataSource = v_ds.Tables[0];
        }

        private void load_du_lieu_vao_bang_loai_ngay_cong()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "DM_LOAI_NGAY_CONG");
            m_grc_ngay_cong.DataSource = v_ds.Tables[0];
        }

        private void text_box_format_numeric(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void text_box_key_up_format_currency(object sender, KeyEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            try
            {
               
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double valueBefore = Double.Parse(textbox.Text, System.Globalization.NumberStyles.AllowThousands);
                textbox.Text = String.Format(culture, "{0:N0}", valueBefore);       
            }
            catch (Exception)
            {

                MessageBox.Show("Nhập chẵn số tiền!");
                textbox.Text = "";
            }

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            

        }

        private void m_btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                switch (tab_Control1.SelectedTab.Name)
                {
                    case "tab_loaingaycong":
                        LOAI_NGAY_CONG_DETAIL v_f_loai_ngay_cong = new LOAI_NGAY_CONG_DETAIL();
                        v_f_loai_ngay_cong.dislay_for_insert();
                        load_du_lieu_vao_bang_loai_ngay_cong();
                        break;
                    case "tab_lamthemgio":
                        LAM_THEM_GIO_DETAIL v_f_lam_them_gio = new LAM_THEM_GIO_DETAIL();
                        v_f_lam_them_gio.dislay_for_insert();
                        load_du_lieu_vao_bang_Lam_them_gio();
                        break;
                    case "tab_phucap":
                        PHU_CAP_DETAIL v_f_phu_cap = new PHU_CAP_DETAIL();
                        v_f_phu_cap.dislay_for_insert();
                        load_du_lieu_vao_bang_phu_cap();
                        break;
                    case "tab_baohiem":
                        BAO_HIEM_DETAIL v_f_bao_hiem = new BAO_HIEM_DETAIL();
                        v_f_bao_hiem.dislay_for_insert();
                        load_du_lieu_vao_bang_bao_hiem();
                        break;
                    case "tab_thue":
                        THUE_DETAIL v_f_thue = new THUE_DETAIL();
                        v_f_thue.dislay_for_insert();
                        load_du_lieu_vao_bang_loai_ngay_cong();
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

        private void m_btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                switch (tab_Control1.SelectedTab.Name)
                {
                    case "tab_loaingaycong":
                        loại_ngay_cong_delete();
                        break;
                    case "tab_lamthemgio":
                        lam_them_gio_delete();
                        break;
                        
                    default:
                        break;
                }
                
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void lam_them_gio_delete()
        {
            DialogResult dialogresult = MessageBox.Show("bạn có chắc chắn muốn hoàn thành tác vụ này không?", "cảnh báo", MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                DataRow v_dr = m_grv_lam_them_gio.GetDataRow(m_grv_lam_them_gio.FocusedRowHandle);
                decimal v_id = CIPConvert.ToDecimal(v_dr["ID"].ToString());
                US_DM_TI_LE_LAM_THEM v_us = new US_DM_TI_LE_LAM_THEM(v_id);
                v_us.Delete();
                MessageBox.Show("Đã xóa thành công sản phẩm " + v_dr["TEN_LOAI_LAM_THEM"] + " !");
                load_du_lieu_vao_bang_Lam_them_gio();
            }
        }

        private void loại_ngay_cong_delete()
        {
            DialogResult dialogresult = MessageBox.Show("bạn có chắc chắn muốn hoàn thành tác vụ này không?", "cảnh báo", MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                DataRow v_dr = m_grv_ngay_cong.GetDataRow(m_grv_ngay_cong.FocusedRowHandle);
                decimal v_id = CIPConvert.ToDecimal(v_dr["ID"].ToString());
                US_DM_LOAI_NGAY_CONG v_us = new US_DM_LOAI_NGAY_CONG(v_id);
                v_us.Delete();
                MessageBox.Show("Đã xóa thành công sản phẩm " + v_dr["TEN_NGAY_CONG"] + " !");
                load_du_lieu_vao_bang_loai_ngay_cong();
            }
        }

        private void m_btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                switch (tab_Control1.SelectedTab.Name)
                {
                    case "tab_loaingaycong":
                        loai_ngay_cong_update();
                        break;
                    case "tab_lamthemgio":
                        lam_them_gio_update();
                        break;
                    case "tab_phucap":
                        phu_cap_update();
                        break;
                    case "tab_baohiem":
                       //bap_hiem_update();
                        break;
                    case "tab_thue":
                       //thue_update();
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

        private void phu_cap_update()
        {
            var v_count_phu_cap = m_grv_phu_cap.SelectedRowsCount;
            if (v_count_phu_cap == 0)
            {
                MessageBox.Show("Bạn phải chọn 1 sản phẩm mới có thể cập nhật!");
            }
            else if (v_count_phu_cap > 1)
            {
                MessageBox.Show("Vui lòng chỉ lựa chọn 1 sản phẩm để cập nhật!");
            }
            else
            {
                DataRow v_dr = m_grv_phu_cap.GetDataRow(m_grv_phu_cap.FocusedRowHandle);
                US_DM_PHU_CAP v_us = new US_DM_PHU_CAP(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                PHU_CAP_DETAIL v_f = new PHU_CAP_DETAIL();
                v_f.dislay_for_update(v_us);
                load_du_lieu_vao_bang_phu_cap();
            }
        }

        private void lam_them_gio_update()
        {
            var v_count_lam_them_gio = m_grv_lam_them_gio.SelectedRowsCount;
            if (v_count_lam_them_gio == 0)
            {
                MessageBox.Show("Bạn phải chọn 1 sản phẩm mới có thể cập nhật!");
            }
            else if (v_count_lam_them_gio > 1)
            {
                MessageBox.Show("Vui lòng chỉ lựa chọn 1 sản phẩm để cập nhật!");
            }
            else
            {
                DataRow v_dr = m_grv_lam_them_gio.GetDataRow(m_grv_lam_them_gio.FocusedRowHandle);
                US_DM_TI_LE_LAM_THEM v_us = new US_DM_TI_LE_LAM_THEM(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                LAM_THEM_GIO_DETAIL v_f = new LAM_THEM_GIO_DETAIL();
                v_f.dislay_for_update(v_us);
                load_du_lieu_vao_bang_Lam_them_gio();
            }
        }

        private void loai_ngay_cong_update()
        {
            var v_count_loai_ngay_cong = m_grv_ngay_cong.SelectedRowsCount;
            if (v_count_loai_ngay_cong == 0)
            {
                MessageBox.Show("Bạn phải chọn 1 sản phẩm mới có thể cập nhật!");
            }
            else if (v_count_loai_ngay_cong > 1)
            {
                MessageBox.Show("Vui lòng chỉ lựa chọn 1 sản phẩm để cập nhật!");
            }
            else
            {
                DataRow v_dr = m_grv_ngay_cong.GetDataRow(m_grv_ngay_cong.FocusedRowHandle);
                US_DM_LOAI_NGAY_CONG v_us = new US_DM_LOAI_NGAY_CONG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                LOAI_NGAY_CONG_DETAIL v_f = new LOAI_NGAY_CONG_DETAIL();
                v_f.dislay_for_update(v_us);
                load_du_lieu_vao_bang_loai_ngay_cong();
            }
        }

        
      
        
        


       
        
       
        
       


       
      
     
    }
}
