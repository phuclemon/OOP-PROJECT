using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSINHVIEN.DAL
{
    class Dal_SinhVien
    {
        KetNoi kn;
        public Dal_SinhVien()
        {
            kn = new KetNoi();
        }
        public DataTable LoadGrid()
        {
            string loadGrid = "select * from SinhVien";
            return kn.Load_Data(loadGrid);
        }
        public DataTable LoadComBo()
        {
            string loadComBo = "select MaLop from Lop";
            return kn.Load_Data(loadComBo);
        }
        public void dalThem(string maSV, string tenSV, DateTime ngaySinh, int soDT, string maLop)
        {
            string dalThem = "insert into SinhVien values('" + maSV + "', N'" + tenSV + "', Convert(Datetime,'" + ngaySinh + "',103), " +
                "'" + soDT + "','" + maLop + "')";
            kn.Nonquery(dalThem);
        }
        public void dalSua(string tenSV, DateTime ngaySinh, int soDT, string maLop, string maSV)
        {
            string dalSua = "update SinhVien set TenSV = N'" + tenSV + "', NgaySinh = Convert(Datetime,'" + ngaySinh + "',103), " +
                "SDT = '" + soDT + "', MaLop = '" + maLop + "' where MaSV = N'" + maSV + "'";
            kn.Nonquery(dalSua);
        }
        public void dalXoa(string maSV)
        {
            string dalXoa = "delete from SinhVien where MaSV = '" + maSV + "'";
            kn.Nonquery(dalXoa);
        }
        public DataTable dalTim(string timKiem)
        {
            string dalTim = "select * from SinhVien where MaSV like '%" + timKiem + "%' or TenSV like N'%" + timKiem + "%'";
            return kn.Load_Data(dalTim);
        }
    }
}
