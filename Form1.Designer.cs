namespace onlineChat
{
    partial class mainWindow
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.avatar = new System.Windows.Forms.PictureBox();
            this.userName = new System.Windows.Forms.Label();
            this.IPAddress = new System.Windows.Forms.Label();
            this.recentUserList = new System.Windows.Forms.ListBox();
            this.seeeionTab = new System.Windows.Forms.TabControl();
            this.onlineTab = new System.Windows.Forms.TabPage();
            this.onlineUserList = new System.Windows.Forms.ListBox();
            this.recentSessionTab = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.seeeionTab.SuspendLayout();
            this.onlineTab.SuspendLayout();
            this.recentSessionTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // avatar
            // 
            this.avatar.BackColor = System.Drawing.Color.CadetBlue;
            this.avatar.Image = ((System.Drawing.Image)(resources.GetObject("avatar.Image")));
            this.avatar.Location = new System.Drawing.Point(26, 46);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(100, 100);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar.TabIndex = 0;
            this.avatar.TabStop = false;
            this.avatar.Click += new System.EventHandler(this.Avatar_Click);
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userName.Location = new System.Drawing.Point(149, 46);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(253, 30);
            this.userName.TabIndex = 1;
            this.userName.Text = "黄伟业";
            this.userName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IPAddress
            // 
            this.IPAddress.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IPAddress.Location = new System.Drawing.Point(149, 116);
            this.IPAddress.Name = "IPAddress";
            this.IPAddress.Size = new System.Drawing.Size(253, 30);
            this.IPAddress.TabIndex = 2;
            this.IPAddress.Text = "127.0.0.1";
            this.IPAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // recentUserList
            // 
            this.recentUserList.BackColor = System.Drawing.SystemColors.Window;
            this.recentUserList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recentUserList.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recentUserList.FormattingEnabled = true;
            this.recentUserList.ItemHeight = 24;
            this.recentUserList.Items.AddRange(new object[] {
            "鼠辈（192.168.43.12）",
            "江某民（192.168.43.26）",
            "pilotWei（192.168.43.22）",
            "zigzag（192.168.43.55）"});
            this.recentUserList.Location = new System.Drawing.Point(0, -1);
            this.recentUserList.Name = "recentUserList";
            this.recentUserList.Size = new System.Drawing.Size(372, 744);
            this.recentUserList.TabIndex = 6;
            this.recentUserList.SelectedIndexChanged += new System.EventHandler(this.OnlineList_SelectedIndexChanged);
            // 
            // seeeionTab
            // 
            this.seeeionTab.Controls.Add(this.onlineTab);
            this.seeeionTab.Controls.Add(this.recentSessionTab);
            this.seeeionTab.Location = new System.Drawing.Point(26, 163);
            this.seeeionTab.Name = "seeeionTab";
            this.seeeionTab.SelectedIndex = 0;
            this.seeeionTab.Size = new System.Drawing.Size(380, 778);
            this.seeeionTab.TabIndex = 7;
            // 
            // onlineTab
            // 
            this.onlineTab.Controls.Add(this.onlineUserList);
            this.onlineTab.Location = new System.Drawing.Point(4, 25);
            this.onlineTab.Name = "onlineTab";
            this.onlineTab.Padding = new System.Windows.Forms.Padding(3);
            this.onlineTab.Size = new System.Drawing.Size(372, 749);
            this.onlineTab.TabIndex = 0;
            this.onlineTab.Text = "在线用户";
            this.onlineTab.UseVisualStyleBackColor = true;
            // 
            // onlineUserList
            // 
            this.onlineUserList.BackColor = System.Drawing.SystemColors.Window;
            this.onlineUserList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.onlineUserList.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.onlineUserList.FormattingEnabled = true;
            this.onlineUserList.ItemHeight = 24;
            this.onlineUserList.Items.AddRange(new object[] {
            "鼠辈（192.168.43.12）",
            "江某民（192.168.43.26）",
            "pilotWei（192.168.43.22）",
            "zigzag（192.168.43.55）"});
            this.onlineUserList.Location = new System.Drawing.Point(0, -1);
            this.onlineUserList.Name = "onlineUserList";
            this.onlineUserList.Size = new System.Drawing.Size(372, 744);
            this.onlineUserList.TabIndex = 7;
            this.onlineUserList.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // recentSessionTab
            // 
            this.recentSessionTab.Controls.Add(this.recentUserList);
            this.recentSessionTab.Location = new System.Drawing.Point(4, 25);
            this.recentSessionTab.Name = "recentSessionTab";
            this.recentSessionTab.Padding = new System.Windows.Forms.Padding(3);
            this.recentSessionTab.Size = new System.Drawing.Size(372, 749);
            this.recentSessionTab.TabIndex = 1;
            this.recentSessionTab.Text = "最近会话";
            this.recentSessionTab.UseVisualStyleBackColor = true;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 953);
            this.Controls.Add(this.seeeionTab);
            this.Controls.Add(this.IPAddress);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.avatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainWindow";
            this.Text = "onlineChat";
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.seeeionTab.ResumeLayout(false);
            this.onlineTab.ResumeLayout(false);
            this.recentSessionTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label IPAddress;
        private System.Windows.Forms.ListBox recentUserList;
        private System.Windows.Forms.TabControl seeeionTab;
        private System.Windows.Forms.TabPage onlineTab;
        private System.Windows.Forms.TabPage recentSessionTab;
        private System.Windows.Forms.ListBox onlineUserList;
    }
}

