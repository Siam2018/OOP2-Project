using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Connection
    {
        public SqlConnection CreateConnection()
        {
            SqlConnection con = new SqlConnection();
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\repos\PMSDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            return con;
        }
    }
}
