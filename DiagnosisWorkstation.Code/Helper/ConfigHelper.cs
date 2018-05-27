using DiagnosisWorkstation.ICode.Helper;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace DiagnosisWorkstation.Code.Helper
{
    /// <summary>
    /// 配置文件帮助类
    /// </summary>
    public class ConfigHelper : IConfigHelper
    {
        private string m_ConfigFilePath = "";

        public ConfigHelper()
        {
            m_ConfigFilePath = Application.ExecutablePath;
        }

        #region 逻辑函数
        /// <summary>
        /// 修改数据库连接字符串
        /// </summary>
        /// <param name="key">连接字符串名</param>
        /// <param name="db">数据库类型</param>
        /// <param name="serviceName">服务器名或IP</param>
        /// <param name="dbName">数据库名</param>
        /// <param name="uid">用户名</param>
        /// <param name="pwd">密码</param>
        public void SetConnConfig(string key, DataBase db, string serviceName, string dbName, string uid, string pwd)
        {
            switch (db)
            {
                case DataBase.SqlServer:
                    string sqlConn = string.Format("Data Source={0};Initial Catalog={1};User Name={2};Password={3};Connect Timeout=20;", serviceName, dbName, uid, pwd);
                    WriteConnStr(key, sqlConn, "System.Data.SqlClient");
                    break;
                case DataBase.Oracle:
                    break;
            }
        }

        /// <summary>
        /// 将数据库连接转入字典
        /// </summary>
        /// <param name="key"></param>
        /// <param name="provider"></param>
        /// <returns></returns>
        public Dictionary<string, string> ReadConnToDict(string key)
        {
            string
                provider = "",
                connStr = "";

            connStr = ReadConnStr(key, out provider);

            Dictionary<string, string> connDict = new Dictionary<string, string>();

            if (!string.IsNullOrEmpty(provider))
            {
                string[] providerArray = provider.Split('.');
                connDict.Add("provider", providerArray.Last());
            }

            if (!string.IsNullOrEmpty(connStr))
            {
                string[] connArray = connStr.Split(';');

                foreach (string s in connArray)
                {
                    if (string.IsNullOrEmpty(s))
                    {
                        continue;
                    }

                    string[] array = s.Split('=');
                    connDict.Add(array[0], array[1]);
                }
            }

            return connDict;
        }
        #endregion

        #region 读写配置文件
        /// <summary>
        /// 修改连接字符串
        /// </summary>
        /// <param name="key">连接字符串名称</param>
        /// <param name="connStr">要修改的连接字符串</param>
        private void WriteConnStr(string key, string connStr, string provider)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(m_ConfigFilePath);

            bool exist = false;
            if (ConfigurationManager.ConnectionStrings[key] != null)
            {
                exist = true;
            }

            if (exist)
            {
                config.ConnectionStrings.ConnectionStrings[key].ConnectionString = connStr;
            }
            else
            {
                ConnectionStringSettings css = new ConnectionStringSettings(key, connStr, provider);
                config.ConnectionStrings.ConnectionStrings.Add(css);
            }
            config.Save(ConfigurationSaveMode.Modified, false);
            ConfigurationManager.RefreshSection("connectionStrings");
        }

        /// <summary>
        /// 读取连接字符串
        /// </summary>
        /// <param name="key">连接字符串名称</param>
        private string ReadConnStr(string key, out string provider)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(m_ConfigFilePath);

            string
                connStr = "";
            provider = "";

            bool exist = false;
            if (ConfigurationManager.ConnectionStrings[key] != null)
            {
                exist = true;
            }

            if (exist)
            {
                connStr = config.ConnectionStrings.ConnectionStrings[key].ConnectionString;
                provider = config.ConnectionStrings.ConnectionStrings[key].ProviderName;
            }

            return connStr;
        }

        ///<summary>  
        ///在appSettings中配置节增加一对键值对  
        ///</summary>  
        ///<param name="key"></param>  
        ///<param name="value"></param>  
        public void SetAppConfig(string key, string value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(m_ConfigFilePath);

            bool exist = false;
            foreach (string k in config.AppSettings.Settings.AllKeys)
            {
                if (k == key)
                {
                    exist = true;
                    break;
                }
            }

            if (exist)
            {
                config.AppSettings.Settings[key].Value = value;
            }
            else
            {
                config.AppSettings.Settings.Add(key, value);
            }

            config.Save(ConfigurationSaveMode.Modified, false);
            ConfigurationManager.RefreshSection("appSettings");
        }

        /// <summary>
        /// 读取配置文件
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string GetAppConfig(string key)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(m_ConfigFilePath);

            bool exist = false;
            foreach (string k in config.AppSettings.Settings.AllKeys)
            {
                if (k == key)
                {
                    exist = true;
                    break;
                }
            }

            if (exist)
            {
                return config.AppSettings.Settings[key].Value;
            }
            else
            {
                return "";
            }
        }
        #endregion
    }
}
