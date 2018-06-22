using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DCDapModel;
using DiagnosisWorkstation.Code.BLL;
using DiagnosisWorkstation.Code.Function;
using DiagnosisWorkstation.Controls.Base;
using DiagnosisWorkstation.ICode.BLL;
using DiagnosisWorkstation.ICode.Function;

namespace DiagnosisWorkstation.Controls.Users
{
    public partial class UcUserInfoCtrl : BaseConfigCtrl
    {
        private readonly IGeneralFunc _generalFunc = new GeneralFunc();
        private readonly IUsersBll _usersBll = new UsersBll();
        private IList<UserUser> _userList = new List<UserUser>();
        private IList<Pitaya_Role> _roleList = new List<Pitaya_Role>();
        private UserUser _user = new UserUser();

        public UcUserInfoCtrl()
        {
            InitializeComponent();
        }

        #region 事件
        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            CreateUser();
        }
        #endregion

        #region 函數

        public override void ReadConfig()
        {
            _userList = _usersBll.GetUsers();
            _roleList = _usersBll.GetRole();

            if (_roleList.Count == 0) return;

            BindRoleList();
        }

        /// <summary>
        /// 保存
        /// </summary>
        public override void Save()
        {
            switch (OperationType)
            {
                case OperationType.Create:
                    Create();
                    break;
                case OperationType.Modify:
                    Modify();
                    break;
            }
        }

        /// <summary>
        /// 創建用戶
        /// </summary>
        public void CreateUser()
        {
            if (_userList.Count == 0)
            {
                txtUserCode.Text = @"001";
                txtUserCode.Enabled = true;
            }
            else
            {
                var maxNo = _userList.Max(u => u.UserID);
                var newNo = _generalFunc.AddOne(maxNo);

                txtUserCode.Text = newNo;
                txtUserCode.Enabled = false;
            }

            txtUserName.Text = "";
            txtPwd.Text = "";
            txtConfirmPwd.Text = "";

            OperationType = OperationType.Create;
        }

        /// <summary>
        /// 显示详细信息
        /// </summary>
        /// <param name="key"></param>
        public override void ShowInfo(string key)
        {
            txtUserCode.Text = key;
            txtUserCode.Enabled = false;

            if (_userList.Any(u => u.UserID == key))
            {
                _user = _userList.First(u => u.UserID == key);

                txtUserName.Text = _user.UserName;
                txtPwd.Text = _user.PassWord;

                if (_roleList.Count == 0) return;

                if (_roleList.Any(r => r.RoleID == _user.UserRole))
                {
                    var role = _roleList.First(r => r.RoleID == _user.UserRole);

                    if (!string.IsNullOrEmpty(role.RoleName))
                    {
                        cbRole.Text = role.RoleName;
                    }
                }
            }
        }

        /// <summary>
        /// 绑定角色列表
        /// </summary>
        public void BindRoleList()
        {
            cbRole.DataSource = _roleList;
            cbRole.DisplayMember = "RoleName";
            cbRole.ValueMember = "RoleID";
            cbRole.SelectedIndex = 0;
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        private void Modify()
        {
            if (!ValidateInput())
            {
                return;
            }

            var roleName = cbRole.Text;
            _user.UserName = txtUserName.Text.Trim();
            _user.PassWord = txtPwd.Text.Trim();
            _user.UserRole = _usersBll.GetRoleIdByRoleName(roleName);

            if (!_usersBll.ModifyUser(_user))
            {
                MessageBox.Show(@"更新用户信息失败", @"系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 创建新用户
        /// </summary>
        private void Create()
        {
            if (!ValidateInput())
            {
                return;
            }
            
            _user = new UserUser()
            {
                UserID = txtUserCode.Text.Trim(),
                UserName = txtUserName.Text.Trim(),
                PassWord = txtPwd.Text.Trim(),
                UserRole = _usersBll.GetRoleIdByRoleName(cbRole.Text)
            };


        }

        /// <summary>
        /// 输入验证
        /// </summary>
        private bool ValidateInput()
        {
            var result = true;
            if (string.IsNullOrEmpty(txtUserCode.Text.Trim()))
            {
                result = false;
                MessageBox.Show(@"用户编号不能为空", @"系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                result = false;
                MessageBox.Show(@"用户名不能为空", @"系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(txtPwd.Text.Trim()))
            {
                result = false;
                MessageBox.Show(@"密码不能为空", @"系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!txtPwd.Text.Equals(_user.PassWord))
            {
                if (string.IsNullOrEmpty(txtConfirmPwd.Text.Trim()))
                {
                    result = false;
                    MessageBox.Show(@"请再次输入密码", @"系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!txtConfirmPwd.Text.Trim().Equals(txtPwd.Text.Trim()))
                {
                    result = false;
                    MessageBox.Show(@"两次密码输入不一致，请重新输入", @"系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            return result;
        }
        #endregion
    }
}
