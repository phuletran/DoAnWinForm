using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoQLKS.BUS
{
    class BUSLichSuHoaDon
    {
        DAO.DAOLichSuHoaDon da;

        public BUSLichSuHoaDon()
        {
            da = new DAO.DAOLichSuHoaDon();
        }

        public void layDS(DataGridView dg)
        {
            dg.DataSource = da.LayDS();
        }

    }
}
