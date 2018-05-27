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
    public partial class BaseConfigCtrl : UserControl
    {
        public BaseConfigCtrl()
        {
            InitializeComponent();
        }

        public virtual void Save()
        {
            // 子控件重写该方法
        }

        public virtual void ReadConfig()
        {
            // 子控件重写该方法
        }
    }
}
