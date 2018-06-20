#region 系统
using System;
using System.Drawing;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing.Printing;
#endregion
#region 框架
using QpFormsControl;
using IBLL;
using BLL;
#endregion
#region 程序集
using DiagnosisWorkstation.Model;
using DiagnosisWorkstation.Menu.SystemSetting;
using DiagnosisWorkstation.Code.Helper;
using DiagnosisWorkstation.Code.Initialize;
using DiagnosisWorkstation.ICode.Initialize;
#endregion

namespace DiagnosisWorkstation
{
    public partial class MainForm : Form
    {
        #region 全局变量
        #region 实例化
        CaseList.UserControl1 m_CaseInfoCtrl;
        QpDengJiCtrl m_RegistedCtrl;

        IInitializeData m_IniData = new InitializeData();
        ConfigHelper m_Tool = new ConfigHelper();
        
        Thread m_MainThread;
        #endregion

        #region 变量
        bool m_IsRegistFirst = true;
        #endregion
        #endregion

        #region 构造函数
        public MainForm(string pathologyID, int roleID, string userName, string ckcode, string fullPath)
        {
            InitializeComponent();
            InitializeCaseInfoCtrl();
            InitializeRegistedCtrl();
            InitializeCytologyCtrl();
            InitializePrinter();
            m_IniData.InitializeBaseData(pathologyID, roleID, userName, ckcode, fullPath);
        }
        #endregion

        #region 初始化
        /// <summary>
        /// 初始化病例列表控件
        /// </summary>
        private void InitializeCaseInfoCtrl()
        {
            m_CaseInfoCtrl = new CaseList.UserControl1()
            {
                Dock = DockStyle.Fill,
                m_dyztfilter = "Status >= 256"
            };

            m_CaseInfoCtrl.AddRightMenu("All", "查询全部");
            m_CaseInfoCtrl.AddRightMenu("C", "批量审核");
            m_CaseInfoCtrl.AddRightMenu("P", "批量打印");
            m_CaseInfoCtrl.AddRightMenu("S", "批量发送");

            sceControls.Panel2.Controls.Add(m_CaseInfoCtrl);
        }

        /// <summary>
        /// 初始化登记控件
        /// </summary>
        private void InitializeRegistedCtrl()
        {
            m_RegistedCtrl = new QpDengJiCtrl("\\Registered\\dengji.html");
            m_RegistedCtrl.Dock = DockStyle.Fill;
            m_RegistedCtrl.BorderColor = Color.DarkGray;
            m_RegistedCtrl.Borderless = true;
            m_RegistedCtrl.BorderSize = 1;
            m_RegistedCtrl.Location = new Point(3, 3);
            m_RegistedCtrl.Name = "djPatientInfo";
            m_RegistedCtrl.NonclientModeDropShadow = true;
            m_RegistedCtrl.Resizable = false;
            m_RegistedCtrl.SplashBackColor = Color.Transparent;
            m_RegistedCtrl.SplashImage = null;
            m_RegistedCtrl.SplashImageLayout = ImageLayout.Tile;
            m_RegistedCtrl.IsSelect2Data = true;
            m_RegistedCtrl.IsTagging = true;

            tpRegisterPage.Controls.Add(m_RegistedCtrl);
        }

        /// <summary>
        /// 加载细胞学界面
        /// </summary>
        private void InitializeCytologyCtrl()
        {
            tsddbCytologyPageStyle.Text = "界面：" + SystemSetting.DefaultUI;
        }

        /// <summary>
        /// 绑定打印机
        /// </summary>
        public void InitializePrinter()
        {
            PrinterSettings.StringCollection printers = PrinterSettings.InstalledPrinters;

            foreach (string s in printers)
            {
                tsddbPrinter.DropDownItems.Add(s, null, new EventHandler(tsmiPrinter_Click));
            }

            if (!string.IsNullOrEmpty(SystemSetting.DefaultPrinterName))
            {
                tsddbPrinter.Text = "打印机：" + SystemSetting.DefaultPrinterName;
            }
            else
            {
                tsddbPrinter.Text = "打印机：" + printers[0];
            }
        }
        #endregion

        #region 事件
        #region 窗体
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            tcDiagnosis.SelectedIndex = 1;
        }

        /// <summary>
        /// 切换Tab页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tcDiagnosis_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = tcDiagnosis.SelectedIndex;
            if (index < 0)
            {
                return;
            }

            if (index == 0)
            {
                m_RegistedCtrl.Focus();
                if (m_IsRegistFirst)
                {
                    m_RegistedCtrl.CustomJS(m_RegistedCtrl.InitCalr());

                    m_IsRegistFirst = false;
                }
            }
            else if (index == 1)
            {

            }
            else if (index == 2)
            {

            }
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
        #endregion

        #region 用户控件
        #endregion

        #region 菜单栏
        /// <summary>
        /// 点击菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiMenu_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            string tag = tsmi.Tag.ToString();
            if(string.IsNullOrEmpty(tag))
            {
                return;
            }

            OpenFormOfMenu(tag);
        }
        #endregion

        #region 工具栏
        #endregion

        #region 状态栏
        /// <summary>
        /// 选择细胞学界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiCytologyUI_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            tsddbCytologyPageStyle.Text = "界面：" + tsmi.Text;

            m_Tool.SetAppConfig("DefaultUI", tsmi.Text);
        }

        /// <summary>
        /// 选择打印机
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiPrinter_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            tsddbPrinter.Text = "打印机：" + tsmi.Text;

            m_Tool.SetAppConfig("DefaultPrinter", tsmi.Text);
        }
        #endregion

        #endregion

        #region 函数
        /// <summary>
        /// 打开菜单功能
        /// </summary>
        /// <param name="tag"></param>
        private void OpenFormOfMenu(string tag)
        {
            switch (tag)
            {
                case "A":
                    break;
                case "U":
                    break;
                case "I":
                    break;
                case "D":
                    break;
                case "F":
                    break;
                case "T":
                    break;
                case "O":
                    frmOptionsForm operationForm = new frmOptionsForm
                    {
                        StartPosition = FormStartPosition.CenterParent
                    };
                    operationForm.ShowDialog();
                    break;
            }
        }
        #endregion
    }
}
