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
    public partial class fBienLai : Form
    {
        private string idPhong;
        BUS.BUSBienLai busBL;
        public fBienLai()
        {
            InitializeComponent();
            busBL = new BUS.BUSBienLai();
        }
        public fBienLai(string id): this()
        {
            idPhong = id;
        }
        private void fBienLai_Load(object sender, EventArgs e)
        {
            lb_idPhong.Text = idPhong;
            List<TTPhongDangThue> dsbl = busBL.xuatBL(int.Parse(idPhong));
            if (dsbl.Any())
            {

                TTPhongDangThue ttbl = new TTPhongDangThue();
                ttbl = dsbl.First(s => s.idPhong == int.Parse(idPhong));
                busBL.tinhCheckOut(ttbl);
                lb_tenKH.Text = ttbl.TênKH;
                lb_cmnd.Text = ttbl.CMND;
                lb_soNguoi.Text = ttbl.SoNguoi.ToString();
                lb_tgThue.Text = ttbl.ThoiGianThue.ToString();
                lb_tgVao.Text = ttbl.TimeStart.ToString();
                lb_total.Text = ttbl.Total.ToString();
                lbCheckIn.Text = ttbl.PhuThuCheckIn.ToString();
                lbCheckOut.Text = ttbl.PhuThuCheckOut.ToString();
                lbGiaNY.Text = ttbl.GiaPhongNiemYet.ToString();
                lbTienCI.Text = ((ttbl.PhuThuCheckIn * ttbl.GiaPhongNiemYet) / 100).ToString();
                lbTienCO.Text = ((ttbl.PhuThuCheckOut * ttbl.GiaPhongNiemYet) /100).ToString();
                tb_phuthu.Text = ttbl.PhuThuThem.ToString();

            }
            else
            {
                MessageBox.Show("Phòng trống không thể trả!");
                this.Close();
            }
        }

        private void bt_xacnhan_Click(object sender, EventArgs e)
        {
            busBL.themPhuThu(int.Parse(tb_phuthu.Text.ToString()), int.Parse(idPhong));
            List<TTPhongDangThue> dsbl = busBL.xuatBL(int.Parse(idPhong));
            TTPhongDangThue ttbl = dsbl.First(s => s.idPhong == int.Parse(idPhong));
            busBL.tinhGiaPhong(ttbl);
            lb_total.Text = ttbl.Total.ToString();

            busBL.ThemHoaDon(int.Parse(idPhong));
            busBL.xoaTTPhongDangThue(int.Parse(idPhong));
            busBL.CapNhatTTPhong(int.Parse(idPhong));           
            this.Close();
        }

        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            busBL.themPhuThu(int.Parse(tb_phuthu.Text.ToString()), int.Parse(idPhong));
            List<TTPhongDangThue> dsbl = busBL.xuatBL(int.Parse(idPhong));
            TTPhongDangThue ttbl = dsbl.First(s => s.idPhong == int.Parse(idPhong));
            busBL.tinhGiaPhong(ttbl);
            lb_total.Text = ttbl.Total.ToString();
        }

      
       
    }
}
