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
    public partial class frm_TaiKhoan : Form
    {
        BLL.Bll_TaiKhoan bllTaiKhoan;
        public frm_TaiKhoan()
        {
            bllTaiKhoan = new BLL.Bll_TaiKhoan(this);
            InitializeComponent();
        }
        private void frm_TaiKhoan_Load(object sender, EventArgs e)
        {
            LoadTK();
            dataGridView1.Columns[0].HeaderText = "Tên Đăng Nhập";
            dataGridView1.Columns[1].HeaderText = "Mật Khẩu";
            dataGridView1.Columns[2].HeaderText = "Email";

            dataGridView1.Columns[0].Width = 330;
            dataGridView1.Columns[1].Width = 460;
            dataGridView1.Columns[2].Width = 330;
        }
        public void LoadTK()
        {
            bllTaiKhoan.bllTaiKhoan();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txt_TenDN.Text = dataGridView1.Rows[i].Cells["TenDangNhap"].Value.ToString();
            txt_MK.Text = dataGridView1.Rows[i].Cells["MatKhau"].Value.ToString();
            txt_Email.Text = dataGridView1.Rows[i].Cells["Email"].Value.ToString();
        }
        private void bt_Reset_Click(object sender, EventArgs e)
        {
            txt_TenDN.ResetText();
            txt_MK.ResetText();
            txt_Email.ResetText();
        }
        private void bt_Hủy_Click(object sender, EventArgs e)
        {
            txt_TenDN.Enabled = false;
            txt_MK.Enabled = false;
            txt_Email.Enabled = false;
            bt_Hủy.Visible = false;
        }
        private void bt_Them_Click(object sender, EventArgs e)
        {
            txt_TenDN.Enabled = true;
            txt_MK.Enabled = true;
            txt_Email.Enabled = true;
            bt_Hủy.Visible = true;
            bt_Reset.Visible = true;
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TenDN.Text))
            {
                MessageBox.Show("Chưa Nhập Mã Sinh Viên");
            }
            else
            {
                try
                {
                    bllTaiKhoan.bllThemTK();
                    MessageBox.Show("Thêm Thành Công");
                }
                catch (Exception)
                {
                    MessageBox.Show("Đã Tồn Tại Tên Đăng Nhập");
                }
                LoadTK();
            }
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            txt_TenDN.Enabled = true;
            txt_MK.Enabled = true;
            txt_Email.Enabled = true;
            bt_Hủy.Visible = true;
            bt_Reset.Visible = true;
            if (string.IsNullOrEmpty(txt_TenDN.Text))
            {
                MessageBox.Show("Chưa Nhập Sinh Viên Cần Sửa");
            }
            else
            {
                MessageBox.Show("Sửa Thành Công");
                bllTaiKhoan.bllSuaTK();
            }
            LoadTK();
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TenDN.Text))
            {
                MessageBox.Show("Chưa Chọn Tài Khoản Cần Xóa");
            }
            else
            {
                DialogResult thongbao;
                thongbao = MessageBox.Show("Bạn Có Muốn Xóa Tài Khoản Này ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (thongbao == DialogResult.Yes)
                {
                    bllTaiKhoan.bllXoaTK();
                    MessageBox.Show("Xóa Thành Công","Thông Báo");
                }
                else
                {
                    MessageBox.Show("Xóa Thất Bại", "Thông Báo");
                }
            }
            LoadTK();
        }
    }
}
