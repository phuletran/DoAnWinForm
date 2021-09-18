using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoQLKS.DAO
{
    class DAODSPhongDT
    {
        QLKSDataContext db;
        public DAODSPhongDT()
        {
            db = new QLKSDataContext();
        }

        public dynamic LayDS()
        {
            dynamic ds = db.TTPhongDangThues.Select(p => new
            {
                p.idPhong,
                p.CMND,
                p.TênKH,
                p.SoNguoi,
                p.ThoiGianThue,
                p.TimeStart,      
            }); ;
            return ds;
        }
    }
}
