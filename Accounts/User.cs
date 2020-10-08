using System;

namespace CourseProject.Accounts
{
    public class User : Account
    {
        public User(string login, string password, string fio, string group) : base(login, password, fio, group)
        {            
            Role = "user";
        }

        public override string ToString()
        {
            return Login + "|" + Password + "|" + Fio + "|" + Group + "|" + Role;
        }
    }
}
