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
    public partial class fThongTinDatPhong : Form
    {
        BUS.BUSThongTinDatPhong busTTDP;
        private string idPhong;
        public fThongTinDatPhong()
        {
            InitializeComponent();
            busTTDP = new BUS.BUSThongTinDatPhong();
        }

        public fThongTinDatPhong(string id):this()
        {
            idPhong = id;
        }
       
        private void bt_xacnhan_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHang kh = new KhachHang();
                kh.CMND = tb_cmnd.Text.ToString();
                kh.Name = tb_name.Text.ToString();
                kh.Phone = tb_sdt.Text.ToString();
                kh.Address = tb_dc.Text.ToString();


                TTPhongDangThue tt = new TTPhongDangThue();
                tt.idPhong = int.Parse(lb_IdPhong.Text);
                tt.CMND = tb_cmnd.Text.ToString();
                tt.TênKH = tb_name.Text.ToString();
                DateTime dt = DateTime.Now;
                tt.TimeStart = dt;
                tt.ThoiGianThue = int.Parse(cb_tgt.SelectedItem.ToString());
                tt.SoNguoi = int.Parse(cb_sn.SelectedItem.ToString());
                tt.PhuThuThem = 0;

                busTTDP.tinhCheckIn(tt);

                if (busTTDP.checkTrungLap(tb_cmnd.Text.ToString(), int.Parse(lb_IdPhong.Text)))
                {

                    if (busTTDP.themTTKH(kh, tt))
                    {
                        MessageBox.Show("Đặt thành công");
                        busTTDP.CapNhatPhong(int.Parse(lb_IdPhong.Text));
                        this.Close();
                    }
                    else
                        MessageBox.Show("Vui lòng nhập lại!");
                }
                else
                    MessageBox.Show("Phòng không còn trống hoặc CMND bạn nhập hiện đang được dùng!");
            }
            catch (Exception)
            {
                
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }

        private void ThongTinDatPhong_Load(object sender, EventArgs e)
        {
            lb_IdPhong.Text = idPhong;
        }

      
    }
}
