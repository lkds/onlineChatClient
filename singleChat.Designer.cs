namespace onlineChat
{
    partial class singleChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(singleChat));
            this.inputBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imageSelectBox = new System.Windows.Forms.PictureBox();
            this.fileSelectBox = new System.Windows.Forms.PictureBox();
            this.userName = new System.Windows.Forms.Label();
            this.userAvatar = new System.Windows.Forms.PictureBox();
            this.singleChatMessageBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageSelectBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSelectBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.BackColor = System.Drawing.Color.LightGreen;
            this.inputBox.Location = new System.Drawing.Point(1, 349);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(466, 89);
            this.inputBox.TabIndex = 1;
            this.inputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(485, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "发送";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageSelectBox
            // 
            this.imageSelectBox.Image = ((System.Drawing.Image)(resources.GetObject("imageSelectBox.Image")));
            this.imageSelectBox.Location = new System.Drawing.Point(485, 349);
            this.imageSelectBox.Name = "imageSelectBox";
            this.imageSelectBox.Size = new System.Drawing.Size(33, 32);
            this.imageSelectBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageSelectBox.TabIndex = 3;
            this.imageSelectBox.TabStop = false;
            this.imageSelectBox.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // fileSelectBox
            // 
            this.fileSelectBox.Image = ((System.Drawing.Image)(resources.GetObject("fileSelectBox.Image")));
            this.fileSelectBox.Location = new System.Drawing.Point(537, 349);
            this.fileSelectBox.Name = "fileSelectBox";
            this.fileSelectBox.Size = new System.Drawing.Size(33, 32);
            this.fileSelectBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fileSelectBox.TabIndex = 4;
            this.fileSelectBox.TabStop = false;
            this.fileSelectBox.Click += new System.EventHandler(this.FileSelectBox_Click);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userName.Location = new System.Drawing.Point(36, 7);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(58, 22);
            this.userName.TabIndex = 5;
            this.userName.Text = "黄伟业";
            // 
            // userAvatar
            // 
            this.userAvatar.Image = ((System.Drawing.Image)(resources.GetObject("userAvatar.Image")));
            this.userAvatar.Location = new System.Drawing.Point(1, 4);
            this.userAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.userAvatar.Name = "userAvatar";
            this.userAvatar.Size = new System.Drawing.Size(30, 32);
            this.userAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userAvatar.TabIndex = 6;
            this.userAvatar.TabStop = false;
            // 
            // singleChatMessageBox
            // 
            this.singleChatMessageBox.BackColor = System.Drawing.Color.LightBlue;
            this.singleChatMessageBox.Location = new System.Drawing.Point(2, 42);
            this.singleChatMessageBox.Name = "singleChatMessageBox";
            this.singleChatMessageBox.Size = new System.Drawing.Size(572, 300);
            this.singleChatMessageBox.TabIndex = 7;
            this.singleChatMessageBox.Text = "";
            // 
            // singleChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 450);
            this.Controls.Add(this.singleChatMessageBox);
            this.Controls.Add(this.userAvatar);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.fileSelectBox);
            this.Controls.Add(this.imageSelectBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "singleChat";
            this.Load += new System.EventHandler(this.singleChat_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SingleChat_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.imageSelectBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSelectBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox imageSelectBox;
        private System.Windows.Forms.PictureBox fileSelectBox;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.PictureBox userAvatar;
        private System.Windows.Forms.RichTextBox singleChatMessageBox;
    }
}