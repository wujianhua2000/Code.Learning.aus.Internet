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
    class TestXlsxEmptySheet : OpenXlsxBase
    {
        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="worksheetpart"></param>
        public override void GenerateXlsxDocument( WorkbookPart workbookpart )
        {
            List<double> listing = new List<double>( ) { 8, 12, 12, 8 };

            WorksheetPart worksheetpart = this.MakeNewWorksheetData( workbookpart, listing );        //new SheetData( );
            SheetData sheetData = worksheetpart.Worksheet.GetFirstChild<SheetData>( );

            // I don't know what the InnerText of Row.Spans is used for. It doesn't seem to change the resulting xml.
            Row row = new Row( ) { RowIndex = 1U, Height=20D, CustomHeight= true, Spans = new ListValue<StringValue>( ) { InnerText = "1:3" } };

            Cell cell1 = new Cell( ) { CellReference = "A1", DataType = CellValues.Number, CellValue = new CellValue( "99" ) };
            Cell cell2 = new Cell( ) { CellReference = "B1", DataType = CellValues.Number, CellValue = new CellValue( "55" ) };
            Cell cell3 = new Cell( ) { CellReference = "C1", DataType = CellValues.Number, CellValue = new CellValue( "33" ) };

            row.Append( cell1 );
            row.Append( cell2 );
            row.Append( cell3 );

            sheetData.Append( row );

            return;
        }

        //.....................................................................
    }
}
