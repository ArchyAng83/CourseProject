using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Accounts
{
    public class Admin : Account
    {
      
        public Admin(string login, string password, string fio, string group)
        {
            Login = login;
            Password = password;
            Fio = fio;
            Group = group;
            Role = "admin";
        }

        public override string ToString()
        {
            return Login + " " + Password + " " + Fio + " " + Group + " " + Role;
        }
    }
}
