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
    public partial class fTatCaHoaDon : Form
    {
        BUS.BUSLichSuHoaDon busLSHD;
        public fTatCaHoaDon()
        {
            InitializeComponent();
            busLSHD = new BUS.BUSLichSuHoaDon();
        }

        private void fTatCaHoaDon_Load(object sender, EventArgs e)
        {
            busLSHD.layDS(gvHD);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            busLSHD.layDS(gvHD);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
