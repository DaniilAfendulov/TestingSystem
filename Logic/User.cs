using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSystem.Logic
{
    public abstract class User
    {
        protected string _login;
        protected string _password;

        public User(string login, string password)
        {
            _login = login;
            _password = password;
        }
    }
}
