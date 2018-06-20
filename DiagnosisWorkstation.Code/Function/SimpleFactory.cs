using DiagnosisWorkstation.Code.Helper;
using DiagnosisWorkstation.ICode.Helper;
using DiagnosisWorkstation.ICode.Function;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagnosisWorkstation.Code.Function
{
    public class SimpleFactory : ISimpleFactory
    {
        IConfigHelper m_Tool = new ConfigHelper();

        public void SetConsoleDAL(string sqlType)
        {
            switch (sqlType)
            {
                case "SQLServer":
                    m_Tool.SetAppConfig("ConsoleDAL", "SQLServerDAL");
                    break;
                case "Oracle":
                    m_Tool.SetAppConfig("ConsoleDAL", "OracleDAL");
                    break;
            }
        }
    }
}
