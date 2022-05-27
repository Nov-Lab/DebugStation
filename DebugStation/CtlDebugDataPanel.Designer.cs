
namespace DebugStation
{
    partial class CtlDebugDataPanel
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtHeaderInfo = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TxtContent = new System.Windows.Forms.TextBox();
            this.TxtDetail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtHeaderInfo
            // 
            this.TxtHeaderInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtHeaderInfo.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtHeaderInfo.Location = new System.Drawing.Point(8, 8);
            this.TxtHeaderInfo.Name = "TxtHeaderInfo";
            this.TxtHeaderInfo.ReadOnly = true;
            this.TxtHeaderInfo.Size = new System.Drawing.Size(384, 19);
            this.TxtHeaderInfo.TabIndex = 0;
            this.TxtHeaderInfo.Text = "TxtHeaderInfo";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(8, 32);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TxtContent);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TxtDetail);
            this.splitContainer1.Panel2MinSize = 20;
            this.splitContainer1.Size = new System.Drawing.Size(384, 360);
            this.splitContainer1.SplitterDistance = 318;
            this.splitContainer1.TabIndex = 1;
            // 
            // TxtContent
            // 
            this.TxtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtContent.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtContent.Location = new System.Drawing.Point(0, 0);
            this.TxtContent.Multiline = true;
            this.TxtContent.Name = "TxtContent";
            this.TxtContent.ReadOnly = true;
            this.TxtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtContent.Size = new System.Drawing.Size(384, 318);
            this.TxtContent.TabIndex = 1;
            this.TxtContent.Text = "TxtContent";
            // 
            // TxtDetail
            // 
            this.TxtDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtDetail.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtDetail.Location = new System.Drawing.Point(0, 0);
            this.TxtDetail.Multiline = true;
            this.TxtDetail.Name = "TxtDetail";
            this.TxtDetail.ReadOnly = true;
            this.TxtDetail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtDetail.Size = new System.Drawing.Size(384, 38);
            this.TxtDetail.TabIndex = 2;
            this.TxtDetail.Text = "TxtDetail-Line1\r\nTxtDetail-Line2";
            // 
            // CtlDebugDataPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.TxtHeaderInfo);
            this.Name = "CtlDebugDataPanel";
            this.Size = new System.Drawing.Size(400, 400);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtHeaderInfo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox TxtContent;
        private System.Windows.Forms.TextBox TxtDetail;
    }
}
