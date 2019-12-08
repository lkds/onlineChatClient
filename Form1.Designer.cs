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
            this.chatBox = new System.Windows.Forms.RichTextBox();
            this.textInputBox = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.onlineList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // avatar
            // 
            this.avatar.BackColor = System.Drawing.Color.CadetBlue;
            this.avatar.Image = ((System.Drawing.Image)(resources.GetObject("avatar.Image")));
            this.avatar.Location = new System.Drawing.Point(26, 24);
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
            this.userName.Location = new System.Drawing.Point(153, 24);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(200, 30);
            this.userName.TabIndex = 1;
            this.userName.Text = "黄伟业";
            this.userName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IPAddress
            // 
            this.IPAddress.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IPAddress.Location = new System.Drawing.Point(153, 78);
            this.IPAddress.Name = "IPAddress";
            this.IPAddress.Size = new System.Drawing.Size(200, 30);
            this.IPAddress.TabIndex = 2;
            this.IPAddress.Text = "127.0.0.1";
            this.IPAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chatBox
            // 
            this.chatBox.BackColor = System.Drawing.SystemColors.Info;
            this.chatBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatBox.Location = new System.Drawing.Point(25, 161);
            this.chatBox.Name = "chatBox";
            this.chatBox.ReadOnly = true;
            this.chatBox.Size = new System.Drawing.Size(500, 300);
            this.chatBox.TabIndex = 3;
            this.chatBox.Text = "赵晗泽 2019.12.25    18:56:49\n黄伟业是沙雕\n黄伟业 2019.12.25    18:57:16\n给爷爬\nzigzag 2019.12.2" +
    "5    18:58:46\n撒刁";
            // 
            // textInputBox
            // 
            this.textInputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textInputBox.Location = new System.Drawing.Point(25, 482);
            this.textInputBox.Multiline = true;
            this.textInputBox.Name = "textInputBox";
            this.textInputBox.Size = new System.Drawing.Size(500, 75);
            this.textInputBox.TabIndex = 4;
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.sendBtn.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.sendBtn.Location = new System.Drawing.Point(425, 507);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(100, 50);
            this.sendBtn.TabIndex = 5;
            this.sendBtn.Text = "发送";
            this.sendBtn.UseVisualStyleBackColor = false;
            // 
            // onlineList
            // 
            this.onlineList.BackColor = System.Drawing.SystemColors.Window;
            this.onlineList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.onlineList.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.onlineList.FormattingEnabled = true;
            this.onlineList.ItemHeight = 24;
            this.onlineList.Items.AddRange(new object[] {
            "鼠辈（192.168.43.12）",
            "江某民（192.168.43.26）",
            "pilotWei（192.168.43.22）",
            "zigzag（192.168.43.55）"});
            this.onlineList.Location = new System.Drawing.Point(569, 161);
            this.onlineList.Name = "onlineList";
            this.onlineList.Size = new System.Drawing.Size(380, 384);
            this.onlineList.TabIndex = 6;
            this.onlineList.SelectedIndexChanged += new System.EventHandler(this.OnlineList_SelectedIndexChanged);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 571);
            this.Controls.Add(this.onlineList);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.textInputBox);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.IPAddress);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.avatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainWindow";
            this.Text = "onlineChat";
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label IPAddress;
        private System.Windows.Forms.RichTextBox chatBox;
        private System.Windows.Forms.TextBox textInputBox;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.ListBox onlineList;
    }
}

