namespace PropertyGrid2
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
            this.prpG = new System.Windows.Forms.PropertyGrid();
            this.btnAssign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prpG
            // 
            this.prpG.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.prpG.Location = new System.Drawing.Point(12, 41);
            this.prpG.Name = "prpG";
            this.prpG.Size = new System.Drawing.Size(310, 186);
            this.prpG.TabIndex = 3;
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(12, 11);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(113, 21);
            this.btnAssign.TabIndex = 2;
            this.btnAssign.Text = "Assign Class";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 252);
            this.Controls.Add(this.prpG);
            this.Controls.Add(this.btnAssign);
            this.Name = "FormMain";
            this.Text = "Another Demo PropertyGrid";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid prpG;
        private System.Windows.Forms.Button btnAssign;
    }
}

