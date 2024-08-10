using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Cau_Lac_Bo
{
    public class Taikhoan
    {
        private string tentk;
        public string Tentk
        {
            get
            {
                return tentk;
            }
            set
            {
                tentk = value;
            }
        }
        private string mk;
        public string Mk
        {
            get
            {
                return mk;
            }
            set
            {
                mk = value;
            }
        }

        public enum Loaitaikhoan
        {
            quanly,
            nhavien,
        }

        private Loaitaikhoan loaiTk;

        public Loaitaikhoan LoaiTk
        {
            get { return loaiTk; }
            set { loaiTk = value; }
        }

        private string hienthi;

        public string Hienthi
        {
            get
            {
                switch (LoaiTk)
                {
                    case Loaitaikhoan.quanly:
                        Hienthi = "Quản lý";
                        break;
                    default:
                        Hienthi = "Nhân viên";
                        break;

                }
                return hienthi;
            }
            set { hienthi = value; }
        }

        public Taikhoan(string Tentk, string Mk, Loaitaikhoan LoaiTk)
        {
            this.tentk = Tentk;
            this.mk = Mk;
            this.loaiTk = LoaiTk;
        }
    }
}
