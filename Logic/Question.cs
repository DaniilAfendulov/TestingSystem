using System;
using System.Collections.Generic;

namespace TestingSystem.Logic
{
    [Serializable]
    public class Question
    {
        private List<Answer> _answers;
        private int _score;
        private string _task;

        public int Score { get => _score; set => _score = value; }
        public string Task { get => _task; set => _task = value; }
        public List<Answer> Answers { get => _answers; set => _answers = value; }

        public Question(string task, Answer[] answers, int score)
        {
            _task = task;
            _answers = new List<Answer>(answers);
            _score = score;
        }
        public int GiveAnAnswer(Answer[] selectedAnswers)
        {
            foreach (var answer in selectedAnswers)
            {
                if (!answer.isRight)
                {
                    return 0;
                }
            }

            int rightAnswersCount = 0;
            foreach (var answer in _answers)
            {
                if (answer.isRight)
                {
                    rightAnswersCount++;
                }
            }

            if (rightAnswersCount != selectedAnswers.Length)
            {
                return 0;
            }
            return _score;
        }

    }

}