using System.Collections.Generic;
using DiagnosisWorkstation.Code.Base;
using DiagnosisWorkstation.ICode.DAL;
using DCDapModel;
using System.Linq;

namespace DiagnosisWorkstation.Code.DAL
{
    public class UsersDal : BaseClass, IUsersDal
    {
        #region 用户
        /// <summary>
        /// 获取全部用户
        /// </summary>
        /// <returns></returns>
        public List<UserUser> GetUsers()
        {
            var users = CrudBll.GetDataList<UserUser>("select * from UserUser");

            return users.Count == 0 ? new List<UserUser>() : users.ToList();
        }

        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool ModifyUser(UserUser user)
        {
            var sql = "Update UserUser set UserName='" + user.UserName + "', PassWord='" + user.PassWord + "', UserRole='" +
                         user.UserRole + "' where UserID='" + user.UserID + "'";
            return CrudBll.Update(user, sql);
        }

        
        #endregion

        #region 角色
        /// <summary>
        /// 获取全部角色
        /// </summary>
        /// <returns></returns>
        public List<Pitaya_Role> GetRole()
        {
            var roles = CrudBll.GetDataList<Pitaya_Role>("select * from Pitaya_Role");

            return roles.Count == 0 ? new List<Pitaya_Role>() : roles.ToList();
        }
        #endregion

        #region 权限
        #endregion
    }
}
