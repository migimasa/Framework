using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace Migi.Framework.Sql
{
    public interface IAccessLayerBase
    {
        string ConnectionString { get; }
        SqlConnection GetOpenConnection();
    }
}
