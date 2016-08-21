using BKI_DichVuMatDat.CAI_DAT;
using BKI_DichVuMatDat.NghiepVu;
using BKI_DichVuMatDat.NghiepVu.THEONGAY;
using BKI_DichVuMatDat.NghiepVu.THEOTHOIGIAN;
using BKI_DichVuMatDat.NghiepVu.ThongTinNhanVien;
using MaterialSkin;
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
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    { 
        //US_TBL_FOREIGN m_us_tbl_foreign = new US_TBL_FOREIGN(); 
        //DS_TBL_FOREIGN m_ds_tbl_foreign = new DS_TBL_FOREIGN(); 
        private readonly MaterialSkinManager materialSkinManager;
        public Form1() 
        { 
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
        }

        private void cachinhthuctinhluong_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            CAC_HINH_THUC_TINH_LUONG v_f = new CAC_HINH_THUC_TINH_LUONG();
            m_lbl_formname.Text = v_f.Text.ToUpper();
            v_f.TopLevel = false;
            v_f.Dock = DockStyle.Fill;
            m_pn_form.Controls.Add(v_f);
            v_f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            v_f.WindowState = FormWindowState.Maximized;
            v_f.Show();
            m_pn_form_chucnang.Dock = DockStyle.Fill;
            m_pn_form_chucnang.Visible = true;
        }

        private void danhmucngaycong_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            THAM_SO_CHAM_CONG_THOI_GIAN v_f = new THAM_SO_CHAM_CONG_THOI_GIAN();
            m_lbl_formname.Text = v_f.Text.ToUpper();
            v_f.TopLevel = false;
            v_f.Dock = DockStyle.Fill;
            m_pn_form.Controls.Add(v_f);
            v_f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            v_f.WindowState = FormWindowState.Maximized;
            v_f.Show();
            m_pn_form_chucnang.Dock = DockStyle.Fill;
            m_pn_form_chucnang.Visible = true;
        }

        private void caidatngaycongtieuchuan_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            F100_NgayCongTieuChuan v_f = new F100_NgayCongTieuChuan();
            m_lbl_formname.Text = v_f.Text.ToUpper();
            v_f.TopLevel = false;
            v_f.Dock = DockStyle.Fill;
            m_pn_form.Controls.Add(v_f);
            v_f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            v_f.WindowState = FormWindowState.Maximized;
            v_f.Show();
            m_pn_form_chucnang.Dock = DockStyle.Fill;
            m_pn_form_chucnang.Visible = true;
        }

        private void thamsokhac_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            THAM_SO_KHAC v_f = new THAM_SO_KHAC();
            m_lbl_formname.Text = v_f.Text.ToUpper();
            v_f.TopLevel = false;
            v_f.Dock = DockStyle.Fill;
            m_pn_form.Controls.Add(v_f);
            v_f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            v_f.WindowState = FormWindowState.Maximized;
            v_f.Show();
            m_pn_form_chucnang.Dock = DockStyle.Fill;
            m_pn_form_chucnang.Visible = true;
        }

        private void themmoinhanvien_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            THEM_MOI_NHAN_VIEN v_f = new THEM_MOI_NHAN_VIEN();
            m_lbl_formname.Text = v_f.Text.ToUpper();
            v_f.TopLevel = false;
            v_f.Dock = DockStyle.Fill;
            m_pn_form.Controls.Add(v_f);
            v_f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            v_f.WindowState = FormWindowState.Maximized;
            v_f.Show();
            m_pn_form_chucnang.Dock = DockStyle.Fill;
            m_pn_form_chucnang.Visible = true;
        }

        private void suathongtinnhanvien_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            SEARCH_NHAN_VIEN v_f = new SEARCH_NHAN_VIEN();
            decimal m_open_form_thong_tin = -1;
            decimal m_id_nhan_vien = -1;
            //-1 là đóng, 1 là mở
            v_f.Show_for_search(ref m_open_form_thong_tin, ref m_id_nhan_vien);
            if (m_open_form_thong_tin == 1)
            {
                THEM_MOI_NHAN_VIEN v_f_them_moi_nv = new THEM_MOI_NHAN_VIEN();
                m_lbl_formname.Text = v_f_them_moi_nv.Text.ToUpper();
                v_f_them_moi_nv.TopLevel = false;
                v_f_them_moi_nv.Dock = DockStyle.Fill;
                m_pn_form.Controls.Add(v_f_them_moi_nv);
                v_f_them_moi_nv.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                v_f_them_moi_nv.WindowState = FormWindowState.Maximized;
                v_f_them_moi_nv.Show();
                m_pn_form_chucnang.Dock = DockStyle.Fill;
                m_pn_form_chucnang.Visible = true;
                ShowForUpdateForm(v_f_them_moi_nv, m_id_nhan_vien);
            }
        }

        private void ShowForUpdateForm(BKI_DichVuMatDat.THEM_MOI_NHAN_VIEN v_f, decimal m_id_nhan_vien)
        {
            v_f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            v_f.Dock = DockStyle.Fill;
            v_f.ShowForUpdateInform(m_id_nhan_vien);
        }

        private void chamcong_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            F696_Cham_cong_xls v_f = new F696_Cham_cong_xls();
            m_lbl_formname.Text = v_f.Text.ToUpper();
            v_f.TopLevel = false;
            v_f.Dock = DockStyle.Fill;
            m_pn_form.Controls.Add(v_f);
            v_f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            v_f.WindowState = FormWindowState.Maximized;
            v_f.Show();
            m_pn_form_chucnang.Dock = DockStyle.Fill;
            m_pn_form_chucnang.Visible = true;
        }

        private void chamconglamthem_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                LAM_THEM_THEO_THOI_GIAN v_f = new LAM_THEM_THEO_THOI_GIAN();
                m_lbl_formname.Text = v_f.Text.ToUpper();
                v_f.TopLevel = false;
                v_f.Dock = DockStyle.Fill;
                m_pn_form.Controls.Add(v_f);
                v_f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                v_f.WindowState = FormWindowState.Maximized;
                v_f.Show();
                m_pn_form_chucnang.Dock = DockStyle.Fill;
                m_pn_form_chucnang.Visible = true;
            }
            catch (Exception v_e)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(v_e.Message);
            }
        }

        private void bangluong_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                BKI_DichVuMatDat.BaoCao.f412_rpt_tong_hop_tt_v2 v_f = new BaoCao.f412_rpt_tong_hop_tt_v2();
                m_lbl_formname.Text = v_f.Text.ToUpper();
                v_f.TopLevel = false;
                v_f.Dock = DockStyle.Fill;
                m_pn_form.Controls.Add(v_f);
                v_f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                v_f.WindowState = FormWindowState.Maximized;
                v_f.Show();
                m_pn_form_chucnang.Dock = DockStyle.Fill;
                m_pn_form_chucnang.Visible = true;
            }
            catch (Exception v_e)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(v_e.Message);
            }
        }

        private void phieuluong_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                BKI_DichVuMatDat.BaoCao.Luong.PHIEU_LUONG v_f = new BaoCao.Luong.PHIEU_LUONG();
                m_lbl_formname.Text = v_f.Text.ToUpper();
                v_f.TopLevel = false;
                v_f.Dock = DockStyle.Fill;
                m_pn_form.Controls.Add(v_f);
                v_f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                v_f.WindowState = FormWindowState.Maximized;
                v_f.Show();
                m_pn_form_chucnang.Dock = DockStyle.Fill;
                m_pn_form_chucnang.Visible = true;
            }
            catch (Exception v_e)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(v_e.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            m_pn_form.Controls.Clear();
            m_pn_form_chucnang.Visible = false;
        }

        private void quantrihethong_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                DANG_NHAP_HE_THONG v_f = new DANG_NHAP_HE_THONG();
                m_lbl_formname.Text = v_f.Text.ToUpper();
                v_f.TopLevel = false;
                v_f.Dock = DockStyle.Fill;
                m_pn_form.Controls.Add(v_f);
                v_f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                v_f.WindowState = FormWindowState.Maximized;
                v_f.Show();
                m_pn_form_chucnang.Dock = DockStyle.Fill;
                m_pn_form_chucnang.Visible = true;
            }
            catch (Exception v_e)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(v_e.Message);
            }
        }

        private void cacloaitienkhac_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                CAC_LOAI_TIEN_KHAC v_f = new CAC_LOAI_TIEN_KHAC();
                m_lbl_formname.Text = v_f.Text.ToUpper();
                v_f.TopLevel = false;
                v_f.Dock = DockStyle.Fill;
                m_pn_form.Controls.Add(v_f);
                v_f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                v_f.WindowState = FormWindowState.Maximized;
                v_f.Show();
                m_pn_form_chucnang.Dock = DockStyle.Fill;
                m_pn_form_chucnang.Visible = true;
            }
            catch (Exception v_e)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(v_e.Message);
            }
        }

        private void theongay_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                CHAM_CONG_THEO_NGAY v_f = new CHAM_CONG_THEO_NGAY();
                m_lbl_formname.Text = v_f.Text.ToUpper();
                v_f.TopLevel = false;
                v_f.Dock = DockStyle.Fill;
                m_pn_form.Controls.Add(v_f);
                v_f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                v_f.WindowState = FormWindowState.Maximized;
                v_f.Show();
                m_pn_form_chucnang.Dock = DockStyle.Fill;
                m_pn_form_chucnang.Visible = true;
            }
            catch (Exception v_e)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(v_e.Message);
            }
        }
    } 
}