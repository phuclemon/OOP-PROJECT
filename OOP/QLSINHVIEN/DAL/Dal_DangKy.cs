using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSINHVIEN.DAL
{
    class Dal_DangKy
    {
        KetNoi kn;
        public Dal_DangKy()
        {
            kn = new KetNoi();
        }
        public void DalDangKy(string tenTK, string matKhau, string email)
        {
            string sqlDangKy = "insert into TaiKhoan values ('" + tenTK + "','" + matKhau + "','" + email + "')";
            kn.Nonquery(sqlDangKy);
        }
    }
}
