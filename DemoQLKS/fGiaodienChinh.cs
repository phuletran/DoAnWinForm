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
    public partial class fGiaodienChinh : Form
    {
       public static fNhanVien fNhanVien;
       public static fPhong fPhong;
       public static fLichSuDangNhap flsdn;
       public static fDSPhongDangThue fdspdt;
       public static fDSPhong fdsp;
       public static fTatCaHoaDon ftchd;
       public static fKhachHang fkh;



        private string idNV;
        BUS.BUSGiaoDienChinh busGDC = new BUS.BUSGiaoDienChinh();
        public fGiaodienChinh()
        {
            InitializeComponent();
        }

        public fGiaodienChinh(string id):this()
        {
            // TODO: Complete member initialization
            idNV = id;
        }

       

        private void GiaodienChinh_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            LichSuDN lsdn = new LichSuDN ();
       
            lsdn.idNhanVien = int.Parse(idNV);
            lsdn.TimeLogin = dt;

            busGDC.LichSu(lsdn);
            lbID.Text = idNV;
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (busGDC.checkRole(int.Parse(idNV)))
            {
                MessageBox.Show("Giao diện QUẢN LÝ NHÂN VIÊN sẽ hiện ra trong giây lát! Vui lòng đợi!");
                //fNhanVien fNV = new fNhanVien();
                //fNV.MdiParent = this;
                //fNV.Show();

                if (fNhanVien == null || fNhanVien.IsDisposed)
                {
                    fNhanVien = new fNhanVien();
                    fNhanVien.MdiParent = this;
                    fNhanVien.Show();
                }
            }
            else
                MessageBox.Show("Bạn không có quyền truy cập vào mục này!");
        }

        private void quảnLýThuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //fPhong f = new fPhong();
            //f.MdiParent = this;
            //f.Show();
            if (fPhong == null || fPhong.IsDisposed)
            {
                fPhong = new fPhong();
                fPhong.MdiParent = this;
                fPhong.Show();
            }
        }

        private void lịchSửĐăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //fLichSuDangNhap lsdn = new fLichSuDangNhap();
            //lsdn.MdiParent = this;
            //lsdn.Show();
            if (flsdn == null || flsdn.IsDisposed)
            {
                flsdn = new fLichSuDangNhap();
                flsdn.MdiParent = this;
                flsdn.Show();
            }
        }

        private void phòngĐangThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //fDSPhongDangThue f = new fDSPhongDangThue();
            //f.Show();
            if (fdspdt == null || fdspdt.IsDisposed)
            {
                fdspdt = new fDSPhongDangThue();
                fdspdt.MdiParent = this;
                fdspdt.Show();
            }
        }

        private void tấtCảCácPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //fDSPhong f = new fDSPhong();
            //f.Show();
            if (fdsp == null || fdsp.IsDisposed)
            {
                fdsp = new fDSPhong();
                fdsp.MdiParent = this;
                fdsp.Show();
            }

        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //fTatCaHoaDon f = new fTatCaHoaDon();
            //f.Show();
            if (ftchd == null || ftchd.IsDisposed)
            {
                ftchd = new fTatCaHoaDon();
                ftchd.MdiParent = this;
                ftchd.Show();
            }
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //fKhachHang f = new fKhachHang();
            //f.Show();
            if (fkh == null || fkh.IsDisposed)
            {
                fkh = new fKhachHang();
                fkh.MdiParent = this;
                fkh.Show();
            }
        }


     
    }
}
