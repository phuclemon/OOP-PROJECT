using QLSINHVIEN.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSINHVIEN.BLL
{
    class Bll_DangNhap
    {
        DAL.Dal_DangNhap dalDangNhap;
        frm_DangNhap DN;

        public Bll_DangNhap(frm_DangNhap frm_DangNhap)
        {
            dalDangNhap = new DAL.Dal_DangNhap();
            DN = frm_DangNhap;
        }
        public int BllDangNhap()
        {
            return dalDangNhap.DalDangNhap(DN.txt_TK.Text, DN.txt_MK.Text);
        }
    }
}
