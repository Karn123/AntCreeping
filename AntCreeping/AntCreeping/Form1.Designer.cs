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
            this.minTimeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maxTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StartOrEndButton
            // 
            this.StartOrEndButton.Location = new System.Drawing.Point(472, 340);
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
            this.MainPictureBox.Location = new System.Drawing.Point(34, 48);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(532, 266);
            this.MainPictureBox.TabIndex = 1;
            this.MainPictureBox.TabStop = false;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TimeLabel.Location = new System.Drawing.Point(44, 340);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(70, 14);
            this.TimeLabel.TabIndex = 2;
            this.TimeLabel.Text = "最小时间:";
            this.TimeLabel.Click += new System.EventHandler(this.TimeLabel_Click);
            // 
            // minTimeLabel
            // 
            this.minTimeLabel.AutoSize = true;
            this.minTimeLabel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.minTimeLabel.Location = new System.Drawing.Point(120, 342);
            this.minTimeLabel.Name = "minTimeLabel";
            this.minTimeLabel.Size = new System.Drawing.Size(0, 14);
            this.minTimeLabel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(210, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "最大时间:";
            // 
            // maxTimeLabel
            // 
            this.maxTimeLabel.AutoSize = true;
            this.maxTimeLabel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maxTimeLabel.Location = new System.Drawing.Point(286, 342);
            this.maxTimeLabel.Name = "maxTimeLabel";
            this.maxTimeLabel.Size = new System.Drawing.Size(0, 14);
            this.maxTimeLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 399);
            this.Controls.Add(this.maxTimeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minTimeLabel);
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
        private System.Windows.Forms.Label minTimeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label maxTimeLabel;
    }
}

