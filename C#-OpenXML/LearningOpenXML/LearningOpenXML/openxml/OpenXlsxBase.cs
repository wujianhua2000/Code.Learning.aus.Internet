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
    /// https://www.c-sharpcorner.com/article/creating-excel-file-using-openxml/
    /// 
    /// https://docs.microsoft.com/en-us/office/open-xml/how-to-retrieve-the-values-of-cells-in-a-spreadsheet
    /// 
    /// http://polymathprogrammer.com/2009/12/21/advanced-styling-in-excel-open-xml/
    /// 
    /// https://forums.asp.net/t/1941903.aspx?Inserting+multiple+worksheet+to+Excel+using+Openxml+C+
    /// 
    /// </summary>
    class OpenXlsxBase
    {
        /// <summary>
        /// 
        /// </summary>
        public string NamePath = "d:\\123-test-openxml";

        /// <summary>
        /// 
        /// </summary>
        public string NameXlsx = "test-openxml.xlsx";


                //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        public OpenXlsxBase( )
        {
            bool miss = ( !Directory.Exists( this.NamePath ) );
            if ( miss ) Directory.CreateDirectory( this.NamePath );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string GetXlsxName( )
        {
            System.DateTime today = System.DateTime.Now;

            this.NameXlsx = string.Format( "test-xlsx-{0}-{1}-{2}-{3}-{4}.xlsx",
                                            today.Year,
                                            today.Month,
                                            today.Day,
                                            today.Hour,
                                            today.Minute
                                            );

            string result = this.NamePath + "\\" + this.NameXlsx;

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        protected SpreadsheetDocument spreadsheetDocument = null;

        //.....................................................................
        /// <summary>
        /// http://www.dispatchertimer.com/tutorial/how-to-create-an-excel-file-in-net-using-openxml-part-2-export-a-collection-to-spreadsheet/
        /// </summary>
        /// <param name="filepath"></param>
        /// public void TestXlsx( )
        public void TestXlsx( )        //string filepath )
        {
            // Create a spreadsheet document by supplying the filepath.
            // By default, AutoSave = true, Editable = true, and Type = xlsx.
            using ( this.spreadsheetDocument = SpreadsheetDocument.Create(
                                                    this.GetXlsxName( ),
                                                    SpreadsheetDocumentType.Workbook ) )
            {
                // Add a WorkbookPart to the document.
                WorkbookPart workbookpart = spreadsheetDocument.AddWorkbookPart( );
                workbookpart.Workbook = new Workbook( );
                workbookpart.Workbook.AppendChild( new Sheets( ) );

                // Adding style
                WorkbookStylesPart stylePart = workbookpart.AddNewPart<WorkbookStylesPart>( );
                stylePart.Stylesheet = this.GenerateStylesheet( );
                stylePart.Stylesheet.Save( );

                this.GenerateXlsxDocument( workbookpart );

                //.............................................
                workbookpart.Workbook.Save( );

                // Close the document.
                spreadsheetDocument.Close( );
            }

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="worksheetpart"></param>
        //public virtual void GenerateXlsxDocument( WorksheetPart worksheetPart, Sheets sheets )
        //{
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="worksheetPart"></param>
        /// <param name="sheets"></param>
        public virtual void GenerateXlsxDocument( WorkbookPart workbookpart )
        {
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="workbookpart"></param>
        /// <param name="sheetname"></param>
        /// <returns></returns>
        public WorksheetPart MakeNewWorksheetData( WorkbookPart workbookpart, List<double> widtlisting, string sheetname = "" )
        {
            var select = workbookpart.Workbook.Sheets.Elements<Sheet>( ).Select( s => s.SheetId.Value );

            uint maxID = ( select.Count( ) == 0 ) ? 1 : select.Max( ) + 1;

            string nextID = string.Format( "rID{0}", maxID );

            string newshtname = ( string.IsNullOrEmpty( sheetname ) ) 
                                                ? "sheet" + maxID.ToString( ) 
                                                : sheetname;

            //.............................................
            WorksheetPart worksheetpart = workbookpart.AddNewPart<WorksheetPart>( nextID );



            //.............................................
            //string nextID = workbookpart.GetIdOfPart( worksheetpart );

            Sheet sheet = new Sheet( ) { Id = nextID, SheetId = maxID, Name = newshtname };

            //Console.WriteLine( "" + maxID + "; " + nextID );

            Sheets sheets = workbookpart.Workbook.Sheets;
            sheets.Append( sheet );
            //.............................................
            Column con1 = new Column( ) { Min = 1, Max = 1, Width = 4D, CustomWidth = true }; // Id column
            Column con2 = new Column( ) { Min = 2, Max = 3, Width = 15D, CustomWidth = true };// Name and Birthday columns
            Column con3 = new Column( ) { Min = 4, Max = 4, Width = 8D, CustomWidth = true };// Salary column

            // Setting up columns
            Columns columns = new Columns( );

            columns.Append( con1 );  // con2, con3 );
            columns.Append( con2 );  // con2, con3 );
            columns.Append( con3 );  // con2, con3 );

            //.............................................
            SheetData sheetData = new SheetData( );

            SheetFormatProperties sheetFormatProperties = new SheetFormatProperties( ) { DefaultRowHeight = 15D };
            PageMargins pageMargins = new PageMargins( ) { Left = 0.7D, Right = 0.7D, Top = 0.7D, Bottom = 0.75D, Header = 0.3D, Footer = 0.3D };

            //.............................................
            Worksheet worksheet = new Worksheet( );
            worksheet.AddNamespaceDeclaration( "r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships" );

            //worksheet.Append( sheetDimension );
            //worksheet.Append( sheetViews );
            worksheet.Append( sheetFormatProperties );
            worksheet.Append( columns );
            worksheet.Append( sheetData );
            worksheet.Append( pageMargins );

            worksheetpart.Worksheet = worksheet;

            //SheetData sdata = worksheetpart.Worksheet.GetFirstChild<SheetData>( );

            //bool same = ( sdata == sheetData );

            ////  worksheetpart.Worksheet 必须非空。
            //this.SetupSheetColumns( worksheetpart );

            return worksheetpart;
        }

        //.....................................................................
        /// <summary>
        /// Stylesheet class is used to add custom style to a spreadsheet. 
        /// 
        /// Stylesheet can accept different elements such as, Borders, Colors, Fills, and etc. 
        /// as its child elements which specifies the look of a spreadsheet. 
        /// 
        /// The CellFormats stores the combination of different Styles 
        /// which later can be applied on a cell.
        /// 
        /// In order to add a Stylesheet to our workbook, we need to add a WorkbookStylePart
        /// to the Workbook part and initialize its StyleSheet property.
        /// 
        /// We are going to make our header bold and white with dark background 
        /// as well as adding border to all other cells.
        /// 
        /// Create a new method GenerateStylesheet() which 
        /// returns a StyleSheet object to the Report class.
        /// 
        /// </summary>
        /// <returns></returns>
        private Stylesheet GenerateStylesheet( )
        {
            //  Fonts can have one or more Font children which each have different properties 
            //  like FontSize, Bold, Color, and etc.
            //
            //  Take note that we add two Font children to the Fonts object. 
            //  The first one is the default font use by all cells, 
            //  and the second one is specific to header.
            //
            Color color = new Color( ) { Rgb = "FFFFFF" };

            Font font1 = new Font( new FontSize( ) { Val = 10 } );                        // Index 0 - default
            Font font2 = new Font( new FontSize( ) { Val = 10 }, new Bold( ), color );    // Index 1 - header
            
            Fonts fonts = new Fonts( font1, font2 );

            //.............................................
            //  Fills can have one or more Fill children which you can set its ForegroundColor.
            //
            //  Excel needs to have the first two as the default. 
            //  The 3rd one is the style we want to have for our header cells; a gray sold background.
            //
            ForegroundColor fcolor = new ForegroundColor { Rgb = new HexBinaryValue( ) { Value = "66666666" } };

            Fill fi1 = new Fill( new PatternFill( ) { PatternType = PatternValues.None } );             // Index 0 - default
            Fill fi2 = new Fill( new PatternFill( ) { PatternType = PatternValues.Gray125 } );          // Index 1 - default
            Fill fi3 = new Fill( new PatternFill( fcolor ) { PatternType = PatternValues.Solid } );     // Index 2 - header

            Fills fills = new Fills( fi1, fi2, fi3 );

            //.............................................
            //  Borders can have one or more Border children which each defines how the border should look like:
            //  The 1st is the default border and the 2nd one is our customized border.
            //
            var brLF = new LeftBorder( new Color( ) { Auto = true } ) { Style = BorderStyleValues.Thin };
            var brRT = new RightBorder( new Color( ) { Auto = true } ) { Style = BorderStyleValues.Thin };
            var brTP = new TopBorder( new Color( ) { Auto = true } ) { Style = BorderStyleValues.Thin };
            var brBT = new BottomBorder( new Color( ) { Auto = true } ) { Style = BorderStyleValues.Thin };
            var brDG = new DiagonalBorder( );

            Border bd1 = new Border( );                                     // index 0 default
            Border bd2 = new Border( brLF, brRT, brTP, brBT, brDG );        // index 1 black border

            Borders borders = new Borders( bd1, bd2 );

            //.............................................
            //  Now that we have defied our custom formats elements we can create CellFormats 
            //  which has one or many CellFormat children. 
            //  Each CellFormat gets the index of Font, Border, Fill, or etc. which it will associate with:
            //
            CellFormat cfmt1 = new CellFormat( ); // default
            CellFormat cfmt2 = new CellFormat { FontId = 0, FillId = 0, BorderId = 1, ApplyBorder = true }; // body
            CellFormat cfmt3 = new CellFormat { FontId = 1, FillId = 2, BorderId = 1, ApplyFill = true }; // header

            CellFormats cellFormats = new CellFormats( cfmt1, cfmt2, cfmt3 );

            Stylesheet styleSheet = new Stylesheet( fonts, fills, borders, cellFormats );

            return styleSheet;
        }


        public Columns SetupSheetColumns( List<double> listing )
        {
            // Setting up columns
            Columns columns = new Columns( );

            uint idx = 0;
            foreach ( double value in listing )
            {
                Column con1 = new Column( );
                idx++;
                con1.Min = idx; 
                con1.Max = idx;
                con1.Width = 4D; 
                con1.CustomWidth = true; // Id column

                columns.Append( con1 );  // con2, con3 );
            }

            return columns;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wbookpart"></param>
        private void GenerateWorkBook( WorkbookPart wbookpart )
        {
            Workbook workbook1 = new Workbook( );

            workbook1.AddNamespaceDeclaration( "r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships" );
            
            FileVersion fileVersion1 = new FileVersion( ) { ApplicationName = "xl", LastEdited = "5", LowestEdited = "5", BuildVersion = "9303" };
            
            WorkbookProperties workbookProperties1 = new WorkbookProperties( ) { DefaultThemeVersion = ( UInt32Value ) 124226U };

            BookViews bookViews1 = new BookViews( );
            WorkbookView workbookView1 = new WorkbookView( ) { XWindow = 0, YWindow = 45, WindowWidth = ( UInt32Value ) 15075U, WindowHeight = ( UInt32Value ) 4680U };

            bookViews1.Append( workbookView1 );

            //.............................................
            Sheets sheets1 = new Sheets( );
            Sheet sheet1 = new Sheet( ) { Name = "Sheet1", SheetId = ( UInt32Value ) 1U, Id = "rId1" };
            Sheet sheet2 = new Sheet( ) { Name = "Sheet2", SheetId = ( UInt32Value ) 2U, Id = "rId2" };
            Sheet sheet3 = new Sheet( ) { Name = "Sheet3", SheetId = ( UInt32Value ) 3U, Id = "rId3" };

            sheets1.Append( sheet1 );
            sheets1.Append( sheet2 );
            sheets1.Append( sheet3 );
            //.............................................
            CalculationProperties calculationProperties1 = new CalculationProperties( ) { CalculationId = ( UInt32Value ) 145621U };

            workbook1.Append( fileVersion1 );
            workbook1.Append( workbookProperties1 );
            workbook1.Append( bookViews1 );
            
            workbook1.Append( sheets1 );
            
            workbook1.Append( calculationProperties1 );

            wbookpart.Workbook = workbook1;

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="worksheetpart"></param>
        private void GenerateWorksheet( WorksheetPart worksheetPart )
        {
            
            //  [1]
            SheetDimension sheetDimension3 = new SheetDimension( ) { Reference = "A1:C5" };

            //.............................................
            Selection selection1 = new Selection( ) { ActiveCell = "C6", SequenceOfReferences = new ListValue<StringValue>( ) { InnerText = "C6" } };

            SheetView sheetView3 = new SheetView( ) { TabSelected = true, WorkbookViewId = ( UInt32Value ) 0U };
            sheetView3.Append( selection1 );

            //  [1]
            SheetViews sheetViews3 = new SheetViews( );
            sheetViews3.Append( sheetView3 );
            
            //.............................................
            //  [1]
            SheetFormatProperties sheetFormatProperties3 = new SheetFormatProperties( ) { DefaultRowHeight = 13.5D, DyDescent = 0.15D };

            //.............................................
            Row row1 = new Row( ) { RowIndex = ( UInt32Value ) 1U, Spans = new ListValue<StringValue>( ) { InnerText = "1:3" }, DyDescent = 0.15D };

            Cell cell1 = new Cell( ) { CellReference = "A1" };
            CellValue cellValue1 = new CellValue( );
            cellValue1.Text = "1";

            cell1.Append( cellValue1 );

            Cell cell2 = new Cell( ) { CellReference = "C1" };
            CellValue cellValue2 = new CellValue( );
            cellValue2.Text = "3";

            cell2.Append( cellValue2 );

            row1.Append( cell1 );
            row1.Append( cell2 );

            //.............................................
            Row row2 = new Row( ) { RowIndex = ( UInt32Value ) 2U, Height=44D, Spans = new ListValue<StringValue>( ) { InnerText = "1:3" }, DyDescent = 0.15D };

            Cell cell3 = new Cell( ) { CellReference = "A2" };
            CellValue cellValue3 = new CellValue( );
            cellValue3.Text = "2";

            cell3.Append( cellValue3 );

            Cell cell4 = new Cell( ) { CellReference = "C2" };
            CellValue cellValue4 = new CellValue( );
            cellValue4.Text = "4";

            cell4.Append( cellValue4 );

            row2.Append( cell3 );
            row2.Append( cell4 );

            //.............................................
            Row row3 = new Row( ) { RowIndex = ( UInt32Value ) 5U, Spans = new ListValue<StringValue>( ) { InnerText = "1:3" }, DyDescent = 0.15D };

            Cell cell5 = new Cell( ) { CellReference = "C5", DataType = CellValues.SharedString };
            CellValue cellValue5 = new CellValue( );
            cellValue5.Text = "0";

            cell5.Append( cellValue5 );

            row3.Append( cell5 );

            //.............................................
            //  [1]
            SheetData sheetData3 = new SheetData( );

            sheetData3.Append( row1 );
            sheetData3.Append( row2 );
            sheetData3.Append( row3 );

            //.............................................
            //  [1]
            PhoneticProperties phoneticProperties3 = new PhoneticProperties( ) { FontId = ( UInt32Value ) 1U, Type = PhoneticValues.NoConversion };

            //  [1]
            PageMargins pageMargins3 = new PageMargins( ) { Left = 0.7D, Right = 0.7D, Top = 0.75D, Bottom = 0.75D, Header = 0.3D, Footer = 0.3D };

            //.............................................
            Worksheet worksheet3 = MakeWorkSheet( );

            worksheet3.Append( sheetDimension3 );
            worksheet3.Append( sheetViews3 );
            worksheet3.Append( sheetFormatProperties3 );
            
            worksheet3.Append( sheetData3 );

            worksheet3.Append( phoneticProperties3 );
            worksheet3.Append( pageMargins3 );

            //.............................................
            worksheetPart.Worksheet = worksheet3;

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Worksheet MakeWorkSheet( )
        {
            Worksheet worksheet3 = new Worksheet( ) { MCAttributes = new MarkupCompatibilityAttributes( ) { Ignorable = "x14ac" } };

            worksheet3.AddNamespaceDeclaration( "r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships" );
            worksheet3.AddNamespaceDeclaration( "mc", "http://schemas.openxmlformats.org/markup-compatibility/2006" );
            worksheet3.AddNamespaceDeclaration( "x14ac", "http://schemas.microsoft.com/office/spreadsheetml/2009/9/ac" );
            
            return worksheet3;
        }

        //.....................................................................
    }
}
