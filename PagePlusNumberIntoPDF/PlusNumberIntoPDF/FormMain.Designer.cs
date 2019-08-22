namespace PlusNumberIntoPDF
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
            this.button1 = new System.Windows.Forms.Button( );
            this.DialogFile = new System.Windows.Forms.OpenFileDialog( );
            this.button2 = new System.Windows.Forms.Button( );
            this.DialogPath = new System.Windows.Forms.FolderBrowserDialog( );
            this.ButtonExit = new System.Windows.Forms.Button( );
            this.SuspendLayout( );
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point( 23, 25 );
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size( 225, 23 );
            this.button1.TabIndex = 0;
            this.button1.Text = "Add number in .Net Developer.pdf";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler( this.button1_Click );
            // 
            // DialogFile
            // 
            this.DialogFile.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point( 23, 67 );
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size( 225, 23 );
            this.button2.TabIndex = 1;
            this.button2.Text = "Make showAnchorPoints.pdf";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler( this.ButtonAlignment_Click );
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point( 273, 218 );
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size( 75, 23 );
            this.ButtonExit.TabIndex = 2;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 12F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 360, 262 );
            this.Controls.Add( this.ButtonExit );
            this.Controls.Add( this.button2 );
            this.Controls.Add( this.button1 );
            this.Name = "FormMain";
            this.Text = "Add page number in PDF file";
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog DialogFile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FolderBrowserDialog DialogPath;
        private System.Windows.Forms.Button ButtonExit;
    }
}

