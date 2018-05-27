using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiagnosisWorkstation.Controls.Base;
using DiagnosisWorkstation.Controls.Option;

namespace DiagnosisWorkstation.Menu.SystemSetting
{
    public partial class frmOptionsForm : Form
    {
        #region 全局变量
        #region 实例化
        BaseConfigCtrl m_UserControl;
        #endregion

        #region 变量
        #endregion
        #endregion

        public frmOptionsForm()
        {
            InitializeComponent();
        }

        #region 事件
        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            m_UserControl.Save();

            if (MessageBox.Show("设置完成，部分设置需要重启工作站启用，是否重新启动？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Close();
            }

        }

        /// <summary>
        /// 选择节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvDirectory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode tn = e.Node;

            string name = tn.Name;
            BindUserControl(name);
        }
        #endregion

        #region 函数
        /// <summary>
        /// 绑定用户控件至界面
        /// </summary>
        /// <param name="name">点击的节点名称</param>
        private void BindUserControl(string name)
        {
            switch (name)
            {
                case "System":
                case "General":
                    if (m_UserControl != null && m_UserControl.GetType() == typeof(UcGeneralCtrl))
                    {
                        return;
                    }

                    if (pnlControl.Controls.Count > 0)
                    {
                        pnlControl.Controls.Remove(m_UserControl);
                    }

                    m_UserControl = new UcGeneralCtrl
                    {
                        Dock = DockStyle.Fill
                    };
                    break;
                case "DataBase":
                    if (pnlControl.Controls.Count > 0)
                    {
                        pnlControl.Controls.Remove(m_UserControl);
                    }

                    m_UserControl = new UcDataBaseCtrl
                    {
                        Dock = DockStyle.Fill
                    };
                    break;
                case "Save":
                case "ShareDirectory":
                    if (pnlControl.Controls.Count > 0)
                    {
                        pnlControl.Controls.Remove(m_UserControl);
                    }

                    m_UserControl = null;
                    break;
                case "FTP":
                    if (pnlControl.Controls.Count > 0)
                    {
                        pnlControl.Controls.Remove(m_UserControl);
                    }

                    m_UserControl = null;
                    break;
                case "Pictures":
                case "PictureInfo":
                    if (pnlControl.Controls.Count > 0)
                    {
                        pnlControl.Controls.Remove(m_UserControl);
                    }

                    m_UserControl = null;
                    break;
                case "Hardware":
                case "Imaging":
                    if (pnlControl.Controls.Count > 0)
                    {
                        pnlControl.Controls.Remove(m_UserControl);
                    }

                    m_UserControl = null;
                    break;
            }

            if (m_UserControl != null)
            {
                pnlControl.Controls.Add(m_UserControl);

                m_UserControl.ReadConfig();
            }
        }
        #endregion
    }
}
