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
    public partial class frm_DangNhap : Form
    {
        BLL.Bll_DangNhap blldn;
        public frm_DangNhap()
        {
            blldn = new BLL.Bll_DangNhap(this);
            InitializeComponent();
        }
        public static string taikhoan = "";

        private void bt_DangNhap_Click(object sender, EventArgs e)
        {
            string tk = txt_TK.Text;
            if (string.IsNullOrEmpty(txt_TK.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Tài Khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_TK.Focus();
            }
            else if (string.IsNullOrEmpty(txt_MK.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Mật Khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_MK.Focus();
            }
            else
            {
                if (blldn.BllDangNhap() >= 1)
                {
                    taikhoan = tk;
                    MessageBox.Show("Đăng Nhập Thành Công", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm_GiaoDien frm = new frm_GiaoDien();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai Tên Đăng Nhập Hoặc Mật Khẩu", "Thất Bại");
                }
            }
            
        }


        private void lb_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult Thoat;
            Thoat = MessageBox.Show("Bạn Có Muốn Thoát ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Thoat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lb_DangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_DangKy fdk = new frm_DangKy();
            fdk.Show();
        }

        private void TK_KeyD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_DangNhap.PerformClick();
            }
        }

        private void MK_KeyD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_DangNhap.PerformClick();
            }
        }
    }
}
