using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoQLKS.DAO
{
    class DAOThongTinDatPhong
    {
        QLKSDataContext db;

        public DAOThongTinDatPhong()
        {
            db = new QLKSDataContext();
        }

        public bool themKH(KhachHang kh)
        {
            try
            {
                if (db.KhachHangs.Any(s => s.CMND == kh.CMND))
                    return true;
                else
                {
                    db.KhachHangs.InsertOnSubmit(kh);
                    db.SubmitChanges();
                }
                return true; ;
            }
            catch (Exception)
            {
                
                return false;
            }
        }

        
        public bool themPhongDangThue(TTPhongDangThue pdt)
        {

            try
            {
                db.TTPhongDangThues.InsertOnSubmit(pdt);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public bool checkTrungLap(string cmnd, int idPhong)
        {
            IEnumerable<TTPhongDangThue> check = from PhongDangThue in db.TTPhongDangThues
                                               where PhongDangThue.CMND == cmnd || PhongDangThue.idPhong == idPhong
                                               select PhongDangThue;
            if (!check.Any())
                return true;
            return false;
        }
        public void CapNhatPhong(int idPhong)
        {
            Phong cn = db.Phongs.Where(i => i.idPhong.Equals(idPhong)).SingleOrDefault();
            cn.Status = "Đã thuê";
            db.SubmitChanges();
        }
        public void tinhCheckIn(TTPhongDangThue tt)
        {
            DateTime d = tt.TimeStart.Value;
            if (5 <= d.Hour && d.Hour <= 9)
                tt.PhuThuCheckIn = 50;
            else if (9 < d.Hour && d.Hour < 12)
                tt.PhuThuCheckIn = 30;
            else
                tt.PhuThuCheckIn = 0;
        }

    }
}
