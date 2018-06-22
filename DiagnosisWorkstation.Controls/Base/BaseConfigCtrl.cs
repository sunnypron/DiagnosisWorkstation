using System.Windows.Forms;
using BLL;
using IBLL;

namespace DiagnosisWorkstation.Controls.Base
{
    public enum OperationType
    {
        Create = 0,
        Modify = 1
    }

    public partial class BaseConfigCtrl : UserControl
    {
        /// <summary>
        /// 操作類型
        /// </summary>
        public static OperationType OperationType { get; set; }

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

        public virtual void ShowInfo(string key)
        {
            // 子控件重写该方法
        }
    }
}
