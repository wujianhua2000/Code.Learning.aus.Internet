using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

using OpxM = DocumentFormat.OpenXml.Math;

namespace Hans.Opxm
{
    class TestDocxTableHead_ID : OpenDocxBase
    {

        //.....................................................................
        /// <summary>
        /// Creates an Document instance and adds its children.
        /// </summary>
        /// <returns></returns>
        public override Document GenerateDocument( )
        {
            Document document1 = new Document( ) { MCAttributes = new MarkupCompatibilityAttributes( ) { Ignorable = "w14 wp14" } };

            document1.AddNamespaceDeclaration( "wpc", "http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas" );
            document1.AddNamespaceDeclaration( "mc", "http://schemas.openxmlformats.org/markup-compatibility/2006" );
            document1.AddNamespaceDeclaration( "o", "urn:schemas-microsoft-com:office:office" );
            document1.AddNamespaceDeclaration( "r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships" );
            document1.AddNamespaceDeclaration( "m", "http://schemas.openxmlformats.org/officeDocument/2006/math" );
            document1.AddNamespaceDeclaration( "v", "urn:schemas-microsoft-com:vml" );
            document1.AddNamespaceDeclaration( "wp14", "http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing" );
            document1.AddNamespaceDeclaration( "wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing" );
            document1.AddNamespaceDeclaration( "w10", "urn:schemas-microsoft-com:office:word" );
            document1.AddNamespaceDeclaration( "w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main" );
            document1.AddNamespaceDeclaration( "w14", "http://schemas.microsoft.com/office/word/2010/wordml" );
            document1.AddNamespaceDeclaration( "wpg", "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup" );
            document1.AddNamespaceDeclaration( "wpi", "http://schemas.microsoft.com/office/word/2010/wordprocessingInk" );
            document1.AddNamespaceDeclaration( "wne", "http://schemas.microsoft.com/office/word/2006/wordml" );
            document1.AddNamespaceDeclaration( "wps", "http://schemas.microsoft.com/office/word/2010/wordprocessingShape" );

            Body body1 = new Body( );


            //---------------------------------------------
            Table table1 = new Table( );

            TableProperties tableProperties1 = new TableProperties( );

            TableStyle tableStyle1 = new TableStyle( ) { Val = "a3" };

            TableWidth tableWidth1 = new TableWidth( ) { Width = "0", Type = TableWidthUnitValues.Auto };
            
            TableLook tableLook1 = new TableLook( ) 
            {
                Val = "04A0", 
                FirstRow = true,
                LastRow = false, 
                FirstColumn = true, 
                LastColumn = false, 
                NoHorizontalBand = false, 
                NoVerticalBand = true 
            };

            tableProperties1.Append( tableStyle1 );
            tableProperties1.Append( tableWidth1 );
            tableProperties1.Append( tableLook1 );

            //---------------------------------------------
            TableGrid tableGrid1 = new TableGrid( );

            GridColumn gridColumn1 = new GridColumn( ) { Width = "2840" };

            tableGrid1.Append( gridColumn1 );

            //---------------------------------------------
            TableRow tableRow1 = new TableRow( ) 
            {
                RsidTableRowMarkRevision = "00B721D5", 
                RsidTableRowAddition = "00FC1B7A", 
                RsidTableRowProperties = "00B721D5" 
            };

            TableRowProperties tableRowProperties1 = new TableRowProperties( );
            
            TableRowHeight tableRowHeight1 = new TableRowHeight( ) { Val = ( UInt32Value ) 567U };

            tableRowProperties1.Append( tableRowHeight1 );

            TableCell tableCell1 = MakeHeader_ID( );

            //---------------------------------------------
            tableRow1.Append( tableRowProperties1 );
            tableRow1.Append( tableCell1 );

            //---------------------------------------------

            table1.Append( tableProperties1 );
            table1.Append( tableGrid1 );
            table1.Append( tableRow1 );

            //---------------------------------------------
            Paragraph paragraph2 = new Paragraph( ) { RsidParagraphAddition = "00C84300", RsidRunAdditionDefault = "00C84300" };
            BookmarkStart bookmarkStart1 = new BookmarkStart( ) { Name = "_GoBack", Id = "0" };
            BookmarkEnd bookmarkEnd1 = new BookmarkEnd( ) { Id = "0" };

            paragraph2.Append( bookmarkStart1 );
            paragraph2.Append( bookmarkEnd1 );
            Paragraph paragraph3 = new Paragraph( ) { RsidParagraphAddition = "00D1725A", RsidRunAdditionDefault = "00D1725A" };
            Paragraph paragraph4 = new Paragraph( ) { RsidParagraphAddition = "00D1725A", RsidRunAdditionDefault = "00D1725A" };

            SectionProperties sectionProperties1 = new SectionProperties( ) { RsidR = "00D1725A" };
            PageSize pageSize1 = new PageSize( ) { Width = ( UInt32Value ) 11906U, Height = ( UInt32Value ) 16838U };
            PageMargin pageMargin1 = new PageMargin( ) { Top = 1440, Right = ( UInt32Value ) 1800U, Bottom = 1440, Left = ( UInt32Value ) 1800U, Header = ( UInt32Value ) 851U, Footer = ( UInt32Value ) 992U, Gutter = ( UInt32Value ) 0U };
            Columns columns1 = new Columns( ) { Space = "425" };
            DocGrid docGrid1 = new DocGrid( ) { Type = DocGridValues.Lines, LinePitch = 312 };

            sectionProperties1.Append( pageSize1 );
            sectionProperties1.Append( pageMargin1 );
            sectionProperties1.Append( columns1 );
            sectionProperties1.Append( docGrid1 );

            //---------------------------------------------
            body1.Append( table1 );
            body1.Append( paragraph2 );
            body1.Append( paragraph3 );
            body1.Append( paragraph4 );
            body1.Append( sectionProperties1 );

            document1.Append( body1 );

            return document1;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private TableCell MakeHeader_ID( )
        {
            TableCell tableElem = new TableCell( );

            TableCellProperties tableCellProperties1 = MakeTableCellProperties( 2840 );

            Paragraph paragra = MakeTableCellParagraph( );

            tableElem.Append( tableCellProperties1 );
            tableElem.Append( paragra );

            return tableElem;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private TableCellProperties MakeTableCellProperties( int width )
        {
            TableCellProperties properties = new TableCellProperties( );

            TableCellWidth elemWidth = new TableCellWidth( ) 
            {
                Width = width.ToString() , Type = TableWidthUnitValues.Dxa 
            };

            TableCellVerticalAlignment vertalign = new TableCellVerticalAlignment( ) 
            {
                Val = TableVerticalAlignmentValues.Center 
            };

            properties.Append( elemWidth );
            properties.Append( vertalign );
            
            return properties;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Paragraph MakeTableCellParagraph( )
        {
            Paragraph paragraph1 = new Paragraph( ) 
            {
                RsidParagraphMarkRevision = "00B721D5", 
                RsidParagraphAddition = "00FC1B7A", 
                RsidParagraphProperties = "00B721D5", 
                RsidRunAdditionDefault = "00FC1B7A" 
            };

            //---------------------------------------------
            ParagraphProperties paragraphProperties1 = new ParagraphProperties( );
            Justification justification1 = new Justification( ) { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties1 = new ParagraphMarkRunProperties( );

            Bold bold1 = new Bold( );
            Color color1 = new Color( ) { Val = "FF0000" };

            paragraphMarkRunProperties1.Append( bold1 );
            paragraphMarkRunProperties1.Append( color1 );

            paragraphProperties1.Append( justification1 );
            paragraphProperties1.Append( paragraphMarkRunProperties1 );

            //---------------------------------------------
            Run run1 = this.MakeTextRun( "序号" );

            //---------------------------------------------
            paragraph1.Append( paragraphProperties1 );
            paragraph1.Append( run1 );

            return paragraph1;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Run MakeTextRun( string textln )
        {
            Run docrun = new Run( ) { RsidRunProperties = "00B721D5" };

            //---------------------------------------------
            RunProperties properties = new RunProperties( );

            RunFonts runFonts1 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            Bold bold2 = new Bold( );

            Color color2 = new Color( ) { Val = "FF0000" };

            properties.Append( runFonts1 );
            properties.Append( bold2 );
            properties.Append( color2 );

            //---------------------------------------------
            Text doctext = new Text( );
            doctext.Text = textln;                  //   "序号";

            //---------------------------------------------
            docrun.Append( properties );
            docrun.Append( doctext );

            return docrun;
        }

        //.....................................................................
    }
}
