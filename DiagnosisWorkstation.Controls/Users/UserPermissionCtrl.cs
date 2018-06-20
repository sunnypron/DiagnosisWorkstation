using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using DiagnosisWorkstation.Controls.Base;
using DiagnosisWorkstation.ICode.Function;
using DiagnosisWorkstation.Code.Function;
using DCDapModel;

namespace DiagnosisWorkstation.Controls.Users
{
    public partial class UcUserPermissionCtrl : BaseConfigCtrl
    {
        private BaseConfigCtrl m_UserContrl;
        private IUsersFunc m_UserFunc = new UsersFunc();
        private List<UserUser> m_Users = new List<UserUser>();

        public UcUserPermissionCtrl()
        {
            InitializeComponent();

        }

        public override void Save()
        {
            m_UserContrl?.Save();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            var rb = (RadioButton)sender;

            var name = rb.Name;
            if (name == "rbUserInfo")
            {
                m_UserContrl = new UcUserInfoCtrl()
                {
                    Dock = DockStyle.Fill
                };



                m_Users = m_UserFunc.GetUsers();
                if (m_Users.Count > 0)
                {
                    BindUserList(m_Users);
                }
            }

            pnlInfo.Controls.Add(m_UserContrl);
        }

        #region 函数
        /// <summary>
        /// 绑定用户列表
        /// </summary>
        /// <param name="users"></param>
        private void BindUserList(IEnumerable<UserUser> users)
        {
            lbList.DataSource = new BindingSource(users.Where(u => u.UserName != "admin"), null);
            lbList.ValueMember = "UserID";
            lbList.DisplayMember = "UserName";
        }

        /// <summary>
        /// 绑定角色列表
        /// </summary>
        /// <param name="roles"></param>
        private void BindRoleList(IList<Pitaya_Role> roles)
        {
            for (var i = 0; i < roles.Count; i++)
            {
                lbList.Items.Insert(i, roles[i].RoleName);
            }
        }
        #endregion
    }
}
