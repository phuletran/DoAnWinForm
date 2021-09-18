using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoQLKS.DAO
{
    class DAOPhong
    {
        QLKSDataContext db;

        public DAOPhong()
        {
            db = new QLKSDataContext();
        }

        public int countPhong()
        {
            int count = db.TTPhongDangThues.Count();
            return count;
        }
    }
}
