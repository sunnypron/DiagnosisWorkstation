using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiagnosisWorkstation.Controls.Base;
using DiagnosisWorkstation.ICode.Helper;
using DiagnosisWorkstation.Code.Helper;

namespace DiagnosisWorkstation.Controls.Option
{
    public partial class UcGeneralCtrl : BaseConfigCtrl
    {
        IConfigHelper m_Tool = new ConfigHelper();
        public UcGeneralCtrl()
        {
            InitializeComponent();
        }

        #region 事件
        int times = 0;
        private void cbQuickActions_CheckedChanged(object sender, EventArgs e)
        {
            times += 1;

            CheckBox cb = (CheckBox)sender;
            string tag = cb.Tag.ToString();

            if (times > 1)
            {
                return;
            }

            if (tag == "1")
            {
                if (cb.Checked)
                {
                    cbCreateCase.Checked = true;
                    cbPrintSend.Checked = true;
                    cbWriteDoctor.Checked = true;
                }
                else
                {
                    cbCreateCase.Checked = false;
                    cbPrintSend.Checked = false;
                    cbWriteDoctor.Checked = false;
                }
            }
            else if (tag == "2")
            {
                if (!cbCreateCase.Checked &&
                    !cbWriteDoctor.Checked &&
                    !cbPrintSend.Checked)
                {
                    cbAll.CheckState = CheckState.Unchecked;
                    cbAll.Checked = false;
                }
                else if (cbCreateCase.Checked &&
                    cbWriteDoctor.Checked &&
                    cbPrintSend.Checked)
                {
                    cbAll.CheckState = CheckState.Checked;
                    cbAll.Checked = true;
                }
                else if (!cbCreateCase.Checked ||
                    !cbWriteDoctor.Checked ||
                    !cbPrintSend.Checked)
                {
                    cbAll.CheckState = CheckState.Indeterminate;
                }
            }

            times = 0;
        }

        /// <summary>
        /// 浏览主程序文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFolderBrowser_Click(object sender, EventArgs e)
        {
            if (fbdFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                Button btn = (Button)sender;

                string path = fbdFolderBrowser.SelectedPath;

                string tag = btn.Tag.ToString();
                if (tag == "interface")
                {
                    txtInterfacePath.Text = path;
                }
                else if (tag == "image")
                {
                    txtImagePath.Text = path;
                }
            }
        }
        #endregion

        #region 函数
        /// <summary>
        /// 保存设置
        /// </summary>
        public override void Save()
        {
            string createCase = "0";
            if (cbCreateCase.Checked)
            {
                createCase = "1";
            }
            m_Tool.SetAppConfig("IsCreate", createCase);

            string writeDr = "0";
            if (cbWriteDoctor.Checked)
            {
                writeDr = "1";
            }
            m_Tool.SetAppConfig("IsWriteDiagDr", writeDr);

            string printSend = "0";
            if (cbPrintSend.Checked)
            {
                printSend = "1";
            }
            m_Tool.SetAppConfig("IsPrintSend", printSend);

            if (!string.IsNullOrEmpty(txtInterfacePath.Text.Trim()))
            {
                m_Tool.SetAppConfig("InterFacePath", txtInterfacePath.Text.Trim());
            }

            if(!string.IsNullOrEmpty(txtImagePath.Text.Trim()))
            {
                m_Tool.SetAppConfig("PictPath", txtImagePath.Text.Trim());
            }
        }

        /// <summary>
        /// 读取设置
        /// </summary>
        public override void ReadConfig()
        {
            string createCase = m_Tool.GetAppConfig("IsCreate");
            if (createCase == "1")
            {
                cbCreateCase.Checked = true;
            }
            else
            {
                cbCreateCase.Checked = false;
            }

            string writeDr = m_Tool.GetAppConfig("IsWriteDiagDr");
            if (writeDr == "1")
            {
                cbWriteDoctor.Checked = true;
            }
            else
            {
                cbWriteDoctor.Checked = false;
            }

            string printSend = m_Tool.GetAppConfig("IsPrintSend");
            if (printSend == "1")
            {
                cbPrintSend.Checked = true;
            }
            else
            {
                cbPrintSend.Checked = false;
            }

            txtInterfacePath.Text = m_Tool.GetAppConfig("InterFacePath");
            txtImagePath.Text = m_Tool.GetAppConfig("PictPath");
        }
        #endregion
    }
}
