using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace Quản_lý_bán_hàng
{
    internal class cla_crud //lớp kết nối
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-91FQ1NUL\\HUNG;Initial Catalog=Quan_Ly_Ban_Hang;Integrated Security=True"); //chuỗi kết nối
        private void openconnect() //mở kết nối
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        private void closeconnect() //đóng kết nối
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public Boolean exedata(string cmd) //hàm thực thi dữ liệu
        {
            openconnect();
            Boolean check = false;
            try
            {
                SqlCommand sc = new SqlCommand(cmd, con);
                sc.ExecuteNonQuery();
                check = true;
            }
            catch (Exception)
            {
                check = false;
            }
            closeconnect();
            return check;
        }
        public DataTable readdata(string cmd)
        {
            openconnect();

            DataTable dt = new DataTable();
            try
            {
                SqlCommand sc = new SqlCommand(cmd, con);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                sda.Fill(dt);
            }
            catch (Exception)
            {
                dt = null;
            }
            closeconnect();
            return dt;
        }





    }
}
