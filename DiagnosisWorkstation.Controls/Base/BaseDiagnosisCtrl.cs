using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiagnosisWorkstation.Controls.Base
{
    public partial class BaseDiagnosisCtrl : UserControl
    {
        public BaseDiagnosisCtrl()
        {
            InitializeComponent();
        }

        public virtual void Initialization()
        {
            // 子控件重写此方法
        }

        public virtual void Save()
        {
            // 子控件重写此方法
        }

        public virtual void BindData()
        {
            // 子控件重写此方法
        }

        public virtual void BindDict()
        {
            // 子控件重写此方法
        }

        public virtual void BindReportFormat()
        {
            // 子控件重写此方法
        }

        public virtual void RefreshMsgInfo()
        {
            // 子控件重写此方法
        }

        public virtual void SaveDesabled()
        {
            // 子控件重写此方法
        }

        public virtual void SaveEnabled()
        {
            // 子控件重写此方法
        }
    }
}
