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
    public partial class QLCauLacBo : Form
    {
        DBConnect db = new DBConnect();
        public bool Isthoat = true;
        public event EventHandler DangXuat;

        public QLCauLacBo()
        {
            InitializeComponent();
        }

        //============================= HOATDONG =====================================

        void HienThiDSThongtin()
        {
            string chuoitruyvan = "select * from HOATDONG";
            DBConnect db = new DBConnect();
            DataTable dt = db.getDataTable(chuoitruyvan);

            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns[0];
            dt.PrimaryKey = key;

            dgv_thongtin.DataSource = dt;
        }

        void HienThiDSMaBan()
        {
            string chuoitruyvan = "select * from BAN";
            DBConnect db = new DBConnect();
            DataTable dt = db.getDataTable(chuoitruyvan);

            DataRow dr = dt.NewRow();
            dr["MaBan"] = "All";
            dr["TenBan"] = "Tất cả các ban";
            dt.Rows.InsertAt(dr, 0);

            cbo_ban.DataSource = dt;
            cbo_ban.DisplayMember = "TenBan";
            cbo_ban.ValueMember = "MaBan";

            cbo_maban.DataSource = dt;
            cbo_maban.DisplayMember = "TenBan";
            cbo_maban.ValueMember = "MaBan";
        }

        bool KTMaHoatDong(string mhd)
        {
            DBConnect db = new DBConnect();
            string chuoitruyvan = "select count(*) from HOATDONG where MaHoatDong='" + mhd + "'";

            int r = (int)db.getScalar(chuoitruyvan);
            if (r == 0)
            {
                return true;
            }
            else
                return false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DataTable dtnew = (DataTable)dgv_thongtin.DataSource;
            DataRow dr = dtnew.NewRow();
            dr["MaHoatDong"] = txt_mahd.Text;
            dr["TenHoatDong"] = txt_tenhd.Text;
            dr["DiaDiem"] = txt_diadiem.Text;
            dr["MaBan"] = cbo_ban.SelectedValue;
            dtnew.Rows.Add(dr);

            string chuoitruyvan = "Select * from HOATDONG";
            int k = db.updateDataTable(dtnew, chuoitruyvan);

            if (k != 0)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DataTable dtnew = (DataTable)dgv_thongtin.DataSource;
            DataRow dr = dtnew.Rows.Find(txt_mahd.Text);

            if (dr != null)
            {
                dr.Delete();

                string chuoitruyvan = "Select * from HOATDONG";
                int k = db.updateDataTable(dtnew, chuoitruyvan);

                if (k != 0)
                    MessageBox.Show("Xóa thành công");
                else
                    MessageBox.Show("Xóa thất bại");
            }
            else
            {
                MessageBox.Show("Không tìm thấy Hoạt động");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DataTable dtnew = (DataTable)dgv_thongtin.DataSource;
            DataRow dr = dtnew.Rows.Find(txt_mahd.Text);

            if (dr != null)
            {
                dr["MaHoatDong"] = txt_mahd.Text;
                dr["TenHoatDong"] = txt_tenhd.Text;
                dr["DiaDiem"] = txt_diadiem.Text;
                dr["MaBan"] = cbo_ban.SelectedValue;

                string chuoitruyvan = "Select * from HOATDONG";
                int k = db.updateDataTable(dtnew, chuoitruyvan);

                if (k != 0)
                    MessageBox.Show("Đã hiệu chỉnh");
                else
                    MessageBox.Show("Không hiệu chỉnh");
            }
            else
            {
                MessageBox.Show("Không tìm thấy Khoa");
            }
        }

        private void btn_datlai_Click(object sender, EventArgs e)
        {
            txt_mahd.Text = "";
            txt_tenhd.Text = "";
            txt_diadiem.Text = "";
            cbo_ban.SelectedValue = "";
        }

        public void TimKiem()
        {
            DBConnect db = new DBConnect();
            dgv_thongtin.DataSource = db.getDataTable("Select * from HOATDONG where TenHoatDong LIKE '%" + txt_timkiem.Text + "%'");
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HienThiDSThongtin();
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            DangXuat(this, new EventArgs());
        }

        void PhanQuyen()
        {
            switch (Const.LoaiTk.LoaiTk)
            {
                case Taikhoan.Loaitaikhoan.quanly:
                    btn_qlytk.Enabled = true;
                    break;
                case Taikhoan.Loaitaikhoan.nhavien:
                    btn_qlytk.Enabled = false;
                    btn_them.Enabled = false;
                    btn_sua.Enabled = false;
                    btn_xoa.Enabled = false;
                    btn_datlai.Enabled = false;
                    break;
            }
            label_vaitro.Text = Const.LoaiTk.Hienthi;
            lbl_vaitro1.Text = Const.LoaiTk.Hienthi;
            lbl_vaitro2.Text = Const.LoaiTk.Hienthi;
            lbl_vaitro3.Text = Const.LoaiTk.Hienthi;

        }

        private void QLCauLacBo_Load(object sender, EventArgs e)
        {
            HienThiDSThongtin();
            HienThiDSMaBan();
            PhanQuyen();
            DataTable dt = (DataTable)dgv_thongtin.DataSource;
        }

        private void dgv_thongtin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_thongtin.CurrentRow.Index;
            txt_mahd.Text = dgv_thongtin.Rows[i].Cells[0].Value.ToString();
            txt_tenhd.Text = dgv_thongtin.Rows[i].Cells[1].Value.ToString();
            txt_diadiem.Text = dgv_thongtin.Rows[i].Cells[2].Value.ToString();
            cbo_ban.SelectedValue = dgv_thongtin.Rows[i].Cells[3].Value.ToString();
        }

        private void btn_dangxuat1_Click(object sender, EventArgs e)
        {
            DangXuat(this, new EventArgs());
        }

        private void btn_dangxuat3_Click(object sender, EventArgs e)
        {
            DangXuat(this, new EventArgs());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DangXuat(this, new EventArgs());
        }

        //======================================== THANHVIEN ==========================================

        void HienThiTTTV()
        {
            string chuoitruyvan = "select * from THANHVIEN";
            DBConnect db = new DBConnect();
            DataTable dt = db.getDataTable(chuoitruyvan);

            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns[0];
            dt.PrimaryKey = key;

            dgv_tttv.DataSource = dt;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            HienThiTTTV();
        }

        private void dgv_tttv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_tttv.CurrentRow.Index;
            txt_matv.Text = dgv_tttv.Rows[i].Cells[0].Value.ToString();
            txt_tentv.Text = dgv_tttv.Rows[i].Cells[1].Value.ToString();
            txt_ngaysinh.Text = dgv_tttv.Rows[i].Cells[2].Value.ToString();
            txt_gioitinh.Text = dgv_tttv.Rows[i].Cells[3].Value.ToString();
            txt_quequan.Text = dgv_tttv.Rows[i].Cells[4].Value.ToString();
            txt_email.Text = dgv_tttv.Rows[i].Cells[5].Value.ToString();
            txt_sdt.Text = dgv_tttv.Rows[i].Cells[6].Value.ToString();
            cbo_maban.SelectedValue = dgv_tttv.Rows[i].Cells[7].Value.ToString();
        }

        private void btn_them1_Click(object sender, EventArgs e)
        {
            DataTable dtnew = (DataTable)dgv_thongtin.DataSource;
            DataRow dr = dtnew.NewRow();
            dr["MaHoatDong"] = txt_mahd.Text;
            dr["TenHoatDong"] = txt_tenhd.Text;
            dr["DiaDiem"] = txt_diadiem.Text;
            dr["MaBan"] = cbo_ban.SelectedValue;
            dtnew.Rows.Add(dr);

            string chuoitruyvan = "Select * from HOATDONG";
            int k = db.updateDataTable(dtnew, chuoitruyvan);

            if (k != 0)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại");
        }

        //==================================== BAN ==========================================








        //==================================== QL CHI TIEU ==========================================
    }

}
