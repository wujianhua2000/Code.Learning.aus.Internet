using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Text;

using System.IO;

namespace LearningOpenXML
{
    /// <summary>
    /// 
    /// https://dotnetthoughts.net/read-excel-as-datatable-using-openxml-and-c/
    /// 
    /// </summary>
    class TestReadingExcelCells
    {
        /// <summary>
        /// 
        /// </summary>
        private DataTable dataTable = new DataTable( );

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataTable"></param>
        public void SaveInto( string namefile )
        {
            List<string> listing = new List<string>( );

            StringBuilder buffer2 = new StringBuilder( );

            //  表格的标题
            foreach ( DataColumn line in dataTable.Columns ) buffer2.AppendFormat( "{0},", line.Caption );

            listing.Add( buffer2.ToString( ) );

            //  表格的行内容
            foreach ( DataRow line in dataTable.Rows )
            {
                StringBuilder buffer = new StringBuilder( );

                foreach ( object item in line.ItemArray ) buffer.AppendFormat( "{0},", item.ToString( ) );

                listing.Add( buffer.ToString( ) );
            }

            File.WriteAllLines( namefile, listing, Encoding.Default );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 这里使用了 openxml - 销售数据汇总
        /// 
        /// 可以获得标题行，数据内容
        /// 
        /// 类的含义不是特别明白，没有完全看懂
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public void ReadAsDataTable( string fileName )
        {
            using ( SpreadsheetDocument spstDocument = SpreadsheetDocument.Open( fileName, false ) )
            {
                WorkbookPart workbookPart = spstDocument.WorkbookPart;
                
                IEnumerable<Sheet> sheets = spstDocument.WorkbookPart.Workbook.GetFirstChild<Sheets>( ).Elements<Sheet>( );
                
                string relationshipId = sheets.First( ).Id.Value;

                foreach ( Sheet sht in sheets ) Console.WriteLine( sht.Name );

                WorksheetPart worksheetPart = ( WorksheetPart ) spstDocument.WorkbookPart.GetPartById( relationshipId );
                
                Worksheet workSheet = worksheetPart.Worksheet;
                
                SheetData sheetData = workSheet.GetFirstChild<SheetData>( );
                
                IEnumerable<Row> rows = sheetData.Descendants<Row>( );

                //
                foreach ( Cell cell in rows.ElementAt( 0 ) )
                {
                    dataTable.Columns.Add( this.GetCellValue( spstDocument, cell ) );
                }

                //
                foreach ( Row row in rows )
                {
                    DataRow dataRow = dataTable.NewRow( );

                    for ( int i = 0; i < row.Descendants<Cell>( ).Count( ); i++ )
                    {
                        dataRow[ i ] = this.GetCellValue( spstDocument, row.Descendants<Cell>( ).ElementAt( i ) );
                    }

                    dataTable.Rows.Add( dataRow );
                }
                //
            }

            dataTable.Rows.RemoveAt( 0 );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="document"></param>
        /// <param name="cell"></param>
        /// <returns></returns>
        private string GetCellValue( SpreadsheetDocument document, Cell cell )
        {
            SharedStringTablePart stringTablePart = document.WorkbookPart.SharedStringTablePart;

            string value = cell.CellValue.InnerXml;

            if ( cell.DataType != null && cell.DataType.Value == CellValues.SharedString )
            {
                return stringTablePart.SharedStringTable.ChildElements[ Int32.Parse( value ) ].InnerText;
            }

            return value;
        }

        //.....................................................................
    }
}