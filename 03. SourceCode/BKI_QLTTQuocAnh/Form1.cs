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
using DevExpress.XtraEditors;
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
            m_pn_form_chucnang.Dock = DockStyle.Fill;
            m_pn_form_chucnang.Visible = true;
            CAC_HINH_THUC_TINH_LUONG v_f = new CAC_HINH_THUC_TINH_LUONG();
            m_lbl_formname.Text = "Các hình thức tính lương".ToUpper();
            v_f.TopLevel = false;
            v_f.Dock = DockStyle.Fill;
            m_pn_form.Controls.Add(v_f);
            v_f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            v_f.WindowState = FormWindowState.Maximized;
            v_f.Show();
        }

        private void danhmucngaycong_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            m_pn_form_chucnang.Dock = DockStyle.Fill;
            m_pn_form_chucnang.Visible = true;
            THAM_SO_CHAM_CONG_THOI_GIAN v_f = new THAM_SO_CHAM_CONG_THOI_GIAN();
            m_lbl_formname.Text = "Cài đặt các tham số tính lương".ToUpper();
            v_f.TopLevel = false;
            v_f.Dock = DockStyle.Fill;
            m_pn_form.Controls.Add(v_f);
            v_f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            v_f.WindowState = FormWindowState.Maximized;
            v_f.Show();
        }

        private void caidatngaycongtieuchuan_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            m_pn_form_chucnang.Dock = DockStyle.Fill;
            m_pn_form_chucnang.Visible = true;
            F100_NgayCongTieuChuan v_f = new F100_NgayCongTieuChuan();
            m_lbl_formname.Text = "Cài đặt số ngày công tiêu chuẩn các tháng trong năm".ToUpper();
            v_f.TopLevel = false;
            v_f.Dock = DockStyle.Fill;
            m_pn_form.Controls.Add(v_f);
            v_f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            v_f.WindowState = FormWindowState.Maximized;
            v_f.Show();
        }

        private void thamsokhac_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            m_pn_form_chucnang.Dock = DockStyle.Fill;
            m_pn_form_chucnang.Visible = true;
            THAM_SO_KHAC v_f = new THAM_SO_KHAC();
            m_lbl_formname.Text = "Cài đặt một số tham số khác".ToUpper();
            v_f.TopLevel = false;
            v_f.Dock = DockStyle.Fill;
            m_pn_form.Controls.Add(v_f);
            v_f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            v_f.WindowState = FormWindowState.Maximized;
            v_f.Show();
        }

        private void themmoinhanvien_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            m_pn_form_chucnang.Dock = DockStyle.Fill;
            m_pn_form_chucnang.Visible = true;
            THEM_MOI_NHAN_VIEN v_f = new THEM_MOI_NHAN_VIEN();
            m_lbl_formname.Text = "Thêm mới nhân viên".ToUpper();
            v_f.TopLevel = false;
            v_f.Dock = DockStyle.Fill;
            m_pn_form.Controls.Add(v_f);
            v_f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            v_f.WindowState = FormWindowState.Maximized;
            v_f.Show();
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
                m_pn_form_chucnang.Dock = DockStyle.Fill;
                m_pn_form_chucnang.Visible = true;
                THEM_MOI_NHAN_VIEN v_f_them_moi_nv = new THEM_MOI_NHAN_VIEN();
                m_lbl_formname.Text = "Sửa thông tin nhân viên".ToUpper();
                v_f_them_moi_nv.TopLevel = false;
                v_f_them_moi_nv.Dock = DockStyle.Fill;
                m_pn_form.Controls.Add(v_f_them_moi_nv);
                v_f_them_moi_nv.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                v_f_them_moi_nv.WindowState = FormWindowState.Maximized;
                v_f_them_moi_nv.Show();
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
            m_pn_form_chucnang.Dock = DockStyle.Fill;
            m_pn_form_chucnang.Visible = true;
            F696_Cham_cong_xls v_f = new F696_Cham_cong_xls();
            m_lbl_formname.Text = "Chấm công".ToUpper();
            v_f.TopLevel = false;
            v_f.Dock = DockStyle.Fill;
            m_pn_form.Controls.Add(v_f);
            v_f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            v_f.WindowState = FormWindowState.Maximized;
            v_f.Show();
        }

        private void chamconglamthem_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                m_pn_form_chucnang.Dock = DockStyle.Fill;
                m_pn_form_chucnang.Visible = true;
                LAM_THEM_THEO_THOI_GIAN v_f = new LAM_THEM_THEO_THOI_GIAN();
                m_lbl_formname.Text = "Chấm công làm thêm".ToUpper();
                v_f.TopLevel = false;
                v_f.Dock = DockStyle.Fill;
                m_pn_form.Controls.Add(v_f);
                v_f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                v_f.WindowState = FormWindowState.Maximized;
                v_f.Show();
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
                m_pn_form_chucnang.Dock = DockStyle.Fill;
                m_pn_form_chucnang.Visible = true;
                BKI_DichVuMatDat.BaoCao.f412_rpt_tong_hop_tt_v2 v_f = new BaoCao.f412_rpt_tong_hop_tt_v2();
                m_lbl_formname.Text = "Bảng lương".ToUpper();
                v_f.TopLevel = false;
                v_f.Dock = DockStyle.Fill;
                m_pn_form.Controls.Add(v_f);
                v_f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                v_f.WindowState = FormWindowState.Maximized;
                v_f.Show();
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
                m_pn_form_chucnang.Dock = DockStyle.Fill;
                m_pn_form_chucnang.Visible = true;
                BKI_DichVuMatDat.BaoCao.Luong.PHIEU_LUONG v_f = new BaoCao.Luong.PHIEU_LUONG();
                m_lbl_formname.Text = "Phiếu lương".ToUpper();
                v_f.TopLevel = false;
                v_f.Dock = DockStyle.Fill;
                m_pn_form.Controls.Add(v_f);
                v_f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                v_f.WindowState = FormWindowState.Maximized;
                v_f.Show();
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
                m_pn_form_chucnang.Dock = DockStyle.Fill;
                m_pn_form_chucnang.Visible = true;
                DANG_NHAP_HE_THONG v_f = new DANG_NHAP_HE_THONG();
                m_lbl_formname.Text = "Quản trị hệ thống".ToUpper();
                v_f.TopLevel = false;
                v_f.Dock = DockStyle.Fill;
                m_pn_form.Controls.Add(v_f);
                v_f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                v_f.WindowState = FormWindowState.Maximized;
                v_f.Show();
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
                m_pn_form_chucnang.Dock = DockStyle.Fill;
                m_pn_form_chucnang.Visible = true;
                CAC_LOAI_TIEN_KHAC v_f = new CAC_LOAI_TIEN_KHAC();
                m_lbl_formname.Text = "Các loại thu nhập khác".ToUpper();
                v_f.TopLevel = false;
                v_f.Dock = DockStyle.Fill;
                m_pn_form.Controls.Add(v_f);
                v_f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                v_f.WindowState = FormWindowState.Maximized;
                v_f.Show();
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
                m_pn_form_chucnang.Dock = DockStyle.Fill;
                m_pn_form_chucnang.Visible = true;
                CHAM_CONG_THEO_NGAY v_f = new CHAM_CONG_THEO_NGAY();
                m_lbl_formname.Text = "Chấm công theo ngày".ToUpper();
                v_f.TopLevel = false;
                v_f.Dock = DockStyle.Fill;
                m_pn_form.Controls.Add(v_f);
                v_f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                v_f.WindowState = FormWindowState.Maximized;
                v_f.Show();
            }
            catch (Exception v_e)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(v_e.Message);
            }
        }

        private void danhmucmamuc_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                m_pn_form_chucnang.Dock = DockStyle.Fill;
                m_pn_form_chucnang.Visible = true;
                MA_MUC_LUONG v_f = new MA_MUC_LUONG();
                m_lbl_formname.Text = "Thang lương".ToUpper();
                v_f.TopLevel = false;
                v_f.Dock = DockStyle.Fill;
                m_pn_form.Controls.Add(v_f);
                v_f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                v_f.WindowState = FormWindowState.Maximized;
                v_f.Show();
            }
            catch (Exception v_e)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(v_e.Message);
            }
        }

        private void thoat_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
           var msg=   XtraMessageBox.Show("Bạn có chắc chắn muốn thoát khỏi phần mềm tính lương?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
           if (msg == System.Windows.Forms.DialogResult.Yes)
           {
               Application.Exit();
           }
        }

        private void license_ItemClick(object sender, TileItemEventArgs e)
        {
            F999_ActiveForm v_f = new F999_ActiveForm();
            v_f.showFormForActiveKey();
        }
    } 
}