using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestingSystem.Logic;

namespace TestingSystem
{
    public partial class TestSolvingForm : Form
    {
        private LogicModel _logicModel;
        private PassingModeForm _passingModeForm;
        private Test _test;
        private List<List<Answer>> _answers;
        private int _questionIndex = 0;
        private int _answerIndex = -1;

        public TestSolvingForm()
        {
            InitializeComponent();
        }

        public TestSolvingForm(ref LogicModel logicModel, PassingModeForm passingModeForm, int testIndex): this()
        {
            _logicModel = logicModel;
            _passingModeForm = passingModeForm;
            _test = _logicModel.DataBase.GetTests()[testIndex];
            _answers = new List<List<Answer>>();
            if (_test.Questions.Count != 0)
            {
                Question currentQuestion = _test.Questions[_questionIndex];
                lblQuestionNumber.Text = "Номер вопроса: " + 1;
                lblTestsNameValue.Text = currentQuestion.Task;
                for (int i = 1; i < 5; i++)
                {
                    _answerIndex++;
                    if (_answerIndex == currentQuestion.Answers.Count)
                    {
                        break;
                    }
                    else
                    {
                        SetAnswers(i);
                    }

                }
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            WriteChoosenAnswer();
            HideAnswers();
            Question currentQuestion = _test.Questions[_questionIndex];
            if (_answerIndex == currentQuestion.Answers.Count)
            {
                _questionIndex++;
                if (_questionIndex == _test.Questions.Count)
                {
                    int score = _logicModel.CompleteTest(_test, _answers);
                    MessageBox.Show($"Ваш результат: {score}/{_test.GetScore()}");
                    this.Close();
                }
                else
                {
                    currentQuestion = _test.Questions[_questionIndex];
                    _answerIndex = 0;
                    lblQuestionNumber.Text = "Номер вопроса: " + (_questionIndex+1);
                    lblTestsNameValue.Text = currentQuestion.Task;
                }

            }
            else
            {
                for (int i = 1; i < 5; i++)
                {
                    _answerIndex++;
                    if (_answerIndex == currentQuestion.Answers.Count)
                    {
                        break;
                    }
                    else
                    {
                        SetAnswers(i);
                    }

                }
            }

        }

        private void TestSolvingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _logicModel.DataBase.Save();
            _passingModeForm.Show();
        }

        private void SetAnswers(int number)
        {
            Question currentQuestion = _test.Questions[_questionIndex];
            Answer currentAnswer = currentQuestion.Answers[_answerIndex];
            switch (number)
            {
                case 1:
                    checkBoxAnswer1.Visible =
                        lblAnswer1.Visible = true;
                    lblAnswer1.Text = currentAnswer.text;
                    break;
                case 2:
                    checkBoxAnswer2.Visible =
                        lblAnswer2.Visible = true;
                    lblAnswer2.Text = currentAnswer.text;
                    break;
                case 3:
                    checkBoxAnswer3.Visible =
                        lblAnswer3.Visible = true;
                    lblAnswer3.Text = currentAnswer.text;
                    break;
                case 4:
                    checkBoxAnswer4.Visible =
                        lblAnswer4.Visible = true;
                    lblAnswer4.Text = currentAnswer.text;
                    break;
            }
        }

        private void HideAnswers()
        {
            checkBoxAnswer1.Visible =
                checkBoxAnswer2.Visible =
                checkBoxAnswer3.Visible =
                checkBoxAnswer4.Visible =
                lblAnswer1.Visible =
                lblAnswer2.Visible =
                lblAnswer3.Visible =
                lblAnswer4.Visible =
                false;
            checkBoxAnswer1.Checked =
                checkBoxAnswer2.Checked =
                checkBoxAnswer3.Checked =
                checkBoxAnswer4.Checked =
                false;
        }

        private void WriteChoosenAnswer()
        {
            Question currentQuestion = _test.Questions[_questionIndex];
            if (_answers.Count == _questionIndex)
            {
                _answers.Add(new List<Answer>());
            }
            if (checkBoxAnswer1.Checked && currentQuestion.Answers.Count > _answerIndex - 3)
            {
                _answers[_questionIndex].Add(currentQuestion.Answers[_answerIndex - 3]);
            }
            if (checkBoxAnswer2.Checked && currentQuestion.Answers.Count > _answerIndex - 2)
            {
                _answers[_questionIndex].Add(currentQuestion.Answers[_answerIndex - 2]);
            }
            if (checkBoxAnswer3.Checked && currentQuestion.Answers.Count > _answerIndex - 1)
            {
                _answers[_questionIndex].Add(currentQuestion.Answers[_answerIndex - 1]);
            }
            if (checkBoxAnswer4.Checked && currentQuestion.Answers.Count > _answerIndex)
            {
                _answers[_questionIndex].Add(currentQuestion.Answers[_answerIndex]);
            }
        }
    }
}
