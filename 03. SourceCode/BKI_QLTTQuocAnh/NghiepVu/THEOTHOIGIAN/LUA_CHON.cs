using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BKI_DichVuMatDat.NghiepVu.THEOTHOIGIAN
{
    public partial class LUA_CHON : MaterialSkin.Controls.MaterialForm
    {
        bool m_lua_chon_1 = true;
        public LUA_CHON()
        {
            InitializeComponent();
            m_rd_load_dung.Checked = true;
           
        }

        internal void showForOption(ref bool lua_chon_1)
        {
            this.ShowDialog();
            lua_chon_1 = m_lua_chon_1;
        }

        private void m_btn_luu_Click(object sender, EventArgs e)
        {
            if (m_rd_load_dung.Checked != true)
            {
                m_lua_chon_1 = false;
            }
            this.Close();
        }

      

    }
}
