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
    public partial class FormLoading : Form
    {
        public FormLoading()
        {
            InitializeComponent();
        }

        int startpos = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 1;
            Myprogess.Value = startpos;
            lbl_phantram.Text = startpos + "%";
            if (Myprogess.Value == 100)
            {
                Myprogess.Value = 0;
                timer1.Stop();
                DangNhap dn = new DangNhap();
                dn.Show();
                this.Hide();
            }
        }

        private void FormLoading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
