using System.Collections.Generic;

namespace TestingSystem.Logic
{
    public class LogicModel
    {
        private DataBase _dataBase;
        private Solver _solver;
        private Author _author;

        public Solver Solver { get => _solver; }
        public Author Author { get => _author; }
        public DataBase DataBase { get => _dataBase; }
        public LogicModel()
        {
            _dataBase = new DataBase();
        }
        public void AddNewSolver(string login, string password)
        {
            _solver = new Solver(login, password);
            _dataBase.Add(_solver);
        }
        public void AddNewAuthor(string login, string password)
        {
            _author = new Author(login, password);
            _dataBase.Add(_author);
        }
        public bool TryToFindAuthor(string login, string password)
        {
            return _dataBase.TryFindAuthor(login, password, out _author);
        }
        public bool TryToFindSolver(string login, string password)
        {
            return _dataBase.TryFindSolver(login, password, out _solver);
        }      
        public SolversScore[] GetUsersScore()
        {
            return _solver.GetUsersScore(_dataBase);
        }
        public bool TryAddTest(string name, Question[] questions)
        {
            return _author.TryAddTest(new Test(name, _author, questions), _dataBase);
        }

        public bool TryModifyTest(int index, string name, Question[] questions)
        {
            return _author.TryModifyTest(index, new Test(name, _author, questions), _dataBase);
        }

        public bool TryDeleteTest(int index)
        {
            return _author.TryDeleteTest(index, _dataBase);
        }

        public int CompleteTest(Test test, List<List<Answer>> answers)
        {
            return _solver.CompleteTest(test, answers, _dataBase);
        }
    }
}
