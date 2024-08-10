using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Cau_Lac_Bo
{
    public class Danhsachtk
    {
        private static Danhsachtk instance;

        public static Danhsachtk Instance
        {
            get
            {
                if (instance == null)
                    instance = new Danhsachtk();
                return instance;
            }
            set
            {
                instance = value;
            }
        }

        public List<Taikhoan> listTK { get; set; }
        Danhsachtk()
        {
            listTK = new List<Taikhoan>();
            listTK.Add(new Taikhoan("VanHuy", "123", Taikhoan.Loaitaikhoan.nhavien));
            listTK.Add(new Taikhoan("QuocHuy", "123", Taikhoan.Loaitaikhoan.nhavien));
            listTK.Add(new Taikhoan("AnhThi", "123", Taikhoan.Loaitaikhoan.quanly));
            listTK.Add(new Taikhoan("HuuPhuc", "123", Taikhoan.Loaitaikhoan.quanly));
        }
    }
}
