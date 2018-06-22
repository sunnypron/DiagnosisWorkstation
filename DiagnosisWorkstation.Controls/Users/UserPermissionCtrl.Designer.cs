namespace DiagnosisWorkstation.Controls.Users
{
    partial class UcUserPermissionCtrl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpUsers = new System.Windows.Forms.TableLayoutPanel();
            this.tlpUserList = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSearch = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSearchLabel = new System.Windows.Forms.Panel();
            this.lblSearchKey = new System.Windows.Forms.Label();
            this.pnlSearchContent = new System.Windows.Forms.Panel();
            this.txtKeyContent = new System.Windows.Forms.TextBox();
            this.lbList = new System.Windows.Forms.ListBox();
            this.tlpContent = new System.Windows.Forms.TableLayoutPanel();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.tlpRbac = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTypes = new System.Windows.Forms.Panel();
            this.rbPermissionInfo = new System.Windows.Forms.RadioButton();
            this.rbRoleInfo = new System.Windows.Forms.RadioButton();
            this.rbUserInfo = new System.Windows.Forms.RadioButton();
            this.tlpUsers.SuspendLayout();
            this.tlpUserList.SuspendLayout();
            this.tlpSearch.SuspendLayout();
            this.pnlSearchLabel.SuspendLayout();
            this.pnlSearchContent.SuspendLayout();
            this.tlpContent.SuspendLayout();
            this.tlpRbac.SuspendLayout();
            this.pnlTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpUsers
            // 
            this.tlpUsers.ColumnCount = 2;
            this.tlpUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.97897F));
            this.tlpUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.02103F));
            this.tlpUsers.Controls.Add(this.tlpUserList, 0, 0);
            this.tlpUsers.Controls.Add(this.tlpContent, 1, 0);
            this.tlpUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUsers.Location = new System.Drawing.Point(3, 46);
            this.tlpUsers.Name = "tlpUsers";
            this.tlpUsers.RowCount = 1;
            this.tlpUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 735F));
            this.tlpUsers.Size = new System.Drawing.Size(1189, 735);
            this.tlpUsers.TabIndex = 0;
            // 
            // tlpUserList
            // 
            this.tlpUserList.ColumnCount = 1;
            this.tlpUserList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUserList.Controls.Add(this.tlpSearch, 0, 0);
            this.tlpUserList.Controls.Add(this.lbList, 0, 1);
            this.tlpUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUserList.Location = new System.Drawing.Point(3, 3);
            this.tlpUserList.Name = "tlpUserList";
            this.tlpUserList.RowCount = 2;
            this.tlpUserList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpUserList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUserList.Size = new System.Drawing.Size(290, 729);
            this.tlpUserList.TabIndex = 1;
            // 
            // tlpSearch
            // 
            this.tlpSearch.ColumnCount = 2;
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearch.Controls.Add(this.pnlSearchLabel, 0, 0);
            this.tlpSearch.Controls.Add(this.pnlSearchContent, 1, 0);
            this.tlpSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearch.Location = new System.Drawing.Point(3, 3);
            this.tlpSearch.Name = "tlpSearch";
            this.tlpSearch.RowCount = 1;
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearch.Size = new System.Drawing.Size(284, 31);
            this.tlpSearch.TabIndex = 0;
            // 
            // pnlSearchLabel
            // 
            this.pnlSearchLabel.Controls.Add(this.lblSearchKey);
            this.pnlSearchLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearchLabel.Location = new System.Drawing.Point(3, 3);
            this.pnlSearchLabel.Name = "pnlSearchLabel";
            this.pnlSearchLabel.Size = new System.Drawing.Size(98, 25);
            this.pnlSearchLabel.TabIndex = 0;
            // 
            // lblSearchKey
            // 
            this.lblSearchKey.AutoSize = true;
            this.lblSearchKey.Location = new System.Drawing.Point(3, 3);
            this.lblSearchKey.Name = "lblSearchKey";
            this.lblSearchKey.Size = new System.Drawing.Size(91, 14);
            this.lblSearchKey.TabIndex = 0;
            this.lblSearchKey.Text = "名称或编号：";
            // 
            // pnlSearchContent
            // 
            this.pnlSearchContent.Controls.Add(this.txtKeyContent);
            this.pnlSearchContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearchContent.Location = new System.Drawing.Point(107, 3);
            this.pnlSearchContent.Name = "pnlSearchContent";
            this.pnlSearchContent.Size = new System.Drawing.Size(174, 25);
            this.pnlSearchContent.TabIndex = 1;
            // 
            // txtKeyContent
            // 
            this.txtKeyContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKeyContent.Location = new System.Drawing.Point(0, 0);
            this.txtKeyContent.Name = "txtKeyContent";
            this.txtKeyContent.Size = new System.Drawing.Size(174, 23);
            this.txtKeyContent.TabIndex = 0;
            // 
            // lbList
            // 
            this.lbList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbList.FormattingEnabled = true;
            this.lbList.ItemHeight = 14;
            this.lbList.Location = new System.Drawing.Point(3, 40);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(284, 686);
            this.lbList.TabIndex = 1;
            this.lbList.SelectedIndexChanged += new System.EventHandler(this.lbList_SelectedIndexChanged);
            // 
            // tlpContent
            // 
            this.tlpContent.ColumnCount = 1;
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContent.Controls.Add(this.pnlInfo, 0, 1);
            this.tlpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContent.Location = new System.Drawing.Point(299, 3);
            this.tlpContent.Name = "tlpContent";
            this.tlpContent.RowCount = 2;
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContent.Size = new System.Drawing.Size(887, 729);
            this.tlpContent.TabIndex = 2;
            // 
            // pnlInfo
            // 
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInfo.Location = new System.Drawing.Point(3, 40);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(881, 686);
            this.pnlInfo.TabIndex = 2;
            // 
            // tlpRbac
            // 
            this.tlpRbac.AutoScroll = true;
            this.tlpRbac.ColumnCount = 1;
            this.tlpRbac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRbac.Controls.Add(this.tlpUsers, 0, 1);
            this.tlpRbac.Controls.Add(this.pnlTypes, 0, 0);
            this.tlpRbac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRbac.Location = new System.Drawing.Point(0, 0);
            this.tlpRbac.Name = "tlpRbac";
            this.tlpRbac.RowCount = 2;
            this.tlpRbac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlpRbac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRbac.Size = new System.Drawing.Size(1195, 784);
            this.tlpRbac.TabIndex = 1;
            // 
            // pnlTypes
            // 
            this.pnlTypes.Controls.Add(this.rbPermissionInfo);
            this.pnlTypes.Controls.Add(this.rbRoleInfo);
            this.pnlTypes.Controls.Add(this.rbUserInfo);
            this.pnlTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTypes.Location = new System.Drawing.Point(3, 3);
            this.pnlTypes.Name = "pnlTypes";
            this.pnlTypes.Size = new System.Drawing.Size(1189, 37);
            this.pnlTypes.TabIndex = 1;
            // 
            // rbPermissionInfo
            // 
            this.rbPermissionInfo.AutoSize = true;
            this.rbPermissionInfo.Location = new System.Drawing.Point(183, 9);
            this.rbPermissionInfo.Name = "rbPermissionInfo";
            this.rbPermissionInfo.Size = new System.Drawing.Size(81, 18);
            this.rbPermissionInfo.TabIndex = 2;
            this.rbPermissionInfo.TabStop = true;
            this.rbPermissionInfo.Text = "权限信息";
            this.rbPermissionInfo.UseVisualStyleBackColor = true;
            this.rbPermissionInfo.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rbRoleInfo
            // 
            this.rbRoleInfo.AutoSize = true;
            this.rbRoleInfo.Location = new System.Drawing.Point(96, 9);
            this.rbRoleInfo.Name = "rbRoleInfo";
            this.rbRoleInfo.Size = new System.Drawing.Size(81, 18);
            this.rbRoleInfo.TabIndex = 1;
            this.rbRoleInfo.TabStop = true;
            this.rbRoleInfo.Text = "角色信息";
            this.rbRoleInfo.UseVisualStyleBackColor = true;
            this.rbRoleInfo.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rbUserInfo
            // 
            this.rbUserInfo.AutoSize = true;
            this.rbUserInfo.Location = new System.Drawing.Point(9, 9);
            this.rbUserInfo.Name = "rbUserInfo";
            this.rbUserInfo.Size = new System.Drawing.Size(81, 18);
            this.rbUserInfo.TabIndex = 0;
            this.rbUserInfo.TabStop = true;
            this.rbUserInfo.Text = "用户信息";
            this.rbUserInfo.UseVisualStyleBackColor = true;
            this.rbUserInfo.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // UcUserPermissionCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpRbac);
            this.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Name = "UcUserPermissionCtrl";
            this.Size = new System.Drawing.Size(1195, 784);
            this.tlpUsers.ResumeLayout(false);
            this.tlpUserList.ResumeLayout(false);
            this.tlpSearch.ResumeLayout(false);
            this.pnlSearchLabel.ResumeLayout(false);
            this.pnlSearchLabel.PerformLayout();
            this.pnlSearchContent.ResumeLayout(false);
            this.pnlSearchContent.PerformLayout();
            this.tlpContent.ResumeLayout(false);
            this.tlpRbac.ResumeLayout(false);
            this.pnlTypes.ResumeLayout(false);
            this.pnlTypes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpUsers;
        private System.Windows.Forms.Panel pnlSearchLabel;
        private System.Windows.Forms.TableLayoutPanel tlpUserList;
        private System.Windows.Forms.Label lblSearchKey;
        private System.Windows.Forms.TableLayoutPanel tlpSearch;
        private System.Windows.Forms.Panel pnlSearchContent;
        private System.Windows.Forms.TextBox txtKeyContent;
        private System.Windows.Forms.ListBox lbList;
        private System.Windows.Forms.TableLayoutPanel tlpRbac;
        private System.Windows.Forms.Panel pnlTypes;
        private System.Windows.Forms.RadioButton rbUserInfo;
        private System.Windows.Forms.RadioButton rbRoleInfo;
        private System.Windows.Forms.RadioButton rbPermissionInfo;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
    }
}
