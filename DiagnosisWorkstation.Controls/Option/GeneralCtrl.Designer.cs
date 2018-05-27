namespace DiagnosisWorkstation.Controls.Option
{
    partial class UcGeneralCtrl
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
            this.tlpGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.gbQuickActions = new System.Windows.Forms.GroupBox();
            this.cbAll = new System.Windows.Forms.CheckBox();
            this.cbPrintSend = new System.Windows.Forms.CheckBox();
            this.cbWriteDoctor = new System.Windows.Forms.CheckBox();
            this.cbCreateCase = new System.Windows.Forms.CheckBox();
            this.tlpInterfacePath = new System.Windows.Forms.TableLayoutPanel();
            this.pnlInterfacePath = new System.Windows.Forms.Panel();
            this.lblInterfacePath = new System.Windows.Forms.Label();
            this.pnlShowInterfacePath = new System.Windows.Forms.Panel();
            this.btnFolderBrowser = new System.Windows.Forms.Button();
            this.pnlWriteInterfacePath = new System.Windows.Forms.Panel();
            this.txtInterfacePath = new System.Windows.Forms.TextBox();
            this.tlpImagePath = new System.Windows.Forms.TableLayoutPanel();
            this.pnlImagePath = new System.Windows.Forms.Panel();
            this.lblImagePath = new System.Windows.Forms.Label();
            this.pnlWriteImagePath = new System.Windows.Forms.Panel();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.pnlShowImagePath = new System.Windows.Forms.Panel();
            this.btnImagePath = new System.Windows.Forms.Button();
            this.fbdFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.tlpGeneral.SuspendLayout();
            this.gbQuickActions.SuspendLayout();
            this.tlpInterfacePath.SuspendLayout();
            this.pnlInterfacePath.SuspendLayout();
            this.pnlShowInterfacePath.SuspendLayout();
            this.pnlWriteInterfacePath.SuspendLayout();
            this.tlpImagePath.SuspendLayout();
            this.pnlImagePath.SuspendLayout();
            this.pnlWriteImagePath.SuspendLayout();
            this.pnlShowImagePath.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpGeneral
            // 
            this.tlpGeneral.ColumnCount = 1;
            this.tlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGeneral.Controls.Add(this.gbQuickActions, 0, 0);
            this.tlpGeneral.Controls.Add(this.tlpInterfacePath, 0, 1);
            this.tlpGeneral.Controls.Add(this.tlpImagePath, 0, 2);
            this.tlpGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGeneral.Location = new System.Drawing.Point(0, 0);
            this.tlpGeneral.Name = "tlpGeneral";
            this.tlpGeneral.RowCount = 4;
            this.tlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGeneral.Size = new System.Drawing.Size(597, 503);
            this.tlpGeneral.TabIndex = 0;
            // 
            // gbQuickActions
            // 
            this.gbQuickActions.Controls.Add(this.cbAll);
            this.gbQuickActions.Controls.Add(this.cbPrintSend);
            this.gbQuickActions.Controls.Add(this.cbWriteDoctor);
            this.gbQuickActions.Controls.Add(this.cbCreateCase);
            this.gbQuickActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbQuickActions.Location = new System.Drawing.Point(3, 3);
            this.gbQuickActions.Name = "gbQuickActions";
            this.gbQuickActions.Size = new System.Drawing.Size(591, 134);
            this.gbQuickActions.TabIndex = 1;
            this.gbQuickActions.TabStop = false;
            this.gbQuickActions.Text = "快捷操作";
            // 
            // cbAll
            // 
            this.cbAll.AutoSize = true;
            this.cbAll.Location = new System.Drawing.Point(22, 23);
            this.cbAll.Name = "cbAll";
            this.cbAll.Size = new System.Drawing.Size(82, 18);
            this.cbAll.TabIndex = 0;
            this.cbAll.Tag = "1";
            this.cbAll.Text = "所有操作";
            this.cbAll.UseVisualStyleBackColor = true;
            this.cbAll.CheckedChanged += new System.EventHandler(this.cbQuickActions_CheckedChanged);
            // 
            // cbPrintSend
            // 
            this.cbPrintSend.AutoSize = true;
            this.cbPrintSend.Location = new System.Drawing.Point(45, 97);
            this.cbPrintSend.Name = "cbPrintSend";
            this.cbPrintSend.Size = new System.Drawing.Size(166, 18);
            this.cbPrintSend.TabIndex = 3;
            this.cbPrintSend.Tag = "2";
            this.cbPrintSend.Text = "报告打印后自动发送。";
            this.cbPrintSend.UseVisualStyleBackColor = true;
            this.cbPrintSend.CheckedChanged += new System.EventHandler(this.cbQuickActions_CheckedChanged);
            // 
            // cbWriteDoctor
            // 
            this.cbWriteDoctor.AutoSize = true;
            this.cbWriteDoctor.Location = new System.Drawing.Point(45, 72);
            this.cbWriteDoctor.Name = "cbWriteDoctor";
            this.cbWriteDoctor.Size = new System.Drawing.Size(348, 18);
            this.cbWriteDoctor.TabIndex = 2;
            this.cbWriteDoctor.Tag = "2";
            this.cbWriteDoctor.Text = "诊断时，根据病例诊断情况自动填写上级诊断医生。";
            this.cbWriteDoctor.UseVisualStyleBackColor = true;
            this.cbWriteDoctor.CheckedChanged += new System.EventHandler(this.cbQuickActions_CheckedChanged);
            // 
            // cbCreateCase
            // 
            this.cbCreateCase.AutoSize = true;
            this.cbCreateCase.Location = new System.Drawing.Point(45, 47);
            this.cbCreateCase.Name = "cbCreateCase";
            this.cbCreateCase.Size = new System.Drawing.Size(404, 18);
            this.cbCreateCase.TabIndex = 1;
            this.cbCreateCase.Tag = "2";
            this.cbCreateCase.Text = "细胞学工作站可具备登记、修改、保存病例基本信息等功能。";
            this.cbCreateCase.UseVisualStyleBackColor = true;
            this.cbCreateCase.CheckedChanged += new System.EventHandler(this.cbQuickActions_CheckedChanged);
            // 
            // tlpInterfacePath
            // 
            this.tlpInterfacePath.ColumnCount = 3;
            this.tlpInterfacePath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tlpInterfacePath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInterfacePath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tlpInterfacePath.Controls.Add(this.pnlInterfacePath, 0, 0);
            this.tlpInterfacePath.Controls.Add(this.pnlShowInterfacePath, 2, 0);
            this.tlpInterfacePath.Controls.Add(this.pnlWriteInterfacePath, 1, 0);
            this.tlpInterfacePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInterfacePath.Location = new System.Drawing.Point(3, 143);
            this.tlpInterfacePath.Name = "tlpInterfacePath";
            this.tlpInterfacePath.RowCount = 1;
            this.tlpInterfacePath.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInterfacePath.Size = new System.Drawing.Size(591, 31);
            this.tlpInterfacePath.TabIndex = 1;
            // 
            // pnlInterfacePath
            // 
            this.pnlInterfacePath.Controls.Add(this.lblInterfacePath);
            this.pnlInterfacePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInterfacePath.Location = new System.Drawing.Point(3, 3);
            this.pnlInterfacePath.Name = "pnlInterfacePath";
            this.pnlInterfacePath.Size = new System.Drawing.Size(111, 25);
            this.pnlInterfacePath.TabIndex = 0;
            // 
            // lblInterfacePath
            // 
            this.lblInterfacePath.AutoSize = true;
            this.lblInterfacePath.Location = new System.Drawing.Point(3, 4);
            this.lblInterfacePath.Name = "lblInterfacePath";
            this.lblInterfacePath.Size = new System.Drawing.Size(105, 14);
            this.lblInterfacePath.TabIndex = 0;
            this.lblInterfacePath.Text = "接口文件路径：";
            // 
            // pnlShowInterfacePath
            // 
            this.pnlShowInterfacePath.Controls.Add(this.btnFolderBrowser);
            this.pnlShowInterfacePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlShowInterfacePath.Location = new System.Drawing.Point(532, 3);
            this.pnlShowInterfacePath.Name = "pnlShowInterfacePath";
            this.pnlShowInterfacePath.Size = new System.Drawing.Size(56, 25);
            this.pnlShowInterfacePath.TabIndex = 2;
            // 
            // btnFolderBrowser
            // 
            this.btnFolderBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFolderBrowser.Location = new System.Drawing.Point(0, 0);
            this.btnFolderBrowser.Name = "btnFolderBrowser";
            this.btnFolderBrowser.Size = new System.Drawing.Size(56, 25);
            this.btnFolderBrowser.TabIndex = 2;
            this.btnFolderBrowser.Tag = "interface";
            this.btnFolderBrowser.Text = "浏览";
            this.btnFolderBrowser.UseVisualStyleBackColor = true;
            this.btnFolderBrowser.Click += new System.EventHandler(this.btnFolderBrowser_Click);
            // 
            // pnlWriteInterfacePath
            // 
            this.pnlWriteInterfacePath.Controls.Add(this.txtInterfacePath);
            this.pnlWriteInterfacePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWriteInterfacePath.Location = new System.Drawing.Point(120, 3);
            this.pnlWriteInterfacePath.Name = "pnlWriteInterfacePath";
            this.pnlWriteInterfacePath.Size = new System.Drawing.Size(406, 25);
            this.pnlWriteInterfacePath.TabIndex = 1;
            // 
            // txtInterfacePath
            // 
            this.txtInterfacePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInterfacePath.Location = new System.Drawing.Point(0, 0);
            this.txtInterfacePath.Name = "txtInterfacePath";
            this.txtInterfacePath.Size = new System.Drawing.Size(406, 23);
            this.txtInterfacePath.TabIndex = 1;
            // 
            // tlpImagePath
            // 
            this.tlpImagePath.ColumnCount = 3;
            this.tlpImagePath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tlpImagePath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpImagePath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tlpImagePath.Controls.Add(this.pnlImagePath, 0, 0);
            this.tlpImagePath.Controls.Add(this.pnlWriteImagePath, 1, 0);
            this.tlpImagePath.Controls.Add(this.pnlShowImagePath, 2, 0);
            this.tlpImagePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpImagePath.Location = new System.Drawing.Point(3, 180);
            this.tlpImagePath.Name = "tlpImagePath";
            this.tlpImagePath.RowCount = 1;
            this.tlpImagePath.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpImagePath.Size = new System.Drawing.Size(591, 31);
            this.tlpImagePath.TabIndex = 3;
            // 
            // pnlImagePath
            // 
            this.pnlImagePath.Controls.Add(this.lblImagePath);
            this.pnlImagePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImagePath.Location = new System.Drawing.Point(3, 3);
            this.pnlImagePath.Name = "pnlImagePath";
            this.pnlImagePath.Size = new System.Drawing.Size(111, 25);
            this.pnlImagePath.TabIndex = 0;
            // 
            // lblImagePath
            // 
            this.lblImagePath.AutoSize = true;
            this.lblImagePath.Location = new System.Drawing.Point(4, 5);
            this.lblImagePath.Name = "lblImagePath";
            this.lblImagePath.Size = new System.Drawing.Size(105, 14);
            this.lblImagePath.TabIndex = 0;
            this.lblImagePath.Text = "镜下采图路径：";
            // 
            // pnlWriteImagePath
            // 
            this.pnlWriteImagePath.Controls.Add(this.txtImagePath);
            this.pnlWriteImagePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWriteImagePath.Location = new System.Drawing.Point(120, 3);
            this.pnlWriteImagePath.Name = "pnlWriteImagePath";
            this.pnlWriteImagePath.Size = new System.Drawing.Size(406, 25);
            this.pnlWriteImagePath.TabIndex = 1;
            // 
            // txtImagePath
            // 
            this.txtImagePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtImagePath.Location = new System.Drawing.Point(0, 0);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(406, 23);
            this.txtImagePath.TabIndex = 0;
            // 
            // pnlShowImagePath
            // 
            this.pnlShowImagePath.Controls.Add(this.btnImagePath);
            this.pnlShowImagePath.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlShowImagePath.Location = new System.Drawing.Point(532, 3);
            this.pnlShowImagePath.Name = "pnlShowImagePath";
            this.pnlShowImagePath.Size = new System.Drawing.Size(56, 25);
            this.pnlShowImagePath.TabIndex = 2;
            // 
            // btnImagePath
            // 
            this.btnImagePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnImagePath.Location = new System.Drawing.Point(0, 0);
            this.btnImagePath.Name = "btnImagePath";
            this.btnImagePath.Size = new System.Drawing.Size(56, 25);
            this.btnImagePath.TabIndex = 0;
            this.btnImagePath.Tag = "image";
            this.btnImagePath.Text = "浏览";
            this.btnImagePath.UseVisualStyleBackColor = true;
            this.btnImagePath.Click += new System.EventHandler(this.btnFolderBrowser_Click);
            // 
            // UcGeneralCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpGeneral);
            this.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Name = "UcGeneralCtrl";
            this.Size = new System.Drawing.Size(597, 503);
            this.tlpGeneral.ResumeLayout(false);
            this.gbQuickActions.ResumeLayout(false);
            this.gbQuickActions.PerformLayout();
            this.tlpInterfacePath.ResumeLayout(false);
            this.pnlInterfacePath.ResumeLayout(false);
            this.pnlInterfacePath.PerformLayout();
            this.pnlShowInterfacePath.ResumeLayout(false);
            this.pnlWriteInterfacePath.ResumeLayout(false);
            this.pnlWriteInterfacePath.PerformLayout();
            this.tlpImagePath.ResumeLayout(false);
            this.pnlImagePath.ResumeLayout(false);
            this.pnlImagePath.PerformLayout();
            this.pnlWriteImagePath.ResumeLayout(false);
            this.pnlWriteImagePath.PerformLayout();
            this.pnlShowImagePath.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpGeneral;
        private System.Windows.Forms.GroupBox gbQuickActions;
        private System.Windows.Forms.CheckBox cbPrintSend;
        private System.Windows.Forms.CheckBox cbWriteDoctor;
        private System.Windows.Forms.CheckBox cbCreateCase;
        private System.Windows.Forms.CheckBox cbAll;
        private System.Windows.Forms.TableLayoutPanel tlpInterfacePath;
        private System.Windows.Forms.Panel pnlInterfacePath;
        private System.Windows.Forms.FolderBrowserDialog fbdFolderBrowser;
        private System.Windows.Forms.Button btnFolderBrowser;
        private System.Windows.Forms.Label lblInterfacePath;
        private System.Windows.Forms.TextBox txtInterfacePath;
        private System.Windows.Forms.TableLayoutPanel tlpImagePath;
        private System.Windows.Forms.Panel pnlImagePath;
        private System.Windows.Forms.Label lblImagePath;
        private System.Windows.Forms.Panel pnlShowInterfacePath;
        private System.Windows.Forms.Panel pnlWriteInterfacePath;
        private System.Windows.Forms.Panel pnlWriteImagePath;
        private System.Windows.Forms.Panel pnlShowImagePath;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Button btnImagePath;
    }
}
