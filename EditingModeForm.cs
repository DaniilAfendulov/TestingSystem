using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestingSystem.Logic;
namespace TestingSystem
{
    public partial class EditingModeForm : Form
    {
        private AuthorizationForm _authorizationForm;
        private LogicModel _logicModel;
        public EditingModeForm(AuthorizationForm authorizationForm, ref LogicModel logicModel)
        {
            _authorizationForm = authorizationForm;
            _logicModel = logicModel;
            InitializeComponent();
            RefreshTestList();
        }

        private void EditingModeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _logicModel.DataBase.Save();
            _authorizationForm.Show();
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {            
            if (listBoxTests.SelectedItem != null)
            {
                int index = listBoxTests.SelectedIndex;
                OpenChildForm(new CreatingTestForm(ref _logicModel, this, index));
            }
            else
            {
                MessageBox.Show("Тест для модификации не выбран");
            }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CreatingTestForm(ref _logicModel, this));
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int index = listBoxTests.SelectedIndex;            
            if (!_logicModel.TryDeleteTest(index))
            {
                MessageBox.Show("удалить объект не удалось");
                return;
            }
            RefreshTestList();
        }
        private void OpenChildForm(Form form)
        {
            _logicModel.DataBase.Save();
            form.Show();
            this.Hide();
        }

        private void EditingModeForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                RefreshTestList();
            }
        }
        private void RefreshTestList()
        {
            List<string> names = new List<string>();
            foreach (var test in _logicModel.Author.GetTests)
            {
                names.Add(test.Name);
            }
            listBoxTests.DataSource = names;
        }
    }
}
