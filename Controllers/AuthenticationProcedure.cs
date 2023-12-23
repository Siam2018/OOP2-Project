using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace Controllers
{
    public class AuthenticationProcedure
    {
        public Boolean authenticationCheck(string username, string pass)
        {
            Authintication au = new Authintication();

            return au.LoginConnection(username, pass);

        }
        public Boolean authenticationCheckfaculty(string username, string pass)
        {
            Authintication au = new Authintication();
            

            return au.LoginConnectionfaculty(username, pass);

        }
    }
}
