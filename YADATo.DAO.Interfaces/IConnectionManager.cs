using System;
using System.Collections;
using System.Collections.Generic;

namespace YADATo.DAO.Interfaces
{
    public interface IConnectionManager : IDisposable
    {
        IConnectionManager Connect();
        IConnectionManager Connect(string connectionString);
        IConnectionManager BeginTransaction();
        IConnectionManager RollbackTransaction();
        IConnectionManager CommitTransaction();

        object ExecuteScalar(string command);
        object ExecuteScalar(string command, ICMParameter[] parameters);
        object ExecuteScalar(string command, ICMParamaterList parameters);
        object ExecuteScalar(ISmartQuery query);

        bool Execute(string command);
        bool Execute(string command, ICMParameter[] parameters);
        bool Execute(string command, ICMParamaterList parameters);
        bool Execute(ISmartQuery query);

        T GetData<T>(string command, Func<IEnumerable, T> parser ) where T : class;
        T GetData<T>(string command, ICMParameter[] parameters,  Func<IEnumerable, T> parser) where T : class;
        T GetData<T>(string command, ICMParamaterList parameters, Func<IEnumerable, T> parser) where T : class;
        T GetData<T>(ISmartQuery query, Func<IEnumerable, T> parser) where T : class;

        IEnumerable<T> GetList<T>(string command, Func<IEnumerable, T> parser) where T : class;
        IEnumerable<T> GetList<T>(string command, ICMParameter[] parameters, Func<IEnumerable, T> parser) where T : class;
        IEnumerable<T> GetList<T>(string command, ICMParamaterList parameters, Func<IEnumerable, T> parser) where T : class;
        IEnumerable<T> GetList<T>(ISmartQuery query, Func<IEnumerable, T> parser) where T : class;

        Func<string> LogOperations { get; set; }

    }

    
}
