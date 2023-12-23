using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ShowData
    {
        string username = "";
        Connection cs = new Connection();
        SqlConnection con;
        string quary;
        SqlCommand com;
        String[] info = new String[20];



        public ShowData(string username)
        {
            this.username = username;
            con = cs.CreateConnection();
            quary = "select * from Students where username='" + username + "'";
            com = new SqlCommand(quary, con);
        }

        public string[] showingName()
        {

            int i = 0;
            SqlDataReader reader = com.ExecuteReader();
            reader.Read();
            info[i++] = reader["UserName"].ToString();
            info[i++] = reader["FirstName"].ToString();
            info[i++] = reader["LastName"].ToString();
            info[i++] = reader["PhoneNumber"].ToString();
            info[i++] = reader["EMail"].ToString();
            info[i++] = reader["Gender"].ToString();
            info[i++] = reader["BirthDate"].ToString();
            info[i++] = reader["Department"].ToString();
            info[i++] = reader["Semester"].ToString();
            info[i++] = reader["CGPA"].ToString();
            info[i++] = reader["CurrentAddress"].ToString();
            
            //info[i++] = reader["password"].ToString();


            reader.Close();
            return info;
        }
    }
}
