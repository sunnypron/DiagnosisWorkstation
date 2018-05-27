using DCDapModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;

namespace DiagnosisWorkstation.Model
{
    public static class SystemSetting
    {
        #region 基本信息
        /// <summary>
        /// 工号
        /// </summary>
        public static string EmployeeID { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public static string UserName { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        public static int RoleID { get; set; }

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
                if (list.Count() > 0)
                {
                    return ConfigurationManager.AppSettings["DefaultPrinter"].ToString();
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        /// <summary>
        /// 默认细胞学界面
        /// </summary>
        public static string DefaultUI
        {
            get
            {
                var list = ConfigurationManager.AppSettings.AllKeys.Where(k => k == "DefaultUI");
                if (list.Count() > 0)
                {
                    return ConfigurationManager.AppSettings["DefaultUI"].ToString();
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        /// <summary>
        /// 病理号
        /// </summary>
        public static string PathologyID { get; set; }

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
        public static string CAID { get; set; }

        /// <summary>
        /// 是否新建病例
        /// </summary>
        public static bool IsCreate
        {
            get
            {
                int i = Convert.ToInt32(ConfigurationManager.AppSettings["IsCreate"]);

                if (i == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
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
                else
                {
                    return true;
                }
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
                else
                {
                    return true;
                }
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
        public static string PicturePath
        {
            get
            {
                return ConfigurationManager.AppSettings["PictPath"].ToString();
            }
        }

        /// <summary>
        /// 图片字典
        /// </summary>
        public static Dictionary<string[], Image> DicImage { get; set; }

        /// <summary>
        /// 图像类型
        /// </summary>
        public static string ImgType
        {
            get
            {
                try
                {
                    return ConfigurationManager.AppSettings["ImgType"].ToString();
                }
                catch (NullReferenceException)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// 图像存储模式
        /// </summary>
        public static string ImgSaveMode
        {
            get
            {
                try
                {
                    return ConfigurationManager.AppSettings["ImgSaveMode"].ToString();
                }
                catch (NullReferenceException)
                {
                    throw;
                }
            }
        }

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
        public static string ShareDirPath
        {
            get
            {
                try
                {
                    return ConfigurationManager.AppSettings["ShareDirPath"].ToString();
                }
                catch (NullReferenceException)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// 共享目录登录账号
        /// </summary>
        public static string ShareUserName
        {
            get
            {
                try
                {
                    return ConfigurationManager.AppSettings["ShareUserName"].ToString();
                }
                catch (NullReferenceException)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// 共享目录登录密码
        /// </summary>
        public static string SharePassword
        {
            get
            {
                try
                {
                    return ConfigurationManager.AppSettings["SharePassword"].ToString();
                }
                catch (NullReferenceException)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// 登记时间
        /// </summary>
        public static DateTime RegDate { get; set; }
        #endregion

        #region FTP信息
        /// <summary>
        /// FTP服务器IP地址
        /// </summary>
        public static string FtpIp
        {
            get
            {
                try
                {
                    return ConfigurationManager.AppSettings["FtpIp"].ToString();
                }
                catch (NullReferenceException ex)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// FTP服务器端口号
        /// </summary>
        public static string FtpPort
        {
            get
            {
                try
                {
                    return ConfigurationManager.AppSettings["FtpPort"].ToString();
                }
                catch (NullReferenceException)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// FTP服务器用户名
        /// </summary>
        public static string FtpUid
        {
            get
            {
                try
                {
                    return ConfigurationManager.AppSettings["FtpUid"].ToString();
                }
                catch (NullReferenceException)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// FTP服务器密码
        /// </summary>
        public static string FtpPwd
        {
            get
            {
                try
                {
                    return ConfigurationManager.AppSettings["FtpPwd"].ToString();
                }
                catch (NullReferenceException)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// FTP服务器路径
        /// </summary>
        public static string FtpUri { get; set; }

        /// <summary>
        /// FTP主目录
        /// </summary>
        public static string FtpMainPath
        {
            get
            {
                try
                {
                    return ConfigurationManager.AppSettings["FtpMainPath"].ToString();
                }
                catch (NullReferenceException)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// FTP存放路径
        /// </summary>
        public static string FtpRemotePath { get; set; }
        #endregion

        #region 设备
        /// <summary>
        /// 摄像头驱动
        /// </summary>
        public static string CamaraDriver
        {
            get
            {
                try
                {
                    return ConfigurationManager.AppSettings["CamaraDriver"];
                }
                catch (NullReferenceException)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// 设备是否启动
        /// </summary>
        public static bool IsImageTag { get; set; }

        /// <summary>
        /// 图像设备类型
        /// </summary>
        public static string CamaraType
        {
            get
            {
                try
                {
                    return ConfigurationManager.AppSettings["CamaraType"];
                }
                catch (NullReferenceException)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// DSHOW设备名称
        /// </summary>
        public static string DShowName
        {
            get
            {
                try
                {
                    return ConfigurationManager.AppSettings["DShowName"];
                }
                catch (NullReferenceException)
                {
                    throw;
                }
            }
        }

        #endregion
    }
}
