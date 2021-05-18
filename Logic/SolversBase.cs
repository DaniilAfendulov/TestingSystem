using System;

namespace TestingSystem.Logic
{
    [Serializable]
    public class SolversBase : ListDataBase<Solver>
    {
        public  bool TryFind(string login, string password, out Solver solver)
        {
            foreach (var currentSolver in _data)
            {
                if (currentSolver.Equals(new Solver(login, password)))
                {
                    solver = currentSolver;
                    return true;
                }
            }
            solver = null;
            return false;
        }
    }
}