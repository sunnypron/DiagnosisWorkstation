using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DiagnosisWorkstation.Code.Function;
using DiagnosisWorkstation.Code.Helper;
using DiagnosisWorkstation.Controls.Base;
using DiagnosisWorkstation.ICode.Function;
using DiagnosisWorkstation.ICode.Helper;

namespace DiagnosisWorkstation.Controls.Option
{
    public partial class UcDataBaseCtrl : BaseConfigCtrl
    {
        private readonly IConfigHelper _tool = new ConfigHelper();
        private readonly ISimpleFactory _simpleFactory = new SimpleFactory();

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
            var cb = (CheckBox)sender;

            txtPwd.UseSystemPasswordChar = !cb.Checked;
        }

        /// <summary>
        /// 切换第二连接方式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbDbLinkType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cb = (ComboBox)sender;
            var txt = cb.SelectedItem.ToString();

            switch (txt)
            {
                case "内部":
                    txtIniFileName.Enabled = false;
                    break;
                case "外部":
                    txtIniFileName.Enabled = true;
                    break;
            }
        }

        private void cbDbType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _simpleFactory.SetConsoleDAL(cbDbType.SelectedItem.ToString());
        }
        #endregion

        #region 函数
        /// <summary>
        /// 保存
        /// </summary>
        public override void Save()
        {
            if (string.IsNullOrEmpty(txtServiceName.Text.Trim()))
            {
                MessageBox.Show(@"服务器名不能为空", @"系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtDbName.Text.Trim()))
            {
                MessageBox.Show(@"数据库名不能为空", @"系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                MessageBox.Show(@"用户名不能为空", @"系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtPwd.Text.Trim()))
            {
                MessageBox.Show(@"密码不能为空", @"系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var serviceName = txtServiceName.Text.Trim();
            var dbName = txtDbName.Text.Trim();
            var uid = txtUserName.Text.Trim();
            var pwd = txtPwd.Text.Trim();

            _tool.SetConnConfig("Database", DataBase.SqlServer, serviceName, dbName, uid, pwd);

            var type = cbDbLinkType.Text;
            switch (type)
            {
                case "内部":
                    _tool.SetAppConfig("dbLinkType", "Inside");
                    _tool.SetAppConfig("iniFname", "");
                    break;
                case "外部" when txtIniFileName.Text.Trim() == "":
                    MessageBox.Show(@"请输入INI配置文件名", @"系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                case "外部":
                    var name = txtIniFileName.Text.Trim();
                    _tool.SetAppConfig("dbLinkType", "Outside");
                    _tool.SetAppConfig("iniFname", name);
                    break;
            }
        }

        /// <summary>
        /// 读取连接字符串
        /// </summary>
        public override void ReadConfig()
        {
            Dictionary<string, string> connDict = _tool.ReadConnToDict("Database");
            if (connDict.Count == 0)
            {
                return;
            }

            if (connDict.ContainsKey("provider"))
            {
                var val = connDict["provider"];

                switch (val)
                {
                    case "SqlClient":
                        cbDbType.Text = @"SQLServer";
                        break;
                    case "Oracle":
                    case "odbc":
                        cbDbType.Text = @"Oracle";
                        break;
                }
            }

            if (connDict.ContainsKey("Data Source"))
            {
                txtServiceName.Text = connDict["Data Source"];
            }

            if (connDict.ContainsKey("Initial Catalog"))
            {
                txtDbName.Text = connDict["Initial Catalog"];
            }

            if (connDict.ContainsKey("User ID"))
            {
                txtUserName.Text = connDict["User ID"];
            }

            if (connDict.ContainsKey("Password"))
            {
                txtPwd.Text = connDict["Password"];
            }

            var linkType = _tool.GetAppConfig("dbLinkType");
            switch (linkType)
            {
                case "Inside":
                    cbDbLinkType.Text = @"内部";
                    break;
                case "Outside":
                    cbDbLinkType.Text = @"外部";
                    txtIniFileName.Text = _tool.GetAppConfig("iniFname");
                    break;
            }
        }
        #endregion
    }
}
