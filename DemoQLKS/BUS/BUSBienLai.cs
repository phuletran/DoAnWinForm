using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoQLKS.BUS
{
    class BUSBienLai
    {
        DAO.DAOBienLai da;

        public BUSBienLai()
        {
            da = new DAO.DAOBienLai();
        }

        public List<TTPhongDangThue> xuatBL(int id)
        {
           return da.xuatBienLai(id);
        }
        public void xoaTTPhongDangThue(int idPhong)
        {
            if (da.xoaTTPhongDangThue(idPhong))
                MessageBox.Show("Đã trả phòng");
            else
                MessageBox.Show("Có lỗi xảy ra trong việc xóa thông tin thuê phòng");
        }

        public void CapNhatTTPhong(int idPhong)
        {
            da.CapNhatTTPhong(idPhong);
        }

        public void ThemHoaDon(int idPhong)
        {
            da.CapNhatHoaDon(idPhong);
        }

        public void tinhCheckOut(TTPhongDangThue tt)
        {
            da.tinhCheckOut(tt);
        }

        public void themPhuThu(int gia, int id)
        {
            da.themPhuThu(gia, id);
        }
        public void tinhGiaPhong(TTPhongDangThue tt)
        {
            da.tinPhGiahong(tt);
        }

    }
}
