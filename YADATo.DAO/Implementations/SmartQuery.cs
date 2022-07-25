using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using YADATo.DAO.Interfaces;

namespace YADATo.DAO.Implementations
{
    public class SmartQuery : YADATo.DAO.Interfaces.ISmartQuery
    {
        protected Implementations.CMParameterList list = new Implementations.CMParameterList();
        protected string currentQuery = "";

        public object this[string name] { get => list[name]; set => list[name] = value; }
        public object this[int index] { get => list[index]; set => list[index] = value; }

        public ICMParamaterList Add(ICMParameter paramater)
        {
            list.Add(paramater);
            return this;
        }

        public ICMParamaterList Add(string name, object value, bool? isOut = null)
        {
            list.Add(name, value, isOut);
            return this;
        }

        public ICMParamaterList Clear()
        {
            list.Clear();
            return this;
        }

        public IEnumerator<ICMParameter> GetEnumerator() => list.GetEnumerator();

        public ICMParameter GetParameter(string name) => list.GetParameter(name);

        public ICMParameter GetParameter(int index) => list.GetParameter(index);

        public object GetParameterValue(string name) => list.GetParameterValue(name);

        public object GetParameterValue(int index) => list.GetParameterValue(index);

        public string GetQuery()
        {
            return currentQuery;
        }

        public ICMParamaterList Remove(string name)
        {
            list.Remove(name);
            return this;
        }

        public ICMParamaterList Remove(int index)
        {
            list.Remove(index);
            return this;
        }

        public ISmartQuery SetQuery(string newQuery)
        {
            currentQuery = newQuery;
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();    
        }
    }
}
