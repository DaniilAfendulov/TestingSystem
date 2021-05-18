using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestingSystem.Logic;

namespace TestingSystem
{
    public partial class CreatingTestForm : Form
    {
        private EditingModeForm _form;
        private LogicModel _logicModel;
        private List<Question> _questions;
        private List<Answer> _answers;
        private int _index;

        public CreatingTestForm(ref LogicModel logicModel, EditingModeForm form)
        {
            _form = form;
            _logicModel = logicModel;
            _logicModel.TryAddTest(
                "Новый тест",
                new Question[] 
                {
                    new Question("Новый вопрос",
                    new Answer[] { new Answer("Новый ответ", false) }
                    , 0)
                });
            _index = _logicModel.Author.GetTests.Length - 1;
            InitializeComponent();
            SetSource();
        }
        public CreatingTestForm(ref LogicModel logicModel, EditingModeForm form, int index) 
        {
            _form = form;
            _logicModel = logicModel;
            _index = index;          
            InitializeComponent();
            SetSource();
        }

        private void BtnAddQuestion_Click(object sender, EventArgs e)
        {
            _questions.Add(
                new Question("Новый вопрос",
                new Answer[] { new Answer("Новый ответ", false) }
                , 0));
            RefreshQuestion();
            RefreshQuestionsNames();
            listBoxQuestions.SelectedIndex = listBoxQuestions.Items.Count - 1;
        }

        private void ButtonDeleteQuestion_Click(object sender, EventArgs e)
        {
            if (listBoxQuestions.SelectedItem != null)
            {
                int index = listBoxQuestions.SelectedIndex;
                _questions.RemoveAt(index);
                listBoxQuestions.SelectedIndex = -1;
                RefreshQuestion();
                RefreshQuestionsNames();
            }
            else
            {
                MessageBox.Show("Вопрос не выбран");
            }
            
        }

        private void BtnAddAnswer_Click(object sender, EventArgs e)
        {
            _answers.Add(new Answer("Новый ответ", false));            
            RefreshAnswersNames();
            RefreshAnswers();
            listBoxAnswers.SelectedIndex = listBoxAnswers.Items.Count - 1;
        }

        private void BtnDeleteAnswer_Click(object sender, EventArgs e)
        {
            if (listBoxAnswers.SelectedItem != null)
            {
                int index = listBoxAnswers.SelectedIndex;
                _answers.RemoveAt(index);
                listBoxAnswers.SelectedIndex = -1;
                RefreshAnswers();
                RefreshAnswersNames();
            }
            else
            {
                MessageBox.Show("Ответ не выбран");
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (_questions.Count != 0)
            {
                string testName = textBoxTestsName.Text;
                if (!string.IsNullOrWhiteSpace(testName))
                {
                    _logicModel.TryModifyTest(_index, testName, _questions.ToArray());
                    _logicModel.DataBase.Save();
                }
                else MessageBox.Show("Название не может быть пустой строкой");
            }
            else
            {
                MessageBox.Show("Количество вопросов не должно равнятся 0");
            }            
        }

        private void CreatingTestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _logicModel.DataBase.Save();
            _form.Show();
        }
        private void ListBoxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshQuestion();
        }

        private void ListBoxAnswers_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshAnswers();
        }

        private void TextBoxAnswerText_Leave(object sender, EventArgs e)
        {
            SaveAnswer();
            RefreshAnswers();
            RefreshAnswersNames();
        }

        private void CheckBoxRightAnswer_Leave(object sender, EventArgs e)
        {
            SaveAnswer();
            RefreshAnswers();
        }

        private void TextBoxQuestionTask_Leave(object sender, EventArgs e)
        {
            if (listBoxQuestions.SelectedItem != null)
            {
                int index = listBoxQuestions.SelectedIndex;
                string task = textBoxQuestionTask.Text;
                if (!string.IsNullOrWhiteSpace(task))
                {
                    _questions[index].Task = task;
                    RefreshQuestionsNames();
                }
                else
                {
                    MessageBox.Show("Не удалось изменить значение поля: " + lblQuestionName.Text);
                }
            }
        }

        private void TextBoxScore_Leave(object sender, EventArgs e)
        {
            if (listBoxQuestions.SelectedItem != null)
            {             
                if (int.TryParse(textBoxScore.Text, out int score))
                {
                    int index = listBoxQuestions.SelectedIndex;
                    _questions[index].Score = score;
                }
                else
                {
                    MessageBox.Show("Не удалось изменить значение поля: " + lblScore.Text);                   
                }            
              
            }
        }

        private void RefreshQuestionsNames()
        {
            List<string> names = new List<string>();
            _questions.ForEach(question => names.Add(question.Task));
            int lastIndex = listBoxQuestions.SelectedIndex;
            listBoxQuestions.DataSource = names;
            if (lastIndex > -1)
            {
                listBoxQuestions.SelectedIndex = lastIndex;
            }
        }
        private void RefreshAnswersNames()
        {
            List<string> names = new List<string>();
            _answers.ForEach(answer => names.Add(answer.text));
            int lastIndex = listBoxAnswers.SelectedIndex;
            listBoxAnswers.DataSource = names;
            if (lastIndex > -1 && _answers.Count > lastIndex)
            {
                listBoxAnswers.SelectedIndex = lastIndex;
            }
        }
        private void SaveAnswer()
        {
            if (listBoxAnswers.SelectedItem != null)
            {
                string text = textBoxAnswerText.Text;
                bool isRight = checkBoxRightAnswer.Checked;
                Answer answer = new Answer(text, isRight);
                _answers[listBoxAnswers.SelectedIndex] = answer;
            }
        }

        private void RefreshQuestion()
        {
            if (_questions.Count != 0)
            {
                if (listBoxQuestions.SelectedIndex < 0)
                {
                    listBoxQuestions.SelectedIndex = 0;
                }
                Question currentQuestion = _questions[listBoxQuestions.SelectedIndex];                
                textBoxQuestionTask.Text = currentQuestion.Task;
                textBoxScore.Text = currentQuestion.Score.ToString();                
                _answers = currentQuestion.Answers;
                if (_answers.Count != 0)
                {
                    RefreshAnswersNames();
                    RefreshAnswers();
                }
            }
            
        }
        private void RefreshAnswers()
        {
            if (_answers.Count != 0)
            {
                if (listBoxAnswers.SelectedIndex == -1)
                {
                    listBoxAnswers.SelectedIndex = 0;
                }
                Answer currentAnswer = _answers[listBoxAnswers.SelectedIndex];
                textBoxAnswerText.Text = currentAnswer.text;
                checkBoxRightAnswer.Checked = currentAnswer.isRight;
            }
            
        }
        private void SetSource()
        {
            Test test = _logicModel.Author.GetTests[_index];
            textBoxTestsName.Text = test.Name;
            _questions = test.Questions;            
            RefreshQuestionsNames();
            RefreshQuestion();
            listBoxQuestions.SelectedIndex = 0;
            if (_answers.Count != 0)
            {
                RefreshAnswersNames();
                RefreshAnswers();
                listBoxAnswers.SelectedIndex = 0;
            }

        }

    }
}
