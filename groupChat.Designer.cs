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
            this.groupMemberListBox = new System.Windows.Forms.ListBox();
            this.chatQuitGroupBtn = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.chatSendBtn = new System.Windows.Forms.Button();
            this.chatGroupName = new System.Windows.Forms.Label();
            this.fileSelectBox = new System.Windows.Forms.PictureBox();
            this.imageSelectBox = new System.Windows.Forms.PictureBox();
            this.groupAvatarBox = new System.Windows.Forms.PictureBox();
            this.groupAvatar = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSelectBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSelectBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupAvatarBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupMemberListBox
            // 
            this.groupMemberListBox.BackColor = System.Drawing.Color.LightPink;
            this.groupMemberListBox.FormattingEnabled = true;
            this.groupMemberListBox.ItemHeight = 12;
            this.groupMemberListBox.Location = new System.Drawing.Point(2, 63);
            this.groupMemberListBox.Name = "groupMemberListBox";
            this.groupMemberListBox.Size = new System.Drawing.Size(165, 340);
            this.groupMemberListBox.TabIndex = 0;
            // 
            // chatQuitGroupBtn
            // 
            this.chatQuitGroupBtn.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.chatQuitGroupBtn.ForeColor = System.Drawing.Color.Red;
            this.chatQuitGroupBtn.Location = new System.Drawing.Point(49, 409);
            this.chatQuitGroupBtn.Name = "chatQuitGroupBtn";
            this.chatQuitGroupBtn.Size = new System.Drawing.Size(75, 29);
            this.chatQuitGroupBtn.TabIndex = 1;
            this.chatQuitGroupBtn.Text = "退出群聊";
            this.chatQuitGroupBtn.UseVisualStyleBackColor = true;
            // 
            // inputBox
            // 
            this.inputBox.BackColor = System.Drawing.Color.LightGreen;
            this.inputBox.Location = new System.Drawing.Point(182, 349);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(466, 89);
            this.inputBox.TabIndex = 3;
            // 
            // chatSendBtn
            // 
            this.chatSendBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chatSendBtn.ForeColor = System.Drawing.Color.Green;
            this.chatSendBtn.Location = new System.Drawing.Point(667, 406);
            this.chatSendBtn.Name = "chatSendBtn";
            this.chatSendBtn.Size = new System.Drawing.Size(79, 30);
            this.chatSendBtn.TabIndex = 4;
            this.chatSendBtn.Text = "发送";
            this.chatSendBtn.UseVisualStyleBackColor = true;
            this.chatSendBtn.Click += new System.EventHandler(this.chatSendBtn_Click);
            // 
            // chatGroupName
            // 
            this.chatGroupName.AutoSize = true;
            this.chatGroupName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chatGroupName.Location = new System.Drawing.Point(57, 20);
            this.chatGroupName.Name = "chatGroupName";
            this.chatGroupName.Size = new System.Drawing.Size(90, 22);
            this.chatGroupName.TabIndex = 7;
            this.chatGroupName.Text = "西瓜俱乐部";
            this.chatGroupName.Click += new System.EventHandler(this.Label1_Click);
            // 
            // fileSelectBox
            // 
            this.fileSelectBox.Image = ((System.Drawing.Image)(resources.GetObject("fileSelectBox.Image")));
            this.fileSelectBox.Location = new System.Drawing.Point(712, 349);
            this.fileSelectBox.Name = "fileSelectBox";
            this.fileSelectBox.Size = new System.Drawing.Size(33, 32);
            this.fileSelectBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fileSelectBox.TabIndex = 9;
            this.fileSelectBox.TabStop = false;
            // 
            // imageSelectBox
            // 
            this.imageSelectBox.Image = ((System.Drawing.Image)(resources.GetObject("imageSelectBox.Image")));
            this.imageSelectBox.Location = new System.Drawing.Point(667, 349);
            this.imageSelectBox.Name = "imageSelectBox";
            this.imageSelectBox.Size = new System.Drawing.Size(33, 32);
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
            // groupAvatar
            // 
            this.groupAvatar.Image = ((System.Drawing.Image)(resources.GetObject("groupAvatar.Image")));
            this.groupAvatar.Location = new System.Drawing.Point(7, 10);
            this.groupAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.groupAvatar.Name = "groupAvatar";
            this.groupAvatar.Size = new System.Drawing.Size(45, 46);
            this.groupAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.groupAvatar.TabIndex = 10;
            this.groupAvatar.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.LightBlue;
            this.richTextBox1.Location = new System.Drawing.Point(172, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(577, 334);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // groupChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupAvatar);
            this.Controls.Add(this.fileSelectBox);
            this.Controls.Add(this.imageSelectBox);
            this.Controls.Add(this.chatGroupName);
            this.Controls.Add(this.chatSendBtn);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.chatQuitGroupBtn);
            this.Controls.Add(this.groupMemberListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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

        private System.Windows.Forms.ListBox groupMemberListBox;
        private System.Windows.Forms.Button chatQuitGroupBtn;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button chatSendBtn;
        private System.Windows.Forms.Label chatGroupName;
        private System.Windows.Forms.PictureBox fileSelectBox;
        private System.Windows.Forms.PictureBox imageSelectBox;
        private System.Windows.Forms.PictureBox groupAvatarBox;
        private System.Windows.Forms.PictureBox groupAvatar;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}