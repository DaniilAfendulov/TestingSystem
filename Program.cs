using System;
using System.Windows.Forms;
using TestingSystem.Logic;

namespace TestingSystem
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LogicModel logicModel = new LogicModel();
            Application.Run(new AuthorizationForm(logicModel));
        }
    }
}
