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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imageSelectBox = new System.Windows.Forms.PictureBox();
            this.fileSelectBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageSelectBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSelectBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(1, 52);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(759, 364);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1, 436);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(620, 110);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(647, 508);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "发送";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // imageSelectBox
            // 
            this.imageSelectBox.Image = ((System.Drawing.Image)(resources.GetObject("imageSelectBox.Image")));
            this.imageSelectBox.Location = new System.Drawing.Point(647, 436);
            this.imageSelectBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imageSelectBox.Name = "imageSelectBox";
            this.imageSelectBox.Size = new System.Drawing.Size(44, 40);
            this.imageSelectBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageSelectBox.TabIndex = 3;
            this.imageSelectBox.TabStop = false;
            this.imageSelectBox.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // fileSelectBox
            // 
            this.fileSelectBox.Image = ((System.Drawing.Image)(resources.GetObject("fileSelectBox.Image")));
            this.fileSelectBox.Location = new System.Drawing.Point(708, 436);
            this.fileSelectBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fileSelectBox.Name = "fileSelectBox";
            this.fileSelectBox.Size = new System.Drawing.Size(44, 40);
            this.fileSelectBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fileSelectBox.TabIndex = 4;
            this.fileSelectBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "聊天对象";
            // 
            // singleChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileSelectBox);
            this.Controls.Add(this.imageSelectBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "singleChat";
            this.Text = "黄伟业";
            ((System.ComponentModel.ISupportInitialize)(this.imageSelectBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSelectBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox imageSelectBox;
        private System.Windows.Forms.PictureBox fileSelectBox;
        private System.Windows.Forms.Label label1;
    }
}