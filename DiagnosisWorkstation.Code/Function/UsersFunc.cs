using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using DiagnosisWorkstation.Code.Base;
using DiagnosisWorkstation.ICode.Function;
using DCDapModel;
using IBLL;
using BLL;

namespace DiagnosisWorkstation.Code.Function
{
    public class UsersFunc : BaseConnection, IUsersFunc
    {
        public List<UserUser> GetUsers()
        {
            //var users = m_CrudBll.GetDataList<UserUser>();
            //if (users.Count == 0)
            //{
            //    return new List<UserUser>();
            //}

            //List<UserUser> list = users.ToList();
            //return list;

            DataTable dt = conn.GetTable("select * from UserUser");

            if (dt.Rows.Count == 0)
            {
                return new List<UserUser>();
            }

            List<UserUser> list = new List<UserUser>();
            foreach (DataRow row in dt.Rows)
            {
                UserUser user = new UserUser()
                {
                    UserID = row["UserID"] == null ? "" : row["UserID"].ToString(),
                    UserName = row["UserName"] == null ? "" : row["UserName"].ToString(),
                    PassWord = row["PassWord"] == null ? "" : row["PassWord"].ToString(),
                    UserRole = row["UserRole"] == null ? "" : row["UserRole"].ToString()
                };

                list.Add(user);
            }

            return list;
        }
    }
}
