namespace LearningKurzCode
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.ButtonGroupBy = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonGroupBy
            // 
            this.ButtonGroupBy.Location = new System.Drawing.Point(12, 12);
            this.ButtonGroupBy.Name = "ButtonGroupBy";
            this.ButtonGroupBy.Size = new System.Drawing.Size(417, 23);
            this.ButtonGroupBy.TabIndex = 0;
            this.ButtonGroupBy.Text = "LINQ GroupBy";
            this.ButtonGroupBy.UseVisualStyleBackColor = true;
            this.ButtonGroupBy.Click += new System.EventHandler(this.ButtonGroupBy_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(797, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 446);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonGroupBy);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonGroupBy;
        private System.Windows.Forms.Button button1;
    }
}

