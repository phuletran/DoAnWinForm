using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoQLKS.BUS
{
    class BUSPhong
    {
        DAO.DAOPhong da;

        public BUSPhong()
        {
            da = new DAO.DAOPhong();

        }

        public int count()
        {
            return da.countPhong();
        }
    }
}
