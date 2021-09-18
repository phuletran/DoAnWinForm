using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoQLKS.DAO
{
    class DAODsKH
    {
        QLKSDataContext db;
        public DAODsKH()
        {
            db = new QLKSDataContext();
        }

        public List<KhachHang> layDSKH()
        {
            return db.KhachHangs.Select(s => s).ToList();
        }
    }
}
