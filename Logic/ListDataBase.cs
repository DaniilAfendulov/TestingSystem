using System;
using System.Collections.Generic;

namespace TestingSystem.Logic
{
    [Serializable]
    public abstract class ListDataBase<T>
    {
        protected List<T> _data;
        public void Add(T data)
        {
            _data.Add(data);
        }
        public ListDataBase()
        {
            _data = new List<T>();
        }
        public ListDataBase(T[] data)
        {
            _data = new List<T>(data);
        }
        public T[] GetData()
        {
            return _data.ToArray();
        }
        public void RemoveData(T data)
        {
            for (int i = 0; i < _data.Count; i++)
            {
                if (_data[i].Equals(data))
                {
                    _data.RemoveAt(i);
                    break;
                }
            }
        }
        public void ModifyData(T oldData, T newData)
        {
            for (int i = 0; i < _data.Count; i++)
            {
                if (_data[i].Equals(oldData))
                {
                    _data[i] = newData;
                    break;
                }
            }
        }

    }
}
