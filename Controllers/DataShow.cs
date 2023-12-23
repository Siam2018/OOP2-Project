using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace Controllers
{
    public class DataShow
    {
        public string[] datashow(string username)
        {
            ShowData sd = new ShowData(username);

            String[] result = new String[20];


            result = sd.showingName();

            return result;
        }
        public string[] datashowfaculty(string username ,string type)
        {
            ShowData sd = new ShowData(username, type);

            String[] result = new String[20];


            result = sd.showingNameFaculty();

            return result;
        }

    }
}
