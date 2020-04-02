namespace Learning
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
            this.Button001 = new System.Windows.Forms.Button();
            this.Button_002 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button001
            // 
            this.Button001.Location = new System.Drawing.Point(36, 32);
            this.Button001.Name = "Button001";
            this.Button001.Size = new System.Drawing.Size(214, 23);
            this.Button001.TabIndex = 0;
            this.Button001.Text = "Test Collection 1";
            this.Button001.UseVisualStyleBackColor = true;
            this.Button001.Click += new System.EventHandler(this.Button_001_Click);
            // 
            // Button_002
            // 
            this.Button_002.Location = new System.Drawing.Point(36, 73);
            this.Button_002.Name = "Button_002";
            this.Button_002.Size = new System.Drawing.Size(214, 23);
            this.Button_002.TabIndex = 1;
            this.Button_002.Text = "Test Collection 2";
            this.Button_002.UseVisualStyleBackColor = true;
            this.Button_002.Click += new System.EventHandler(this.Button_002_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 425);
            this.Controls.Add(this.Button_002);
            this.Controls.Add(this.Button001);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button001;
        private System.Windows.Forms.Button Button_002;
    }
}

