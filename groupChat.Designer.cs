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
            this.chatUserListBox = new System.Windows.Forms.ListBox();
            this.chatQuitGroupBtn = new System.Windows.Forms.Button();
            this.chatMessageBox = new System.Windows.Forms.ListBox();
            this.chatSendBox = new System.Windows.Forms.TextBox();
            this.chatSendBtn = new System.Windows.Forms.Button();
            this.chatGroupName = new System.Windows.Forms.Label();
            this.fileSelectBox = new System.Windows.Forms.PictureBox();
            this.imageSelectBox = new System.Windows.Forms.PictureBox();
            this.groupAvatarBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSelectBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSelectBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupAvatarBox)).BeginInit();
            this.SuspendLayout();
            // 
            // chatUserListBox
            // 
            this.chatUserListBox.FormattingEnabled = true;
            this.chatUserListBox.ItemHeight = 15;
            this.chatUserListBox.Location = new System.Drawing.Point(3, 71);
            this.chatUserListBox.Margin = new System.Windows.Forms.Padding(4);
            this.chatUserListBox.Name = "chatUserListBox";
            this.chatUserListBox.Size = new System.Drawing.Size(219, 424);
            this.chatUserListBox.TabIndex = 0;
            // 
            // chatQuitGroupBtn
            // 
            this.chatQuitGroupBtn.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.chatQuitGroupBtn.ForeColor = System.Drawing.Color.Red;
            this.chatQuitGroupBtn.Location = new System.Drawing.Point(65, 511);
            this.chatQuitGroupBtn.Margin = new System.Windows.Forms.Padding(4);
            this.chatQuitGroupBtn.Name = "chatQuitGroupBtn";
            this.chatQuitGroupBtn.Size = new System.Drawing.Size(100, 36);
            this.chatQuitGroupBtn.TabIndex = 1;
            this.chatQuitGroupBtn.Text = "退出群聊";
            this.chatQuitGroupBtn.UseVisualStyleBackColor = true;
            // 
            // chatMessageBox
            // 
            this.chatMessageBox.FormattingEnabled = true;
            this.chatMessageBox.ItemHeight = 15;
            this.chatMessageBox.Location = new System.Drawing.Point(230, 4);
            this.chatMessageBox.Margin = new System.Windows.Forms.Padding(4);
            this.chatMessageBox.Name = "chatMessageBox";
            this.chatMessageBox.Size = new System.Drawing.Size(772, 409);
            this.chatMessageBox.TabIndex = 2;
            this.chatMessageBox.SelectedIndexChanged += new System.EventHandler(this.ListBox2_SelectedIndexChanged);
            // 
            // chatSendBox
            // 
            this.chatSendBox.Location = new System.Drawing.Point(230, 436);
            this.chatSendBox.Margin = new System.Windows.Forms.Padding(4);
            this.chatSendBox.Multiline = true;
            this.chatSendBox.Name = "chatSendBox";
            this.chatSendBox.Size = new System.Drawing.Size(633, 110);
            this.chatSendBox.TabIndex = 3;
            // 
            // chatSendBtn
            // 
            this.chatSendBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chatSendBtn.ForeColor = System.Drawing.Color.Green;
            this.chatSendBtn.Location = new System.Drawing.Point(889, 508);
            this.chatSendBtn.Margin = new System.Windows.Forms.Padding(4);
            this.chatSendBtn.Name = "chatSendBtn";
            this.chatSendBtn.Size = new System.Drawing.Size(105, 38);
            this.chatSendBtn.TabIndex = 4;
            this.chatSendBtn.Text = "发送";
            this.chatSendBtn.UseVisualStyleBackColor = true;
            // 
            // chatGroupName
            // 
            this.chatGroupName.AutoSize = true;
            this.chatGroupName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chatGroupName.Location = new System.Drawing.Point(70, 4);
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
            this.fileSelectBox.Location = new System.Drawing.Point(950, 436);
            this.fileSelectBox.Margin = new System.Windows.Forms.Padding(4);
            this.fileSelectBox.Name = "fileSelectBox";
            this.fileSelectBox.Size = new System.Drawing.Size(44, 40);
            this.fileSelectBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fileSelectBox.TabIndex = 9;
            this.fileSelectBox.TabStop = false;
            // 
            // imageSelectBox
            // 
            this.imageSelectBox.Image = ((System.Drawing.Image)(resources.GetObject("imageSelectBox.Image")));
            this.imageSelectBox.Location = new System.Drawing.Point(889, 436);
            this.imageSelectBox.Margin = new System.Windows.Forms.Padding(4);
            this.imageSelectBox.Name = "imageSelectBox";
            this.imageSelectBox.Size = new System.Drawing.Size(44, 40);
            this.imageSelectBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageSelectBox.TabIndex = 8;
            this.imageSelectBox.TabStop = false;
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
            // groupChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 562);
            this.Controls.Add(this.groupAvatarBox);
            this.Controls.Add(this.fileSelectBox);
            this.Controls.Add(this.imageSelectBox);
            this.Controls.Add(this.chatGroupName);
            this.Controls.Add(this.chatSendBtn);
            this.Controls.Add(this.chatSendBox);
            this.Controls.Add(this.chatMessageBox);
            this.Controls.Add(this.chatQuitGroupBtn);
            this.Controls.Add(this.chatUserListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "groupChat";
            this.Text = "群聊";
            ((System.ComponentModel.ISupportInitialize)(this.fileSelectBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSelectBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupAvatarBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox chatUserListBox;
        private System.Windows.Forms.Button chatQuitGroupBtn;
        private System.Windows.Forms.ListBox chatMessageBox;
        private System.Windows.Forms.TextBox chatSendBox;
        private System.Windows.Forms.Button chatSendBtn;
        private System.Windows.Forms.Label chatGroupName;
        private System.Windows.Forms.PictureBox fileSelectBox;
        private System.Windows.Forms.PictureBox imageSelectBox;
        private System.Windows.Forms.PictureBox groupAvatarBox;
    }
}