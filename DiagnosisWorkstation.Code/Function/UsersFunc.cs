using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiagnosisWorkstation.Code.Base;
using DiagnosisWorkstation.ICode.Function;
using DCDapModel;
using IBLL;
using BLL;

namespace DiagnosisWorkstation.Code.Function
{
    public class UsersFunc : BaseClass, IUsersFunc
    {
        ICRUDBLL m_CrudBll = new CRUDBLL();
        public List<UserUser> GetUsers()
        {
            List<UserUser> list = m_CrudBll.GetDataList<UserUser>().ToList();
            return list;
        }
    }
}
