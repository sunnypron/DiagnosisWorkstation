using System.Collections.Generic;
using DCDapModel;

namespace DiagnosisWorkstation.ICode.DAL
{
    public interface IUsersDal
    {
        #region 用户
        List<UserUser> GetUsers();
        bool ModifyUser(UserUser user);
        #endregion

        #region 角色
        List<Pitaya_Role> GetRole();
        #endregion

        #region 权限
        #endregion
    }
}
