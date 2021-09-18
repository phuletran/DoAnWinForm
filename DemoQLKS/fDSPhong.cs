using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoQLKS
{
    public partial class fDSPhong : Form
    {
        BUS.BUSDsPhong busDsP;

        public fDSPhong()
        {
            InitializeComponent();
            busDsP = new BUS.BUSDsPhong();
        }

        private void fDSPhong_Load(object sender, EventArgs e)
        {
           busDsP.LayDS(gvP);
        }

        private void btCP_Click(object sender, EventArgs e)
        {
            busDsP.LayDS(gvP);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
