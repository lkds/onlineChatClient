namespace onlineChat
{
    partial class chatWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chatWindow));
            this.chatBox = new System.Windows.Forms.RichTextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.textInputBox = new System.Windows.Forms.TextBox();
            this.chatName = new System.Windows.Forms.Label();
            this.chatList = new System.Windows.Forms.ListBox();
            this.selectImgBox = new System.Windows.Forms.PictureBox();
            this.selectFileBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.selectImgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectFileBox)).BeginInit();
            this.SuspendLayout();
            // 
            // chatBox
            // 
            this.chatBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.chatBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatBox.Location = new System.Drawing.Point(142, 61);
            this.chatBox.Name = "chatBox";
            this.chatBox.ReadOnly = true;
            this.chatBox.Size = new System.Drawing.Size(828, 374);
            this.chatBox.TabIndex = 4;
            this.chatBox.Text = "赵晗泽 2019.12.25    18:56:49\n黄伟业是沙雕\n黄伟业 2019.12.25    18:57:16\n给爷爬\nzigzag 2019.12.2" +
    "5    18:58:46\n撒刁";
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.sendBtn.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.sendBtn.Location = new System.Drawing.Point(870, 509);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(100, 50);
            this.sendBtn.TabIndex = 7;
            this.sendBtn.Text = "发送";
            this.sendBtn.UseVisualStyleBackColor = false;
            // 
            // textInputBox
            // 
            this.textInputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textInputBox.Location = new System.Drawing.Point(142, 441);
            this.textInputBox.Multiline = true;
            this.textInputBox.Name = "textInputBox";
            this.textInputBox.Size = new System.Drawing.Size(828, 118);
            this.textInputBox.TabIndex = 6;
            // 
            // chatName
            // 
            this.chatName.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chatName.Location = new System.Drawing.Point(137, 14);
            this.chatName.Name = "chatName";
            this.chatName.Size = new System.Drawing.Size(837, 35);
            this.chatName.TabIndex = 8;
            this.chatName.Text = "香蕉俱乐部";
            this.chatName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chatList
            // 
            this.chatList.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.chatList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatList.FormattingEnabled = true;
            this.chatList.ItemHeight = 15;
            this.chatList.Location = new System.Drawing.Point(12, 15);
            this.chatList.Name = "chatList";
            this.chatList.Size = new System.Drawing.Size(118, 540);
            this.chatList.TabIndex = 9;
            // 
            // selectImgBox
            // 
            this.selectImgBox.Image = ((System.Drawing.Image)(resources.GetObject("selectImgBox.Image")));
            this.selectImgBox.Location = new System.Drawing.Point(870, 463);
            this.selectImgBox.Name = "selectImgBox";
            this.selectImgBox.Size = new System.Drawing.Size(40, 40);
            this.selectImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.selectImgBox.TabIndex = 10;
            this.selectImgBox.TabStop = false;
            // 
            // selectFileBox
            // 
            this.selectFileBox.Image = ((System.Drawing.Image)(resources.GetObject("selectFileBox.Image")));
            this.selectFileBox.Location = new System.Drawing.Point(930, 463);
            this.selectFileBox.Name = "selectFileBox";
            this.selectFileBox.Size = new System.Drawing.Size(40, 40);
            this.selectFileBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.selectFileBox.TabIndex = 11;
            this.selectFileBox.TabStop = false;
            // 
            // chatWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 571);
            this.Controls.Add(this.selectFileBox);
            this.Controls.Add(this.selectImgBox);
            this.Controls.Add(this.chatList);
            this.Controls.Add(this.chatName);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.textInputBox);
            this.Controls.Add(this.chatBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "chatWindow";
            this.Text = "chatWindow";
            ((System.ComponentModel.ISupportInitialize)(this.selectImgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectFileBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox chatBox;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox textInputBox;
        private System.Windows.Forms.Label chatName;
        private System.Windows.Forms.ListBox chatList;
        private System.Windows.Forms.PictureBox selectImgBox;
        private System.Windows.Forms.PictureBox selectFileBox;
    }
}