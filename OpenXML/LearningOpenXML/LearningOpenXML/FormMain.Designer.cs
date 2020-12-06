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
            this.ButtonCalcB24AC = new System.Windows.Forms.Button();
            this.ButtonAnchorRCpressure = new System.Windows.Forms.Button();
            this.ButtonFormula_2 = new System.Windows.Forms.Button();
            this.ButtonSQRT_34 = new System.Windows.Forms.Button();
            this.ButtonMoreLineFormula = new System.Windows.Forms.Button();
            this.ButtonTable_Texts = new System.Windows.Forms.Button();
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
            this.ButtonParagraph.Location = new System.Drawing.Point(45, 62);
            this.ButtonParagraph.Name = "ButtonParagraph";
            this.ButtonParagraph.Size = new System.Drawing.Size(402, 23);
            this.ButtonParagraph.TabIndex = 1;
            this.ButtonParagraph.Text = "easy paragraph";
            this.ButtonParagraph.UseVisualStyleBackColor = true;
            this.ButtonParagraph.Click += new System.EventHandler(this.ButtonParagraph_Click);
            // 
            // ButtonCalcB24AC
            // 
            this.ButtonCalcB24AC.Location = new System.Drawing.Point(45, 91);
            this.ButtonCalcB24AC.Name = "ButtonCalcB24AC";
            this.ButtonCalcB24AC.Size = new System.Drawing.Size(402, 23);
            this.ButtonCalcB24AC.TabIndex = 2;
            this.ButtonCalcB24AC.Text = "一元二次方程的解答计算公式";
            this.ButtonCalcB24AC.UseVisualStyleBackColor = true;
            this.ButtonCalcB24AC.Click += new System.EventHandler(this.ButtonCalcB24AC_Click);
            // 
            // ButtonAnchorRCpressure
            // 
            this.ButtonAnchorRCpressure.Location = new System.Drawing.Point(45, 120);
            this.ButtonAnchorRCpressure.Name = "ButtonAnchorRCpressure";
            this.ButtonAnchorRCpressure.Size = new System.Drawing.Size(402, 23);
            this.ButtonAnchorRCpressure.TabIndex = 3;
            this.ButtonAnchorRCpressure.Text = "设备基础 锚栓-基板处混凝土局部受压";
            this.ButtonAnchorRCpressure.UseVisualStyleBackColor = true;
            this.ButtonAnchorRCpressure.Click += new System.EventHandler(this.ButtonAnchorRCpressure_Click);
            // 
            // ButtonFormula_2
            // 
            this.ButtonFormula_2.Location = new System.Drawing.Point(45, 149);
            this.ButtonFormula_2.Name = "ButtonFormula_2";
            this.ButtonFormula_2.Size = new System.Drawing.Size(402, 23);
            this.ButtonFormula_2.TabIndex = 4;
            this.ButtonFormula_2.Text = "公式：分数，上下标";
            this.ButtonFormula_2.UseVisualStyleBackColor = true;
            this.ButtonFormula_2.Click += new System.EventHandler(this.ButtonFormula_2_Click);
            // 
            // ButtonSQRT_34
            // 
            this.ButtonSQRT_34.Location = new System.Drawing.Point(45, 178);
            this.ButtonSQRT_34.Name = "ButtonSQRT_34";
            this.ButtonSQRT_34.Size = new System.Drawing.Size(402, 23);
            this.ButtonSQRT_34.TabIndex = 5;
            this.ButtonSQRT_34.Text = "公式：开根号 3 4 ";
            this.ButtonSQRT_34.UseVisualStyleBackColor = true;
            this.ButtonSQRT_34.Click += new System.EventHandler(this.ButtonSQRT_34_Click);
            // 
            // ButtonMoreLineFormula
            // 
            this.ButtonMoreLineFormula.Location = new System.Drawing.Point(45, 207);
            this.ButtonMoreLineFormula.Name = "ButtonMoreLineFormula";
            this.ButtonMoreLineFormula.Size = new System.Drawing.Size(402, 23);
            this.ButtonMoreLineFormula.TabIndex = 6;
            this.ButtonMoreLineFormula.Text = "公式：两行、更多行公式";
            this.ButtonMoreLineFormula.UseVisualStyleBackColor = true;
            this.ButtonMoreLineFormula.Click += new System.EventHandler(this.ButtonMoreLineFormula_Click);
            // 
            // ButtonTable_Texts
            // 
            this.ButtonTable_Texts.Location = new System.Drawing.Point(45, 236);
            this.ButtonTable_Texts.Name = "ButtonTable_Texts";
            this.ButtonTable_Texts.Size = new System.Drawing.Size(402, 23);
            this.ButtonTable_Texts.TabIndex = 7;
            this.ButtonTable_Texts.Text = "多段文字和表格";
            this.ButtonTable_Texts.UseVisualStyleBackColor = true;
            this.ButtonTable_Texts.Click += new System.EventHandler(this.ButtonTable_Texts_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 353);
            this.Controls.Add(this.ButtonTable_Texts);
            this.Controls.Add(this.ButtonMoreLineFormula);
            this.Controls.Add(this.ButtonSQRT_34);
            this.Controls.Add(this.ButtonFormula_2);
            this.Controls.Add(this.ButtonAnchorRCpressure);
            this.Controls.Add(this.ButtonCalcB24AC);
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
        private System.Windows.Forms.Button ButtonCalcB24AC;
        private System.Windows.Forms.Button ButtonAnchorRCpressure;
        private System.Windows.Forms.Button ButtonFormula_2;
        private System.Windows.Forms.Button ButtonSQRT_34;
        private System.Windows.Forms.Button ButtonMoreLineFormula;
        private System.Windows.Forms.Button ButtonTable_Texts;
    }
}

