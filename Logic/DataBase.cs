using System;

namespace TestingSystem.Logic
{
    public class DataBase
    {
        private TestsBase _testsBase;
        private AuthorsBase _authorsBase;
        private UsersBase _usersBase;
        private UsersScoreBase _usersScoreBase;

        public DataBase()
        {
            _testsBase = new TestsBase();
            _authorsBase = new AuthorsBase();
            _usersBase = new UsersBase();
            _usersScoreBase = new UsersScoreBase();
        }


        public void Load()
        {
            _testsBase.Load();
            _authorsBase.Load();
            _usersBase.Load();
            _usersScoreBase.Load();
        }

        public UsersScore[] FindUsersScores(Solver solver)
        {
            UsersScore[] usersScores = _usersScoreBase.FindUsersScores(solver);
            return usersScores;
        }


    }
}