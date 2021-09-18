using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoQLKS.DAO
{
    class DAOLichSuHoaDon
    {
        QLKSDataContext db;

        public DAOLichSuHoaDon()
        {
            db = new QLKSDataContext();
        }

        public dynamic LayDS()
        {
            dynamic ds = db.HoaDons.Select(p => new { 
                                
                    p.idPhong,
                    p.TenKH,
                    p.CMND,
                    p.NgayLapHD,
                    p.PhuThuCI,
                    p.PhuThuCO,
                    p.GiaPhongNiemYet,
                    p.SoNgayThue,
                    p.PhuThu,
                    p.TongCong
            });
            return ds;
        }

    }
}
