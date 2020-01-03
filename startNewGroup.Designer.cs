namespace onlineChat
{
    partial class startNewGroup
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
            this.label1 = new System.Windows.Forms.Label();
            this.startGroupBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.newGroupName = new System.Windows.Forms.TextBox();
            this.selectUserBox = new CCWin.SkinControl.ChatListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "请双击选择您想要纳入群聊的用户";
            // 
            // startGroupBtn
            // 
            this.startGroupBtn.BackColor = System.Drawing.Color.LightGreen;
            this.startGroupBtn.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startGroupBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.startGroupBtn.Location = new System.Drawing.Point(61, 505);
            this.startGroupBtn.Name = "startGroupBtn";
            this.startGroupBtn.Size = new System.Drawing.Size(134, 31);
            this.startGroupBtn.TabIndex = 2;
            this.startGroupBtn.Text = "选择完成  创建群聊";
            this.startGroupBtn.UseVisualStyleBackColor = false;
            this.startGroupBtn.Click += new System.EventHandler(this.startGroupBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "设定群聊名称";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // newGroupName
            // 
            this.newGroupName.Location = new System.Drawing.Point(12, 478);
            this.newGroupName.Name = "newGroupName";
            this.newGroupName.Size = new System.Drawing.Size(235, 21);
            this.newGroupName.TabIndex = 4;
            // 
            // selectUserBox
            // 
            this.selectUserBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.selectUserBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectUserBox.ForeColor = System.Drawing.Color.Black;
            this.selectUserBox.FriendsMobile = true;
            this.selectUserBox.ListSubItemMenu = null;
            this.selectUserBox.Location = new System.Drawing.Point(2, 54);
            this.selectUserBox.Name = "selectUserBox";
            this.selectUserBox.SelectSubItem = null;
            this.selectUserBox.Size = new System.Drawing.Size(256, 394);
            this.selectUserBox.SubItemMenu = null;
            this.selectUserBox.TabIndex = 5;
            this.selectUserBox.Text = "chatListBox1";
            this.selectUserBox.DoubleClickSubItem += new CCWin.SkinControl.ChatListBox.ChatListEventHandler(this.selectUserBox_DoubleClickSubItem);
            this.selectUserBox.Click += new System.EventHandler(this.selectUserBox_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(70, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "【头像变亮表示选中】";
            // 
            // startNewGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 548);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectUserBox);
            this.Controls.Add(this.newGroupName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startGroupBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "startNewGroup";
            this.Text = "startNewGroup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startGroupBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newGroupName;
        private CCWin.SkinControl.ChatListBox selectUserBox;
        private System.Windows.Forms.Label label3;
    }
}