using System;

namespace CourseProject.Accounts
{
    public class Admin : Account
    {      
        public Admin(string login, string password, string fio, string group) : base(login, password, fio, group)
        {            
            Role = "admin";
        }

        public override string ToString()
        {
            return Login + "|" + Password + "|" + Fio + "|" + Group + "|" + Role;
        }
    }
}
