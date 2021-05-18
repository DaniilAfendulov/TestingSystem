using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace TestingSystem.Logic
{
    [Serializable]
    public class DataBase
    {
        private string _source = "DataBase.bin";
        private TestsBase _testsBase;
        private AuthorsBase _authorsBase;
        private SolversBase _solversBase;
        private UsersScoreBase _usersScoreBase;

        public DataBase()
        {
            _testsBase = new TestsBase();
            _authorsBase = new AuthorsBase();
            _solversBase = new SolversBase();
            _usersScoreBase = new UsersScoreBase();
        }



        public void Save()
        {
            var binFormatter = new BinaryFormatter();
            using (var file = new FileStream(_source, FileMode.OpenOrCreate))
            {
                binFormatter.Serialize(file, this);
            }
        }

        public void ModifyTest(Test test, Test modifiedTest)
        {
            _testsBase.ModifyData(test, modifiedTest);
        }

        public void Load()
        {
            if (File.Exists(_source))
            {
                var binFormatter = new BinaryFormatter();
                using (var file = new FileStream(_source, FileMode.Open))
                {
                    var dataBase = binFormatter.Deserialize(file) as DataBase;
                    Copy(dataBase);
                }
            }
            else Save();

        }

        public void Remove(Test test)
        {
            _testsBase.RemoveData(test);
        }

        public void Add(Solver solver)
        {
            _solversBase.Add(solver);
        }
        public void Add(Author author)
        {
            _authorsBase.Add(author);
        }
        public void Add(Test test)
        {
            _testsBase.Add(test);
        }
        public void Add(SolversScore usersScore)
        {
            _usersScoreBase.Add(usersScore);
        }
        public SolversScore[] FindUsersScores(Solver solver)
        {
            SolversScore[] usersScores = _usersScoreBase.FindUsersScores(solver);
            return usersScores;
        }
        public int FindTestsScore(Solver solver, Test test) => _usersScoreBase.FindTestsScore(solver, test);

        public bool TryFindAuthor(string login, string password, out Author author)
        {
            return _authorsBase.TryFind(login, password, out author);
        }

        public bool TryFindSolver(string login, string password, out Solver solver)
        {
            return _solversBase.TryFind(login, password, out solver);
        }

        public Test[] GetTests()
        {
            return _testsBase.GetData();
        }

        public void Copy(DataBase dataBase)
        {
            _testsBase = dataBase._testsBase;
            _authorsBase = dataBase._authorsBase;
            _solversBase = dataBase._solversBase;
            _usersScoreBase = dataBase._usersScoreBase;
        }
    }
}