﻿namespace onlineChat
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
            this.inputBox = new System.Windows.Forms.TextBox();
            this.chatSendBtn = new System.Windows.Forms.Button();
            this.chatGroupName = new System.Windows.Forms.Label();
            this.fileSelectBox = new System.Windows.Forms.PictureBox();
            this.imageSelectBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSelectBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSelectBox)).BeginInit();
            this.SuspendLayout();
            // 
            // chatUserListBox
            // 
            this.chatUserListBox.BackColor = System.Drawing.Color.LightPink;
            this.chatUserListBox.FormattingEnabled = true;
            this.chatUserListBox.ItemHeight = 12;
            this.chatUserListBox.Location = new System.Drawing.Point(2, 39);
            this.chatUserListBox.Name = "chatUserListBox";
            this.chatUserListBox.Size = new System.Drawing.Size(165, 364);
            this.chatUserListBox.TabIndex = 0;
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
            // chatMessageBox
            // 
            this.chatMessageBox.BackColor = System.Drawing.Color.LightBlue;
            this.chatMessageBox.FormattingEnabled = true;
            this.chatMessageBox.ItemHeight = 12;
            this.chatMessageBox.Location = new System.Drawing.Point(182, 3);
            this.chatMessageBox.Name = "chatMessageBox";
            this.chatMessageBox.Size = new System.Drawing.Size(570, 328);
            this.chatMessageBox.TabIndex = 2;
            this.chatMessageBox.SelectedIndexChanged += new System.EventHandler(this.ListBox2_SelectedIndexChanged);
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
            this.chatGroupName.Location = new System.Drawing.Point(10, 7);
            this.chatGroupName.Name = "chatGroupName";
            this.chatGroupName.Size = new System.Drawing.Size(74, 22);
            this.chatGroupName.TabIndex = 7;
            this.chatGroupName.Text = "群聊名称";
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
            // groupChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.fileSelectBox);
            this.Controls.Add(this.imageSelectBox);
            this.Controls.Add(this.chatGroupName);
            this.Controls.Add(this.chatSendBtn);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.chatMessageBox);
            this.Controls.Add(this.chatQuitGroupBtn);
            this.Controls.Add(this.chatUserListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "groupChat";
            this.Text = "群聊";
            ((System.ComponentModel.ISupportInitialize)(this.fileSelectBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSelectBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox chatUserListBox;
        private System.Windows.Forms.Button chatQuitGroupBtn;
        private System.Windows.Forms.ListBox chatMessageBox;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button chatSendBtn;
        private System.Windows.Forms.Label chatGroupName;
        private System.Windows.Forms.PictureBox fileSelectBox;
        private System.Windows.Forms.PictureBox imageSelectBox;
    }
}