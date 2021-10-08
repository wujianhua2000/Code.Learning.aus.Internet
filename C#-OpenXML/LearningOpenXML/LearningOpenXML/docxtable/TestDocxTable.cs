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
    /// <summary>
    /// 
    /// </summary>
    class TestDocxTable : OpenDocxBase
    {
        // Creates an Document instance and adds its children.
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

            Table table1 = new Table( );

            TableProperties tableProperties1 = new TableProperties( );

            TableStyle tableStyle1 = new TableStyle( ) { Val = "a3" };
            
            TableWidth tableWidth1 = new TableWidth( ) { Width = "0", Type = TableWidthUnitValues.Auto };
            
            TableLook tableLook1 = new TableLook( ) { Val = "04A0", FirstRow = true, LastRow = false, FirstColumn = true, LastColumn = false, NoHorizontalBand = false, NoVerticalBand = true };

            tableProperties1.Append( tableStyle1 );
            tableProperties1.Append( tableWidth1 );
            tableProperties1.Append( tableLook1 );

            TableGrid tableGrid1 = new TableGrid( );
            
            GridColumn gridColumn1 = new GridColumn( ) { Width = "2840" };
            GridColumn gridColumn2 = new GridColumn( ) { Width = "2841" };
            GridColumn gridColumn3 = new GridColumn( ) { Width = "2841" };

            tableGrid1.Append( gridColumn1 );
            tableGrid1.Append( gridColumn2 );
            tableGrid1.Append( gridColumn3 );

            TableRow tableRow1 = MakeRow001( );

            TableRow tableRow2 = MakeRow002( );

            //---------------------------------------------
            table1.Append( tableProperties1 );
            table1.Append( tableGrid1 );
            table1.Append( tableRow1 );
            table1.Append( tableRow2 );

            //---------------------------------------------

            Paragraph paragraph7 = new Paragraph( ) { RsidParagraphAddition = "00C84300", RsidRunAdditionDefault = "00C84300" };
            Paragraph paragraph8 = new Paragraph( ) { RsidParagraphAddition = "00D1725A", RsidRunAdditionDefault = "00D1725A" };

            Paragraph paragraph9 = new Paragraph( ) { RsidParagraphAddition = "00D1725A", RsidRunAdditionDefault = "00D1725A" };
            
            //BookmarkStart bookmarkStart1 = new BookmarkStart( ) { Name = "_GoBack", Id = "0" };
            //BookmarkEnd bookmarkEnd1 = new BookmarkEnd( ) { Id = "0" };

            //paragraph9.Append( bookmarkStart1 );
            //paragraph9.Append( bookmarkEnd1 );

            SectionProperties sectionProperties1 = new SectionProperties( ) { RsidR = "00D1725A" };
            PageSize pageSize1 = new PageSize( ) { Width = ( UInt32Value ) 11906U, Height = ( UInt32Value ) 16838U };
            
            PageMargin pageMargin1 = new PageMargin( ) { Top = 1440, Right = ( UInt32Value ) 1800U, Bottom = 1440, Left = ( UInt32Value ) 1800U, Header = ( UInt32Value ) 851U, Footer = ( UInt32Value ) 992U, Gutter = ( UInt32Value ) 0U };
            Columns columns1 = new Columns( ) { Space = "425" };
            DocGrid docGrid1 = new DocGrid( ) { Type = DocGridValues.Lines, LinePitch = 312 };

            sectionProperties1.Append( pageSize1 );
            sectionProperties1.Append( pageMargin1 );
            sectionProperties1.Append( columns1 );
            sectionProperties1.Append( docGrid1 );

            body1.Append( table1 );
            body1.Append( paragraph7 );
            body1.Append( paragraph8 );
            body1.Append( paragraph9 );
            body1.Append( sectionProperties1 );

            document1.Append( body1 );
            
            return document1;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private TableRow MakeRow002( )
        {
            TableRow tableRow2 = new TableRow( ) { RsidTableRowAddition = "00B721D5", RsidTableRowProperties = "00B721D5" };

            TableRowProperties tableRowProperties2 = new TableRowProperties( );
            TableRowHeight tableRowHeight2 = new TableRowHeight( ) { Val = ( UInt32Value ) 567U };

            tableRowProperties2.Append( tableRowHeight2 );

            TableCell tableCell4 = MakeElem4( );
            TableCell tableCell5 = MakeElem5( );
            TableCell tableCell6 = MakeElem6( );

            //---------------------------------------------
            tableRow2.Append( tableRowProperties2 );
            tableRow2.Append( tableCell4 );
            tableRow2.Append( tableCell5 );
            tableRow2.Append( tableCell6 );

            return tableRow2;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private TableCell MakeElem4( )
        {
            //---------------------------------------------
            TableCell tableCell4 = new TableCell( );

            TableCellProperties tableCellProperties4 = new TableCellProperties( );

            TableCellWidth tableCellWidth4 = new TableCellWidth( ) { Width = "2840", Type = TableWidthUnitValues.Dxa };
            TableCellVerticalAlignment tableCellVerticalAlignment4 = new TableCellVerticalAlignment( ) { Val = TableVerticalAlignmentValues.Center };

            tableCellProperties4.Append( tableCellWidth4 );
            tableCellProperties4.Append( tableCellVerticalAlignment4 );

            //---------------------------------------------
            Paragraph paragraph4 = new Paragraph( ) { RsidParagraphAddition = "00B721D5", RsidParagraphProperties = "00B721D5", RsidRunAdditionDefault = "00B721D5" };

            ParagraphProperties paragraphProperties4 = new ParagraphProperties( );
            Justification justification4 = new Justification( ) { Val = JustificationValues.Right };
            paragraphProperties4.Append( justification4 );

            //---------------------------------------------
            Run run4 = new Run( );

            RunProperties runProperties4 = new RunProperties( );
            RunFonts runFonts2 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            runProperties4.Append( runFonts2 );
            Text text4 = new Text( );
            text4.Text = "123";

            run4.Append( runProperties4 );
            run4.Append( text4 );

            //---------------------------------------------
            paragraph4.Append( paragraphProperties4 );
            paragraph4.Append( run4 );

            tableCell4.Append( tableCellProperties4 );
            tableCell4.Append( paragraph4 );
            return tableCell4;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private TableCell MakeElem5( )
        {
            //---------------------------------------------
            TableCell tableCell5 = new TableCell( );

            //---------------------------------------------
            TableCellProperties tableCellProperties5 = new TableCellProperties( );

            TableCellWidth tableCellWidth5 = new TableCellWidth( ) { Width = "2841", Type = TableWidthUnitValues.Dxa };
            TableCellVerticalAlignment tableCellVerticalAlignment5 = new TableCellVerticalAlignment( ) { Val = TableVerticalAlignmentValues.Center };

            tableCellProperties5.Append( tableCellWidth5 );
            tableCellProperties5.Append( tableCellVerticalAlignment5 );

            //---------------------------------------------
            Paragraph paragraph5 = new Paragraph( ) { RsidParagraphMarkRevision = "00422B84", RsidParagraphAddition = "00B721D5", RsidRunAdditionDefault = "00B721D5" };

            ParagraphProperties paragraphProperties5 = new ParagraphProperties( );

            //---------------------------------------------
            ParagraphMarkRunProperties paragraphMarkRunProperties4 = new ParagraphMarkRunProperties( );
            Bold bold7 = new Bold( );
            Strike strike1 = new Strike( );

            paragraphMarkRunProperties4.Append( bold7 );
            paragraphMarkRunProperties4.Append( strike1 );

            paragraphProperties5.Append( paragraphMarkRunProperties4 );

            //---------------------------------------------
            ProofError proofError1 = new ProofError( ) { Type = ProofingErrorValues.SpellStart };

            //---------------------------------------------
            Run run5 = new Run( ) { RsidRunProperties = "00422B84" };

            RunProperties runProperties5 = new RunProperties( );
            Bold bold8 = new Bold( );
            Strike strike2 = new Strike( );

            runProperties5.Append( bold8 );
            runProperties5.Append( strike2 );

            Text text5 = new Text( );
            text5.Text = "Wu";

            run5.Append( runProperties5 );
            run5.Append( text5 );

            //---------------------------------------------
            Run run6 = new Run( ) { RsidRunProperties = "00422B84" };

            RunProperties runProperties6 = new RunProperties( );
            RunFonts runFonts3 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };
            Bold bold9 = new Bold( );
            Strike strike3 = new Strike( );

            runProperties6.Append( runFonts3 );
            runProperties6.Append( bold9 );
            runProperties6.Append( strike3 );
            Text text6 = new Text( );
            text6.Text = "jianhua";

            run6.Append( runProperties6 );
            run6.Append( text6 );

            //---------------------------------------------
            ProofError proofError2 = new ProofError( ) { Type = ProofingErrorValues.SpellEnd };

            paragraph5.Append( paragraphProperties5 );
            paragraph5.Append( proofError1 );
            paragraph5.Append( run5 );
            paragraph5.Append( run6 );
            paragraph5.Append( proofError2 );

            tableCell5.Append( tableCellProperties5 );
            tableCell5.Append( paragraph5 );
        
            return tableCell5;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private TableCell MakeElem6( )
        {
            TableCell tableCell6 = new TableCell( );

            //---------------------------------------------
            TableCellProperties tableCellProperties6 = new TableCellProperties( );

            TableCellWidth tableCellWidth6 = new TableCellWidth( ) { Width = "2841", Type = TableWidthUnitValues.Dxa };
            TableCellVerticalAlignment tableCellVerticalAlignment6 = new TableCellVerticalAlignment( ) { Val = TableVerticalAlignmentValues.Center };

            tableCellProperties6.Append( tableCellWidth6 );
            tableCellProperties6.Append( tableCellVerticalAlignment6 );

            //---------------------------------------------
            Paragraph paragraph6 = new Paragraph( ) { RsidParagraphMarkRevision = "00422B84", RsidParagraphAddition = "00B721D5", RsidRunAdditionDefault = "00B721D5" };

            ParagraphProperties paragraphProperties6 = new ParagraphProperties( );

            ParagraphMarkRunProperties paragraphMarkRunProperties5 = new ParagraphMarkRunProperties( );
            Bold bold10 = new Bold( );
            Italic italic1 = new Italic( );
            Underline underline1 = new Underline( ) { Val = UnderlineValues.Wave };

            paragraphMarkRunProperties5.Append( bold10 );
            paragraphMarkRunProperties5.Append( italic1 );
            paragraphMarkRunProperties5.Append( underline1 );

            paragraphProperties6.Append( paragraphMarkRunProperties5 );


            //---------------------------------------------
            Run run7 = new Run( ) { RsidRunProperties = "00422B84" };

            RunProperties runProperties7 = new RunProperties( );

            Bold bold11 = new Bold( );
            Italic italic2 = new Italic( );
            Underline underline2 = new Underline( ) { Val = UnderlineValues.Wave };

            runProperties7.Append( bold11 );
            runProperties7.Append( italic2 );
            runProperties7.Append( underline2 );

            Text text7 = new Text( );
            text7.Text = "P";

            run7.Append( runProperties7 );
            run7.Append( text7 );

            //---------------------------------------------
            Run run8 = new Run( ) { RsidRunProperties = "00422B84" };

            RunProperties runProperties8 = new RunProperties( );
            RunFonts runFonts4 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            Bold bold12 = new Bold( );
            Italic italic3 = new Italic( );
            Underline underline3 = new Underline( ) { Val = UnderlineValues.Wave };

            runProperties8.Append( runFonts4 );
            runProperties8.Append( bold12 );
            runProperties8.Append( italic3 );
            runProperties8.Append( underline3 );

            Text text8 = new Text( );
            text8.Text = "122231";

            run8.Append( runProperties8 );
            run8.Append( text8 );

            //---------------------------------------------
            paragraph6.Append( paragraphProperties6 );
            paragraph6.Append( run7 );
            paragraph6.Append( run8 );

            tableCell6.Append( tableCellProperties6 );
            tableCell6.Append( paragraph6 );
            return tableCell6;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private TableRow MakeRow001( )
        {
            TableRow tableRow1 = new TableRow( ) 
            {
                RsidTableRowMarkRevision = "00B721D5", 
                RsidTableRowAddition = "00B721D5", 
                RsidTableRowProperties = "00B721D5" 
            };

            TableRowProperties tableRowProperties1 = new TableRowProperties( );
            
            TableRowHeight tableRowHeight1 = new TableRowHeight( ) { Val = ( UInt32Value ) 567U };

            tableRowProperties1.Append( tableRowHeight1 );

            TableCell tableCell1 = MakeElem1( );
            TableCell tableCell2 = MakeElem2( );

            TableCell tableCell3 = MakeElem3( );

            tableRow1.Append( tableRowProperties1 );
            tableRow1.Append( tableCell1 );
            tableRow1.Append( tableCell2 );
            tableRow1.Append( tableCell3 );
        
            return tableRow1;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private TableCell MakeElem3( )
        {
            //---------------------------------------------
            TableCell tableCell3 = new TableCell( );

            TableCellProperties tableCellProperties3 = new TableCellProperties( );
            TableCellWidth tableCellWidth3 = new TableCellWidth( ) { Width = "2841", Type = TableWidthUnitValues.Dxa };
            TableCellVerticalAlignment tableCellVerticalAlignment3 = new TableCellVerticalAlignment( ) { Val = TableVerticalAlignmentValues.Center };

            tableCellProperties3.Append( tableCellWidth3 );
            tableCellProperties3.Append( tableCellVerticalAlignment3 );

            //---------------------------------------------
            Paragraph paragraph3 = new Paragraph( ) { RsidParagraphMarkRevision = "00B721D5", RsidParagraphAddition = "00B721D5", RsidParagraphProperties = "00B721D5", RsidRunAdditionDefault = "00B721D5" };

            ParagraphProperties paragraphProperties3 = RedBoldHeaderParagraph( );

            Run run3 = RedBoldRun( "编码" );

            //---------------------------------------------

            paragraph3.Append( paragraphProperties3 );
            paragraph3.Append( run3 );

            tableCell3.Append( tableCellProperties3 );
            tableCell3.Append( paragraph3 );
            return tableCell3;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private TableCell MakeElem2( )
        {
            TableCell tableCell2 = new TableCell( );

            TableCellProperties tableCellProperties2 = SetElemVertCenterWidth( 2841 );

            Paragraph paragraph2 = new Paragraph( ) { RsidParagraphMarkRevision = "00B721D5", RsidParagraphAddition = "00B721D5", RsidParagraphProperties = "00B721D5", RsidRunAdditionDefault = "00B721D5" };

            ParagraphProperties paragraphProperties2 = new ParagraphProperties( );

            Justification justification2 = new Justification( ) { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties2 = ParaMarkRunBold( );

            paragraphProperties2.Append( justification2 );
            paragraphProperties2.Append( paragraphMarkRunProperties2 );

            //---------------------------------------------
            Run run2 = new Run( ) { RsidRunProperties = "00B721D5" };

            RunProperties runProperties2 = new RunProperties( );

            Bold bold4 = new Bold( );
            Color color4 = new Color( ) { Val = "FF0000" };

            runProperties2.Append( bold4 );
            runProperties2.Append( color4 );

            Text text2 = new Text( );
            text2.Text = "名称";

            run2.Append( runProperties2 );
            run2.Append( text2 );

            //---------------------------------------------
            paragraph2.Append( paragraphProperties2 );
            paragraph2.Append( run2 );

            tableCell2.Append( tableCellProperties2 );
            tableCell2.Append( paragraph2 );
        
            return tableCell2;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static TableCell MakeElem1( )
        {
            TableCell tableCell1 = new TableCell( );

            TableCellProperties tableCellProperties1 = new TableCellProperties( );

            TableCellWidth tableCellWidth1 = new TableCellWidth( ) { Width = "2840", Type = TableWidthUnitValues.Dxa };

            TableCellVerticalAlignment tableCellVerticalAlignment1 = new TableCellVerticalAlignment( ) { Val = TableVerticalAlignmentValues.Center };

            tableCellProperties1.Append( tableCellWidth1 );
            tableCellProperties1.Append( tableCellVerticalAlignment1 );

            //---------------------------------------------
            Paragraph paragraph1 = new Paragraph( ) { RsidParagraphMarkRevision = "00B721D5", RsidParagraphAddition = "00B721D5", RsidParagraphProperties = "00B721D5", RsidRunAdditionDefault = "00B721D5" };

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
            Run run1 = new Run( ) { RsidRunProperties = "00B721D5" };

            RunProperties runProperties1 = new RunProperties( );
            RunFonts runFonts1 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };
            Bold bold2 = new Bold( );
            Color color2 = new Color( ) { Val = "FF0000" };

            runProperties1.Append( runFonts1 );
            runProperties1.Append( bold2 );
            runProperties1.Append( color2 );

            Text text1 = new Text( );
            text1.Text = "序号";

            run1.Append( runProperties1 );
            run1.Append( text1 );

            //---------------------------------------------
            paragraph1.Append( paragraphProperties1 );
            paragraph1.Append( run1 );

            tableCell1.Append( tableCellProperties1 );
            tableCell1.Append( paragraph1 );
            
            return tableCell1;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="textstr"></param>
        /// <returns></returns>
        private Run RedBoldRun( string textstr )
        {
            Run run3 = new Run( ) { RsidRunProperties = "00B721D5" };

            //---------------------------------------------
            RunProperties runProperties3 = new RunProperties( );

            Bold bold6 = new Bold( );
            Color color6 = new Color( ) { Val = "FF0000" };

            runProperties3.Append( bold6 );
            runProperties3.Append( color6 );

            //---------------------------------------------
            Text text3 = new Text( );
            text3.Text = textstr;       // "编码";

            //---------------------------------------------
            run3.Append( runProperties3 );
            run3.Append( text3 );

            return run3;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private ParagraphProperties RedBoldHeaderParagraph( )
        {
            Justification justification3 = new Justification( ) { Val = JustificationValues.Center };

            //---------------------------------------------
            ParagraphMarkRunProperties markRunProperties = new ParagraphMarkRunProperties( );

            Bold bold5 = new Bold( );
            Color color5 = new Color( ) { Val = "FF0000" };

            markRunProperties.Append( bold5 );
            markRunProperties.Append( color5 );

            //---------------------------------------------
            ParagraphProperties properties = new ParagraphProperties( );

            properties.Append( justification3 );
            properties.Append( markRunProperties );

            return properties;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private ParagraphMarkRunProperties ParaMarkRunBold( )
        {
            ParagraphMarkRunProperties properties = new ParagraphMarkRunProperties( );
            
            Bold fontbold = new Bold( );
            
            Color fontcolor = new Color( ) { Val = "FF0000" };

            properties.Append( fontbold );

            properties.Append( fontcolor );
            
            return properties;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private TableCellProperties SetElemVertCenterWidth(  int width )
        {
            TableCellProperties properties = new TableCellProperties( );

            TableCellWidth elemWidth = new TableCellWidth( ) 
            {
                Width = width.ToString(), 
                Type = TableWidthUnitValues.Dxa 
            };

            TableCellVerticalAlignment elemVertAlign = new TableCellVerticalAlignment( ) 
            {
                Val = TableVerticalAlignmentValues.Center 
            };

            properties.Append( elemWidth );
            
            properties.Append( elemVertAlign );
            
            return properties;
        }

        //.....................................................................
    }
}
