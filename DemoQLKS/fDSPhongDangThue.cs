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
    public partial class fDSPhongDangThue : Form
    {
        BUS.BUSPhongDT Buspdt;
        public fDSPhongDangThue()
        {
            InitializeComponent();
            Buspdt = new BUS.BUSPhongDT();
        }

        private void DSPhongDangThue_Load(object sender, EventArgs e)
        {
            Buspdt.LayDS(gvDsPDT);
            this.gvDsPDT.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.gvDsPDT.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.gvDsPDT.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.gvDsPDT.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.gvDsPDT.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.gvDsPDT.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
