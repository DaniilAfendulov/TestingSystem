using System;
using System.Collections.Generic;

namespace TestingSystem.Logic
{
    [Serializable]
    public class Author: User
    {
        private List<Test> _tests;
        public Test[] GetTests { get => _tests.ToArray(); }
        public Author(string login, string password) : base(login, password)
        {
            _tests = new List<Test>();
        }
        public bool TryAddTest(Test test, DataBase dataBase)
        {
            if (test != null)
            {
                _tests.Add(test);
                dataBase.Add(test);
            }
            return false;
        }

        public bool TryModifyTest(int index, Test modifiedTest, DataBase dataBase)
        {
            if (index >= 0 && index < _tests.Count
                && modifiedTest != null)
            {
                dataBase.ModifyTest(_tests[index], modifiedTest);
                _tests[index] = modifiedTest;
                return true;
            }
            return false;
        }

        public bool TryDeleteTest(int index, DataBase dataBase)
        {
            if (index >= 0 && index < _tests.Count)
            {
                dataBase.Remove(_tests[index]);
                _tests.RemoveAt(index);
                return true;
            }
            return false;
        }
    }
}