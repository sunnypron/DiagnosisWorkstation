using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseConnection;
using DatabaseConnection.Base;
using DatabaseConnection.Connections;

namespace DiagnosisWorkstation.Code.Base
{
    internal class BaseConnection
    {
        SqlServerHelper conn = (SqlServerHelper)new GetDbConn().GetDbConnClass(DBType.SqlServer);
    }
}
