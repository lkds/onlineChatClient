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
            this.onlineUserListBox = new System.Windows.Forms.TabPage();
            this.recentChatUserListBox = new System.Windows.Forms.TabPage();
            this.mainStartGroupBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainUserAvatarBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainUserAvatarBox
            // 
            this.mainUserAvatarBox.Image = ((System.Drawing.Image)(resources.GetObject("mainUserAvatarBox.Image")));
            this.mainUserAvatarBox.Location = new System.Drawing.Point(11, 15);
            this.mainUserAvatarBox.Margin = new System.Windows.Forms.Padding(4);
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
            this.tabControl1.Controls.Add(this.onlineUserListBox);
            this.tabControl1.Controls.Add(this.recentChatUserListBox);
            this.tabControl1.Location = new System.Drawing.Point(5, 121);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(336, 522);
            this.tabControl1.TabIndex = 3;
            // 
            // onlineUserListBox
            // 
            this.onlineUserListBox.Location = new System.Drawing.Point(4, 25);
            this.onlineUserListBox.Margin = new System.Windows.Forms.Padding(4);
            this.onlineUserListBox.Name = "onlineUserListBox";
            this.onlineUserListBox.Padding = new System.Windows.Forms.Padding(4);
            this.onlineUserListBox.Size = new System.Drawing.Size(328, 493);
            this.onlineUserListBox.TabIndex = 0;
            this.onlineUserListBox.Text = "在线用户";
            this.onlineUserListBox.UseVisualStyleBackColor = true;
            // 
            // recentChatUserListBox
            // 
            this.recentChatUserListBox.Location = new System.Drawing.Point(4, 25);
            this.recentChatUserListBox.Margin = new System.Windows.Forms.Padding(4);
            this.recentChatUserListBox.Name = "recentChatUserListBox";
            this.recentChatUserListBox.Padding = new System.Windows.Forms.Padding(4);
            this.recentChatUserListBox.Size = new System.Drawing.Size(328, 493);
            this.recentChatUserListBox.TabIndex = 1;
            this.recentChatUserListBox.Text = "最近聊过";
            this.recentChatUserListBox.UseVisualStyleBackColor = true;
            // 
            // mainStartGroupBtn
            // 
            this.mainStartGroupBtn.Font = new System.Drawing.Font("宋体", 7F);
            this.mainStartGroupBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.mainStartGroupBtn.Location = new System.Drawing.Point(229, 112);
            this.mainStartGroupBtn.Margin = new System.Windows.Forms.Padding(4);
            this.mainStartGroupBtn.Name = "mainStartGroupBtn";
            this.mainStartGroupBtn.Size = new System.Drawing.Size(100, 29);
            this.mainStartGroupBtn.TabIndex = 4;
            this.mainStartGroupBtn.Text = "发起群聊";
            this.mainStartGroupBtn.UseVisualStyleBackColor = true;
            this.mainStartGroupBtn.Click += new System.EventHandler(this.MainStartGroupBtn_Click);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 659);
            this.Controls.Add(this.mainStartGroupBtn);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.mainUserIPLabel);
            this.Controls.Add(this.mainUserNameLabel);
            this.Controls.Add(this.mainUserAvatarBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainPage";
            this.Text = "DogChat火烈狗聊天";
            ((System.ComponentModel.ISupportInitialize)(this.mainUserAvatarBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainUserAvatarBox;
        private System.Windows.Forms.Label mainUserNameLabel;
        private System.Windows.Forms.Label mainUserIPLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage onlineUserListBox;
        private System.Windows.Forms.TabPage recentChatUserListBox;
        private System.Windows.Forms.Button mainStartGroupBtn;
    }
}