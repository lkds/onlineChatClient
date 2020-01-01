namespace onlineChat
{
    partial class mainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPage));
            this.mainUserAvatarBox = new System.Windows.Forms.PictureBox();
            this.mainUserNameLabel = new System.Windows.Forms.Label();
            this.mainUserIPLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.onlineUserTab = new System.Windows.Forms.TabPage();
            this.onlineUserListBox = new CCWin.SkinControl.ChatListBox();
            this.recentChatTab = new System.Windows.Forms.TabPage();
            this.recentChatListBox = new CCWin.SkinControl.ChatListBox();
            this.groupChatTab = new System.Windows.Forms.TabPage();
            this.groupChatListBox = new CCWin.SkinControl.ChatListBox();
            this.startNewGroupBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainUserAvatarBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.onlineUserTab.SuspendLayout();
            this.recentChatTab.SuspendLayout();
            this.groupChatTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainUserAvatarBox
            // 
            this.mainUserAvatarBox.Image = ((System.Drawing.Image)(resources.GetObject("mainUserAvatarBox.Image")));
            this.mainUserAvatarBox.Location = new System.Drawing.Point(11, 15);
            this.mainUserAvatarBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainUserAvatarBox.Name = "mainUserAvatarBox";
            this.mainUserAvatarBox.Size = new System.Drawing.Size(100, 100);
            this.mainUserAvatarBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainUserAvatarBox.TabIndex = 0;
            this.mainUserAvatarBox.TabStop = false;
            this.mainUserAvatarBox.Click += new System.EventHandler(this.MainUserAvatarBox_Click);
            // 
            // mainUserNameLabel
            // 
            this.mainUserNameLabel.AutoSize = true;
            this.mainUserNameLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mainUserNameLabel.Location = new System.Drawing.Point(131, 26);
            this.mainUserNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mainUserNameLabel.Name = "mainUserNameLabel";
            this.mainUserNameLabel.Size = new System.Drawing.Size(72, 27);
            this.mainUserNameLabel.TabIndex = 1;
            this.mainUserNameLabel.Text = "黄伟业";
            // 
            // mainUserIPLabel
            // 
            this.mainUserIPLabel.AutoSize = true;
            this.mainUserIPLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mainUserIPLabel.Location = new System.Drawing.Point(131, 66);
            this.mainUserIPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mainUserIPLabel.Name = "mainUserIPLabel";
            this.mainUserIPLabel.Size = new System.Drawing.Size(150, 27);
            this.mainUserIPLabel.TabIndex = 2;
            this.mainUserIPLabel.Text = "198.168.2.275";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.onlineUserTab);
            this.tabControl1.Controls.Add(this.recentChatTab);
            this.tabControl1.Controls.Add(this.groupChatTab);
            this.tabControl1.Location = new System.Drawing.Point(5, 122);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(336, 546);
            this.tabControl1.TabIndex = 3;
            // 
            // onlineUserTab
            // 
            this.onlineUserTab.Controls.Add(this.onlineUserListBox);
            this.onlineUserTab.Location = new System.Drawing.Point(4, 25);
            this.onlineUserTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.onlineUserTab.Name = "onlineUserTab";
            this.onlineUserTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.onlineUserTab.Size = new System.Drawing.Size(328, 517);
            this.onlineUserTab.TabIndex = 0;
            this.onlineUserTab.Text = "在线用户";
            this.onlineUserTab.UseVisualStyleBackColor = true;
            // 
            // onlineUserListBox
            // 
            this.onlineUserListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.onlineUserListBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.onlineUserListBox.ForeColor = System.Drawing.Color.Black;
            this.onlineUserListBox.FriendsMobile = true;
            this.onlineUserListBox.ListSubItemMenu = null;
            this.onlineUserListBox.Location = new System.Drawing.Point(3, 2);
            this.onlineUserListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.onlineUserListBox.Name = "onlineUserListBox";
            this.onlineUserListBox.SelectSubItem = null;
            this.onlineUserListBox.Size = new System.Drawing.Size(321, 508);
            this.onlineUserListBox.SubItemMenu = null;
            this.onlineUserListBox.TabIndex = 0;
            this.onlineUserListBox.Text = "chatListBox1";
            this.onlineUserListBox.DoubleClickSubItem += new CCWin.SkinControl.ChatListBox.ChatListEventHandler(this.onlineUserListBox_DoubleClickSubItem);
            this.onlineUserListBox.Click += new System.EventHandler(this.onlineUserListBox_Click);
            // 
            // recentChatTab
            // 
            this.recentChatTab.Controls.Add(this.recentChatListBox);
            this.recentChatTab.Location = new System.Drawing.Point(4, 25);
            this.recentChatTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.recentChatTab.Name = "recentChatTab";
            this.recentChatTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.recentChatTab.Size = new System.Drawing.Size(328, 517);
            this.recentChatTab.TabIndex = 1;
            this.recentChatTab.Text = "最近会话";
            this.recentChatTab.UseVisualStyleBackColor = true;
            // 
            // recentChatListBox
            // 
            this.recentChatListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.recentChatListBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recentChatListBox.ForeColor = System.Drawing.Color.Black;
            this.recentChatListBox.FriendsMobile = true;
            this.recentChatListBox.ListSubItemMenu = null;
            this.recentChatListBox.Location = new System.Drawing.Point(3, 2);
            this.recentChatListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.recentChatListBox.Name = "recentChatListBox";
            this.recentChatListBox.SelectSubItem = null;
            this.recentChatListBox.Size = new System.Drawing.Size(321, 508);
            this.recentChatListBox.SubItemMenu = null;
            this.recentChatListBox.TabIndex = 0;
            this.recentChatListBox.Text = "chatListBox1";
            this.recentChatListBox.DoubleClickSubItem += new CCWin.SkinControl.ChatListBox.ChatListEventHandler(this.recentChatListBox_DoubleClickSubItem);
            // 
            // groupChatTab
            // 
            this.groupChatTab.BackColor = System.Drawing.Color.Transparent;
            this.groupChatTab.Controls.Add(this.groupChatListBox);
            this.groupChatTab.Controls.Add(this.startNewGroupBtn);
            this.groupChatTab.Location = new System.Drawing.Point(4, 25);
            this.groupChatTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupChatTab.Name = "groupChatTab";
            this.groupChatTab.Size = new System.Drawing.Size(328, 517);
            this.groupChatTab.TabIndex = 2;
            this.groupChatTab.Text = "我的群聊";
            // 
            // groupChatListBox
            // 
            this.groupChatListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupChatListBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupChatListBox.ForeColor = System.Drawing.Color.Black;
            this.groupChatListBox.FriendsMobile = true;
            this.groupChatListBox.ListSubItemMenu = null;
            this.groupChatListBox.Location = new System.Drawing.Point(0, 35);
            this.groupChatListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupChatListBox.Name = "groupChatListBox";
            this.groupChatListBox.SelectSubItem = null;
            this.groupChatListBox.Size = new System.Drawing.Size(324, 472);
            this.groupChatListBox.SubItemMenu = null;
            this.groupChatListBox.TabIndex = 1;
            this.groupChatListBox.Text = "chatListBox1";
            this.groupChatListBox.DoubleClickSubItem += new CCWin.SkinControl.ChatListBox.ChatListEventHandler(this.groupChatListBox_DoubleClickSubItem);
            // 
            // startNewGroupBtn
            // 
            this.startNewGroupBtn.Font = new System.Drawing.Font("微软雅黑", 7.75F);
            this.startNewGroupBtn.ForeColor = System.Drawing.Color.MediumBlue;
            this.startNewGroupBtn.Location = new System.Drawing.Point(5, 4);
            this.startNewGroupBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startNewGroupBtn.Name = "startNewGroupBtn";
            this.startNewGroupBtn.Size = new System.Drawing.Size(313, 30);
            this.startNewGroupBtn.TabIndex = 0;
            this.startNewGroupBtn.Text = "发起新的群聊";
            this.startNewGroupBtn.UseVisualStyleBackColor = true;
            this.startNewGroupBtn.Click += new System.EventHandler(this.startNewGroupBtn_Click);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 672);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.mainUserIPLabel);
            this.Controls.Add(this.mainUserNameLabel);
            this.Controls.Add(this.mainUserAvatarBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "mainPage";
            this.Text = "DogChat火烈狗聊天";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainUserAvatarBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.onlineUserTab.ResumeLayout(false);
            this.recentChatTab.ResumeLayout(false);
            this.groupChatTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainUserAvatarBox;
        private System.Windows.Forms.Label mainUserNameLabel;
        private System.Windows.Forms.Label mainUserIPLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage onlineUserTab;
        private System.Windows.Forms.TabPage recentChatTab;
        private System.Windows.Forms.TabPage groupChatTab;
        private System.Windows.Forms.Button startNewGroupBtn;
        private CCWin.SkinControl.ChatListBox onlineUserListBox;
        private CCWin.SkinControl.ChatListBox recentChatListBox;
        private CCWin.SkinControl.ChatListBox groupChatListBox;
    }
}