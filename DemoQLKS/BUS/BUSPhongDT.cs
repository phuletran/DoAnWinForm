using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoQLKS.BUS
{
    class BUSPhongDT
    {
        DAO.DAODSPhongDT da;

        public BUSPhongDT()
        {
            da = new DAO.DAODSPhongDT();
        }

        public void LayDS(DataGridView gvPDT)
        {
            gvPDT.DataSource = da.LayDS();
        }
    }
}
