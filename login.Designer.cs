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
            this.sameNameWarning = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.userNameCheckPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(92, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入昵称";
            // 
            // userNameBox
            // 
            this.userNameBox.Location = new System.Drawing.Point(177, 66);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(151, 21);
            this.userNameBox.TabIndex = 1;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.loginBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loginBtn.ForeColor = System.Drawing.Color.Transparent;
            this.loginBtn.Location = new System.Drawing.Point(146, 243);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(137, 38);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "进入DogChat";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // serverIPBox
            // 
            this.serverIPBox.Location = new System.Drawing.Point(177, 187);
            this.serverIPBox.Name = "serverIPBox";
            this.serverIPBox.Size = new System.Drawing.Size(150, 21);
            this.serverIPBox.TabIndex = 4;
            this.serverIPBox.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(92, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "服务器IP";
            // 
            // userNameCheckPicture
            // 
            this.userNameCheckPicture.Image = ((System.Drawing.Image)(resources.GetObject("userNameCheckPicture.Image")));
            this.userNameCheckPicture.Location = new System.Drawing.Point(334, 66);
            this.userNameCheckPicture.Name = "userNameCheckPicture";
            this.userNameCheckPicture.Size = new System.Drawing.Size(22, 21);
            this.userNameCheckPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userNameCheckPicture.TabIndex = 5;
            this.userNameCheckPicture.TabStop = false;
            // 
            // sameNameWarning
            // 
            this.sameNameWarning.AutoSize = true;
            this.sameNameWarning.Font = new System.Drawing.Font("微软雅黑", 7.75F);
            this.sameNameWarning.ForeColor = System.Drawing.Color.Red;
            this.sameNameWarning.Location = new System.Drawing.Point(218, 90);
            this.sameNameWarning.Name = "sameNameWarning";
            this.sameNameWarning.Size = new System.Drawing.Size(74, 16);
            this.sameNameWarning.TabIndex = 6;
            this.sameNameWarning.Text = "存在重名用户";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(92, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "请输入密码";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(177, 131);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(151, 21);
            this.passwordBox.TabIndex = 8;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 293);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sameNameWarning);
            this.Controls.Add(this.userNameCheckPicture);
            this.Controls.Add(this.serverIPBox);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.TextBox serverIPBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox userNameCheckPicture;
        private System.Windows.Forms.Label sameNameWarning;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordBox;
    }
}