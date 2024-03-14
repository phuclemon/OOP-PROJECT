using QLSINHVIEN.GUI;
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
    public partial class frm_DangKy : Form
    {
        KetNoi kn;
        BLL.Bll_DangKy bllDangKy;
        public frm_DangKy()
        {
            kn = new KetNoi();
            bllDangKy = new BLL.Bll_DangKy(this);
            InitializeComponent();
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_DangKy_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(dk_TK.Text)) { MessageBox.Show("Vui Lòng Nhập Tên Tài Khoản"); }
                else if (string.IsNullOrEmpty(dk_MK.Text)) { MessageBox.Show("Vui Lòng Nhập Mật Khẩu"); }
                else if (string.IsNullOrEmpty(dk_XacNhanMK.Text)) { MessageBox.Show("Vui Lòng Xác Nhận Lại Mật Khẩu"); }
                else if (dk_XacNhanMK.Text != dk_MK.Text) { MessageBox.Show("2 Mật Khẩu Không Trùng Khớp Với Nhau"); }
                else if (string.IsNullOrEmpty(dk_Email.Text)) { MessageBox.Show("Vui Lòng Nhập Email"); }
                else
                {

                    bllDangKy.BllDangKy();
                    MessageBox.Show("Đăng Ký Thành Công");
                    dk_TK.ResetText();
                    dk_MK.ResetText();
                    dk_XacNhanMK.ResetText();
                    dk_Email.ResetText();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Tên Tài Khoản Đã Tồn Tại");
                dk_TK.ResetText();
                dk_MK.ResetText();
                dk_XacNhanMK.ResetText();
                dk_Email.ResetText();
            }
        }

        private void frm_DangKy_Load(object sender, EventArgs e)
        {

        }
    }
}
