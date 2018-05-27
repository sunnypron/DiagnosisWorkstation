using DCHTMUI;
using System;
using System.IO;
using System.Windows.Forms;

namespace DiagnosisWorkstation
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] argArray)
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                HtmlUILauncher.EnableFlashSupport = false;
                if (HtmlUILauncher.InitializeChromium((args =>
                {
                    args.Settings.LogSeverity = Chromium.CfxLogSeverity.Default;
                })))
                {
                    //初始化成功，加载程序集内嵌的资源到运行时中
                    HtmlUILauncher.RegisterEmbeddedScheme(System.Reflection.Assembly.GetExecutingAssembly());
                    if (argArray.Length > 0)
                    {
                        Application.Run(new MainForm(argArray[3], int.Parse(argArray[7]), argArray[5], argArray[9], argArray[11]));
                    }
                    else
                    {
                        Application.Run(new MainForm("", 1, "admin", "", "D:\\Projects\\Visual Studio 2017\\Sources\\Workspaces\\DiagnosisWorkstation\\DiagnosisWorkstation\\bin\\Debug"));
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("相关文件不存在：\r" + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
