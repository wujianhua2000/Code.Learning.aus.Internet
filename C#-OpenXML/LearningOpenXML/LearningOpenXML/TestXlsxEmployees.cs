using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;

namespace Hans.Opxm
{
    /// <summary>
    /// 
    /// </summary>
    class TestXlsxEmployees : OpenXlsxBase
    {
        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="workbookPart"></param>
        public override void GenerateXlsxDocument( WorkbookPart workbookpart )
        {
            List<double> listing = new List<double>( ) { 8, 12, 12, 8 };

            WorksheetPart worksheetpart = this.MakeNewWorksheetData( workbookpart,listing, "Employees" );        //new SheetData( );
            SheetData sheetdata = worksheetpart.Worksheet.GetFirstChild<SheetData>( );

            //this.SetupSheetColumns( worksheetpart );

            //.............................................
            List<Employee> employees = Employees.EmployeesList;

            // Insert the header row to the Sheet Data
            sheetdata.AppendChild( Employee.Title() );

            // Inserting each employee
            foreach ( var employee in employees ) sheetdata.AppendChild( employee.ToRow( ) );


            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="worksheetpart"></param>
        public void SetupSheetColumns( WorksheetPart worksheetpart )
        {
            Column con1 = new Column() { Min = 1, Max = 1, Width = 4D, CustomWidth = true }; // Id column
            Column con2 = new Column() { Min = 2, Max = 3, Width = 15D, CustomWidth = true };// Name and Birthday columns
            Column con3 = new Column() { Min = 4, Max = 4, Width = 8D, CustomWidth = true };// Salary column

            // Setting up columns
            Columns columns = new Columns( );

            columns.Append( con1 );  // con2, con3 );
            columns.Append( con2 );  // con2, con3 );
            columns.Append( con3 );  // con2, con3 );

            worksheetpart.Worksheet.AppendChild( columns );

            //// Create custom widths for columns
            //Columns lstColumns = worksheetpart.Worksheet.GetFirstChild<Columns>( );

            //Boolean needToInsertColumns = false;
            //if ( lstColumns == null )
            //{
            //    lstColumns = new Columns( );
            //    needToInsertColumns = true;
            //}
            //// Min = 1, Max = 1 ==> Apply this to column 1 (A)
            //// Min = 2, Max = 2 ==> Apply this to column 2 (B)
            //// Width = 25 ==> Set the borderLineWidth to 25
            //// CustomWidth = true ==> Tell Excel to use the custom borderLineWidth
            //lstColumns.Append( new Column( ) { Min = 1, Max = 1, Width = 25, CustomWidth = true } );
            //lstColumns.Append( new Column( ) { Min = 2, Max = 2, Width = 9, CustomWidth = true } );
            //lstColumns.Append( new Column( ) { Min = 3, Max = 3, Width = 9, CustomWidth = true } );
            //lstColumns.Append( new Column( ) { Min = 4, Max = 4, Width = 9, CustomWidth = true } );
            ////lstColumns.Append( new Column( ) { Min = 5, Max = 5, Width = 13, CustomWidth = true } );
            ////lstColumns.Append( new Column( ) { Min = 6, Max = 6, Width = 17, CustomWidth = true } );
            ////lstColumns.Append( new Column( ) { Min = 7, Max = 7, Width = 12, CustomWidth = true } );

            //// Only insert the columns if we had to create a new columns element
            //if ( needToInsertColumns )
            //    worksheetpart.Worksheet.InsertAt( lstColumns, 0 );

            return;
        }


        //.....................................................................
        /// <summary>
        /// http://www.dispatchertimer.com/tutorial/how-to-create-an-excel-file-in-net-using-openxml-part-2-export-a-collection-to-spreadsheet/
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="dataType"></param>
        /// <returns></returns>
        private Cell ConstructCell( string value, CellValues dataType, uint styleIndex = 0)
        {
            return new Cell( )
            {
                CellValue = new CellValue( value ),
                DataType = new EnumValue<CellValues>( dataType ),
                StyleIndex = styleIndex
            };
        }

        //.....................................................................
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public decimal Salary { get; set; }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Row ToRow( )
        {
            Row row = new Row( );

            row.Append(
                ConstructCell( this.Id.ToString( ), CellValues.Number, 1 ),
                ConstructCell( this.Name, CellValues.String, 1 ),
                ConstructCell( this.DOB.ToString( "yyyy-MM-dd" ), CellValues.String, 1 ),
                ConstructCell( this.Salary.ToString( ), CellValues.Number, 1 )
                );

            return row;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Row Title( )
        {
            // Constructing header
            Row row = new Row( );

            row.Append( ConstructCell( "Id", CellValues.String, 2 ) );
            row.Append( ConstructCell( "Name", CellValues.String, 2 ) );
            row.Append( ConstructCell( "Birth Date", CellValues.String, 2 ) );
            row.Append( ConstructCell( "Salary", CellValues.String, 2 ) );

            return row;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="dataType"></param>
        /// <returns></returns>
        public static Cell ConstructCell( string value, CellValues dataType, uint styleIndex = 0 )
        {
            return new Cell( )
            {
                CellValue = new CellValue( value ),
                DataType = new EnumValue<CellValues>( dataType ),
                StyleIndex = styleIndex
            };
        }
    }

    //.....................................................................
    /// <summary>
    /// 
    /// </summary>
    public sealed class Employees
    {
        static List<Employee> _employees;
        const int COUNT = 15;

        public static List<Employee> EmployeesList
        {
            private set { }
            get
            {
                return _employees;
            }
        }

        static Employees( )
        {
            Initialize( );
        }

        private static void Initialize( )
        {
            _employees = new List<Employee>( );

            Random random = new Random( );

            for ( int i = 0; i < COUNT; i++ )
            {
                _employees.Add( new Employee( )
                {
                    Id = i,
                    Name = "Employee " + i,
                    DOB = new DateTime( 1999, 1, 1 ).AddMonths( i ),
                    Salary = random.Next( 100, 10000 )
                } );
            }

            return;
        }

        //.....................................................................
    }

    //.....................................................................
}
