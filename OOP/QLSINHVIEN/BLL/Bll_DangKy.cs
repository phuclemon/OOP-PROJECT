using QLSINHVIEN.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSINHVIEN.BLL
{
    class Bll_DangKy
    {
        DAL.Dal_DangKy dalDangKy;
        frm_DangKy fdk;
        public Bll_DangKy(frm_DangKy fr_dk)
        {
            dalDangKy = new DAL.Dal_DangKy();
            fdk = fr_dk;
        }
        public void BllDangKy()
        {
            dalDangKy.DalDangKy(fdk.dk_TK.Text, fdk.dk_MK.Text, fdk.dk_Email.Text);
        }
    }
}
