using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace Controllers
{
    public class Edit
    {
        public string editData(string username, string firstname, string lastname, string phonenumber, string email, string gender, string birthdate, string department, string semester, string cgpa, string currentaddress)
        {
            EditProfile ep = new EditProfile();

            String result = ep.editInfo(username, firstname, lastname, phonenumber, email, gender, birthdate, department, semester, cgpa, currentaddress);

            return result;
        }

        public void changePassword(string username, string password)
        {
            EditProfile ep = new EditProfile();
            ep.editPassword(username, password);
        }
    }
}
