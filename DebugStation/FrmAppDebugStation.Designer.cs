namespace DebugStation
{
    partial class FrmAppDebugStation
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAppDebugStation));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFile_NewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFile_OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFile_Sepa1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuFile_SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFile_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFile_Sepa2 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuFile_AppExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEdit_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEdit_Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEdit_Sepa1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuEdit_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEdit_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEdit_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEdit_Sepa2 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuEdit_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuView_ToolBar = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuView_StatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuView_Sepa1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuView_TopMost = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTool_Options = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuDebug = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuDebug_LaunchTestProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuDebug_QuickTest = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuDebug_CloseMailSlot = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuWindows_OpenNewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuWindows_Cascade = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuWindows_TileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuWindows_TileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuWindows_CloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuWindows_ArrangeIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuHelp_Contents = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuHelp_Index = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuHelp_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuHelp_Sepa1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuHelp_About = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.TBtnNewFile = new System.Windows.Forms.ToolStripButton();
            this.TBtnOpenFile = new System.Windows.Forms.ToolStripButton();
            this.TBtnSaveFile = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TmrLogCheck = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFile,
            this.MnuEdit,
            this.MnuView,
            this.MnuTool,
            this.MnuDebug,
            this.MnuWindows,
            this.MnuHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.MnuWindows;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(896, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // MnuFile
            // 
            this.MnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFile_NewFile,
            this.MnuFile_OpenFile,
            this.MnuFile_Sepa1,
            this.MnuFile_SaveFile,
            this.MnuFile_SaveAs,
            this.MnuFile_Sepa2,
            this.MnuFile_AppExit});
            this.MnuFile.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.MnuFile.Name = "MnuFile";
            this.MnuFile.Size = new System.Drawing.Size(67, 20);
            this.MnuFile.Text = "ファイル(&F)";
            // 
            // MnuFile_NewFile
            // 
            this.MnuFile_NewFile.Image = ((System.Drawing.Image)(resources.GetObject("MnuFile_NewFile.Image")));
            this.MnuFile_NewFile.ImageTransparentColor = System.Drawing.Color.Black;
            this.MnuFile_NewFile.Name = "MnuFile_NewFile";
            this.MnuFile_NewFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MnuFile_NewFile.Size = new System.Drawing.Size(181, 22);
            this.MnuFile_NewFile.Text = "新規作成(&N)";
            // 
            // MnuFile_OpenFile
            // 
            this.MnuFile_OpenFile.Image = ((System.Drawing.Image)(resources.GetObject("MnuFile_OpenFile.Image")));
            this.MnuFile_OpenFile.ImageTransparentColor = System.Drawing.Color.Black;
            this.MnuFile_OpenFile.Name = "MnuFile_OpenFile";
            this.MnuFile_OpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MnuFile_OpenFile.Size = new System.Drawing.Size(181, 22);
            this.MnuFile_OpenFile.Text = "開く(&O)";
            this.MnuFile_OpenFile.Click += new System.EventHandler(this.MnuFile_OpenFile_Click);
            // 
            // MnuFile_Sepa1
            // 
            this.MnuFile_Sepa1.Name = "MnuFile_Sepa1";
            this.MnuFile_Sepa1.Size = new System.Drawing.Size(178, 6);
            // 
            // MnuFile_SaveFile
            // 
            this.MnuFile_SaveFile.Image = ((System.Drawing.Image)(resources.GetObject("MnuFile_SaveFile.Image")));
            this.MnuFile_SaveFile.ImageTransparentColor = System.Drawing.Color.Black;
            this.MnuFile_SaveFile.Name = "MnuFile_SaveFile";
            this.MnuFile_SaveFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MnuFile_SaveFile.Size = new System.Drawing.Size(181, 22);
            this.MnuFile_SaveFile.Text = "保存(&S)";
            // 
            // MnuFile_SaveAs
            // 
            this.MnuFile_SaveAs.Name = "MnuFile_SaveAs";
            this.MnuFile_SaveAs.Size = new System.Drawing.Size(181, 22);
            this.MnuFile_SaveAs.Text = "名前を付けて保存(&A)";
            this.MnuFile_SaveAs.Click += new System.EventHandler(this.MnuFile_SaveAs_Click);
            // 
            // MnuFile_Sepa2
            // 
            this.MnuFile_Sepa2.Name = "MnuFile_Sepa2";
            this.MnuFile_Sepa2.Size = new System.Drawing.Size(178, 6);
            // 
            // MnuFile_AppExit
            // 
            this.MnuFile_AppExit.Name = "MnuFile_AppExit";
            this.MnuFile_AppExit.Size = new System.Drawing.Size(181, 22);
            this.MnuFile_AppExit.Text = "終了(&X)";
            this.MnuFile_AppExit.Click += new System.EventHandler(this.MnuFile_AppExit_Click);
            // 
            // MnuEdit
            // 
            this.MnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuEdit_Undo,
            this.MnuEdit_Redo,
            this.MnuEdit_Sepa1,
            this.MnuEdit_Cut,
            this.MnuEdit_Copy,
            this.MnuEdit_Paste,
            this.MnuEdit_Sepa2,
            this.MnuEdit_SelectAll});
            this.MnuEdit.Name = "MnuEdit";
            this.MnuEdit.Size = new System.Drawing.Size(57, 20);
            this.MnuEdit.Text = "編集(&E)";
            // 
            // MnuEdit_Undo
            // 
            this.MnuEdit_Undo.Image = ((System.Drawing.Image)(resources.GetObject("MnuEdit_Undo.Image")));
            this.MnuEdit_Undo.ImageTransparentColor = System.Drawing.Color.Black;
            this.MnuEdit_Undo.Name = "MnuEdit_Undo";
            this.MnuEdit_Undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.MnuEdit_Undo.Size = new System.Drawing.Size(184, 22);
            this.MnuEdit_Undo.Text = "元に戻す(&U)";
            // 
            // MnuEdit_Redo
            // 
            this.MnuEdit_Redo.Image = ((System.Drawing.Image)(resources.GetObject("MnuEdit_Redo.Image")));
            this.MnuEdit_Redo.ImageTransparentColor = System.Drawing.Color.Black;
            this.MnuEdit_Redo.Name = "MnuEdit_Redo";
            this.MnuEdit_Redo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.MnuEdit_Redo.Size = new System.Drawing.Size(184, 22);
            this.MnuEdit_Redo.Text = "やり直し(&R)";
            // 
            // MnuEdit_Sepa1
            // 
            this.MnuEdit_Sepa1.Name = "MnuEdit_Sepa1";
            this.MnuEdit_Sepa1.Size = new System.Drawing.Size(181, 6);
            // 
            // MnuEdit_Cut
            // 
            this.MnuEdit_Cut.Image = ((System.Drawing.Image)(resources.GetObject("MnuEdit_Cut.Image")));
            this.MnuEdit_Cut.ImageTransparentColor = System.Drawing.Color.Black;
            this.MnuEdit_Cut.Name = "MnuEdit_Cut";
            this.MnuEdit_Cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.MnuEdit_Cut.Size = new System.Drawing.Size(184, 22);
            this.MnuEdit_Cut.Text = "切り取り(&T)";
            // 
            // MnuEdit_Copy
            // 
            this.MnuEdit_Copy.Image = ((System.Drawing.Image)(resources.GetObject("MnuEdit_Copy.Image")));
            this.MnuEdit_Copy.ImageTransparentColor = System.Drawing.Color.Black;
            this.MnuEdit_Copy.Name = "MnuEdit_Copy";
            this.MnuEdit_Copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.MnuEdit_Copy.Size = new System.Drawing.Size(184, 22);
            this.MnuEdit_Copy.Text = "コピー(&C)";
            // 
            // MnuEdit_Paste
            // 
            this.MnuEdit_Paste.Image = ((System.Drawing.Image)(resources.GetObject("MnuEdit_Paste.Image")));
            this.MnuEdit_Paste.ImageTransparentColor = System.Drawing.Color.Black;
            this.MnuEdit_Paste.Name = "MnuEdit_Paste";
            this.MnuEdit_Paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.MnuEdit_Paste.Size = new System.Drawing.Size(184, 22);
            this.MnuEdit_Paste.Text = "貼り付け(&P)";
            // 
            // MnuEdit_Sepa2
            // 
            this.MnuEdit_Sepa2.Name = "MnuEdit_Sepa2";
            this.MnuEdit_Sepa2.Size = new System.Drawing.Size(181, 6);
            // 
            // MnuEdit_SelectAll
            // 
            this.MnuEdit_SelectAll.Name = "MnuEdit_SelectAll";
            this.MnuEdit_SelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.MnuEdit_SelectAll.Size = new System.Drawing.Size(184, 22);
            this.MnuEdit_SelectAll.Text = "すべて選択(&A)";
            // 
            // MnuView
            // 
            this.MnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuView_ToolBar,
            this.MnuView_StatusBar,
            this.MnuView_Sepa1,
            this.MnuView_TopMost});
            this.MnuView.Name = "MnuView";
            this.MnuView.Size = new System.Drawing.Size(58, 20);
            this.MnuView.Text = "表示(&V)";
            // 
            // MnuView_ToolBar
            // 
            this.MnuView_ToolBar.Checked = true;
            this.MnuView_ToolBar.CheckOnClick = true;
            this.MnuView_ToolBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MnuView_ToolBar.Name = "MnuView_ToolBar";
            this.MnuView_ToolBar.Size = new System.Drawing.Size(162, 22);
            this.MnuView_ToolBar.Text = "ツール バー(&T)";
            this.MnuView_ToolBar.Click += new System.EventHandler(this.MnuView_ToolBar_Click);
            // 
            // MnuView_StatusBar
            // 
            this.MnuView_StatusBar.Checked = true;
            this.MnuView_StatusBar.CheckOnClick = true;
            this.MnuView_StatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MnuView_StatusBar.Name = "MnuView_StatusBar";
            this.MnuView_StatusBar.Size = new System.Drawing.Size(162, 22);
            this.MnuView_StatusBar.Text = "ステータス バー(&S)";
            this.MnuView_StatusBar.Click += new System.EventHandler(this.MnuView_StatusBar_Click);
            // 
            // MnuView_Sepa1
            // 
            this.MnuView_Sepa1.Name = "MnuView_Sepa1";
            this.MnuView_Sepa1.Size = new System.Drawing.Size(159, 6);
            // 
            // MnuView_TopMost
            // 
            this.MnuView_TopMost.CheckOnClick = true;
            this.MnuView_TopMost.Name = "MnuView_TopMost";
            this.MnuView_TopMost.Size = new System.Drawing.Size(162, 22);
            this.MnuView_TopMost.Text = "最前面に表示(&M)";
            this.MnuView_TopMost.Click += new System.EventHandler(this.MnuView_TopMost_Click);
            // 
            // MnuTool
            // 
            this.MnuTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuTool_Options});
            this.MnuTool.Name = "MnuTool";
            this.MnuTool.Size = new System.Drawing.Size(60, 20);
            this.MnuTool.Text = "ツール(&T)";
            // 
            // MnuTool_Options
            // 
            this.MnuTool_Options.Name = "MnuTool_Options";
            this.MnuTool_Options.Size = new System.Drawing.Size(135, 22);
            this.MnuTool_Options.Text = "オプション(&O)";
            // 
            // MnuDebug
            // 
            this.MnuDebug.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuDebug_LaunchTestProgram,
            this.MnuDebug_QuickTest,
            this.MnuDebug_CloseMailSlot});
            this.MnuDebug.Name = "MnuDebug";
            this.MnuDebug.Size = new System.Drawing.Size(70, 20);
            this.MnuDebug.Text = "デバッグ(&X)";
            // 
            // MnuDebug_LaunchTestProgram
            // 
            this.MnuDebug_LaunchTestProgram.Name = "MnuDebug_LaunchTestProgram";
            this.MnuDebug_LaunchTestProgram.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.MnuDebug_LaunchTestProgram.Size = new System.Drawing.Size(210, 22);
            this.MnuDebug_LaunchTestProgram.Text = "テストプログラムを起動(&L)";
            this.MnuDebug_LaunchTestProgram.Click += new System.EventHandler(this.MnuDebug_LaunchTestProgram_Click);
            // 
            // MnuDebug_QuickTest
            // 
            this.MnuDebug_QuickTest.Name = "MnuDebug_QuickTest";
            this.MnuDebug_QuickTest.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.MnuDebug_QuickTest.Size = new System.Drawing.Size(210, 22);
            this.MnuDebug_QuickTest.Text = "クイックテスト";
            this.MnuDebug_QuickTest.Click += new System.EventHandler(this.MnuDebug_QuickTest_Click);
            // 
            // MnuDebug_CloseMailSlot
            // 
            this.MnuDebug_CloseMailSlot.Name = "MnuDebug_CloseMailSlot";
            this.MnuDebug_CloseMailSlot.Size = new System.Drawing.Size(210, 22);
            this.MnuDebug_CloseMailSlot.Text = "メールスロットを閉じる";
            this.MnuDebug_CloseMailSlot.Click += new System.EventHandler(this.MnuDebug_CloseMailSlot_Click);
            // 
            // MnuWindows
            // 
            this.MnuWindows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuWindows_OpenNewWindow,
            this.MnuWindows_Cascade,
            this.MnuWindows_TileVertical,
            this.MnuWindows_TileHorizontal,
            this.MnuWindows_CloseAll,
            this.MnuWindows_ArrangeIcons});
            this.MnuWindows.Name = "MnuWindows";
            this.MnuWindows.Size = new System.Drawing.Size(80, 20);
            this.MnuWindows.Text = "ウィンドウ(&W)";
            // 
            // MnuWindows_OpenNewWindow
            // 
            this.MnuWindows_OpenNewWindow.Name = "MnuWindows_OpenNewWindow";
            this.MnuWindows_OpenNewWindow.Size = new System.Drawing.Size(191, 22);
            this.MnuWindows_OpenNewWindow.Text = "新しいウィンドウを開く(&N)";
            this.MnuWindows_OpenNewWindow.Click += new System.EventHandler(this.MnuWindows_OpenNewWindow_Click);
            // 
            // MnuWindows_Cascade
            // 
            this.MnuWindows_Cascade.Name = "MnuWindows_Cascade";
            this.MnuWindows_Cascade.Size = new System.Drawing.Size(191, 22);
            this.MnuWindows_Cascade.Text = "重ねて表示(&C)";
            this.MnuWindows_Cascade.Click += new System.EventHandler(this.MnuWindows_Cascade_Click);
            // 
            // MnuWindows_TileVertical
            // 
            this.MnuWindows_TileVertical.Name = "MnuWindows_TileVertical";
            this.MnuWindows_TileVertical.Size = new System.Drawing.Size(191, 22);
            this.MnuWindows_TileVertical.Text = "左右に並べて表示(&V)";
            this.MnuWindows_TileVertical.Click += new System.EventHandler(this.MnuWindows_TileVertical_Click);
            // 
            // MnuWindows_TileHorizontal
            // 
            this.MnuWindows_TileHorizontal.Name = "MnuWindows_TileHorizontal";
            this.MnuWindows_TileHorizontal.Size = new System.Drawing.Size(191, 22);
            this.MnuWindows_TileHorizontal.Text = "上下に並べて表示(&H)";
            this.MnuWindows_TileHorizontal.Click += new System.EventHandler(this.MnuWindows_TileHorizontal_Click);
            // 
            // MnuWindows_CloseAll
            // 
            this.MnuWindows_CloseAll.Name = "MnuWindows_CloseAll";
            this.MnuWindows_CloseAll.Size = new System.Drawing.Size(191, 22);
            this.MnuWindows_CloseAll.Text = "すべて閉じる(&L)";
            this.MnuWindows_CloseAll.Click += new System.EventHandler(this.MnuWindows_CloseAll_Click);
            // 
            // MnuWindows_ArrangeIcons
            // 
            this.MnuWindows_ArrangeIcons.Name = "MnuWindows_ArrangeIcons";
            this.MnuWindows_ArrangeIcons.Size = new System.Drawing.Size(191, 22);
            this.MnuWindows_ArrangeIcons.Text = "アイコンの整列(&A)";
            this.MnuWindows_ArrangeIcons.Click += new System.EventHandler(this.MnuWindows_ArrangeIcons_Click);
            // 
            // MnuHelp
            // 
            this.MnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuHelp_Contents,
            this.MnuHelp_Index,
            this.MnuHelp_Search,
            this.MnuHelp_Sepa1,
            this.MnuHelp_About});
            this.MnuHelp.Name = "MnuHelp";
            this.MnuHelp.Size = new System.Drawing.Size(65, 20);
            this.MnuHelp.Text = "ヘルプ(&H)";
            // 
            // MnuHelp_Contents
            // 
            this.MnuHelp_Contents.Name = "MnuHelp_Contents";
            this.MnuHelp_Contents.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.MnuHelp_Contents.Size = new System.Drawing.Size(167, 22);
            this.MnuHelp_Contents.Text = "目次(&C)";
            // 
            // MnuHelp_Index
            // 
            this.MnuHelp_Index.Image = ((System.Drawing.Image)(resources.GetObject("MnuHelp_Index.Image")));
            this.MnuHelp_Index.ImageTransparentColor = System.Drawing.Color.Black;
            this.MnuHelp_Index.Name = "MnuHelp_Index";
            this.MnuHelp_Index.Size = new System.Drawing.Size(167, 22);
            this.MnuHelp_Index.Text = "インデックス(&I)";
            // 
            // MnuHelp_Search
            // 
            this.MnuHelp_Search.Image = ((System.Drawing.Image)(resources.GetObject("MnuHelp_Search.Image")));
            this.MnuHelp_Search.ImageTransparentColor = System.Drawing.Color.Black;
            this.MnuHelp_Search.Name = "MnuHelp_Search";
            this.MnuHelp_Search.Size = new System.Drawing.Size(167, 22);
            this.MnuHelp_Search.Text = "検索(&S)";
            // 
            // MnuHelp_Sepa1
            // 
            this.MnuHelp_Sepa1.Name = "MnuHelp_Sepa1";
            this.MnuHelp_Sepa1.Size = new System.Drawing.Size(164, 6);
            // 
            // MnuHelp_About
            // 
            this.MnuHelp_About.Name = "MnuHelp_About";
            this.MnuHelp_About.Size = new System.Drawing.Size(167, 22);
            this.MnuHelp_About.Text = "バージョン情報(&A)...";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TBtnNewFile,
            this.TBtnOpenFile,
            this.TBtnSaveFile});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(896, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // TBtnNewFile
            // 
            this.TBtnNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBtnNewFile.Image = ((System.Drawing.Image)(resources.GetObject("TBtnNewFile.Image")));
            this.TBtnNewFile.ImageTransparentColor = System.Drawing.Color.Black;
            this.TBtnNewFile.Name = "TBtnNewFile";
            this.TBtnNewFile.Size = new System.Drawing.Size(23, 22);
            this.TBtnNewFile.Text = "新規";
            this.TBtnNewFile.Click += new System.EventHandler(this.MnuWindows_OpenNewWindow_Click);
            // 
            // TBtnOpenFile
            // 
            this.TBtnOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBtnOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("TBtnOpenFile.Image")));
            this.TBtnOpenFile.ImageTransparentColor = System.Drawing.Color.Black;
            this.TBtnOpenFile.Name = "TBtnOpenFile";
            this.TBtnOpenFile.Size = new System.Drawing.Size(23, 22);
            this.TBtnOpenFile.Text = "開く";
            this.TBtnOpenFile.Click += new System.EventHandler(this.MnuFile_OpenFile_Click);
            // 
            // TBtnSaveFile
            // 
            this.TBtnSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBtnSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("TBtnSaveFile.Image")));
            this.TBtnSaveFile.ImageTransparentColor = System.Drawing.Color.Black;
            this.TBtnSaveFile.Name = "TBtnSaveFile";
            this.TBtnSaveFile.Size = new System.Drawing.Size(23, 22);
            this.TBtnSaveFile.Text = "上書き保存";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 462);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(896, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // TmrLogCheck
            // 
            this.TmrLogCheck.Interval = 20;
            this.TmrLogCheck.Tick += new System.EventHandler(this.TmrLogCheck_Tick);
            // 
            // FrmAppDebugStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 484);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmAppDebugStation";
            this.Text = "DebugStation";
            this.Load += new System.EventHandler(this.FrmAppDebugStation_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator MnuFile_Sepa1;
        private System.Windows.Forms.ToolStripSeparator MnuEdit_Sepa1;
        private System.Windows.Forms.ToolStripSeparator MnuEdit_Sepa2;
        private System.Windows.Forms.ToolStripSeparator MnuHelp_Sepa1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem MnuHelp_About;
        private System.Windows.Forms.ToolStripMenuItem MnuWindows_TileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem MnuFile;
        private System.Windows.Forms.ToolStripMenuItem MnuFile_NewFile;
        private System.Windows.Forms.ToolStripMenuItem MnuFile_OpenFile;
        private System.Windows.Forms.ToolStripMenuItem MnuFile_SaveFile;
        private System.Windows.Forms.ToolStripMenuItem MnuFile_SaveAs;
        private System.Windows.Forms.ToolStripMenuItem MnuFile_AppExit;
        private System.Windows.Forms.ToolStripMenuItem MnuEdit;
        private System.Windows.Forms.ToolStripMenuItem MnuEdit_Undo;
        private System.Windows.Forms.ToolStripMenuItem MnuEdit_Redo;
        private System.Windows.Forms.ToolStripMenuItem MnuEdit_Cut;
        private System.Windows.Forms.ToolStripMenuItem MnuEdit_Copy;
        private System.Windows.Forms.ToolStripMenuItem MnuEdit_Paste;
        private System.Windows.Forms.ToolStripMenuItem MnuEdit_SelectAll;
        private System.Windows.Forms.ToolStripMenuItem MnuView;
        private System.Windows.Forms.ToolStripMenuItem MnuView_ToolBar;
        private System.Windows.Forms.ToolStripMenuItem MnuView_StatusBar;
        private System.Windows.Forms.ToolStripMenuItem MnuTool;
        private System.Windows.Forms.ToolStripMenuItem MnuTool_Options;
        private System.Windows.Forms.ToolStripMenuItem MnuWindows;
        private System.Windows.Forms.ToolStripMenuItem MnuWindows_OpenNewWindow;
        private System.Windows.Forms.ToolStripMenuItem MnuWindows_Cascade;
        private System.Windows.Forms.ToolStripMenuItem MnuWindows_TileVertical;
        private System.Windows.Forms.ToolStripMenuItem MnuWindows_CloseAll;
        private System.Windows.Forms.ToolStripMenuItem MnuWindows_ArrangeIcons;
        private System.Windows.Forms.ToolStripMenuItem MnuHelp;
        private System.Windows.Forms.ToolStripMenuItem MnuHelp_Contents;
        private System.Windows.Forms.ToolStripMenuItem MnuHelp_Index;
        private System.Windows.Forms.ToolStripMenuItem MnuHelp_Search;
        private System.Windows.Forms.ToolStripButton TBtnNewFile;
        private System.Windows.Forms.ToolStripButton TBtnOpenFile;
        private System.Windows.Forms.ToolStripButton TBtnSaveFile;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Timer TmrLogCheck;
        private System.Windows.Forms.ToolStripMenuItem MnuDebug;
        private System.Windows.Forms.ToolStripMenuItem MnuDebug_CloseMailSlot;
        private System.Windows.Forms.ToolStripMenuItem MnuDebug_LaunchTestProgram;
        private System.Windows.Forms.ToolStripSeparator MnuView_Sepa1;
        private System.Windows.Forms.ToolStripMenuItem MnuView_TopMost;
        private System.Windows.Forms.ToolStripSeparator MnuFile_Sepa2;
        private System.Windows.Forms.ToolStripMenuItem MnuDebug_QuickTest;
    }
}



