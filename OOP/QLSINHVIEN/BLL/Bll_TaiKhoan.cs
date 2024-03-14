using QLSINHVIEN.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSINHVIEN.BLL
{
    class Bll_TaiKhoan
    {
        DAL.Dal_TaiKhoan dalTaiKhoan;
        frm_TaiKhoan tk;
        public Bll_TaiKhoan(frm_TaiKhoan fr_TK)
        {
            dalTaiKhoan = new DAL.Dal_TaiKhoan();
            tk = fr_TK;
        }
        public void bllTaiKhoan()
        {
            tk.dataGridView1.DataSource = dalTaiKhoan.LoadTaiKhoan();
        }
        public void bllThemTK()
        {
            dalTaiKhoan.dalThemTK(tk.txt_TenDN.Text, tk.txt_MK.Text, tk.txt_Email.Text);
        }
        public void bllSuaTK()
        {
            dalTaiKhoan.dalSuaTK(tk.txt_MK.Text, tk.txt_Email.Text, tk.txt_TenDN.Text);
        }
        public void bllXoaTK()
        {
            dalTaiKhoan.dalXoaTK(tk.txt_TenDN.Text);
        }
    }
}
