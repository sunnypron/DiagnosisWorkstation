using DiagnosisWorkstation.Model;
using DiagnosisWorkstation.ICode.Initialize;

namespace DiagnosisWorkstation.Code.Initialize
{
    public class InitializeData : IInitializeData
    {
        /// <summary>
        /// 绑定基础数据
        /// </summary>
        public void InitializeBaseData(string pathologyId, int roleId, string userName, string ckcode, string fullPath)
        {
            SystemSetting.RoleId = roleId;
            SystemSetting.UserName = userName;
            SystemSetting.Ckcode = ckcode;

            SystemSetting.FullPath = !string.IsNullOrEmpty(fullPath) ? fullPath : "";
        }
    }
}
