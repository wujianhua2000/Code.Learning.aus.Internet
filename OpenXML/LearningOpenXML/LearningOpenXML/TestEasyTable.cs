using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace LearningOpenXML
{
    class TestEasyTable
    {
        /// <summary>
        /// 
        /// </summary>
        private string NamePath = "d:\\123-test-openxml";

        /// <summary>
        /// 
        /// </summary>
        private string NameDocx = "easy-table.docx";

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        public TestEasyTable( )
        {
            bool miss = ( !Directory.Exists( this.NamePath ) );
            if ( miss ) Directory.CreateDirectory( this.NamePath );

            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public void MakeWord( )
        {
            string docxfile = this.NamePath + "\\" + this.NameDocx;

            // Creates the new instance of the WordprocessingDocument class from the specified file
            // WordprocessingDocument.Open(String, Boolean) method
            // Parameters:
            // string docxfile - docxfile is a string which contains the docxfile of the wordocument
            // bool isEditable

            using ( WordprocessingDocument wordocument = WordprocessingDocument.Create( docxfile, WordprocessingDocumentType.Document ) )
            {
                // Defines the MainDocumentPart            
                MainDocumentPart mainDocxPart = wordocument.AddMainDocumentPart( );
                mainDocxPart.Document = new Document( );

                Body docxbody = mainDocxPart.Document.AppendChild( new Body( ) );

                // Create a new table
                Table docxtable = new Table( );

                TableProperties tabproperties = this.MakeTableProperties( );

                // Add the table properties to the table
                docxtable.AppendChild( tabproperties );

                this.MakeTableRows( docxtable );

                // Add the table to the docxbody
                docxbody.AppendChild( docxtable );

                mainDocxPart.Document.Save( );
            }

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private void MakeTableRows( Table wordtable )
        {
            //List<TableRow> listrows = new List<TableRow>( );

            List<string> line1 = new List<string>( );
            List<string> line2 = new List<string>( );

            line1.Add( "p122231" );
            line1.Add( "wu jianhua" );

            line2.Add( "1149554" );
            line2.Add( "wolfgang" );

            TableRow tabrow1 = MakeTableRowText( line1 );
            TableRow tabrow2 = MakeTableRowText( line2 );

            //listrows.Add( tabrow1 );
            //listrows.Add( tabrow2 );

            //// Add the rows to the table
            wordtable.AppendChild( tabrow1 );
            wordtable.AppendChild( tabrow2 );

            //  return listrows;

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private TableProperties MakeTableProperties( )
        {
            //// Create the table properties
            TableProperties properties = new TableProperties( );

            TableBorders borders = this.MakeTableBorders( BorderValues.Thick, "CC0000" );

            //// Add the table borders to the properties
            properties.AppendChild( borders );

            return properties;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listing"></param>
        /// <returns></returns>
        private TableRow MakeTableRowText( List<string> listing )
        {
            //// Create a new row
            TableRow rowline = new TableRow( );

            ////// Add a cell to each column in the row
            //TableCell tcName1 = new TableCell( new Paragraph( new Run( new Text( "wu jianhua" ) ) ) );
            //TableCell tcId1 = new TableCell( new Paragraph( new Run( new Text( "1" ) ) ) );

            ////// Add the cells to the row
            //rowline.Append( tcName1 );
            //rowline.Append( tcId1 );

            foreach ( string item in listing )
            {
                TableCell itemcell = new TableCell( new Paragraph( new Run( new Text( item ) ) ) );
                rowline.Append( itemcell );
            }

            return rowline;
        }

        //.....................................................................
        /// <summary>
        /// Create Table Borders
        /// 
        /// </summary>
        /// <returns></returns>
        private TableBorders MakeTableBorders( BorderValues btThick, string btColor )
        {
            TableBorders tableborders = new TableBorders( );

            TopBorder borderTOP = new TopBorder( );
            BottomBorder borderBTM = new BottomBorder( );

            LeftBorder borderLFT = new LeftBorder( );
            RightBorder borderRGT = new RightBorder( );

            InsideHorizontalBorder borderHorz = new InsideHorizontalBorder( );
            InsideVerticalBorder borderVert = new InsideVerticalBorder( );

            borderTOP.Val = new EnumValue<BorderValues>( btThick );     //BorderValues.Thick );
            borderTOP.Color = btColor;                                  // "CC0000";

            borderBTM.Val = new EnumValue<BorderValues>( btThick );     //BorderValues.Thick );
            borderBTM.Color = btColor;                                  // "CC0000";

            borderLFT.Val = new EnumValue<BorderValues>( btThick );     //BorderValues.Thick );
            borderLFT.Color = btColor;                                  // "CC0000";

            borderRGT.Val = new EnumValue<BorderValues>( btThick );     //BorderValues.Thick );
            borderRGT.Color = btColor;                                  // "CC0000";

            borderHorz.Val = new EnumValue<BorderValues>( btThick );    //BorderValues.Thick );
            borderHorz.Color = btColor;                                 // "CC0000";

            borderVert.Val = new EnumValue<BorderValues>( btThick );    //BorderValues.Thick );
            borderVert.Color = btColor;                                 // "CC0000";

            tableborders.AppendChild( borderTOP );
            tableborders.AppendChild( borderBTM );
            tableborders.AppendChild( borderRGT );
            tableborders.AppendChild( borderLFT );

            tableborders.AppendChild( borderHorz );
            tableborders.AppendChild( borderVert );

            return tableborders;
        }

        //.....................................................................
    }
}
