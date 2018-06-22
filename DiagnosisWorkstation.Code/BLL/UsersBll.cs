using System.Collections.Generic;
using System.Linq;
using DCDapModel;
using DiagnosisWorkstation.ICode.BLL;
using DiagnosisWorkstation.ICode.DAL;
using DiagnosisWorkstation.Code.DAL;

namespace DiagnosisWorkstation.Code.BLL
{
    public class UsersBll : IUsersBll
    {
        private readonly IUsersDal _dal = new UsersDal();
        private IList<UserUser> _users = new List<UserUser>();
        private IList<Pitaya_Role> _roles=new List<Pitaya_Role>();

        #region 用户

        public IList<UserUser> GetUsers()
        {
            _users = _dal.GetUsers();
            return _users;
        }
        public bool ModifyUser(UserUser user) => _dal.ModifyUser(user);
        #endregion

        #region 角色

        public IList<Pitaya_Role> GetRole()
        {
            _roles = _dal.GetRole();
            return _roles;
        }

        /// <summary>
        /// 根据角色名称获取角色编号
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        public string GetRoleIdByRoleName(string roleName)
        {
            return _roles.Any(r => r.RoleName == roleName)
                ? _roles.First(r => r.RoleName == roleName).RoleID
                : string.Empty;
        }
        #endregion

        #region 权限
        #endregion
    }
}
