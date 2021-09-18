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
    public partial class fPhong : Form
    {
        BUS.BUSPhong busPhong;
        public fPhong()
        {
            InitializeComponent();
            busPhong = new BUS.BUSPhong();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            Label lb = (Label)(sender);
            MessageBox.Show("Test");
        }

        private void btn_datP101_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fThongTinDatPhong f = new fThongTinDatPhong("101");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if(soP2 > soP1)
                lb101.BackColor = Color.Red;    
        }
        private void bt_dat102_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fThongTinDatPhong f = new fThongTinDatPhong("102");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 > soP1)
                lb102.BackColor = Color.Red;
        }
        private void bt_dat103_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fThongTinDatPhong f = new fThongTinDatPhong("103");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 > soP1)
                lb103.BackColor = Color.Red;
        }
        private void bt_dat104_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fThongTinDatPhong f = new fThongTinDatPhong("104");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 > soP1)
                lb104.BackColor = Color.Red;
        }
        private void bt_dat105_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fThongTinDatPhong f = new fThongTinDatPhong("105");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 > soP1)
                lb105.BackColor = Color.Red;
        }

        private void btn_datP201_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fThongTinDatPhong f = new fThongTinDatPhong("201");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 > soP1)
                lb201.BackColor = Color.Red;
        }
        private void bt_dat202_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fThongTinDatPhong f = new fThongTinDatPhong("202");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 > soP1)
                lb202.BackColor = Color.Red;
        }
        private void bt_dat203_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fThongTinDatPhong f = new fThongTinDatPhong("203");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 > soP1)
                lb203.BackColor = Color.Red;
        }
        private void bt_dat204_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fThongTinDatPhong f = new fThongTinDatPhong("204");
            f.ShowDialog();
            lb204.BackColor = Color.Red;
        }
        private void bt_dat205_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fThongTinDatPhong f = new fThongTinDatPhong("205");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 > soP1)
                lb205.BackColor = Color.Red;
        }

        private void btn_datP301_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fThongTinDatPhong f = new fThongTinDatPhong("301");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 > soP1)
                 lb301.BackColor = Color.Red;
        }
        private void bt_dat302_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fThongTinDatPhong f = new fThongTinDatPhong("302");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 > soP1)
                lb302.BackColor = Color.Red;
        }
        private void bt_dat303_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fThongTinDatPhong f = new fThongTinDatPhong("303");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 > soP1)
                lb303.BackColor = Color.Red;
        }
        private void bt_dat304_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fThongTinDatPhong f = new fThongTinDatPhong("304");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 > soP1)
                lb304.BackColor = Color.Red;
        }
        private void bt_dat305_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fThongTinDatPhong f = new fThongTinDatPhong("305");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 > soP1)
             lb305.BackColor = Color.Red;
        }

        private void btn_datP401_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fThongTinDatPhong f = new fThongTinDatPhong("401");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 > soP1)
                lb401.BackColor = Color.Red;
        }
        private void bt_dat402_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fThongTinDatPhong f = new fThongTinDatPhong("402");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 > soP1)
                 lb402.BackColor = Color.Red;
        }
        private void bt_dat403_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fThongTinDatPhong f = new fThongTinDatPhong("403");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 > soP1)
                lb403.BackColor = Color.Red;
        }
        private void bt_dat404_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fThongTinDatPhong f = new fThongTinDatPhong("404");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 > soP1)
                lb404.BackColor = Color.Red;
        }
        private void bt_dat405_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fThongTinDatPhong f = new fThongTinDatPhong("405");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 > soP1)
                lb405.BackColor = Color.Red;
        }

        private void bt_xemds_Click(object sender, EventArgs e)
        {
            fDSPhongDangThue f = new fDSPhongDangThue();
            f.Show();

        }


        private void btn_tra101_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fBienLai f = new fBienLai("101");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 < soP1)
              lb101.BackColor = Color.White;
        }
        private void btn_tra102_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fBienLai f = new fBienLai("102");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 < soP1)
                lb102.BackColor = Color.White;
        }
        private void btn_tra103_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fBienLai f = new fBienLai("103");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 < soP1)
                lb103.BackColor = Color.White;
        }
        private void btn_tra104_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fBienLai f = new fBienLai("104");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 < soP1)
                lb104.BackColor = Color.White;
        }
        private void btn_tra105_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fBienLai f = new fBienLai("105");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 < soP1)
                lb105.BackColor = Color.White;
        }

        private void btn_tra201_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fBienLai f = new fBienLai("201");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 < soP1)
                lb201.BackColor = Color.White;
        }
        private void btn_tra202_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fBienLai f = new fBienLai("202");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 < soP1)
                lb202.BackColor = Color.White;
        }
        private void btn_tra203_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fBienLai f = new fBienLai("203");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 < soP1)
                lb203.BackColor = Color.White;
        }
        private void btn_tra204_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fBienLai f = new fBienLai("204");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 < soP1)
                lb204.BackColor = Color.White;
        }
        private void btn_tra205_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fBienLai f = new fBienLai("205");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 < soP1)
                lb205.BackColor = Color.White;
        }

        private void btn_tra301_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fBienLai f = new fBienLai("301");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 < soP1)
                lb301.BackColor = Color.White;
        }
        private void btn_tra302_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fBienLai f = new fBienLai("302");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 < soP1)
                lb302.BackColor = Color.White;
        }
        private void btn_tra303_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fBienLai f = new fBienLai("303");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 < soP1)
                lb303.BackColor = Color.White;
        }
        private void btn_tra304_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fBienLai f = new fBienLai("304");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 < soP1)
                lb304.BackColor = Color.White;
        }
        private void btn_tra305_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fBienLai f = new fBienLai("305");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 < soP1)
                lb305.BackColor = Color.White;
        }

        private void btn_tra401_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fBienLai f = new fBienLai("401");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 < soP1)
                lb401.BackColor = Color.White;
        }
        private void btn_tra402_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fBienLai f = new fBienLai("402");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 < soP1)
                lb402.BackColor = Color.White;
        }
        private void btn_tra403_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fBienLai f = new fBienLai("403");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 < soP1)
                lb403.BackColor = Color.White;
        }
        private void btn_tra404_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fBienLai f = new fBienLai("404");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 < soP1)
                lb404.BackColor = Color.White;
        }
        private void btn_tra405_Click(object sender, EventArgs e)
        {
            int soP1 = busPhong.count();
            fBienLai f = new fBienLai("405");
            f.ShowDialog();
            int soP2 = busPhong.count();
            if (soP2 < soP1)
                lb405.BackColor = Color.White;
        }

    
        private void button1_Click(object sender, EventArgs e)
        {
            lb_Pdt.Text = busPhong.count().ToString();
            lb_PTrong.Text = (20 - busPhong.count()).ToString();
        }

        

        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            lb_Pdt.Text = busPhong.count().ToString();
            lb_PTrong.Text = (20 - busPhong.count()).ToString();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    

     
    }
}
