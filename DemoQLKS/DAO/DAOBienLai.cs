using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoQLKS.DAO
{
    class DAOBienLai
    {
        QLKSDataContext db;

        public DAOBienLai()
        {
            db = new QLKSDataContext();
        }

        public List<TTPhongDangThue> xuatBienLai(int id)
        {
            List<TTPhongDangThue> bl = db.TTPhongDangThues.Where(i => i.idPhong.Equals(id)).ToList();
            return bl;       
        }

        public bool xoaTTPhongDangThue(int idPhong)
        {
            bool kq = false;

            try
            {
                TTPhongDangThue xoa = db.TTPhongDangThues.Where(i => i.idPhong.Equals(idPhong)).SingleOrDefault();
                db.TTPhongDangThues.DeleteOnSubmit(xoa);
                db.SubmitChanges();
                kq = true;
            }
            catch (Exception)
            {

                kq = false;
            }
            return kq;
        }

        public void CapNhatTTPhong(int idPhong)
        {
            Phong cn = db.Phongs.Where(i => i.idPhong.Equals(idPhong)).SingleOrDefault();
            cn.Status = "Còn trống";
            db.SubmitChanges();
        }

        public void CapNhatHoaDon(int idPhong)
        {
            TTPhongDangThue tt =  db.TTPhongDangThues.Where(i => i.idPhong.Equals(idPhong)).SingleOrDefault();
            HoaDon hd = new HoaDon();
            hd.idPhong = idPhong;
            hd.TenKH = tt.TênKH;
            hd.CMND = tt.CMND;
            hd.NgayLapHD = DateTime.Now;
            hd.PhuThuCI = tt.PhuThuCheckIn;
            hd.PhuThuCO = tt.PhuThuCheckOut;
            hd.GiaPhongNiemYet = tt.GiaPhongNiemYet;
            hd.SoNgayThue = tt.ThoiGianThue;
            hd.PhuThu = tt.PhuThuThem;
            hd.TongCong = tt.Total;

            db.HoaDons.InsertOnSubmit(hd);
            db.SubmitChanges();
        }
        public void tinhCheckOut(TTPhongDangThue tt)
        {
            Phong tg = db.Phongs.Where(i => i.idPhong.Equals(tt.idPhong)).SingleOrDefault();
            DateTime d = DateTime.Now;
            if (14 <= d.Hour && d.Hour <= 18)
                tt.PhuThuCheckOut = 50;
            else if (d.Hour > 18)
                tt.PhuThuCheckOut = 100;
            else
                tt.PhuThuCheckOut = 0;
            tt.GiaPhongNiemYet = tg.Price;
            db.SubmitChanges();

        }
        public void themPhuThu(int gia, int id)
        {
            TTPhongDangThue tt = db.TTPhongDangThues.Where(i => i.idPhong.Equals(id)).SingleOrDefault();
            tt.PhuThuThem = gia;
            db.SubmitChanges();
        }
        public void tinPhGiahong(TTPhongDangThue tt)
        {
            TTPhongDangThue thue = db.TTPhongDangThues.
                Where(i => i.idPhong.Equals(tt.idPhong)).SingleOrDefault();
            Phong pthue = db.Phongs.Where(i => i.idPhong.Equals(tt.idPhong)).SingleOrDefault();

            int tienCI = ((thue.PhuThuCheckIn * pthue.Price)/100).Value;
            int tienCO = ((thue.PhuThuCheckOut  * pthue.Price)/100).Value;
            int tienPhuThu = thue.PhuThuThem.Value;
            int giaThueTheoNgay = (pthue.Price * thue.ThoiGianThue).Value;
            thue.Total = tienCI + tienCO + tienPhuThu + giaThueTheoNgay;
            db.SubmitChanges();

        }


    }
}
