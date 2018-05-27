using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiagnosisWorkstation.Controls.Base;
using DiagnosisWorkstation.Code.Helper;
using DiagnosisWorkstation.ICode.Helper;

namespace DiagnosisWorkstation.Controls.Option
{
    public partial class UcDataBaseCtrl : BaseConfigCtrl
    {
        IConfigHelper m_Tool = new ConfigHelper();

        public UcDataBaseCtrl()
        {
            InitializeComponent();
        }

        #region 事件
        /// <summary>
        /// 显示或隐藏密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbShowPwd_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if (cb.Checked)
            {
                txtPwd.UseSystemPasswordChar = false;
            }
            else
            {
                txtPwd.UseSystemPasswordChar = true;
            }
        }

        /// <summary>
        /// 切换第二连接方式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbDbLinkType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string txt = cb.SelectedItem.ToString();

            if (txt == "内部")
            {
                txtIniFileName.Enabled = false;
            }
            else if (txt == "外部")
            {
                txtIniFileName.Enabled = true;
            }
        }
        #endregion

        #region 函数
        public override void Save()
        {
            if (string.IsNullOrEmpty(txtServiceName.Text.Trim()))
            {
                MessageBox.Show("服务器名不能为空", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(txtDbName.Text.Trim()))
            {
                MessageBox.Show("数据库名不能为空", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                MessageBox.Show("用户名不能为空", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(txtPwd.Text.Trim()))
            {
                MessageBox.Show("密码不能为空", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string serviceName = txtServiceName.Text.Trim();
            string dbName = txtDbName.Text.Trim();
            string uid = txtUserName.Text.Trim();
            string pwd = txtPwd.Text.Trim();

            m_Tool.SetConnConfig("Database", DataBase.SqlServer, serviceName, dbName, uid, pwd);

            string type = cbDbLinkType.Text;
            if (type == "内部")
            {
                m_Tool.SetAppConfig("dbLinkType", "Inside");
            }
            else if (type == "外部")
            {

                if (txtIniFileName.Text.Trim() == "")
                {
                    MessageBox.Show("请输入INI配置文件名", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    string name = txtIniFileName.Text.Trim();
                    m_Tool.SetAppConfig("dbLinkType", "Outside");
                    m_Tool.SetAppConfig("iniFname", name);
                }
            }
        }

        /// <summary>
        /// 读取连接字符串
        /// </summary>
        public override void ReadConfig()
        {
            Dictionary<string, string> connDict = m_Tool.ReadConnToDict("Database");
            if (connDict.Count == 0)
            {
                return;
            }

            string val = "";
            if (connDict.ContainsKey("provider"))
            {
                val = connDict["provider"].ToString();

                if (val == "SqlClient")
                {
                    cbDbType.Text = "SQLServer";
                }
                else if (val == "Oracle" || val == "odbc")
                {
                    cbDbType.Text = "Oracle";
                }
            }

            if (connDict.ContainsKey("Data Source"))
            {
                txtServiceName.Text = connDict["Data Source"].ToString();
            }

            if (connDict.ContainsKey("Initial Catalog"))
            {
                txtDbName.Text = connDict["Initial Catalog"].ToString();
            }

            if (connDict.ContainsKey("User Name"))
            {
                txtUserName.Text = connDict["User Name"].ToString();
            }

            if (connDict.ContainsKey("Password"))
            {
                txtPwd.Text = connDict["Password"].ToString();
            }

            string linkType = m_Tool.GetAppConfig("dbLinkType");
            if (linkType == "Inside")
            {
                cbDbLinkType.Text = "内部";
            }
            else if (linkType == "Outside")
            {
                cbDbLinkType.Text = "外部";
                txtIniFileName.Text = m_Tool.GetAppConfig("iniFname");
            }
        }
        #endregion
    }
}
