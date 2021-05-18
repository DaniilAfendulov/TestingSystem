using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSystem.Logic
{
    [Serializable]
    public class Test
    {
        private string _name;
        private Author _author;
        private List<Question> _questions;
        public string Name { get => _name; set => _name = value; }
        public Author Author { get => _author; set => _author = value; }
        public List<Question> Questions { get => _questions; set => _questions = value; }
        public Test(string name, Author author, Question[] questions)
        {
            _name = name;
            _author = author;
            _questions = new List<Question>(questions);
        }
        public int GetScore()
        {
            int score = 0;
            _questions.ForEach(questuion => score += questuion.Score);
            return score;
        }
                   
        public bool ModifyName(string newName)
        {
            if (!string.IsNullOrWhiteSpace(newName))
            {
                Name = newName;
                return true;
            }
            return false;
        }

        public bool ModifyQuestion(int index, Question modifiedQuestion)
        {
            if (index >= 0 && index < _questions.Count
                && modifiedQuestion != null)
            {
                _questions[index] = modifiedQuestion;
                return true;
            }
            return false;
        }

        public bool AddQuestion(Question question)
        {
            if (question != null)
            {
                _questions.Add(question);
                return true;
            }
            return false;
        }

        public bool DeleteQuestion(int index)
        {
            if (index >= 0 && index < _questions.Count)
            {
                _questions.RemoveAt(index);
                return true;
            }
            return false;
        }

        public int CompleteTest(List<List<Answer>> answers)
        {
            int result = 0;
            for (int i = 0; i < _questions.Count; i++)
            {
                result += _questions[i].GiveAnAnswer(answers[i].ToArray());
            }
            return result;
        }
        public bool Equals(Test test)
        {
            return _name == test._name
                && _author.GetName() == test._author.GetName();
        }
    }
}
