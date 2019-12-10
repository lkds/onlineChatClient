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
            this.onlineUserList = new System.Windows.Forms.TabPage();
            this.recentChatList = new System.Windows.Forms.TabPage();
            this.myGroupList = new System.Windows.Forms.TabPage();
            this.startNewGroupBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainUserAvatarBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.myGroupList.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainUserAvatarBox
            // 
            this.mainUserAvatarBox.Image = ((System.Drawing.Image)(resources.GetObject("mainUserAvatarBox.Image")));
            this.mainUserAvatarBox.Location = new System.Drawing.Point(8, 12);
            this.mainUserAvatarBox.Name = "mainUserAvatarBox";
            this.mainUserAvatarBox.Size = new System.Drawing.Size(75, 80);
            this.mainUserAvatarBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainUserAvatarBox.TabIndex = 0;
            this.mainUserAvatarBox.TabStop = false;
            // 
            // mainUserNameLabel
            // 
            this.mainUserNameLabel.AutoSize = true;
            this.mainUserNameLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mainUserNameLabel.Location = new System.Drawing.Point(98, 21);
            this.mainUserNameLabel.Name = "mainUserNameLabel";
            this.mainUserNameLabel.Size = new System.Drawing.Size(58, 22);
            this.mainUserNameLabel.TabIndex = 1;
            this.mainUserNameLabel.Text = "黄伟业";
            // 
            // mainUserIPLabel
            // 
            this.mainUserIPLabel.AutoSize = true;
            this.mainUserIPLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mainUserIPLabel.Location = new System.Drawing.Point(98, 53);
            this.mainUserIPLabel.Name = "mainUserIPLabel";
            this.mainUserIPLabel.Size = new System.Drawing.Size(125, 22);
            this.mainUserIPLabel.TabIndex = 2;
            this.mainUserIPLabel.Text = "198.168.2.275";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.onlineUserList);
            this.tabControl1.Controls.Add(this.recentChatList);
            this.tabControl1.Controls.Add(this.myGroupList);
            this.tabControl1.Location = new System.Drawing.Point(4, 98);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(252, 437);
            this.tabControl1.TabIndex = 3;
            // 
            // onlineUserList
            // 
            this.onlineUserList.Location = new System.Drawing.Point(4, 22);
            this.onlineUserList.Name = "onlineUserList";
            this.onlineUserList.Padding = new System.Windows.Forms.Padding(3);
            this.onlineUserList.Size = new System.Drawing.Size(244, 411);
            this.onlineUserList.TabIndex = 0;
            this.onlineUserList.Text = "在线用户";
            this.onlineUserList.UseVisualStyleBackColor = true;
            // 
            // recentChatList
            // 
            this.recentChatList.Location = new System.Drawing.Point(4, 22);
            this.recentChatList.Name = "recentChatList";
            this.recentChatList.Padding = new System.Windows.Forms.Padding(3);
            this.recentChatList.Size = new System.Drawing.Size(244, 411);
            this.recentChatList.TabIndex = 1;
            this.recentChatList.Text = "最近会话";
            this.recentChatList.UseVisualStyleBackColor = true;
            // 
            // myGroupList
            // 
            this.myGroupList.BackColor = System.Drawing.Color.Transparent;
            this.myGroupList.Controls.Add(this.startNewGroupBtn);
            this.myGroupList.Location = new System.Drawing.Point(4, 22);
            this.myGroupList.Name = "myGroupList";
            this.myGroupList.Size = new System.Drawing.Size(244, 411);
            this.myGroupList.TabIndex = 2;
            this.myGroupList.Text = "我的群聊";
            // 
            // startNewGroupBtn
            // 
            this.startNewGroupBtn.Font = new System.Drawing.Font("微软雅黑", 7.75F);
            this.startNewGroupBtn.ForeColor = System.Drawing.Color.MediumBlue;
            this.startNewGroupBtn.Location = new System.Drawing.Point(4, 3);
            this.startNewGroupBtn.Name = "startNewGroupBtn";
            this.startNewGroupBtn.Size = new System.Drawing.Size(235, 24);
            this.startNewGroupBtn.TabIndex = 0;
            this.startNewGroupBtn.Text = "发起新的群聊";
            this.startNewGroupBtn.UseVisualStyleBackColor = true;
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 538);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.mainUserIPLabel);
            this.Controls.Add(this.mainUserNameLabel);
            this.Controls.Add(this.mainUserAvatarBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainPage";
            this.Text = "DogChat火烈狗聊天";
            ((System.ComponentModel.ISupportInitialize)(this.mainUserAvatarBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.myGroupList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainUserAvatarBox;
        private System.Windows.Forms.Label mainUserNameLabel;
        private System.Windows.Forms.Label mainUserIPLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage onlineUserList;
        private System.Windows.Forms.TabPage recentChatList;
        private System.Windows.Forms.TabPage myGroupList;
        private System.Windows.Forms.Button startNewGroupBtn;
    }
}