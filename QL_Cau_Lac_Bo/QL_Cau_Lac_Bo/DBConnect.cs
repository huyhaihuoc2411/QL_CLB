using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Cau_Lac_Bo
{
    class DBConnect
    {
        SqlConnection con;
        string chuoiketnoi = "Data Source=HUY-PC\\SA;Initial Catalog=QLHOATDONG_CLB;User ID=sa;Password=123";

        public DBConnect()
        {
            con = new SqlConnection(chuoiketnoi);
        }
        public DBConnect(string chuoikn)
        {
            con = new SqlConnection(chuoikn);
        }
        public void Open()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
        }
        public void Close()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public int getNonQuery(string chuoitruyvan)
        {
            Open();
            SqlCommand cmd = new SqlCommand(chuoitruyvan, con);
            int kq = cmd.ExecuteNonQuery();
            Close();
            return kq;
        }
        public object getScalar(string chuoitruyvan)
        {
            Open();
            SqlCommand cmd = new SqlCommand(chuoitruyvan, con);
            object kq = cmd.ExecuteScalar();
            Close();
            return kq;
        }
        public DataTable getDataTable(string chuoitruyvan)
        {
            SqlDataAdapter da = new SqlDataAdapter(chuoitruyvan, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        public int updateDataTable(DataTable dtnew, string chuoitruyvan)
        {
            SqlDataAdapter da = new SqlDataAdapter(chuoitruyvan, con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            int kq = da.Update(dtnew);
            return kq;
        }
    }
}
