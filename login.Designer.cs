namespace onlineChat
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.label1 = new System.Windows.Forms.Label();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.userNameCheckPicture = new System.Windows.Forms.PictureBox();
            this.userNameTips = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.serverConfigBtn = new System.Windows.Forms.Button();
            this.connectServerBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userNameCheckPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(82, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入昵称";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // userNameBox
            // 
            this.userNameBox.Enabled = false;
            this.userNameBox.Location = new System.Drawing.Point(190, 96);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(151, 21);
            this.userNameBox.TabIndex = 1;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.loginBtn.Enabled = false;
            this.loginBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loginBtn.ForeColor = System.Drawing.Color.Transparent;
            this.loginBtn.Location = new System.Drawing.Point(153, 225);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(137, 38);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "进入DogChat";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // userNameCheckPicture
            // 
            this.userNameCheckPicture.Enabled = false;
            this.userNameCheckPicture.Image = ((System.Drawing.Image)(resources.GetObject("userNameCheckPicture.Image")));
            this.userNameCheckPicture.Location = new System.Drawing.Point(347, 96);
            this.userNameCheckPicture.Name = "userNameCheckPicture";
            this.userNameCheckPicture.Size = new System.Drawing.Size(22, 21);
            this.userNameCheckPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userNameCheckPicture.TabIndex = 5;
            this.userNameCheckPicture.TabStop = false;
            // 
            // userNameTips
            // 
            this.userNameTips.AutoSize = true;
            this.userNameTips.Enabled = false;
            this.userNameTips.Font = new System.Drawing.Font("微软雅黑", 7.75F);
            this.userNameTips.ForeColor = System.Drawing.Color.Blue;
            this.userNameTips.Location = new System.Drawing.Point(82, 117);
            this.userNameTips.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userNameTips.Name = "userNameTips";
            this.userNameTips.Size = new System.Drawing.Size(325, 16);
            this.userNameTips.TabIndex = 6;
            this.userNameTips.Text = "提示:这个账户目前不存在,若继续操作,我们会为您新创建这个账户";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(82, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "请输入密码";
            // 
            // passwordBox
            // 
            this.passwordBox.Enabled = false;
            this.passwordBox.Location = new System.Drawing.Point(190, 151);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(151, 21);
            this.passwordBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("楷体", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(185, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "登录";
            // 
            // serverConfigBtn
            // 
            this.serverConfigBtn.Location = new System.Drawing.Point(250, 181);
            this.serverConfigBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.serverConfigBtn.Name = "serverConfigBtn";
            this.serverConfigBtn.Size = new System.Drawing.Size(89, 23);
            this.serverConfigBtn.TabIndex = 10;
            this.serverConfigBtn.Text = "服务器设置";
            this.serverConfigBtn.UseVisualStyleBackColor = true;
            this.serverConfigBtn.Click += new System.EventHandler(this.ServerConfigBtn_Click);
            // 
            // connectServerBtn
            // 
            this.connectServerBtn.Location = new System.Drawing.Point(137, 181);
            this.connectServerBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.connectServerBtn.Name = "connectServerBtn";
            this.connectServerBtn.Size = new System.Drawing.Size(89, 23);
            this.connectServerBtn.TabIndex = 11;
            this.connectServerBtn.Text = "连接服务器";
            this.connectServerBtn.UseVisualStyleBackColor = true;
            this.connectServerBtn.Click += new System.EventHandler(this.ConnectServerBtn_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 293);
            this.Controls.Add(this.connectServerBtn);
            this.Controls.Add(this.serverConfigBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userNameTips);
            this.Controls.Add(this.userNameCheckPicture);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.userNameBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "login";
            this.Text = "登录";
            ((System.ComponentModel.ISupportInitialize)(this.userNameCheckPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.PictureBox userNameCheckPicture;
        private System.Windows.Forms.Label userNameTips;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button serverConfigBtn;
        private System.Windows.Forms.Button connectServerBtn;
    }
}