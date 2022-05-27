
namespace DebugStation
{
    partial class FrmOutputView
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.LvwDebugData = new System.Windows.Forms.ListView();
            this.message = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.source = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CMnuDebugData = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMnuDebugData_MoveFirst = new System.Windows.Forms.ToolStripMenuItem();
            this.CMnuDebugData_MoveLast = new System.Windows.Forms.ToolStripMenuItem();
            this.CMnuDebugData_AddLine = new System.Windows.Forms.ToolStripMenuItem();
            this.CMnuDebugData_Sepa1 = new System.Windows.Forms.ToolStripSeparator();
            this.CMnuDebugData_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.CMnuDebugData_CopyAll = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlDebugData = new DebugStation.CtlDebugDataPanel();
            this.CMnuDebugData_CopySelection = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.CMnuDebugData.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.LvwDebugData);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PnlDebugData);
            this.splitContainer1.Size = new System.Drawing.Size(800, 453);
            this.splitContainer1.SplitterDistance = 316;
            this.splitContainer1.TabIndex = 3;
            // 
            // LvwDebugData
            // 
            this.LvwDebugData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.message,
            this.dateTime,
            this.source});
            this.LvwDebugData.ContextMenuStrip = this.CMnuDebugData;
            this.LvwDebugData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvwDebugData.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LvwDebugData.FullRowSelect = true;
            this.LvwDebugData.GridLines = true;
            this.LvwDebugData.HideSelection = false;
            this.LvwDebugData.Location = new System.Drawing.Point(0, 0);
            this.LvwDebugData.Name = "LvwDebugData";
            this.LvwDebugData.Size = new System.Drawing.Size(800, 316);
            this.LvwDebugData.TabIndex = 2;
            this.LvwDebugData.UseCompatibleStateImageBehavior = false;
            this.LvwDebugData.View = System.Windows.Forms.View.Details;
            this.LvwDebugData.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LvwDebugData_ItemSelectionChanged);
            // 
            // message
            // 
            this.message.DisplayIndex = 2;
            this.message.Text = "メッセージ";
            this.message.Width = 600;
            // 
            // dateTime
            // 
            this.dateTime.DisplayIndex = 0;
            this.dateTime.Text = "日時";
            this.dateTime.Width = 140;
            // 
            // source
            // 
            this.source.DisplayIndex = 1;
            this.source.Text = "ソース";
            this.source.Width = 160;
            // 
            // CMnuDebugData
            // 
            this.CMnuDebugData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMnuDebugData_MoveFirst,
            this.CMnuDebugData_MoveLast,
            this.CMnuDebugData_AddLine,
            this.CMnuDebugData_Sepa1,
            this.CMnuDebugData_Clear,
            this.CMnuDebugData_CopySelection,
            this.CMnuDebugData_CopyAll});
            this.CMnuDebugData.Name = "CMnuDebugData";
            this.CMnuDebugData.Size = new System.Drawing.Size(181, 164);
            this.CMnuDebugData.Opening += new System.ComponentModel.CancelEventHandler(this.CMnuDebugData_Opening);
            // 
            // CMnuDebugData_MoveFirst
            // 
            this.CMnuDebugData_MoveFirst.Name = "CMnuDebugData_MoveFirst";
            this.CMnuDebugData_MoveFirst.Size = new System.Drawing.Size(180, 22);
            this.CMnuDebugData_MoveFirst.Text = "最上部へ移動";
            this.CMnuDebugData_MoveFirst.Click += new System.EventHandler(this.CMnuDebugData_MoveFirst_Click);
            // 
            // CMnuDebugData_MoveLast
            // 
            this.CMnuDebugData_MoveLast.Name = "CMnuDebugData_MoveLast";
            this.CMnuDebugData_MoveLast.Size = new System.Drawing.Size(180, 22);
            this.CMnuDebugData_MoveLast.Text = "最下部へ移動";
            this.CMnuDebugData_MoveLast.Click += new System.EventHandler(this.CMnuDebugData_MoveLast_Click);
            // 
            // CMnuDebugData_AddLine
            // 
            this.CMnuDebugData_AddLine.Name = "CMnuDebugData_AddLine";
            this.CMnuDebugData_AddLine.Size = new System.Drawing.Size(180, 22);
            this.CMnuDebugData_AddLine.Text = "区切り線を追加(&S)";
            this.CMnuDebugData_AddLine.Click += new System.EventHandler(this.CMnuDebugData_AddLine_Click);
            // 
            // CMnuDebugData_Sepa1
            // 
            this.CMnuDebugData_Sepa1.Name = "CMnuDebugData_Sepa1";
            this.CMnuDebugData_Sepa1.Size = new System.Drawing.Size(177, 6);
            // 
            // CMnuDebugData_Clear
            // 
            this.CMnuDebugData_Clear.Name = "CMnuDebugData_Clear";
            this.CMnuDebugData_Clear.Size = new System.Drawing.Size(180, 22);
            this.CMnuDebugData_Clear.Text = "クリア(&L)";
            this.CMnuDebugData_Clear.Click += new System.EventHandler(this.CMnuDebugData_Clear_Click);
            // 
            // CMnuDebugData_CopyAll
            // 
            this.CMnuDebugData_CopyAll.Name = "CMnuDebugData_CopyAll";
            this.CMnuDebugData_CopyAll.Size = new System.Drawing.Size(180, 22);
            this.CMnuDebugData_CopyAll.Text = "すべてコピー(&C)";
            this.CMnuDebugData_CopyAll.Click += new System.EventHandler(this.CMnuDebugData_CopyAll_Click);
            // 
            // PnlDebugData
            // 
            this.PnlDebugData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlDebugData.Location = new System.Drawing.Point(0, 0);
            this.PnlDebugData.Name = "PnlDebugData";
            this.PnlDebugData.Size = new System.Drawing.Size(800, 133);
            this.PnlDebugData.TabIndex = 0;
            // 
            // CMnuDebugData_CopySelection
            // 
            this.CMnuDebugData_CopySelection.Name = "CMnuDebugData_CopySelection";
            this.CMnuDebugData_CopySelection.Size = new System.Drawing.Size(180, 22);
            this.CMnuDebugData_CopySelection.Text = "選択部分をコピー";
            this.CMnuDebugData_CopySelection.Click += new System.EventHandler(this.CMnuDebugData_CopySelection_Click);
            // 
            // FrmOutputView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmOutputView";
            this.Text = "出力";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmOutputView_FormClosing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.CMnuDebugData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView LvwDebugData;
        private System.Windows.Forms.ColumnHeader message;
        private System.Windows.Forms.ColumnHeader dateTime;
        private System.Windows.Forms.ColumnHeader source;
        private CtlDebugDataPanel PnlDebugData;
        private System.Windows.Forms.ContextMenuStrip CMnuDebugData;
        private System.Windows.Forms.ToolStripMenuItem CMnuDebugData_MoveFirst;
        private System.Windows.Forms.ToolStripMenuItem CMnuDebugData_MoveLast;
        private System.Windows.Forms.ToolStripSeparator CMnuDebugData_Sepa1;
        private System.Windows.Forms.ToolStripMenuItem CMnuDebugData_Clear;
        private System.Windows.Forms.ToolStripMenuItem CMnuDebugData_CopyAll;
        private System.Windows.Forms.ToolStripMenuItem CMnuDebugData_AddLine;
        private System.Windows.Forms.ToolStripMenuItem CMnuDebugData_CopySelection;
    }
}