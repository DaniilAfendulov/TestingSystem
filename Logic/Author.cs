using System.Collections.Generic;

namespace TestingSystem.Logic
{
    public class Author: User
    {
        List<Test> _tests;

        public Author(string login, string password) : base(login, password)
        {
            _tests = new List<Test>();
        }

        public bool AddTest(Test test)
        {
            if (test != null)
            {
                _tests.Add(test);
            }
            return false;
        }

        public bool ModifyTest(int index, Test modifiedTest)
        {
            if (index >= 0 && index < _tests.Count
                && modifiedTest != null)
            {
                _tests[index] = modifiedTest;
                return true;
            }
            return false;
        }

        public bool DeleteTest(int index)
        {
            if (index >= 0 && index < _tests.Count)
            {
                _tests.RemoveAt(index);
                return true;
            }
            return false;
        }
    }
}