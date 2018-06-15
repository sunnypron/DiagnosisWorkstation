using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiagnosisWorkstation.Controls.Base;
using DiagnosisWorkstation.ICode.Function;
using DiagnosisWorkstation.Code.Function;
using DCDapModel;
using System.Collections;

namespace DiagnosisWorkstation.Controls.Users
{
    public partial class UcUserPermissionCtrl : BaseConfigCtrl
    {
        BaseConfigCtrl m_UserContrl;
        IUsersFunc m_UserFunc;

        public UcUserPermissionCtrl()
        {
            InitializeComponent();

        }

        public override void Save()
        {
            if (m_UserContrl != null)
            {
                m_UserContrl.Save();
            }
        }

        public override void ReadConfig()
        {
            base.ReadConfig();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            string name = rb.Name;
            if (name == "rbUserInfo")
            {
                m_UserContrl = new UcUserInfoCtrl()
                {
                    Dock = DockStyle.Fill
                };

                m_UserFunc = new UsersFunc();

                List<UserUser> users = m_UserFunc.GetUsers();
                if (users.Count > 0)
                {
                    BindUserList(users);
                }
            }

            pnlInfo.Controls.Add(m_UserContrl);
        }

        #region 函数
        /// <summary>
        /// 绑定用户列表
        /// </summary>
        /// <param name="users"></param>
        private void BindUserList(List<UserUser> users)
        {
            for (int i = 0; i < users.Count; i++)
            {
                lbList.Items.Insert(i, users[i].UserName);
            }
        }

        /// <summary>
        /// 绑定角色列表
        /// </summary>
        /// <param name="roles"></param>
        private void BindRoleList(List<Pitaya_Role> roles)
        {
            for (int i = 0; i < roles.Count; i++)
            {
                lbList.Items.Insert(i, roles[i].RoleName);
            }
        }
        #endregion
    }
}
