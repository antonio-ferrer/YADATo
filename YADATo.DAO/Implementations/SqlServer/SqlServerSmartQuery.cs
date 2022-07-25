using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace YADATo.DAO.Implementations.SqlServer
{
    public class SqlServerSmartQuery : SmartQuery
    {
        private static Regex rxParameter = new Regex(@"\@\w+");

        public SqlServerSmartQuery()
        {
        }

        public SqlServerSmartQuery(string query)
        {
            this.currentQuery = query;
            var rxParameters = rxParameter.Matches(query);
            if((rxParameters?.Count ?? 0) > 0)
            {
                foreach (Match param in rxParameters) {
                    this.Add(param.Value, null);
                }
            }
        }

        internal IEnumerable<SqlParameter> GetSqlParameter()
        {
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            foreach (var parameter in this)
            {
                SqlParameter sqlParameter = new SqlParameter(parameter.Name, parameter.Value);
                if (parameter.IsOut ?? false)
                    sqlParameter.Direction = System.Data.ParameterDirection.Output;
                sqlParameters.Add(sqlParameter);
            }
            return sqlParameters;
        }

        internal SqlServerSmartQuery FillParameters(IEnumerable<SqlParameter> sqlParameters)
        {
            var outParameters = sqlParameters.Where(p => p.Direction == System.Data.ParameterDirection.Output);
            foreach(var sqlParameter in outParameters)
            {
                this[sqlParameter.ParameterName] = sqlParameter.Value;
            }
            return this;
        }

        public static implicit operator SqlServerSmartQuery(string str)
        {
            return new SqlServerSmartQuery(str);
        }

        public override string ToString()
        {
            return this.currentQuery;
        }

    }
}
