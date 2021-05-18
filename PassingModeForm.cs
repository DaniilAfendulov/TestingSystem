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
    public partial class PassingModeForm : Form
    {
        private AuthorizationForm _authorizationForm;
        private LogicModel _logicModel;

        public PassingModeForm(AuthorizationForm authorizationForm, ref LogicModel logicModel)
        {
            _authorizationForm = authorizationForm;
            _logicModel = logicModel;
            InitializeComponent();            
        }

        private void PassingModeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _logicModel.DataBase.Save();
            _authorizationForm.Show();
        }

        private void BtnStartTest_Click(object sender, EventArgs e)
        {
            if (listBoxTests.SelectedIndex != -1)
            {
                var solvingForm = new TestSolvingForm(ref _logicModel, this, listBoxTests.SelectedIndex);
                solvingForm.Show();
                this.Hide();
            }
            else MessageBox.Show("Тест не выбран");
        }

        private void ListBoxTests_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxTests.SelectedIndex;
            Test test = _logicModel.DataBase.GetTests()[index];
            lblTestsNameValue.Text = test.Name;
            lblBestScore.Text = "Лучший результат: " 
                + _logicModel.DataBase.FindTestsScore(_logicModel.Solver, test).ToString()
                + " / " + test.GetScore();
        }

        private void PassingModeForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                List<string> tests = new List<string>();
                foreach (var test in _logicModel.DataBase.GetTests())
                {
                    tests.Add(test.Name);
                }
                listBoxTests.DataSource = tests;
                if (listBoxTests.Items.Count != 0)
                {
                    listBoxTests.SelectedIndex = 0;
                }
            }
        }
    }
}
