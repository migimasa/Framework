using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace Migi.Framework.Sql
{
    public class SqlClient
    {
        public static SqlParameter GetSqlParameter(string parameterName, SqlDbType dbType, object value)
        {
            SqlParameter param = new SqlParameter(parameterName, dbType);
            param.Value = value;

            return param;
        }
    }
}
