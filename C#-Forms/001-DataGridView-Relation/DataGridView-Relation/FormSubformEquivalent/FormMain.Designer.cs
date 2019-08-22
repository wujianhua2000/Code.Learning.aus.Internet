namespace FormSubformEquivalent
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
            this.GridCustomer = new System.Windows.Forms.DataGridView( );
            this.GridOrder = new System.Windows.Forms.DataGridView( );
            this.lblCustomer = new System.Windows.Forms.Label( );
            this.lblOrder = new System.Windows.Forms.Label( );
            this.ButtonExit = new System.Windows.Forms.Button( );
            ( ( System.ComponentModel.ISupportInitialize ) ( this.GridCustomer ) ).BeginInit( );
            ( ( System.ComponentModel.ISupportInitialize ) ( this.GridOrder ) ).BeginInit( );
            this.SuspendLayout( );
            // 
            // GridCustomer
            // 
            this.GridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCustomer.Location = new System.Drawing.Point( 12, 31 );
            this.GridCustomer.Name = "GridCustomer";
            this.GridCustomer.Size = new System.Drawing.Size( 245, 138 );
            this.GridCustomer.TabIndex = 0;
            // 
            // GridOrder
            // 
            this.GridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridOrder.Location = new System.Drawing.Point( 263, 31 );
            this.GridOrder.Name = "GridOrder";
            this.GridOrder.Size = new System.Drawing.Size( 350, 138 );
            this.GridOrder.TabIndex = 1;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point( 12, 13 );
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size( 53, 12 );
            this.lblCustomer.TabIndex = 2;
            this.lblCustomer.Text = "Customer";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point( 260, 13 );
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size( 35, 12 );
            this.lblOrder.TabIndex = 3;
            this.lblOrder.Text = "Order";
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point( 538, 197 );
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size( 75, 23 );
            this.ButtonExit.TabIndex = 4;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler( this.ButtonExit_Click );
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 12F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 633, 239 );
            this.Controls.Add( this.ButtonExit );
            this.Controls.Add( this.lblOrder );
            this.Controls.Add( this.lblCustomer );
            this.Controls.Add( this.GridOrder );
            this.Controls.Add( this.GridCustomer );
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler( this.FormMain_Load );
            ( ( System.ComponentModel.ISupportInitialize ) ( this.GridCustomer ) ).EndInit( );
            ( ( System.ComponentModel.ISupportInitialize ) ( this.GridOrder ) ).EndInit( );
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.DataGridView GridCustomer;
        private System.Windows.Forms.DataGridView GridOrder;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Button ButtonExit;

    }
}

