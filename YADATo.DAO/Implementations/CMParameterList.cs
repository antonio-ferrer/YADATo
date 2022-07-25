using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using YADATo.DAO.Interfaces;

namespace YADATo.DAO.Implementations
{
    public class CMParameterList : ICMParamaterList
    {
        private readonly List<ICMParameter> _parameters = new List<ICMParameter>();

        private ICMParameter getParameter(string name) => _parameters.FirstOrDefault(p => Regex.IsMatch(p.Name, name, RegexOptions.IgnoreCase));

        private ICMParameter getParameter(int index, bool notThrowErrorWhenOutOfRange = true)
        {
            ICMParameter parameter = null;
            if (index >= 0 && index < _parameters.Count)
            {
                parameter = _parameters[index];
            }
            if(!notThrowErrorWhenOutOfRange)
                return parameter ?? throw new ArgumentOutOfRangeException();
            return parameter;
        }
        
        public object this[string name] { 
            get => getParameter(name)?.Value; 
            set
            {
                var parameter = getParameter(name);
                if(parameter == null)
                {
                    parameter = new CMParameter {  Name = name, Value = value };
                    _parameters.Add(parameter);
                }
                parameter.Value = value;    
            }
        }

        public object this[int index] {
            get => getParameter(index);
            set
            {
                var parameter = getParameter(index);
                if (parameter != null)
                {
                    _parameters[index].Value = value;
                }
            }
        }

        public ICMParamaterList Add(ICMParameter paramater)
        {
            _parameters.Add(paramater ?? throw new ArgumentNullException("invalid parameter"));
            return this;
        }

        public ICMParamaterList Add(string name, object value, bool? isOut = null)
        {
            var parameter = new CMParameter { Name = name, Value = value, IsOut = isOut };
            _parameters.Add(parameter);
            return this;
        }

        public ICMParamaterList Clear()
        {
            _parameters.Clear();
            return this;
        }

        public IEnumerator<ICMParameter> GetEnumerator()
        {
            return _parameters.GetEnumerator();
        }

        public ICMParameter GetParameter(string name)
        {
            return getParameter(name);  
        }

        public ICMParameter GetParameter(int index) => getParameter(index, false);

        public object GetParameterValue(string name)
        {
            return getParameter(name)?.Value;
        }

        public object GetParameterValue(int index) => getParameter(index);

        public ICMParamaterList Remove(string name)
        {
            var parameter = getParameter(name);
            if (parameter != null)
                _parameters.Remove(parameter);
            return this;
        }

        public ICMParamaterList Remove(int index)
        {
            var parameter = getParameter(index);
            if (parameter != null)
                _parameters.Remove(parameter);
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _parameters.GetEnumerator();
        }
    }
}
