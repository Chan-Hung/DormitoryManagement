using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DormitoryManagement.DataAccessLayer
{
    public class DAL
    {
        SqlConnection cnn;
        SqlCommand cmd;
        String connString = @"Data Source=DESKTOP-07KO9B1\SQLEXPRESS;Initial Catalog=QuanlyKiTucXa1;Integrated Security=True";
        public DAL()
        {
            cnn = new SqlConnection(connString);
            cmd = cnn.CreateCommand();
        }
        public SqlConnection GetConnection()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                return conn;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public DataTable GetTable(String sql)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = GetConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
    }
}
