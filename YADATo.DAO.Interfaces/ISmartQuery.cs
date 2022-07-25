using System;
using System.Collections.Generic;
using System.Text;

namespace YADATo.DAO.Interfaces
{
    public interface ISmartQuery : ICMParamaterList
    {
        string GetQuery();

        ISmartQuery SetQuery(string newQuery);

    }
}
