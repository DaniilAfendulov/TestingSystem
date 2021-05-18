using System;
using TestingSystem.Logic;

namespace TestingSystem
{
    [Serializable]
    public struct SolversScore
    {
        public Solver solver;
        public Test test;
        public int score;
        public SolversScore(Solver solver, Test test, int score)
        {
            this.solver = solver;
            this.test = test;
            this.score = score;
        }

    }
}