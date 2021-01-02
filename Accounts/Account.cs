using System;

namespace CourseProject.Accounts
{
    public class Account
    {
        public string Login { get; private set; }
        public string Password { get; private set; }
        public string Fio { get; private set; }
        public string Group { get; private set; }
        public string Role { get; set; }

        public Account(string login, string password, string fio, string group)
        {
            Login = login;
            Password = password;
            Fio = fio;
            Group = group;
        }
    }
}
