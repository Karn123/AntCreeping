namespace AntCreeping
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.StartOrEndButton = new System.Windows.Forms.Button();
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StartOrEndButton
            // 
            this.StartOrEndButton.Location = new System.Drawing.Point(510, 344);
            this.StartOrEndButton.Name = "StartOrEndButton";
            this.StartOrEndButton.Size = new System.Drawing.Size(75, 23);
            this.StartOrEndButton.TabIndex = 0;
            this.StartOrEndButton.Text = "Start";
            this.StartOrEndButton.UseVisualStyleBackColor = true;
            this.StartOrEndButton.Click += new System.EventHandler(this.StartOrEndButton_Click);
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.BackColor = System.Drawing.Color.White;
            this.MainPictureBox.Location = new System.Drawing.Point(53, 52);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(532, 266);
            this.MainPictureBox.TabIndex = 1;
            this.MainPictureBox.TabStop = false;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(430, 349);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(29, 12);
            this.TimeLabel.TabIndex = 2;
            this.TimeLabel.Text = "时间";
            this.TimeLabel.Click += new System.EventHandler(this.TimeLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 439);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.MainPictureBox);
            this.Controls.Add(this.StartOrEndButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartOrEndButton;
        private System.Windows.Forms.PictureBox MainPictureBox;
        private System.Windows.Forms.Label TimeLabel;
    }
}

