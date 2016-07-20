using DevExpress.XtraEditors;
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
    public partial class LOGIN_DETAIL: MaterialSkin.Controls.MaterialForm
    {
        public LOGIN_DETAIL()
        {
            InitializeComponent();
       
        }
        private void load_du_lieu_bang_HT_USER()
        {
        }

        private void m_btn_dangnhap_Click(object sender, EventArgs e)
        {

            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "SELECT * FROM HT_USER WHERE USERNAME=N'" + m_txt_username.Text + "' AND PASSWORD=N'" + m_txt_password.Text+"'");

            if (v_ds.Tables[0].Rows.Count > 0)
            {
                FORM_MENU v_f = new FORM_MENU();
                v_f.ShowDialog();
                this.Close();
            }
            else
            {

                XtraMessageBox.Show("USERNAME và PASSWORD không chính xác. \n Xin vui lòng nhập lại thông tin !");
                m_txt_username.Text = "";
                m_txt_password.Text = "";
            }



        }

        private void m_btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void m_txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void m_txt_password_TextChanged(object sender, EventArgs e)
        {

        }    
                
            
        }

       
}
