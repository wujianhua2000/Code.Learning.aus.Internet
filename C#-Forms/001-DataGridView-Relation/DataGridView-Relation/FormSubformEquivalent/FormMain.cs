using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormSubformEquivalent
{
    /// <summary>
    /// This class demonstrates the use of DataTables and DataRelations,
    /// creating Master/Child views to mimic a one-to-many form 
    /// (form/subform) in Microsoft Access.  This should be considered a 
    /// starting point.
    /// </summary>
    public partial class FormMain : Form
    {
        private DataTable TdataCustomer;

        private DataTable TdataOrder;

        private DataSet Oracle;

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        public FormMain( )
        {
            InitializeComponent( );

            // Create Tables
            TdataCustomer = new DataTable( "tblCustomer" );
            TdataOrder = new DataTable( "tblOrder" );

            // Create DataSet
            Oracle = new DataSet( );

            // Create Columns and Add to Tables
            TdataCustomer.Columns.Add( "ID", typeof( int ) );
            TdataCustomer.Columns.Add( "CustomerName", typeof( string ) );

            TdataOrder.Columns.Add( "ID", typeof( int ) );
            TdataOrder.Columns.Add( "Order", typeof( string ) );
            TdataOrder.Columns.Add( "CustomerID", typeof( int ) );

            // Add Test Data
            TdataCustomer.Rows.Add( 1, "Jane Doe" );
            TdataCustomer.Rows.Add( 2, "John Smith" );
            TdataCustomer.Rows.Add( 3, "Richard Roe" );

            TdataOrder.Rows.Add( 1, "Order1.1", 1 );
            TdataOrder.Rows.Add( 2, "Order1.2", 1 );
            TdataOrder.Rows.Add( 3, "Order1.3", 1 );
            TdataOrder.Rows.Add( 4, "Order2.1", 2 );
            TdataOrder.Rows.Add( 5, "Order3.1", 3 );
            TdataOrder.Rows.Add( 6, "Order3.2", 3 );

            // Add Tables to DataSet
            Oracle.Tables.Add( TdataCustomer );
            Oracle.Tables.Add( TdataOrder );

            // Create Relation
            Oracle.Relations.Add( "CustOrderRelation", TdataCustomer.Columns[ "ID" ], TdataOrder.Columns[ "CustomerID" ] );

            BindingSource BindingCustomer = new BindingSource( );
            BindingCustomer.DataSource = Oracle;
            BindingCustomer.DataMember = "tblCustomer";

            BindingSource BindingOrder = new BindingSource( );
            BindingOrder.DataSource = BindingCustomer;                  //  <<<---------    重点！！！！
            BindingOrder.DataMember = "CustOrderRelation";

            // Bind Data to DataGridViews
            GridCustomer.DataSource = BindingCustomer;
            GridOrder.DataSource = BindingOrder;

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load( object sender, EventArgs e )
        {

        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExit_Click( object sender, EventArgs e )
        {
            this.Close( );
        }

        //.....................................................................
    }
}
