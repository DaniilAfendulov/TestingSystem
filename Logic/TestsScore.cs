using TestingSystem.Logic;

namespace TestingSystem
{
    public struct UsersScore
    {
        public Solver solver;
        public Test test;
        public int score;
        public UsersScore(Solver solver, Test test, int score)
        {
            this.solver = solver;
            this.test = test;
            this.score = score;
        }

    }
}