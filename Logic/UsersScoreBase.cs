using System;
using System.Collections.Generic;

namespace TestingSystem.Logic
{
    public class UsersScoreBase
    {
        private List<UsersScore> _allUsersScores;
        public UsersScoreBase()
        {
            _allUsersScores = new List<UsersScore>();
        }
        public UsersScoreBase(UsersScore[] usersScores)
        {
            _allUsersScores = new List<UsersScore>(usersScores);
        }
        public UsersScore[] FindUsersScores(Solver solver)
        {
            List<UsersScore> usersScores = new List<UsersScore>();
            foreach (var userScore in _allUsersScores)
            {
                if (userScore.solver == solver)
                {
                    usersScores.Add(userScore);
                }
            }
            return usersScores.ToArray();
        }
    }
}