using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DCDapModel;
using DiagnosisWorkstation.Controls.Base;
using IBLL;
using BLL;

namespace DiagnosisWorkstation.Controls.Users
{
    public partial class UcUserInfoCtrl : BaseConfigCtrl
    {
        private ICRUDBLL m_CrudBll = new CRUDBLL();
        public UcUserInfoCtrl()
        {
            InitializeComponent();
        }

        #region 事件
        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            CreateUser();
        }
        #endregion

        #region 函數
        /// <summary>
        /// 保存
        /// </summary>
        public override void Save()
        {
            try
            {

            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 創建用戶
        /// </summary>
        public void CreateUser()
        {
            var users = m_CrudBll.GetDataList<UserUser>().ToList();
            if (users.Count == 0)
            {
                txtUserCode.Text = @"001";
            }
            else
            {
                
            }
        }
        #endregion
    }
}
