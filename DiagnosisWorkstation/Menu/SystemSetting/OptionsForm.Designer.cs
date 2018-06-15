namespace DiagnosisWorkstation.Menu.SystemSetting
{
    partial class frmOptionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("常规");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("数据库");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("用户");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("系统", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("共享目录");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("FTP服务器");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("存储", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("图像信息");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("图像", new System.Windows.Forms.TreeNode[] {
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("图像设备");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("设备", new System.Windows.Forms.TreeNode[] {
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("快速录入");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("选择项");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("操作", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOptionsForm));
            this.tvDirectory = new System.Windows.Forms.TreeView();
            this.tlpOptions = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTreeView = new System.Windows.Forms.Panel();
            this.tlpContent = new System.Windows.Forms.TableLayoutPanel();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tlpOptions.SuspendLayout();
            this.pnlTreeView.SuspendLayout();
            this.tlpContent.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvDirectory
            // 
            this.tvDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvDirectory.Location = new System.Drawing.Point(0, 0);
            this.tvDirectory.Name = "tvDirectory";
            treeNode1.Name = "General";
            treeNode1.Text = "常规";
            treeNode2.Name = "DataBase";
            treeNode2.Text = "数据库";
            treeNode3.Name = "Users";
            treeNode3.Text = "用户";
            treeNode4.Name = "System";
            treeNode4.Text = "系统";
            treeNode5.Name = "ShareDirectory";
            treeNode5.Text = "共享目录";
            treeNode6.Name = "FTP";
            treeNode6.Text = "FTP服务器";
            treeNode7.Name = "Save";
            treeNode7.Text = "存储";
            treeNode8.Name = "PictureInfo";
            treeNode8.Text = "图像信息";
            treeNode9.Name = "Pictures";
            treeNode9.Text = "图像";
            treeNode10.Name = "Imaging";
            treeNode10.Text = "图像设备";
            treeNode11.Name = "Hardware";
            treeNode11.Text = "设备";
            treeNode12.Name = "QuickInput";
            treeNode12.Text = "快速录入";
            treeNode13.Name = "SelectedItems";
            treeNode13.Text = "选择项";
            treeNode14.Name = "Operation";
            treeNode14.Text = "操作";
            this.tvDirectory.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7,
            treeNode9,
            treeNode11,
            treeNode14});
            this.tvDirectory.Size = new System.Drawing.Size(216, 645);
            this.tvDirectory.TabIndex = 0;
            this.tvDirectory.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDirectory_AfterSelect);
            // 
            // tlpOptions
            // 
            this.tlpOptions.ColumnCount = 2;
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5641F));
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.4359F));
            this.tlpOptions.Controls.Add(this.pnlTreeView, 0, 0);
            this.tlpOptions.Controls.Add(this.tlpContent, 1, 0);
            this.tlpOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOptions.Location = new System.Drawing.Point(0, 0);
            this.tlpOptions.Name = "tlpOptions";
            this.tlpOptions.RowCount = 1;
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOptions.Size = new System.Drawing.Size(984, 651);
            this.tlpOptions.TabIndex = 1;
            // 
            // pnlTreeView
            // 
            this.pnlTreeView.Controls.Add(this.tvDirectory);
            this.pnlTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTreeView.Location = new System.Drawing.Point(3, 3);
            this.pnlTreeView.Name = "pnlTreeView";
            this.pnlTreeView.Size = new System.Drawing.Size(216, 645);
            this.pnlTreeView.TabIndex = 0;
            // 
            // tlpContent
            // 
            this.tlpContent.ColumnCount = 1;
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContent.Controls.Add(this.pnlControl, 0, 0);
            this.tlpContent.Controls.Add(this.tlpButtons, 0, 1);
            this.tlpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContent.Location = new System.Drawing.Point(225, 3);
            this.tlpContent.Name = "tlpContent";
            this.tlpContent.RowCount = 2;
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpContent.Size = new System.Drawing.Size(756, 645);
            this.tlpContent.TabIndex = 1;
            // 
            // pnlControl
            // 
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControl.Location = new System.Drawing.Point(3, 3);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(750, 604);
            this.pnlControl.TabIndex = 1;
            this.pnlControl.TabStop = true;
            // 
            // tlpButtons
            // 
            this.tlpButtons.ColumnCount = 4;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpButtons.Controls.Add(this.btnExit, 3, 0);
            this.tlpButtons.Controls.Add(this.btnSave, 1, 0);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtons.Location = new System.Drawing.Point(3, 613);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(750, 29);
            this.tlpButtons.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.Location = new System.Drawing.Point(683, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(64, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(605, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 651);
            this.Controls.Add(this.tlpOptions);
            this.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(675, 490);
            this.Name = "frmOptionsForm";
            this.Text = "选项";
            this.tlpOptions.ResumeLayout(false);
            this.pnlTreeView.ResumeLayout(false);
            this.tlpContent.ResumeLayout(false);
            this.tlpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvDirectory;
        private System.Windows.Forms.TableLayoutPanel tlpOptions;
        private System.Windows.Forms.Panel pnlTreeView;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
    }
}