namespace DiagnosisWorkstation
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.msCaseInfo = new System.Windows.Forms.MenuStrip();
            this.tsmiCaseHistoryBase = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReportManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddReport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModifyReport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPictureManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPictureSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSystemSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDictionaryManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFavoriteManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTagManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tssSystemSetting = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiOptionSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpFormTable = new System.Windows.Forms.TableLayoutPanel();
            this.tsTools = new System.Windows.Forms.ToolStrip();
            this.tsbCreate = new System.Windows.Forms.ToolStripButton();
            this.tsbCustom = new System.Windows.Forms.ToolStripButton();
            this.tsbCaitu = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tssToolCase = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbLast = new System.Windows.Forms.ToolStripButton();
            this.tsbNext = new System.Windows.Forms.ToolStripButton();
            this.tsbChecked = new System.Windows.Forms.ToolStripButton();
            this.tsbModify = new System.Windows.Forms.ToolStripButton();
            this.tssRefresh = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPreview = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.tsbSend = new System.Windows.Forms.ToolStripButton();
            this.tssPrintSend = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFavorite = new System.Windows.Forms.ToolStripButton();
            this.tsbMessage = new System.Windows.Forms.ToolStripButton();
            this.tsbFocus = new System.Windows.Forms.ToolStripButton();
            this.tsbAccess = new System.Windows.Forms.ToolStripButton();
            this.tsbStructurization = new System.Windows.Forms.ToolStripButton();
            this.tssTools = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLogout = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.sceControls = new QpFormsControl.SplitContainerEx();
            this.tcDiagnosis = new System.Windows.Forms.TabControl();
            this.tpRegisterPage = new System.Windows.Forms.TabPage();
            this.tpDiagnosisPage = new System.Windows.Forms.TabPage();
            this.tpPicturePage = new System.Windows.Forms.TabPage();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.tsslUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDepartment = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslLevel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDBType = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsddbPrinter = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsddbCytologyPageStyle = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiCytology2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCytology1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCommCytology = new System.Windows.Forms.ToolStripMenuItem();
            this.msCaseInfo.SuspendLayout();
            this.tlpFormTable.SuspendLayout();
            this.tsTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sceControls)).BeginInit();
            this.sceControls.Panel1.SuspendLayout();
            this.sceControls.SuspendLayout();
            this.tcDiagnosis.SuspendLayout();
            this.ssStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // msCaseInfo
            // 
            this.msCaseInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.msCaseInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCaseHistoryBase,
            this.tsmiReportManage,
            this.tsmiPictureManage,
            this.tsmiSystemSetting});
            this.msCaseInfo.Location = new System.Drawing.Point(0, 0);
            this.msCaseInfo.Name = "msCaseInfo";
            this.msCaseInfo.Size = new System.Drawing.Size(1370, 28);
            this.msCaseInfo.TabIndex = 0;
            // 
            // tsmiCaseHistoryBase
            // 
            this.tsmiCaseHistoryBase.Name = "tsmiCaseHistoryBase";
            this.tsmiCaseHistoryBase.Size = new System.Drawing.Size(82, 24);
            this.tsmiCaseHistoryBase.Text = "病例库(&C)";
            // 
            // tsmiReportManage
            // 
            this.tsmiReportManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddReport,
            this.tsmiModifyReport});
            this.tsmiReportManage.Name = "tsmiReportManage";
            this.tsmiReportManage.Size = new System.Drawing.Size(96, 24);
            this.tsmiReportManage.Text = "报告管理(&R)";
            // 
            // tsmiAddReport
            // 
            this.tsmiAddReport.Name = "tsmiAddReport";
            this.tsmiAddReport.Size = new System.Drawing.Size(154, 24);
            this.tsmiAddReport.Tag = "A";
            this.tsmiAddReport.Text = "新增报告(&A)";
            // 
            // tsmiModifyReport
            // 
            this.tsmiModifyReport.Name = "tsmiModifyReport";
            this.tsmiModifyReport.Size = new System.Drawing.Size(154, 24);
            this.tsmiModifyReport.Tag = "U";
            this.tsmiModifyReport.Text = "更改报告(&U)";
            // 
            // tsmiPictureManage
            // 
            this.tsmiPictureManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPictureSetting});
            this.tsmiPictureManage.Name = "tsmiPictureManage";
            this.tsmiPictureManage.Size = new System.Drawing.Size(96, 24);
            this.tsmiPictureManage.Text = "图像管理(&P)";
            // 
            // tsmiPictureSetting
            // 
            this.tsmiPictureSetting.Name = "tsmiPictureSetting";
            this.tsmiPictureSetting.Size = new System.Drawing.Size(148, 24);
            this.tsmiPictureSetting.Tag = "I";
            this.tsmiPictureSetting.Text = "图像设置(&I)";
            // 
            // tsmiSystemSetting
            // 
            this.tsmiSystemSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDictionaryManage,
            this.tsmiFavoriteManage,
            this.tsmiTagManage,
            this.tssSystemSetting,
            this.tsmiOptionSetting});
            this.tsmiSystemSetting.Name = "tsmiSystemSetting";
            this.tsmiSystemSetting.Size = new System.Drawing.Size(95, 24);
            this.tsmiSystemSetting.Text = "系统设置(&S)";
            // 
            // tsmiDictionaryManage
            // 
            this.tsmiDictionaryManage.Name = "tsmiDictionaryManage";
            this.tsmiDictionaryManage.Size = new System.Drawing.Size(166, 24);
            this.tsmiDictionaryManage.Tag = "D";
            this.tsmiDictionaryManage.Text = "词典管理(&D)";
            // 
            // tsmiFavoriteManage
            // 
            this.tsmiFavoriteManage.Name = "tsmiFavoriteManage";
            this.tsmiFavoriteManage.Size = new System.Drawing.Size(166, 24);
            this.tsmiFavoriteManage.Tag = "F";
            this.tsmiFavoriteManage.Text = "收藏管理(&F)";
            // 
            // tsmiTagManage
            // 
            this.tsmiTagManage.Name = "tsmiTagManage";
            this.tsmiTagManage.Size = new System.Drawing.Size(166, 24);
            this.tsmiTagManage.Tag = "T";
            this.tsmiTagManage.Text = "标记物管理(&T)";
            // 
            // tssSystemSetting
            // 
            this.tssSystemSetting.Name = "tssSystemSetting";
            this.tssSystemSetting.Size = new System.Drawing.Size(163, 6);
            // 
            // tsmiOptionSetting
            // 
            this.tsmiOptionSetting.Name = "tsmiOptionSetting";
            this.tsmiOptionSetting.Size = new System.Drawing.Size(166, 24);
            this.tsmiOptionSetting.Tag = "O";
            this.tsmiOptionSetting.Text = "选项(&O)";
            this.tsmiOptionSetting.Click += new System.EventHandler(this.tsmiMenu_Click);
            // 
            // tlpFormTable
            // 
            this.tlpFormTable.ColumnCount = 1;
            this.tlpFormTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFormTable.Controls.Add(this.tsTools, 0, 0);
            this.tlpFormTable.Controls.Add(this.sceControls, 0, 1);
            this.tlpFormTable.Controls.Add(this.ssStatus, 0, 2);
            this.tlpFormTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFormTable.Location = new System.Drawing.Point(0, 28);
            this.tlpFormTable.Name = "tlpFormTable";
            this.tlpFormTable.RowCount = 3;
            this.tlpFormTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpFormTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFormTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tlpFormTable.Size = new System.Drawing.Size(1370, 721);
            this.tlpFormTable.TabIndex = 1;
            // 
            // tsTools
            // 
            this.tsTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsTools.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tsTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsTools.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCreate,
            this.tsbCustom,
            this.tsbCaitu,
            this.tsbSave,
            this.tssToolCase,
            this.tsbRefresh,
            this.tsbLast,
            this.tsbNext,
            this.tsbChecked,
            this.tsbModify,
            this.tssRefresh,
            this.tsbPreview,
            this.tsbPrint,
            this.tsbSend,
            this.tssPrintSend,
            this.tsbFavorite,
            this.tsbMessage,
            this.tsbFocus,
            this.tsbAccess,
            this.tsbStructurization,
            this.tssTools,
            this.tsbLogout,
            this.tsbExit});
            this.tsTools.Location = new System.Drawing.Point(0, 0);
            this.tsTools.Name = "tsTools";
            this.tsTools.Size = new System.Drawing.Size(1370, 60);
            this.tsTools.TabIndex = 1;
            // 
            // tsbCreate
            // 
            this.tsbCreate.Image = global::DiagnosisWorkstation.Properties.Resources.Add;
            this.tsbCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCreate.Name = "tsbCreate";
            this.tsbCreate.Size = new System.Drawing.Size(41, 57);
            this.tsbCreate.Text = "新建";
            this.tsbCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCreate.ToolTipText = "新建";
            // 
            // tsbCustom
            // 
            this.tsbCustom.Image = global::DiagnosisWorkstation.Properties.Resources.Custom;
            this.tsbCustom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCustom.Name = "tsbCustom";
            this.tsbCustom.Size = new System.Drawing.Size(55, 57);
            this.tsbCustom.Text = "自定义";
            this.tsbCustom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbCaitu
            // 
            this.tsbCaitu.Image = global::DiagnosisWorkstation.Properties.Resources.Camara;
            this.tsbCaitu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCaitu.Name = "tsbCaitu";
            this.tsbCaitu.Size = new System.Drawing.Size(41, 57);
            this.tsbCaitu.Text = "采图";
            this.tsbCaitu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbSave
            // 
            this.tsbSave.Image = global::DiagnosisWorkstation.Properties.Resources.Save;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(41, 57);
            this.tsbSave.Text = "保存";
            this.tsbSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tssToolCase
            // 
            this.tssToolCase.Name = "tssToolCase";
            this.tssToolCase.Size = new System.Drawing.Size(6, 60);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.Image = global::DiagnosisWorkstation.Properties.Resources.Refresh;
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(41, 57);
            this.tsbRefresh.Text = "刷新";
            this.tsbRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbLast
            // 
            this.tsbLast.Image = global::DiagnosisWorkstation.Properties.Resources.Pre;
            this.tsbLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLast.Name = "tsbLast";
            this.tsbLast.Size = new System.Drawing.Size(55, 57);
            this.tsbLast.Text = "上一例";
            this.tsbLast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbNext
            // 
            this.tsbNext.Image = global::DiagnosisWorkstation.Properties.Resources.Next;
            this.tsbNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNext.Name = "tsbNext";
            this.tsbNext.Size = new System.Drawing.Size(55, 57);
            this.tsbNext.Text = "下一例";
            this.tsbNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbChecked
            // 
            this.tsbChecked.Image = global::DiagnosisWorkstation.Properties.Resources.Check;
            this.tsbChecked.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChecked.Name = "tsbChecked";
            this.tsbChecked.Size = new System.Drawing.Size(41, 57);
            this.tsbChecked.Text = "审核";
            this.tsbChecked.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbModify
            // 
            this.tsbModify.Image = global::DiagnosisWorkstation.Properties.Resources.Edit;
            this.tsbModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModify.Name = "tsbModify";
            this.tsbModify.Size = new System.Drawing.Size(41, 57);
            this.tsbModify.Text = "修改";
            this.tsbModify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tssRefresh
            // 
            this.tssRefresh.Name = "tssRefresh";
            this.tssRefresh.Size = new System.Drawing.Size(6, 60);
            // 
            // tsbPreview
            // 
            this.tsbPreview.Image = global::DiagnosisWorkstation.Properties.Resources.Preview;
            this.tsbPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPreview.Name = "tsbPreview";
            this.tsbPreview.Size = new System.Drawing.Size(41, 57);
            this.tsbPreview.Text = "预览";
            this.tsbPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbPrint
            // 
            this.tsbPrint.Image = global::DiagnosisWorkstation.Properties.Resources.Print;
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(41, 57);
            this.tsbPrint.Text = "打印";
            this.tsbPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbSend
            // 
            this.tsbSend.Image = global::DiagnosisWorkstation.Properties.Resources.Send;
            this.tsbSend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSend.Name = "tsbSend";
            this.tsbSend.Size = new System.Drawing.Size(41, 57);
            this.tsbSend.Text = "发送";
            this.tsbSend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tssPrintSend
            // 
            this.tssPrintSend.Name = "tssPrintSend";
            this.tssPrintSend.Size = new System.Drawing.Size(6, 60);
            // 
            // tsbFavorite
            // 
            this.tsbFavorite.Image = global::DiagnosisWorkstation.Properties.Resources.Star;
            this.tsbFavorite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFavorite.Name = "tsbFavorite";
            this.tsbFavorite.Size = new System.Drawing.Size(41, 57);
            this.tsbFavorite.Text = "收藏";
            this.tsbFavorite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbMessage
            // 
            this.tsbMessage.Image = global::DiagnosisWorkstation.Properties.Resources.Chart;
            this.tsbMessage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMessage.Name = "tsbMessage";
            this.tsbMessage.Size = new System.Drawing.Size(41, 57);
            this.tsbMessage.Text = "留言";
            this.tsbMessage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbFocus
            // 
            this.tsbFocus.Image = global::DiagnosisWorkstation.Properties.Resources.Hart;
            this.tsbFocus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFocus.Name = "tsbFocus";
            this.tsbFocus.Size = new System.Drawing.Size(41, 57);
            this.tsbFocus.Text = "关注";
            this.tsbFocus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbAccess
            // 
            this.tsbAccess.Image = global::DiagnosisWorkstation.Properties.Resources.Document;
            this.tsbAccess.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAccess.Name = "tsbAccess";
            this.tsbAccess.Size = new System.Drawing.Size(41, 57);
            this.tsbAccess.Text = "调阅";
            this.tsbAccess.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbStructurization
            // 
            this.tsbStructurization.Image = global::DiagnosisWorkstation.Properties.Resources.Point;
            this.tsbStructurization.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStructurization.Name = "tsbStructurization";
            this.tsbStructurization.Size = new System.Drawing.Size(55, 57);
            this.tsbStructurization.Text = "结构化";
            this.tsbStructurization.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tssTools
            // 
            this.tssTools.Name = "tssTools";
            this.tssTools.Size = new System.Drawing.Size(6, 60);
            // 
            // tsbLogout
            // 
            this.tsbLogout.Image = global::DiagnosisWorkstation.Properties.Resources.Close;
            this.tsbLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLogout.Name = "tsbLogout";
            this.tsbLogout.Size = new System.Drawing.Size(41, 57);
            this.tsbLogout.Text = "注销";
            this.tsbLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbExit
            // 
            this.tsbExit.Image = global::DiagnosisWorkstation.Properties.Resources.Logout;
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(41, 57);
            this.tsbExit.Text = "退出";
            this.tsbExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // sceControls
            // 
            this.sceControls.ButtonColorHover = System.Drawing.Color.Red;
            this.sceControls.ButtonColorNormal = System.Drawing.Color.DarkRed;
            this.sceControls.Cursor = System.Windows.Forms.Cursors.Default;
            this.sceControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sceControls.Location = new System.Drawing.Point(3, 63);
            this.sceControls.Name = "sceControls";
            // 
            // sceControls.Panel1
            // 
            this.sceControls.Panel1.Controls.Add(this.tcDiagnosis);
            this.sceControls.Panel1MinSize = 0;
            this.sceControls.Panel2MinSize = 0;
            this.sceControls.Size = new System.Drawing.Size(1364, 632);
            this.sceControls.SplitterDistance = 1014;
            this.sceControls.SplitterWidth = 9;
            this.sceControls.TabIndex = 3;
            // 
            // tcDiagnosis
            // 
            this.tcDiagnosis.Controls.Add(this.tpRegisterPage);
            this.tcDiagnosis.Controls.Add(this.tpDiagnosisPage);
            this.tcDiagnosis.Controls.Add(this.tpPicturePage);
            this.tcDiagnosis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcDiagnosis.Location = new System.Drawing.Point(0, 0);
            this.tcDiagnosis.Name = "tcDiagnosis";
            this.tcDiagnosis.SelectedIndex = 0;
            this.tcDiagnosis.Size = new System.Drawing.Size(1014, 632);
            this.tcDiagnosis.TabIndex = 2;
            this.tcDiagnosis.SelectedIndexChanged += new System.EventHandler(this.tcDiagnosis_SelectedIndexChanged);
            // 
            // tpRegisterPage
            // 
            this.tpRegisterPage.Location = new System.Drawing.Point(4, 24);
            this.tpRegisterPage.Name = "tpRegisterPage";
            this.tpRegisterPage.Size = new System.Drawing.Size(1006, 604);
            this.tpRegisterPage.TabIndex = 0;
            this.tpRegisterPage.Text = "病例信息";
            // 
            // tpDiagnosisPage
            // 
            this.tpDiagnosisPage.Location = new System.Drawing.Point(4, 22);
            this.tpDiagnosisPage.Name = "tpDiagnosisPage";
            this.tpDiagnosisPage.Size = new System.Drawing.Size(1006, 606);
            this.tpDiagnosisPage.TabIndex = 1;
            this.tpDiagnosisPage.Text = "细胞学诊断";
            // 
            // tpPicturePage
            // 
            this.tpPicturePage.Location = new System.Drawing.Point(4, 22);
            this.tpPicturePage.Name = "tpPicturePage";
            this.tpPicturePage.Size = new System.Drawing.Size(1006, 606);
            this.tpPicturePage.TabIndex = 2;
            this.tpPicturePage.Text = "病理图像";
            // 
            // ssStatus
            // 
            this.ssStatus.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslUserName,
            this.tsslDepartment,
            this.tsslLevel,
            this.tsslDBType,
            this.tsddbPrinter,
            this.tsddbCytologyPageStyle});
            this.ssStatus.Location = new System.Drawing.Point(0, 698);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(1370, 23);
            this.ssStatus.TabIndex = 3;
            this.ssStatus.Text = "statusStrip1";
            // 
            // tsslUserName
            // 
            this.tsslUserName.Name = "tsslUserName";
            this.tsslUserName.Size = new System.Drawing.Size(65, 18);
            this.tsslUserName.Text = "用户名：";
            // 
            // tsslDepartment
            // 
            this.tsslDepartment.Name = "tsslDepartment";
            this.tsslDepartment.Size = new System.Drawing.Size(107, 18);
            this.tsslDepartment.Text = "部门：病理科；";
            // 
            // tsslLevel
            // 
            this.tsslLevel.Name = "tsslLevel";
            this.tsslLevel.Size = new System.Drawing.Size(79, 18);
            this.tsslLevel.Text = "诊断级别：";
            // 
            // tsslDBType
            // 
            this.tsslDBType.Name = "tsslDBType";
            this.tsslDBType.Size = new System.Drawing.Size(65, 18);
            this.tsslDBType.Text = "库类别：";
            // 
            // tsddbPrinter
            // 
            this.tsddbPrinter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbPrinter.Image = ((System.Drawing.Image)(resources.GetObject("tsddbPrinter.Image")));
            this.tsddbPrinter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbPrinter.Name = "tsddbPrinter";
            this.tsddbPrinter.Size = new System.Drawing.Size(78, 21);
            this.tsddbPrinter.Text = "打印机：";
            // 
            // tsddbCytologyPageStyle
            // 
            this.tsddbCytologyPageStyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbCytologyPageStyle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCytology2,
            this.tsmiCytology1,
            this.tsmiCommCytology});
            this.tsddbCytologyPageStyle.Image = ((System.Drawing.Image)(resources.GetObject("tsddbCytologyPageStyle.Image")));
            this.tsddbCytologyPageStyle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbCytologyPageStyle.Name = "tsddbCytologyPageStyle";
            this.tsddbCytologyPageStyle.Size = new System.Drawing.Size(64, 21);
            this.tsddbCytologyPageStyle.Text = "界面：";
            // 
            // tsmiCytology2
            // 
            this.tsmiCytology2.Name = "tsmiCytology2";
            this.tsmiCytology2.Size = new System.Drawing.Size(156, 24);
            this.tsmiCytology2.Text = "液基细胞学2";
            this.tsmiCytology2.Click += new System.EventHandler(this.tsmiCytologyUI_Click);
            // 
            // tsmiCytology1
            // 
            this.tsmiCytology1.Name = "tsmiCytology1";
            this.tsmiCytology1.Size = new System.Drawing.Size(156, 24);
            this.tsmiCytology1.Text = "液基细胞学1";
            this.tsmiCytology1.Click += new System.EventHandler(this.tsmiCytologyUI_Click);
            // 
            // tsmiCommCytology
            // 
            this.tsmiCommCytology.Name = "tsmiCommCytology";
            this.tsmiCommCytology.Size = new System.Drawing.Size(156, 24);
            this.tsmiCommCytology.Text = "普通细胞学";
            this.tsmiCommCytology.Click += new System.EventHandler(this.tsmiCytologyUI_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.tlpFormTable);
            this.Controls.Add(this.msCaseInfo);
            this.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msCaseInfo;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "千屏科技液基细胞学辅助诊断系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.msCaseInfo.ResumeLayout(false);
            this.msCaseInfo.PerformLayout();
            this.tlpFormTable.ResumeLayout(false);
            this.tlpFormTable.PerformLayout();
            this.tsTools.ResumeLayout(false);
            this.tsTools.PerformLayout();
            this.sceControls.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sceControls)).EndInit();
            this.sceControls.ResumeLayout(false);
            this.tcDiagnosis.ResumeLayout(false);
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msCaseInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiCaseHistoryBase;
        private System.Windows.Forms.ToolStripMenuItem tsmiReportManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddReport;
        private System.Windows.Forms.ToolStripMenuItem tsmiModifyReport;
        private System.Windows.Forms.ToolStripMenuItem tsmiPictureManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiPictureSetting;
        private System.Windows.Forms.ToolStripMenuItem tsmiSystemSetting;
        private System.Windows.Forms.ToolStripMenuItem tsmiDictionaryManage;
        private System.Windows.Forms.ToolStripSeparator tssSystemSetting;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptionSetting;
        private System.Windows.Forms.TableLayoutPanel tlpFormTable;
        private System.Windows.Forms.ToolStrip tsTools;
        private System.Windows.Forms.ToolStripButton tsbCreate;
        private System.Windows.Forms.ToolStripButton tsbCustom;
        private QpFormsControl.SplitContainerEx sceControls;
        private System.Windows.Forms.TabControl tcDiagnosis;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsslUserName;
        private System.Windows.Forms.ToolStripStatusLabel tsslDepartment;
        private System.Windows.Forms.ToolStripStatusLabel tsslLevel;
        private System.Windows.Forms.ToolStripStatusLabel tsslDBType;
        private System.Windows.Forms.ToolStripDropDownButton tsddbPrinter;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripSeparator tssToolCase;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripButton tsbLast;
        private System.Windows.Forms.ToolStripButton tsbNext;
        private System.Windows.Forms.ToolStripButton tsbChecked;
        private System.Windows.Forms.ToolStripButton tsbModify;
        private System.Windows.Forms.ToolStripSeparator tssRefresh;
        private System.Windows.Forms.ToolStripButton tsbCaitu;
        private System.Windows.Forms.ToolStripButton tsbPreview;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.ToolStripSeparator tssPrintSend;
        private System.Windows.Forms.ToolStripButton tsbSend;
        private System.Windows.Forms.ToolStripButton tsbFavorite;
        private System.Windows.Forms.ToolStripButton tsbMessage;
        private System.Windows.Forms.ToolStripButton tsbFocus;
        private System.Windows.Forms.ToolStripButton tsbAccess;
        private System.Windows.Forms.ToolStripButton tsbStructurization;
        private System.Windows.Forms.ToolStripSeparator tssTools;
        private System.Windows.Forms.ToolStripButton tsbLogout;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.TabPage tpRegisterPage;
        private System.Windows.Forms.TabPage tpDiagnosisPage;
        private System.Windows.Forms.TabPage tpPicturePage;
        private System.Windows.Forms.ToolStripDropDownButton tsddbCytologyPageStyle;
        private System.Windows.Forms.ToolStripMenuItem tsmiCytology2;
        private System.Windows.Forms.ToolStripMenuItem tsmiCytology1;
        private System.Windows.Forms.ToolStripMenuItem tsmiCommCytology;
        private System.Windows.Forms.ToolStripMenuItem tsmiFavoriteManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiTagManage;
    }
}