using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_GiuXe
{
    public class PhanQuyen_NguoiDung
    {

        private static PhanQuyen_NguoiDung instance;

        public static PhanQuyen_NguoiDung Instance
        {
            get { if (instance == null) instance = new PhanQuyen_NguoiDung(); return instance; }
            private set { instance = value; }
        }

        private PhanQuyen_NguoiDung() { }

        public string MaNhanVien = "NV001";


        public string Quyen_NV = "Cấm";
        public string Quyen_VeThang = "Cấm";
        public string Quyen_Xe = "Cấm";
        public string Quyen_Cong = "Cấm";
        public string Quyen_KhachHang = "Cấm";
        public string Quyen_CauHinhMayTinh = "Cấm";
        public string Quyen_CauHinhCamera = "Cấm";
        public string Quyen_SaoLuuDuLieu = "Cấm";
        public string Quyen_ThongTinCongTy = "Cấm";
        public string Quyen_PhanQuyenNhanVien = "Cấm";
        public string Quyen_DoiMatKhau = "Cấm";


        public void LoadPQ()
        {
            using (QL_BaiXeDataContext db = new QL_BaiXeDataContext())
            {
                //Load quyền
                var load = (from a in db.NhanViens
                            join b in db.NhanVien_NhomNguoiDungs
                            on a.MaNV equals b.MaNV
                            join c in db.ChiTietQuyens
                            on b.MaCTQuyen equals c.MaCTQuyen
                            join d in db.PhanQuyen_NhomNguoiDungs
                            on b.PQ_NND equals d.PQ_NND
                            join ee in db.NhomNguoiDungs
                            on d.MaNhom equals ee.MaNhom
                            join f in db.PhanQuyens
                            on d.MaQuyen equals f.MaQuyen /*new {A=d.MaQuyen } equals new {A=f.MaQuyen}*/
                            where a.MaNV == MaNhanVien
                            select new
                            {
                                a.MaNV,
                                a.TenNV,
                                f.TenQuyen,
                                ee.TenNhom,
                                c.TenCTQuyen,
                                d.PQ_NND
                            }).ToList();


                foreach (var item in load)
                {
                    if (item.TenQuyen == "Nhân Viên")
                    {
                        Quyen_NV = item.TenCTQuyen;
                    }
                    if (item.TenQuyen == "Vé tháng")
                    {
                        Quyen_VeThang = item.TenCTQuyen;
                    }
                    if (item.TenQuyen == "Xe")
                    {
                        Quyen_Xe = item.TenCTQuyen;
                    }
                    if (item.TenQuyen == "Cổng")
                    {
                        Quyen_Cong= item.TenCTQuyen;
                    }
                    if (item.TenQuyen == "Khách hàng")
                    {
                        Quyen_KhachHang = item.TenCTQuyen;
                    }
                    if (item.TenQuyen == "Cấu hình máy tính")
                    {
                        Quyen_CauHinhMayTinh = item.TenCTQuyen;
                    }
                    if (item.TenQuyen == "Cấu hình camera")
                    {
                        Quyen_CauHinhCamera = item.TenCTQuyen;
                    }
                    if (item.TenQuyen == "Sao lưu dữ liệu")
                    {
                        Quyen_SaoLuuDuLieu = item.TenCTQuyen;
                    }
                    if (item.TenQuyen == "Thông tin công ty")
                    {
                        Quyen_ThongTinCongTy = item.TenCTQuyen;
                    }
                    if (item.TenQuyen == "Phân quyền nhân viên")
                    {
                        Quyen_PhanQuyenNhanVien = item.TenCTQuyen;
                    }
                    if (item.TenQuyen == "Đổi mật khẩu")
                    {
                        Quyen_DoiMatKhau = item.TenCTQuyen;
                    }
                }

            }
        }
    }
}
