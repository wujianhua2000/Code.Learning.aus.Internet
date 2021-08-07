namespace PropertyGrid5
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
            this.btnAssign = new System.Windows.Forms.Button();
            this.prpG = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(16, 14);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(100, 28);
            this.btnAssign.TabIndex = 0;
            this.btnAssign.Text = "Assign Class";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // prpG
            // 
            this.prpG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prpG.Location = new System.Drawing.Point(3, 67);
            this.prpG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prpG.Name = "prpG";
            this.prpG.Size = new System.Drawing.Size(571, 359);
            this.prpG.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 425);
            this.Controls.Add(this.prpG);
            this.Controls.Add(this.btnAssign);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Demo for PropertyGrid5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.PropertyGrid prpG;
    }
}

