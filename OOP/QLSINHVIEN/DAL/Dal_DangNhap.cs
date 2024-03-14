using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSINHVIEN.DAL
{
    
    class Dal_DangNhap
    {
        KetNoi kn;
        public Dal_DangNhap()
        {
            kn = new KetNoi();
        }
        public int DalDangNhap(string tenDN, string matKhau)
        {
            string sqlDangNhap = "select count (*) from TaiKhoan where TenDangNhap ='" + tenDN + "' and MatKhau ='" + matKhau + "'";
            return (int)kn.Scalar(sqlDangNhap);
        }
    }
}
