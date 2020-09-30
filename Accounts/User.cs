using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Accounts
{
    class User : Account
    {
        public User(string login, string password, string fio, string group)
        {
            Login = login;
            Password = password;
            Fio = fio;
            Group = group;
            Role = "user";
        }

        public override string ToString()
        {
            return Login + " " + Password + " " + Fio + " " + Group + " " + Role;
        }
    }
}
