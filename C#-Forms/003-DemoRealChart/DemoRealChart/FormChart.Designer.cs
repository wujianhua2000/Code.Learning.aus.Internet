namespace DemoSharp
{
    partial class FormChart
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
            this.components = new System.ComponentModel.Container();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ButtonStop = new System.Windows.Forms.Button();
            this.ButtonInit = new System.Windows.Forms.Button();
            this.RadioLine = new System.Windows.Forms.RadioButton();
            this.RadioSpline = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonStart
            // 
            this.ButtonStart.Enabled = false;
            this.ButtonStart.Location = new System.Drawing.Point(621, 10);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(75, 23);
            this.ButtonStart.TabIndex = 0;
            this.ButtonStart.Text = "开始";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // chart1
            // 
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart1.Location = new System.Drawing.Point(12, 42);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(884, 422);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ButtonStop
            // 
            this.ButtonStop.Enabled = false;
            this.ButtonStop.Location = new System.Drawing.Point(721, 10);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(75, 23);
            this.ButtonStop.TabIndex = 2;
            this.ButtonStop.Text = "停止";
            this.ButtonStop.UseVisualStyleBackColor = true;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // ButtonInit
            // 
            this.ButtonInit.Location = new System.Drawing.Point(521, 10);
            this.ButtonInit.Name = "ButtonInit";
            this.ButtonInit.Size = new System.Drawing.Size(75, 23);
            this.ButtonInit.TabIndex = 3;
            this.ButtonInit.Text = "初始化";
            this.ButtonInit.UseVisualStyleBackColor = true;
            this.ButtonInit.Click += new System.EventHandler(this.ButtonInit_Click);
            // 
            // RadioLine
            // 
            this.RadioLine.AutoSize = true;
            this.RadioLine.Checked = true;
            this.RadioLine.Location = new System.Drawing.Point(78, 13);
            this.RadioLine.Name = "rb1";
            this.RadioLine.Size = new System.Drawing.Size(59, 16);
            this.RadioLine.TabIndex = 4;
            this.RadioLine.TabStop = true;
            this.RadioLine.Text = "折线图";
            this.RadioLine.UseVisualStyleBackColor = true;
            // 
            // RadioSpline
            // 
            this.RadioSpline.AutoSize = true;
            this.RadioSpline.Location = new System.Drawing.Point(180, 13);
            this.RadioSpline.Name = "rb2";
            this.RadioSpline.Size = new System.Drawing.Size(59, 16);
            this.RadioSpline.TabIndex = 5;
            this.RadioSpline.Text = "波形图";
            this.RadioSpline.UseVisualStyleBackColor = true;
            // 
            // FormChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 476);
            this.Controls.Add(this.RadioSpline);
            this.Controls.Add(this.RadioLine);
            this.Controls.Add(this.ButtonInit);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.ButtonStart);
            this.Name = "FormChart";
            this.Text = "Network";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.Button ButtonInit;
        private System.Windows.Forms.RadioButton RadioLine;
        private System.Windows.Forms.RadioButton RadioSpline;
    }
}

