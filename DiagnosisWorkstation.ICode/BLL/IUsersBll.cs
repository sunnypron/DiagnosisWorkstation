using DCDapModel;
using System.Collections.Generic;

namespace DiagnosisWorkstation.ICode.BLL
{
    public interface IUsersBll
    {
        #region 用户
        IList<UserUser> GetUsers();
        bool ModifyUser(UserUser user);
        #endregion

        #region 角色
        IList<Pitaya_Role> GetRole();
        string GetRoleIdByRoleName(string roleName);

        #endregion

        #region 权限

        #endregion
    }
}
