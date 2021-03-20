using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Akadia
{
	// Shows Master-Detail, Table-Mapping, Fill a Combobox
	public class MasterDetail : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid grdOrders;
		private System.Windows.Forms.DataGrid grdOrderDetails;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbCust;
		private System.Windows.Forms.TextBox txtPhoneNo;
		private System.Windows.Forms.TextBox txtFaxNo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtContact;
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnPrev;
		private System.Windows.Forms.Button btnNext;

		// My privates
		private String ConnectionString;
		private DataViewManager dsView;
		private DataSet ds;

		public MasterDetail()
		{
			// Create Components
			InitializeComponent();

			// Setup DB-Connection
			ConnectionString = "data source=xeon;uid=sa;password=manager;database=northwind";
			SqlConnection cn = new SqlConnection(ConnectionString);

			// Create the DataSet      
			ds = new DataSet("CustOrders");

			// Fill the Dataset with Customers, map Default Tablename
			// "Table" to "Customers".
			SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM Customers",cn);
			da1.TableMappings.Add("Table","Customers");
			da1.Fill(ds);
			
			// Fill the Dataset with Orders, map Default Tablename
			// "Table" to "Orders".			
			SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM Orders",cn);
			da2.TableMappings.Add("Table","Orders");
			da2.Fill(ds);

			// Fill the Dataset with [Order Details], map Default Tablename
			// "Table" to "OrderDetails".			
			SqlDataAdapter da3 = new SqlDataAdapter("SELECT * FROM [Order Details]",cn);
			da3.TableMappings.Add("Table","OrderDetails");
			da3.Fill(ds);

			// Show created Tablenames within the Dataset
			string myMessage = "Table Mappings: ";
			for(int i=0; i < ds.Tables.Count; i++) 
			{
				myMessage += i.ToString() + " "
					+ ds.Tables[i].ToString() + " ";
			}

			// Establish the Relationship "RelCustOrd" 
			// between Customers ---< Orders
			System.Data.DataRelation relCustOrd;
			System.Data.DataColumn  colMaster1;
			System.Data.DataColumn  colDetail1;
			colMaster1 = ds.Tables["Customers"].Columns["CustomerID"];
			colDetail1 = ds.Tables["Orders"].Columns["CustomerID"];
			relCustOrd = new System.Data.DataRelation("RelCustOrd",colMaster1,colDetail1);
			ds.Relations.Add(relCustOrd);

			// Establish the Relationship "RelOrdDet" 
			// between Orders ---< [Order Details]
			System.Data.DataRelation relOrdDet;
			System.Data.DataColumn  colMaster2;
			System.Data.DataColumn  colDetail2;
			colMaster2 = ds.Tables["Orders"].Columns["OrderID"];
			colDetail2 = ds.Tables["OrderDetails"].Columns["OrderID"];
			relOrdDet = new System.Data.DataRelation("RelOrdDet",colMaster2,colDetail2);
			ds.Relations.Add(relOrdDet);
 
			// Show created Relations within the Dataset
			myMessage += "Relation Mappings: ";
			for(int i=0; i < ds.Relations.Count; i++) 
			{
				myMessage += i.ToString() + " "
					+ ds.Relations[i].ToString() + " ";
			}
			txtMessage.Text = myMessage;

			// The DataViewManager returned by the DefaultViewManager
			// property allows you to create custom settings for each
			// DataTable in the DataSet.
			dsView = ds.DefaultViewManager;

			// Databinding for the Grid's
			grdOrders.DataSource = dsView;
			grdOrders.DataMember = "Customers.RelCustOrd";

			grdOrderDetails.DataSource = dsView;
			grdOrderDetails.DataMember = "Customers.RelCustOrd.RelOrdDet";
      
			// Databinding for the Combo Box
			//
			// If you have two controls bound to the same datasource, 
			// and you do not want them to share the same position, 
			// then you must make sure that the BindingContext member 
			// of one control differs from the BindingContext member of 
			// the other control. If they have the same BindingContext,
			// they will share the same position in the datasource.
			//
			// If you add a ComboBox and a DataGrid to a form, the default
			// behavior is for the BindingContext member of each of the
			// two controls to be set to the Form's BindingContext. Thus,
			// the default behavior is for the DataGrid and ComboBox to share
			// the same BindingContext, and hence the selection in the ComboBox
			// is synchronized with the current row of the DataGrid. If you
			// do not want this behavior, you should create a new BindingContext
			// member for at least one of the controls.
			//
			// IF YOU UNCOMMENT THE FOLLOWING LINE THE SYNC WILL NO MORE WORK
			// cbCust.BindingContext = new BindingContext(); 
			cbCust.DataSource = dsView;
			cbCust.DisplayMember = "Customers.CompanyName";
            cbCust.ValueMember = "Customers.CustomerID";

			// Databinding for the Text Columns
			txtContact.DataBindings.Add("Text",dsView,"Customers.ContactName");
			txtPhoneNo.DataBindings.Add("Text",dsView,"Customers.Phone");
			txtFaxNo.DataBindings.Add("Text",dsView,"Customers.Fax");
		}
	
		// Position to prev Record in Customer
		private void btnPrev_Click(object sender, System.EventArgs e)
		{
			if (this.BindingContext[dsView,"Customers"].Position > 0) 
			{
				this.BindingContext[dsView,"Customers"].Position--;
			}
		}

		// Position to next Record in Customer
		private void btnNext_Click(object sender, System.EventArgs e)
		{
			CurrencyManager cm = (CurrencyManager)this.BindingContext[dsView,"Customers"];
			if (cm.Position < cm.Count - 1) 
			{
				cm.Position++;
			}
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.grdOrders = new System.Windows.Forms.DataGrid();
            this.grdOrderDetails = new System.Windows.Forms.DataGrid();
            this.cbCust = new System.Windows.Forms.ComboBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtFaxNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrderDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdOrders
            // 
            this.grdOrders.AllowNavigation = false;
            this.grdOrders.BackgroundColor = System.Drawing.Color.White;
            this.grdOrders.CaptionVisible = false;
            this.grdOrders.DataMember = "";
            this.grdOrders.GridLineColor = System.Drawing.Color.White;
            this.grdOrders.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.grdOrders.Location = new System.Drawing.Point(34, 190);
            this.grdOrders.Name = "grdOrders";
            this.grdOrders.Size = new System.Drawing.Size(564, 151);
            this.grdOrders.TabIndex = 1;
            // 
            // grdOrderDetails
            // 
            this.grdOrderDetails.BackgroundColor = System.Drawing.Color.White;
            this.grdOrderDetails.CaptionVisible = false;
            this.grdOrderDetails.DataMember = "";
            this.grdOrderDetails.GridLineColor = System.Drawing.Color.White;
            this.grdOrderDetails.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.grdOrderDetails.Location = new System.Drawing.Point(34, 382);
            this.grdOrderDetails.Name = "grdOrderDetails";
            this.grdOrderDetails.Size = new System.Drawing.Size(564, 152);
            this.grdOrderDetails.TabIndex = 2;
            // 
            // cbCust
            // 
            this.cbCust.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCust.Location = new System.Drawing.Point(305, 34);
            this.cbCust.Name = "cbCust";
            this.cbCust.Size = new System.Drawing.Size(288, 20);
            this.cbCust.TabIndex = 3;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(305, 92);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(288, 21);
            this.txtPhoneNo.TabIndex = 4;
            // 
            // txtFaxNo
            // 
            this.txtFaxNo.Location = new System.Drawing.Point(305, 120);
            this.txtFaxNo.Name = "txtFaxNo";
            this.txtFaxNo.Size = new System.Drawing.Size(288, 21);
            this.txtFaxNo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(253, 41);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(252, 97);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Phone";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(268, 124);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(30, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fax";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(242, 70);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(56, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "Contact";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(305, 64);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(288, 21);
            this.txtContact.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.btnPrev);
            this.groupBox1.Controls.Add(this.txtMessage);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(17, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 152);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(156, 97);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(60, 25);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(156, 40);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(60, 25);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.Text = "Prev";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessage.Location = new System.Drawing.Point(23, 39);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(103, 96);
            this.txtMessage.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(22, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 11);
            this.label5.TabIndex = 1;
            this.label5.Text = "Messages";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(17, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 177);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Orders";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(17, 361);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(594, 188);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order Details";
            // 
            // MasterDetail
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(669, 559);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFaxNo);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.cbCust);
            this.Controls.Add(this.grdOrderDetails);
            this.Controls.Add(this.grdOrders);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "MasterDetail";
            this.Text = "Automatically synchronized Master-Detail";
            this.Load += new System.EventHandler(this.MasterDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrderDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		// The main entry point for the application.
		static void Main() 
		{
			Application.Run(new MasterDetail());
		}

        private void MasterDetail_Load( object sender, EventArgs e )
        {

        }
	}
}
