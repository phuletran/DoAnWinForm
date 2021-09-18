using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoQLKS.BUS
{
    class BUSThongTinDatPhong
    {
        DAO.DAOThongTinDatPhong da;

        public BUSThongTinDatPhong()
        {
            da = new DAO.DAOThongTinDatPhong();
        }

        public bool themTTKH(KhachHang kh,TTPhongDangThue pdt)
        {
            if (da.themKH(kh) && da.themPhongDangThue(pdt))
                return true;
            return false;
        }

        public bool checkTrungLap(string cmnd, int idPhong)
        {
            if (da.checkTrungLap(cmnd, idPhong))
                return true;
            return false;
        }
        public void CapNhatPhong(int idPhong)
        {
            da.CapNhatPhong(idPhong);
        }

        public void tinhCheckIn(TTPhongDangThue tt)
        {
            da.tinhCheckIn(tt);
        }

    }
 }

