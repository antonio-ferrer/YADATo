using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using YADATo.DAO.Interfaces;

namespace YADATo.DAO.Implementations.SqlServer
{
    public class SqlServerConnectionManager : YADATo.DAO.Interfaces.IConnectionManager
    {
        public Func<string> LogOperations { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IConnectionManager BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public IConnectionManager CommitTransaction()
        {
            throw new NotImplementedException();
        }

        public IConnectionManager Connect()
        {
            throw new NotImplementedException();
        }

        public IConnectionManager Connect(string connectionString)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool Execute(string command)
        {
            throw new NotImplementedException();
        }

        public bool Execute(string command, ICMParameter[] parameters)
        {
            throw new NotImplementedException();
        }

        public bool Execute(string command, ICMParamaterList parameters)
        {
            throw new NotImplementedException();
        }

        public bool Execute(ISmartQuery query)
        {
            throw new NotImplementedException();
        }

        public object ExecuteScalar(string command)
        {
            throw new NotImplementedException();
        }

        public object ExecuteScalar(string command, ICMParameter[] parameters)
        {
            throw new NotImplementedException();
        }

        public object ExecuteScalar(string command, ICMParamaterList parameters)
        {
            throw new NotImplementedException();
        }

        public object ExecuteScalar(ISmartQuery query)
        {
            throw new NotImplementedException();
        }

        public T GetData<T>(string command, Func<IEnumerable, T> parser) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetData<T>(string command, ICMParameter[] parameters, Func<IEnumerable, T> parser) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetData<T>(string command, ICMParamaterList parameters, Func<IEnumerable, T> parser) where T : class
        {
            throw new NotImplementedException();
        }

        public T GetData<T>(ISmartQuery query, Func<IEnumerable, T> parser) where T : class
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetList<T>(string command, Func<IEnumerable, T> parser) where T : class
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetList<T>(string command, ICMParameter[] parameters, Func<IEnumerable, T> parser) where T : class
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetList<T>(string command, ICMParamaterList parameters, Func<IEnumerable, T> parser) where T : class
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetList<T>(ISmartQuery query, Func<IEnumerable, T> parser) where T : class
        {
            throw new NotImplementedException();
        }

        public IConnectionManager RollbackTransaction()
        {
            throw new NotImplementedException();
        }
    }
}
