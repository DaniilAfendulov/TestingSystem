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
    public partial class AuthorizationForm : Form
    {
        private LogicModel _logicModel;

        private enum SystemMode
        {
            PassingMode = 0,
            EditingMode
        }
        public AuthorizationForm(LogicModel logicModel) 
        {
            _logicModel = logicModel;
            _logicModel.DataBase.Load();
            InitializeComponent();
            listBoxSystemMode.SelectedIndex = 0;
        }

        private void AuthorizationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _logicModel.DataBase.Save();
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            if (string.IsNullOrWhiteSpace(login)
                || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Логин и пароль не могут быть пустыми");
                return;
            }
            switch ((SystemMode)listBoxSystemMode.SelectedIndex)
            {
                case SystemMode.PassingMode:
                    SolverAuthorization(login, password);
                    break;
                case SystemMode.EditingMode:
                    AuthorAuthorization(login, password);
                    break;
                default:
                    break;
            }
        }

        private void SolverAuthorization(string login, string password)
        {
            if (checkBoxIsNewUser.Checked)
            {
                _logicModel.AddNewSolver(login, password);
            }
            else
            {
                if (!_logicModel.TryToFindSolver(login, password))
                {
                    MessageBox.Show("Пользователь не найден");
                    return;
                }
            }
            OpenShildForm(new PassingModeForm(this, ref _logicModel));
        }
        private void AuthorAuthorization(string login, string password)
        {
            if (checkBoxIsNewUser.Checked)
            {
                _logicModel.AddNewAuthor(login, password);
            }
            else
            {
                if (!_logicModel.TryToFindAuthor(login, password))
                {
                    MessageBox.Show("Пользователь не найден");
                    return;
                }
            }
            OpenShildForm(new EditingModeForm(this, ref _logicModel));
        }
        private void OpenShildForm(Form form)
        {
            _logicModel.DataBase.Save();
            form.Show();
            this.Hide();
        }

    }
}
