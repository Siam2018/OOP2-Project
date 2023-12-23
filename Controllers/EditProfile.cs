using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controllers
{
    public class EditProfile
    {
        public string editInfo(string username, string firstname, string lastname, string phonenumber, string email, string gender, string birthdate, string department, string semester, string cgpa, string currentaddress)
        {
            Connection cs = new Connection();
            SqlConnection con = cs.CreateConnection();

            try
            {
                String query = "UPDATE Students SET UserName='" + username + "',FirstName='" + firstname + "',LastName='" + lastname + "',PhoneNumber='" + phonenumber + "',EMail='" + email + "',Gender='" + gender + "',BirthDate='" + birthdate + "',Department='" + department + "',Semester='" + semester + "',CGPA='" + cgpa + "',CurrentAddress='" + currentaddress + "'where UserName='" + username + "'";


                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return username;
        }

        public void editPassword(string username, string password)
        {
            Connection cs = new Connection();
            SqlConnection con = cs.CreateConnection();

            try
            {
                String query = "UPDATE Authenticate SET password='" + password + "'where username='" + username + "'";


                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public string editInfofaculty(string username, string firstname, string lastname, string phonenumber, string email, string gender, string birthdate, string department, string currentaddress)
        {
            Connection cs = new Connection();
            SqlConnection con = cs.CreateConnection();

            try
            {
                String query = "UPDATE Faculties SET UserName='" + username + "',FirstName='" + firstname + "',LastName='" + lastname + "',PhoneNumber='" + phonenumber + "',EMail='" + email + "',Gender='" + gender + "',BirthDate='" + birthdate + "',Department='" + department + "',CurrentAddress='" + currentaddress + "'where UserName='" + username + "'";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return username;
        }

        public void editPasswordfaculty(string username, string password)
        {
            Connection cs = new Connection();
            SqlConnection con = cs.CreateConnection();

            try
            {
                String query = "UPDATE FacultyAuthenticate SET password='" + password + "'where username='" + username + "'";


                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
