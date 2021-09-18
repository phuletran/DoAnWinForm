using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoQLKS.DAO
{
    class DAOLogin
    {
        QLKSDataContext db;
        public DAOLogin()
        {
            db = new QLKSDataContext();
        }

        public bool checkID(int id)
        {
            bool kq = false;
            if (db.NhanViens.Any(s => s.ID == id))
                kq = true;
            return kq;
        }
       
    }
}
