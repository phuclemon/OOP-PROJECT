using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSINHVIEN.DAL
{
    class Dal_TaiKhoan
    {
        KetNoi kn;
        public Dal_TaiKhoan()
        {
            kn = new KetNoi();
        }
        public DataTable LoadTaiKhoan()
        {
            string loadTaiKhoan = "select * from TaiKhoan";
            return kn.Load_Data(loadTaiKhoan);
        }
        public void dalThemTK(string tenDn, string matKhau, string email)
        {
            string dalThem = "insert into TaiKhoan values('" + tenDn + "','" + matKhau + "','" + email + "')";
            kn.Nonquery(dalThem);
        }
        public void dalSuaTK(string matKhau, string email, string tenDN)
        {
            string dalSua = "update TaiKhoan set MatKhau ='" + matKhau + "', Email ='" + email + "' where TenDangNhap = '" + tenDN + "'";
            kn.Nonquery(dalSua);
        }
        public void dalXoaTK(string tenDN)
        {
            string dalXoa = "delete from TaiKhoan where TenDangNhap ='" + tenDN + "'";
            kn.Nonquery(dalXoa);
        }
    }
}
