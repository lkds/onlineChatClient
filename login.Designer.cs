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
            this.serverIPBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userNameCheckPicture = new System.Windows.Forms.PictureBox();
            this.userNameTips = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.userNameCheckPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(92, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入昵称";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // userNameBox
            // 
            this.userNameBox.Location = new System.Drawing.Point(236, 82);
            this.userNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(200, 25);
            this.userNameBox.TabIndex = 1;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.loginBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loginBtn.ForeColor = System.Drawing.Color.Transparent;
            this.loginBtn.Location = new System.Drawing.Point(195, 304);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(183, 48);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "进入DogChat";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // serverIPBox
            // 
            this.serverIPBox.Location = new System.Drawing.Point(236, 234);
            this.serverIPBox.Margin = new System.Windows.Forms.Padding(4);
            this.serverIPBox.Name = "serverIPBox";
            this.serverIPBox.Size = new System.Drawing.Size(199, 25);
            this.serverIPBox.TabIndex = 4;
            this.serverIPBox.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(92, 234);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "服务器IP";
            // 
            // userNameCheckPicture
            // 
            this.userNameCheckPicture.Image = ((System.Drawing.Image)(resources.GetObject("userNameCheckPicture.Image")));
            this.userNameCheckPicture.Location = new System.Drawing.Point(445, 82);
            this.userNameCheckPicture.Margin = new System.Windows.Forms.Padding(4);
            this.userNameCheckPicture.Name = "userNameCheckPicture";
            this.userNameCheckPicture.Size = new System.Drawing.Size(29, 26);
            this.userNameCheckPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userNameCheckPicture.TabIndex = 5;
            this.userNameCheckPicture.TabStop = false;
            // 
            // userNameTips
            // 
            this.userNameTips.AutoSize = true;
            this.userNameTips.Font = new System.Drawing.Font("微软雅黑", 7.75F);
            this.userNameTips.ForeColor = System.Drawing.Color.Blue;
            this.userNameTips.Location = new System.Drawing.Point(67, 109);
            this.userNameTips.Name = "userNameTips";
            this.userNameTips.Size = new System.Drawing.Size(382, 19);
            this.userNameTips.TabIndex = 6;
            this.userNameTips.Text = "提示:这个账户目前不存在,若继续操作,我们会为您新创建这个账户";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(92, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "请输入密码";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(236, 131);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(200, 25);
            this.passwordBox.TabIndex = 8;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 366);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userNameTips);
            this.Controls.Add(this.userNameCheckPicture);
            this.Controls.Add(this.serverIPBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.userNameBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox serverIPBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox userNameCheckPicture;
        private System.Windows.Forms.Label userNameTips;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordBox;
    }
}