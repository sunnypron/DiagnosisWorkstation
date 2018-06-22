using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using DiagnosisWorkstation.Controls.Base;
using DiagnosisWorkstation.ICode.BLL;
using DiagnosisWorkstation.Code.BLL;
using DCDapModel;

namespace DiagnosisWorkstation.Controls.Users
{
    public partial class UcUserPermissionCtrl : BaseConfigCtrl
    {
        private BaseConfigCtrl _userContrl;
        private readonly IUsersBll _usersBll = new UsersBll();
        private List<UserUser> _users = new List<UserUser>();

        public UcUserPermissionCtrl()
        {
            InitializeComponent();
        }

        public override void Save()
        {
            _userContrl?.Save();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            var rb = (RadioButton)sender;

            if (pnlInfo.Controls.Count > 0)
            {
                pnlInfo.Controls.Remove(_userContrl);
            }

            // ReSharper disable once RedundantCheckBeforeAssignment
            if (_userContrl != null)
            {
                _userContrl = null;
            }

            var name = rb.Name;
            switch (name)
            {
                case "rbUserInfo":
                    _userContrl = new UcUserInfoCtrl()
                    {
                        Dock = DockStyle.Fill
                    };



                    _users = _usersBll.GetUsers();
                    if (_users.Count > 0)
                    {
                        BindUserList(_users);
                    }

                    break;
                case "rbRoleInfo":
                    break;
                case "rbPermissionInfo":
                    break;
            }

            if (_userContrl == null) return;

            pnlInfo.Controls.Add(_userContrl);

            _userContrl.ReadConfig();
        }

        private void lbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbList.SelectedIndex == -1) return;

            OperationType = OperationType.Modify;

            var userId = lbList.SelectedValue.ToString();

            _userContrl.ShowInfo(userId);
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
