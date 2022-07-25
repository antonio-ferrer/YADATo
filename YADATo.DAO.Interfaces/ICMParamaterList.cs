using System;
using System.Collections.Generic;
using System.Text;

namespace YADATo.DAO.Interfaces
{
    public interface ICMParamaterList : IEnumerable<ICMParameter>
    {
        object this[string name]{ get; set; }   

        object this[int index] { get; set; }

        ICMParamaterList Add(ICMParameter paramater);

        ICMParamaterList Add(string name, object value, bool? isOut = null);

        ICMParameter GetParameter(string name);

        ICMParameter GetParameter(int index);

        ICMParamaterList Remove(string name);

        ICMParamaterList Remove(int index);

        object GetParameterValue(string name);

        object GetParameterValue(int index);

        ICMParamaterList Clear();



    }

}
