using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using DCDapModel;

namespace DiagnosisWorkstation.Model
{
    public static class SystemSetting
    {
        #region 基本信息
        /// <summary>
        /// 工号
        /// </summary>
        public static string EmployeeId { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public static string UserName { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        public static int RoleId { get; set; }

        /// <summary>
        /// 校验码
        /// </summary>
        public static string Ckcode { get; set; }

        /// <summary>
        /// 用户角色
        /// </summary>
        public static Pitaya_Role Role { get; set; }

        /// <summary>
        /// 用户权限
        /// </summary>
        public static List<Pitaya_Permission> Permissions { get; set; }

        /// <summary>
        /// 默认打印机名
        /// </summary>
        public static string DefaultPrinterName
        {
            get
            {
                var list = ConfigurationManager.AppSettings.AllKeys.Where(k => k == "DefaultPrinter");
                return list.Any() ? ConfigurationManager.AppSettings["DefaultPrinter"] : string.Empty;
            }
        }

        /// <summary>
        /// 默认细胞学界面
        /// </summary>
        public static string DefaultUi
        {
            get
            {
                var list = ConfigurationManager.AppSettings.AllKeys.Where(k => k == "DefaultUI");
                return list.Any() ? ConfigurationManager.AppSettings["DefaultUI"] : string.Empty;
            }
        }

        /// <summary>
        /// 病理号
        /// </summary>
        public static string PathologyId { get; set; }

        /// <summary>
        /// 诊断级别
        /// </summary>
        public static string DiagnosisLevel { get; set; }

        /// <summary>
        /// 诊断编码
        /// </summary>
        public static string DiagnosisResultIndex { get; set; }

        /// <summary>
        /// 病例信息
        /// </summary>
        public static Pitaya Pitaya { get; set; }

        /// <summary>
        /// 冰冻报告编号
        /// </summary>
        public static int FrozenIndex { get; set; }

        /// <summary>
        /// 补充报告编号
        /// </summary>
        public static int AdditionalIndex { get; set; }

        /// <summary>
        /// 字典数组
        /// </summary>
        public static Pitaya_Dictionary[] PitayaDicts { get; set; }

        /// <summary>
        /// 库类别
        /// </summary>
        public static int DbType { get; set; }

        /// <summary>
        /// CA证书号
        /// </summary>
        public static string Caid { get; set; }

        /// <summary>
        /// 是否新建病例
        /// </summary>
        public static bool IsCreate
        {
            get
            {
                var i = Convert.ToInt32(ConfigurationManager.AppSettings["IsCreate"]);

                return i != 0;
            }
        }

        /// <summary>
        /// 接口路径
        /// </summary>
        public static string InterFacePath
        {
            get
            {
                return ConfigurationManager.AppSettings["InterFacePath"];
            }
        }

        /// <summary>
        /// 是否自动填写诊断医生
        /// </summary>
        public static bool IsWriteDiagDr
        {
            get
            {
                int i = int.Parse(ConfigurationManager.AppSettings["IsWriteDiagDr"]);
                if (i == 0)
                {
                    return false;
                }

                return true;
            }
        }

        /// <summary>
        /// 是否打印并发送
        /// </summary>
        public static bool IsPrintSend
        {
            get
            {
                int i = int.Parse(ConfigurationManager.AppSettings["IsPrintSend"]);
                if (i == 0)
                {
                    return false;
                }

                return true;
            }
        }

        /// <summary>
        /// 项目路径名
        /// </summary>
        public static string FullPath { get; set; }
        #endregion

        #region 图像信息
        /// <summary>
        /// 获取图像路径
        /// </summary>
        public static string PicturePath => ConfigurationManager.AppSettings["PictPath"];

        /// <summary>
        /// 图片字典
        /// </summary>
        public static Dictionary<string[], Image> DicImage { get; set; }

        /// <summary>
        /// 图像类型
        /// </summary>
        public static string ImgType => ConfigurationManager.AppSettings["ImgType"];

        /// <summary>
        /// 图像存储模式
        /// </summary>
        public static string ImgSaveMode => ConfigurationManager.AppSettings["ImgSaveMode"];

        /// <summary>
        /// 创建GUID编码
        /// </summary>
        public static string ImgGuid
        {
            get
            {
                return Guid.NewGuid().ToString();
            }
        }

        /// <summary>
        /// 勾选图片的列表
        /// </summary>
        public static string[] SelectedPicItems { get; set; }

        /// <summary>
        /// 所有已勾选图像的病例集合
        /// </summary>
        public static Dictionary<string, string[]> PicItemsDict { get; set; }
        #endregion

        #region 共享目录信息
        /// <summary>
        /// 共享目录的连接状态
        /// </summary>
        public static bool ShareConnState { get; set; }

        /// <summary>
        /// 共享目录路径
        /// </summary>
        public static string ShareDirPath => ConfigurationManager.AppSettings["ShareDirPath"];

        /// <summary>
        /// 共享目录登录账号
        /// </summary>
        public static string ShareUserName => ConfigurationManager.AppSettings["ShareUserName"];

        /// <summary>
        /// 共享目录登录密码
        /// </summary>
        public static string SharePassword => ConfigurationManager.AppSettings["SharePassword"];

        /// <summary>
        /// 登记时间
        /// </summary>
        public static DateTime RegDate { get; set; }
        #endregion

        #region FTP信息
        /// <summary>
        /// FTP服务器IP地址
        /// </summary>
        public static string FtpIp => ConfigurationManager.AppSettings["FtpIp"];

        /// <summary>
        /// FTP服务器端口号
        /// </summary>
        public static string FtpPort => ConfigurationManager.AppSettings["FtpPort"];

        /// <summary>
        /// FTP服务器用户名
        /// </summary>
        public static string FtpUid => ConfigurationManager.AppSettings["FtpUid"];

        /// <summary>
        /// FTP服务器密码
        /// </summary>
        public static string FtpPwd => ConfigurationManager.AppSettings["FtpPwd"];

        /// <summary>
        /// FTP服务器路径
        /// </summary>
        public static string FtpUri { get; set; }

        /// <summary>
        /// FTP主目录
        /// </summary>
        public static string FtpMainPath => ConfigurationManager.AppSettings["FtpMainPath"];

        /// <summary>
        /// FTP存放路径
        /// </summary>
        public static string FtpRemotePath { get; set; }
        #endregion

        #region 设备
        /// <summary>
        /// 摄像头驱动
        /// </summary>
        public static string CamaraDriver => ConfigurationManager.AppSettings["CamaraDriver"];

        /// <summary>
        /// 设备是否启动
        /// </summary>
        public static bool IsImageTag { get; set; }

        /// <summary>
        /// 图像设备类型
        /// </summary>
        public static string CamaraType => ConfigurationManager.AppSettings["CamaraType"];

        /// <summary>
        /// DSHOW设备名称
        /// </summary>
        public static string DShowName => ConfigurationManager.AppSettings["DShowName"];

        #endregion
    }
}
