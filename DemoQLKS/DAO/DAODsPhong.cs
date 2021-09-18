using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoQLKS.DAO
{
    class DAODsPhong
    {
        QLKSDataContext db;
        public DAODsPhong()
        {
            db = new QLKSDataContext();
        }

        public List<Phong> LayDS()
        {
            List<Phong> ds = db.Phongs.Select(p => p).ToList();
            return ds;
        }
    }
}
