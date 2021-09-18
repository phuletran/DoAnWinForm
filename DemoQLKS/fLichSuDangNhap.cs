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
    public partial class fLichSuDangNhap : Form
    {
        BUS.BUSLichSuDangNhap busLS;
        public fLichSuDangNhap()
        {
            InitializeComponent();
        }

        private void LichSuDangNhap_Load(object sender, EventArgs e)
        {
            busLS = new BUS.BUSLichSuDangNhap();
            busLS.CapNhat(gvLS);
            this.gvLS.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.gvLS.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.gvLS.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
