namespace TestingSystem.Logic
{
    public class Question
    {
        private string _task;
        private Answer[] _answers;
        private int _score;
        public string Task => _task;
        public Answer[] Answers => _answers;
        public int Score => _score;
        public Question(string task, Answer[] answers, int score)
        {
            _task = task;
            _answers = answers;
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