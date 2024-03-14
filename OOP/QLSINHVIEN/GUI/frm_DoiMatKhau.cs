using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSINHVIEN.GUI
{
    public partial class frm_DoiMatKhau : Form
    {
        public frm_DoiMatKhau()
        {
            InitializeComponent();
        }

        private void bt_DoiMK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MatKhau.Text)) { MessageBox.Show("Vui Lòng Nhập Mật Khẩu Cũ"); }
            else if (string.IsNullOrEmpty(XacNhanMK.Text)) { MessageBox.Show("Vui Lòng Nhập Mật Khẩu Mới"); }
            else if (string.IsNullOrEmpty(New_MK.Text)) { MessageBox.Show("Vui Lòng Nhập Mật Khẩu Mới"); }
            else if(MatKhau.Text != XacNhanMK.Text) { MessageBox.Show("2 Mật Khẩu Cũ Không Trùng Khớp"); }
            else
            {
                string sqlDMK = "update TaiKhoan ";
            }
        }
    }
}
