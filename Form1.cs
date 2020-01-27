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
    public partial class Form1 : Form
    {
        private LogicModel _logicModel;

        public Form1(LogicModel logicModel) 
        {
            _logicModel = logicModel;
            InitializeComponent();
        }

    }
}
