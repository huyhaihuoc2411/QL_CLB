using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Cau_Lac_Bo
{
    public partial class DangNhap : Form
    {
        List<Taikhoan> listtaikhoan = Danhsachtk.Instance.listTK;

        public DangNhap()
        {
            InitializeComponent();
        }

        private void lbl_x_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if (Kiemtra(txt_taikhoan.Text, txt_matkhau.Text))
            {
                QLCauLacBo s = new QLCauLacBo();
                s.Show();
                this.Hide();
                s.DangXuat += s_DangXuat;
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Lỗi");
                txt_taikhoan.Focus();
            }
        }

        void s_DangXuat(object sender, EventArgs e)
        {
            (sender as QLCauLacBo).Isthoat = false;
            (sender as QLCauLacBo).Close();
            this.Show();
        }

        bool Kiemtra(string tentk, string mk)
        {
            for (int i = 0; i < listtaikhoan.Count; i++)
            {
                if (tentk == listtaikhoan[i].Tentk && mk == listtaikhoan[i].Mk)
                {
                    Const.LoaiTk = listtaikhoan[i];
                    return true;
                }
            }

            return false;
        }


    }
}
