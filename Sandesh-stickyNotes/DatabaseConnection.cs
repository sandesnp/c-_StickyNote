using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandesh_stickyNotes
{
    public class DatabaseConnection
    {
        SqlConnection cn = new SqlConnection(@"Data Source=MSI;Initial catalog=sandesh_stickyNotes; Integrated Security=True");

        //SqlConnection cn= new SqlConnection(myconnString);
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        //Used for insert, update, delete

        public void manipulate(string query)
        {
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        //dataset = collection of datatable
        //Below fucntion is used for selecting and retriving
        public DataTable retrive(string query)
        {
            DataSet ds = new DataSet();
            da = new SqlDataAdapter(query, cn);
            da.Fill(ds);
            return ds.Tables[0];
        }
    }
}
