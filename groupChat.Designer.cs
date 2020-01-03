namespace onlineChat
{
    partial class groupChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(groupChat));
            this.chatQuitGroupBtn = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.chatSendBtn = new System.Windows.Forms.Button();
            this.chatGroupName = new System.Windows.Forms.Label();
            this.fileSelectBox = new System.Windows.Forms.PictureBox();
            this.imageSelectBox = new System.Windows.Forms.PictureBox();
            this.groupAvatarBox = new System.Windows.Forms.PictureBox();
            this.groupAvatar = new System.Windows.Forms.PictureBox();
            this.groupChatMessageBox = new System.Windows.Forms.RichTextBox();
            this.groupMemberListBox = new CCWin.SkinControl.ChatListBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSelectBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSelectBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupAvatarBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // chatQuitGroupBtn
            // 
            this.chatQuitGroupBtn.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.chatQuitGroupBtn.ForeColor = System.Drawing.Color.Red;
            this.chatQuitGroupBtn.Location = new System.Drawing.Point(65, 511);
            this.chatQuitGroupBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chatQuitGroupBtn.Name = "chatQuitGroupBtn";
            this.chatQuitGroupBtn.Size = new System.Drawing.Size(100, 36);
            this.chatQuitGroupBtn.TabIndex = 1;
            this.chatQuitGroupBtn.Text = "退出群聊";
            this.chatQuitGroupBtn.UseVisualStyleBackColor = true;
            this.chatQuitGroupBtn.Click += new System.EventHandler(this.chatQuitGroupBtn_Click);
            // 
            // inputBox
            // 
            this.inputBox.BackColor = System.Drawing.Color.LightGreen;
            this.inputBox.Location = new System.Drawing.Point(243, 436);
            this.inputBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(620, 110);
            this.inputBox.TabIndex = 3;
            // 
            // chatSendBtn
            // 
            this.chatSendBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chatSendBtn.ForeColor = System.Drawing.Color.Green;
            this.chatSendBtn.Location = new System.Drawing.Point(889, 508);
            this.chatSendBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chatSendBtn.Name = "chatSendBtn";
            this.chatSendBtn.Size = new System.Drawing.Size(105, 38);
            this.chatSendBtn.TabIndex = 4;
            this.chatSendBtn.Text = "发送";
            this.chatSendBtn.UseVisualStyleBackColor = true;
            this.chatSendBtn.Click += new System.EventHandler(this.chatSendBtn_Click);
            // 
            // chatGroupName
            // 
            this.chatGroupName.AutoSize = true;
            this.chatGroupName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chatGroupName.Location = new System.Drawing.Point(76, 25);
            this.chatGroupName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chatGroupName.Name = "chatGroupName";
            this.chatGroupName.Size = new System.Drawing.Size(112, 27);
            this.chatGroupName.TabIndex = 7;
            this.chatGroupName.Text = "西瓜俱乐部";
            this.chatGroupName.Click += new System.EventHandler(this.Label1_Click);
            // 
            // fileSelectBox
            // 
            this.fileSelectBox.Image = ((System.Drawing.Image)(resources.GetObject("fileSelectBox.Image")));
            this.fileSelectBox.Location = new System.Drawing.Point(949, 436);
            this.fileSelectBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fileSelectBox.Name = "fileSelectBox";
            this.fileSelectBox.Size = new System.Drawing.Size(44, 40);
            this.fileSelectBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fileSelectBox.TabIndex = 9;
            this.fileSelectBox.TabStop = false;
            this.fileSelectBox.Click += new System.EventHandler(this.FileSelectBox_Click);
            // 
            // imageSelectBox
            // 
            this.imageSelectBox.Image = ((System.Drawing.Image)(resources.GetObject("imageSelectBox.Image")));
            this.imageSelectBox.Location = new System.Drawing.Point(889, 436);
            this.imageSelectBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imageSelectBox.Name = "imageSelectBox";
            this.imageSelectBox.Size = new System.Drawing.Size(44, 40);
            this.imageSelectBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageSelectBox.TabIndex = 8;
            this.imageSelectBox.TabStop = false;
            this.imageSelectBox.Click += new System.EventHandler(this.ImageSelectBox_Click);
            // 
            // groupAvatarBox
            // 
            this.groupAvatarBox.Image = ((System.Drawing.Image)(resources.GetObject("groupAvatarBox.Image")));
            this.groupAvatarBox.Location = new System.Drawing.Point(3, 4);
            this.groupAvatarBox.Name = "groupAvatarBox";
            this.groupAvatarBox.Size = new System.Drawing.Size(60, 60);
            this.groupAvatarBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.groupAvatarBox.TabIndex = 10;
            this.groupAvatarBox.TabStop = false;
            // 
            // groupAvatar
            // 
            this.groupAvatar.Image = ((System.Drawing.Image)(resources.GetObject("groupAvatar.Image")));
            this.groupAvatar.Location = new System.Drawing.Point(9, 12);
            this.groupAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupAvatar.Name = "groupAvatar";
            this.groupAvatar.Size = new System.Drawing.Size(60, 58);
            this.groupAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.groupAvatar.TabIndex = 10;
            this.groupAvatar.TabStop = false;
            // 
            // groupChatMessageBox
            // 
            this.groupChatMessageBox.BackColor = System.Drawing.Color.LightBlue;
            this.groupChatMessageBox.Location = new System.Drawing.Point(229, 6);
            this.groupChatMessageBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupChatMessageBox.Name = "groupChatMessageBox";
            this.groupChatMessageBox.Size = new System.Drawing.Size(768, 416);
            this.groupChatMessageBox.TabIndex = 11;
            this.groupChatMessageBox.Text = "";
            // 
            // groupMemberListBox
            // 
            this.groupMemberListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupMemberListBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupMemberListBox.ForeColor = System.Drawing.Color.Black;
            this.groupMemberListBox.FriendsMobile = true;
            this.groupMemberListBox.ListSubItemMenu = null;
            this.groupMemberListBox.Location = new System.Drawing.Point(9, 85);
            this.groupMemberListBox.Name = "groupMemberListBox";
            this.groupMemberListBox.SelectSubItem = null;
            this.groupMemberListBox.Size = new System.Drawing.Size(213, 419);
            this.groupMemberListBox.SubItemMenu = null;
            this.groupMemberListBox.TabIndex = 12;
            this.groupMemberListBox.Text = "chatListBox1";
            // 
            // groupChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 562);
            this.Controls.Add(this.groupMemberListBox);
            this.Controls.Add(this.groupChatMessageBox);
            this.Controls.Add(this.groupAvatar);
            this.Controls.Add(this.fileSelectBox);
            this.Controls.Add(this.imageSelectBox);
            this.Controls.Add(this.chatGroupName);
            this.Controls.Add(this.chatSendBtn);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.chatQuitGroupBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "groupChat";
            this.Text = "群聊";
            ((System.ComponentModel.ISupportInitialize)(this.fileSelectBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSelectBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupAvatarBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button chatQuitGroupBtn;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button chatSendBtn;
        private System.Windows.Forms.Label chatGroupName;
        private System.Windows.Forms.PictureBox fileSelectBox;
        private System.Windows.Forms.PictureBox imageSelectBox;
        private System.Windows.Forms.PictureBox groupAvatarBox;
        private System.Windows.Forms.PictureBox groupAvatar;
        private System.Windows.Forms.RichTextBox groupChatMessageBox;
        private CCWin.SkinControl.ChatListBox groupMemberListBox;
    }
}