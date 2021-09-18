using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoQLKS.BUS
{
    class BUSDsPhong
    {
        DAO.DAODsPhong da;

        public BUSDsPhong()
        {
            da = new DAO.DAODsPhong();
        }

        public void LayDS(DataGridView gvP)
        {
            gvP.DataSource = da.LayDS();
        }
    }
}
