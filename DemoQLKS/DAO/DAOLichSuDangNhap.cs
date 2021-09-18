using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoQLKS.DAO
{
    class DAOLichSuDangNhap
    {
        QLKSDataContext db;
        public DAOLichSuDangNhap()
        {
            db = new QLKSDataContext();
        }

        public List<LichSuDN> CapNhat()
        {
             
            List<LichSuDN> lsdn = db.LichSuDNs.Select(p => p).ToList();
            return lsdn;
        }
        
    }
}
