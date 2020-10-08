using System;

namespace CourseProject.Accounts
{
    public class Account
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Fio { get; set; }
        public string Group { get; set; }
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
