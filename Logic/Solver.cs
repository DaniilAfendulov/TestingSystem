using System;
using System.Collections.Generic;

namespace TestingSystem.Logic
{
    [Serializable]
    public class Solver : User
    {
        public Solver(string login, string password) : base(login, password)
        {
        }
        public SolversScore[] GetUsersScore(DataBase dataBase)
        {
            return dataBase.FindUsersScores(this);
        }

        public int CompleteTest(Test test, List<List<Answer>> answers, DataBase dataBase)
        {
            int result = test.CompleteTest(answers);
            dataBase.Add(new SolversScore(this, test, result));
            return result;
        }
    }
}
