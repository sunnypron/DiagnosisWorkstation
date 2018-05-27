using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagnosisWorkstation.ICode.Helper
{
    /// <summary>
    /// 数据库
    /// </summary>
    public enum DataBase
    {
        SqlServer = 1,
        Oracle = 2
    }

    public interface IConfigHelper
    {
        void SetConnConfig(string key, DataBase db, string serviceName, string dbName, string uid, string pwd);
        void SetAppConfig(string key, string value);
        string GetAppConfig(string key);
        Dictionary<string, string> ReadConnToDict(string key);
    }
}
