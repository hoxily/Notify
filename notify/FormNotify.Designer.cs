namespace notify
{
    partial class FormNotify
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotify));
            this.myNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.myMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyDataGrid = new System.Windows.Forms.DataGridView();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTimeout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notifyDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // myNotify
            // 
            this.myNotify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.myNotify.ContextMenuStrip = this.myMenu;
            this.myNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("myNotify.Icon")));
            this.myNotify.Text = "Notify Tray";
            this.myNotify.Visible = true;
            this.myNotify.Click += new System.EventHandler(this.myNotify_Click);
            // 
            // myMenu
            // 
            this.myMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitEToolStripMenuItem});
            this.myMenu.Name = "myMenu";
            this.myMenu.Size = new System.Drawing.Size(112, 26);
            // 
            // exitEToolStripMenuItem
            // 
            this.exitEToolStripMenuItem.Name = "exitEToolStripMenuItem";
            this.exitEToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.exitEToolStripMenuItem.Text = "Exit(&E)";
            this.exitEToolStripMenuItem.Click += new System.EventHandler(this.exitEToolStripMenuItem_Click);
            // 
            // notifyDataGrid
            // 
            this.notifyDataGrid.AllowUserToAddRows = false;
            this.notifyDataGrid.AllowUserToDeleteRows = false;
            this.notifyDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notifyDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTime,
            this.ColumnTimeout,
            this.ColumnTitle,
            this.ColumnText});
            this.notifyDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notifyDataGrid.Location = new System.Drawing.Point(0, 0);
            this.notifyDataGrid.Name = "notifyDataGrid";
            this.notifyDataGrid.ReadOnly = true;
            this.notifyDataGrid.RowTemplate.Height = 23;
            this.notifyDataGrid.Size = new System.Drawing.Size(624, 442);
            this.notifyDataGrid.TabIndex = 1;
            // 
            // ColumnTime
            // 
            this.ColumnTime.FillWeight = 150F;
            this.ColumnTime.HeaderText = "接收时间";
            this.ColumnTime.Name = "ColumnTime";
            this.ColumnTime.ReadOnly = true;
            this.ColumnTime.ToolTipText = "消息接收时间";
            this.ColumnTime.Width = 120;
            // 
            // ColumnTimeout
            // 
            this.ColumnTimeout.HeaderText = "持续时间";
            this.ColumnTimeout.Name = "ColumnTimeout";
            this.ColumnTimeout.ReadOnly = true;
            this.ColumnTimeout.ToolTipText = "提示持续时间（毫秒）";
            this.ColumnTimeout.Width = 80;
            // 
            // ColumnTitle
            // 
            this.ColumnTitle.HeaderText = "标题";
            this.ColumnTitle.Name = "ColumnTitle";
            this.ColumnTitle.ReadOnly = true;
            this.ColumnTitle.ToolTipText = "消息标题";
            this.ColumnTitle.Width = 180;
            // 
            // ColumnText
            // 
            this.ColumnText.HeaderText = "正文";
            this.ColumnText.Name = "ColumnText";
            this.ColumnText.ReadOnly = true;
            this.ColumnText.ToolTipText = "消息正文";
            this.ColumnText.Width = 200;
            // 
            // FormNotify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.notifyDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNotify";
            this.Text = "Notify List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNotify_FormClosing);
            this.Load += new System.EventHandler(this.FormNotify_Load);
            this.myMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.notifyDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon myNotify;
        private System.Windows.Forms.ContextMenuStrip myMenu;
        private System.Windows.Forms.ToolStripMenuItem exitEToolStripMenuItem;
        private System.Windows.Forms.DataGridView notifyDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTimeout;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnText;
    }
}

