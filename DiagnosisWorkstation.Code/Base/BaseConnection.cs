﻿using DatabaseConnection;
using DatabaseConnection.Base;
using DatabaseConnection.Products;

namespace DiagnosisWorkstation.Code.Base
{
    public class BaseConnection
    {
        internal SqlServerHelper conn = (SqlServerHelper)new GetDbConn().GetDbConnClass(DBType.SqlServer);
        
        public BaseConnection()
        {
            conn.SetConnKey = "Database";
        }
    }
}
