using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSystem.Logic
{
    public class LogicModel
    {
        private DataBase _dataBase;
        public LogicModel()
        {
            _dataBase = new DataBase();
        }
        public void Load()
        {
            _dataBase.Load();
        }
    }
}
