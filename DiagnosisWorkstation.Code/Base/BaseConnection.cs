using DatabaseConnection;
using DatabaseConnection.Base;
using DatabaseConnection.Products;

namespace DiagnosisWorkstation.Code.Base
{
    internal class BaseConnection
    {
        SqlServerHelper conn = (SqlServerHelper)new GetDbConn().GetDbConnClass(DBType.SqlServer);
    }
}
