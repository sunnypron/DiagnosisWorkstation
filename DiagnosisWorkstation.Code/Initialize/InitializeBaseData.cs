using System;
using DiagnosisWorkstation.Model;
using DiagnosisWorkstation.ICode.Initialize;

namespace DiagnosisWorkstation.Code.Initialize
{
    public class InitializeData : IInitializeData
    {
        /// <summary>
        /// 绑定基础数据
        /// </summary>
        public void InitializeBaseData(string pathologyID, int roleID, string userName, string ckcode, string fullPath)
        {
            SystemSetting.RoleID = roleID;
            SystemSetting.UserName = userName;
            SystemSetting.Ckcode = ckcode;

            if (!string.IsNullOrEmpty(fullPath))
            {
                SystemSetting.FullPath = fullPath;
                //Environment.CurrentDirectory = fullPath;
            }
            else
            {
                SystemSetting.FullPath = "";
            }
        }
    }
}
