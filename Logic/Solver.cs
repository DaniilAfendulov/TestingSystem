using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSystem.Logic
{
    public class Solver : User
    {
        public Solver(string login, string password) : base(login, password)
        {
        }

        public UsersScore[] GetUsersScore(DataBase dataBase)
        {
            return dataBase.FindUsersScores(this);
        }
    }
}
