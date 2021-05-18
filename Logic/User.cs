using System;

namespace TestingSystem.Logic
{
    [Serializable]
    public abstract class User
    {
        protected string _login;
        protected string _password;

        public User(string login, string password)
        {
            _login = login;
            _password = password;
        }
        public string GetName()
        {
            return _login;
        }
        public bool Equals(User user)
        {
            return _login.Equals(user._login) && _password.Equals(user._password);
        }
    }
}
