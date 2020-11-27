namespace LearningOpenXML
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
            this.ButtonEasyTable = new System.Windows.Forms.Button();
            this.ButtonParagraph = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonEasyTable
            // 
            this.ButtonEasyTable.Location = new System.Drawing.Point(45, 33);
            this.ButtonEasyTable.Name = "ButtonEasyTable";
            this.ButtonEasyTable.Size = new System.Drawing.Size(402, 23);
            this.ButtonEasyTable.TabIndex = 0;
            this.ButtonEasyTable.Text = "创建一个简单的表格";
            this.ButtonEasyTable.UseVisualStyleBackColor = true;
            this.ButtonEasyTable.Click += new System.EventHandler(this.ButtonEasyTable_Click);
            // 
            // ButtonParagraph
            // 
            this.ButtonParagraph.Location = new System.Drawing.Point(45, 84);
            this.ButtonParagraph.Name = "ButtonParagraph";
            this.ButtonParagraph.Size = new System.Drawing.Size(402, 23);
            this.ButtonParagraph.TabIndex = 1;
            this.ButtonParagraph.Text = "easy paragraph";
            this.ButtonParagraph.UseVisualStyleBackColor = true;
            this.ButtonParagraph.Click += new System.EventHandler(this.ButtonParagraph_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 353);
            this.Controls.Add(this.ButtonParagraph);
            this.Controls.Add(this.ButtonEasyTable);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonEasyTable;
        private System.Windows.Forms.Button ButtonParagraph;
    }
}

