using System;
using System.Collections.Generic;

namespace TestingSystem.Logic
{
    [Serializable]
    public class UsersScoreBase: ListDataBase<SolversScore>
    {
        public SolversScore[] FindUsersScores(Solver solver)
        {
            List<SolversScore> usersScores = new List<SolversScore>();
            foreach (var userScore in _data)
            {
                if (userScore.solver.GetName().Equals(solver.GetName()))
                {
                    usersScores.Add(userScore);
                }
            }
            return usersScores.ToArray();
        }
        public int FindTestsScore(Solver solver, Test test)
        {
            SolversScore[] scores = FindUsersScores(solver);
            foreach (var score in scores)
            {
                if (score.test.Equals(test))
                {
                    return score.score;
                }
            }
            return 0;
        }
    }
}