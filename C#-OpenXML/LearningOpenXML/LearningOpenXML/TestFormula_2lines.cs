using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

using M = DocumentFormat.OpenXml.Math;

namespace LearningOpenXML
{
    class TestFormula_2lines : TestOpenDocx
    {
        //.....................................................................
        /// <summary>
        /// 
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
            Paragraph paragraph1 = MakeP1( );

            Paragraph paragraph3 = MakeP2( );

            //---------------------------------------------
            Paragraph paragraph5 = new Paragraph( ) { RsidParagraphMarkRevision = "00985895", RsidParagraphAddition = "00985895", RsidRunAdditionDefault = "00985895" };

            ParagraphProperties paragraphProperties1 = new ParagraphProperties( );

            ParagraphMarkRunProperties paragraphMarkRunProperties1 = new ParagraphMarkRunProperties( );
            RunFonts runFonts4 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            paragraphMarkRunProperties1.Append( runFonts4 );

            paragraphProperties1.Append( paragraphMarkRunProperties1 );
            BookmarkStart bookmarkStart1 = new BookmarkStart( ) { Name = "_GoBack", Id = "0" };
            BookmarkEnd bookmarkEnd1 = new BookmarkEnd( ) { Id = "0" };

            paragraph5.Append( paragraphProperties1 );
            paragraph5.Append( bookmarkStart1 );
            paragraph5.Append( bookmarkEnd1 );

            SectionProperties sectionProperties1 = new SectionProperties( ) { RsidRPr = "00985895", RsidR = "00985895" };
            PageSize pageSize1 = new PageSize( ) { Width = ( UInt32Value ) 11906U, Height = ( UInt32Value ) 16838U };
            PageMargin pageMargin1 = new PageMargin( ) { Top = 1440, Right = ( UInt32Value ) 1800U, Bottom = 1440, Left = ( UInt32Value ) 1800U, Header = ( UInt32Value ) 851U, Footer = ( UInt32Value ) 992U, Gutter = ( UInt32Value ) 0U };
            Columns columns1 = new Columns( ) { Space = "425" };
            DocGrid docGrid1 = new DocGrid( ) { Type = DocGridValues.Lines, LinePitch = 312 };

            sectionProperties1.Append( pageSize1 );
            sectionProperties1.Append( pageMargin1 );
            sectionProperties1.Append( columns1 );
            sectionProperties1.Append( docGrid1 );

            body1.Append( paragraph1 );
            body1.Append( paragraph3 );
            body1.Append( this.MakeP3() );

            body1.Append( paragraph5 );
            body1.Append( sectionProperties1 );

            document1.Append( body1 );
            
            return document1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Paragraph MakeP1( )
        {
            Paragraph paragraphNORM = new Paragraph( ) { RsidParagraphMarkRevision = "00985895", RsidParagraphAddition = "00337477", RsidRunAdditionDefault = "00985895" };

            M.Justification justification = new M.Justification( ) { Val = M.JustificationValues.Right };
            
            M.ParagraphProperties paraProperties = new M.ParagraphProperties( );
            paraProperties.Append( justification );

            M.Paragraph paragraphMATH = new M.Paragraph( );

            M.OfficeMath paraMathLine = new M.OfficeMath( );

            M.Run run1 = HansOpenDocx.MakeMathRun( "x=1+2/3=1.6667" ); // new M.Run( );

            paraMathLine.Append( run1 );

            paragraphMATH.Append( paraMathLine );
            paragraphMATH.Append( paraProperties );

            paragraphNORM.Append( paragraphMATH );

            return paragraphNORM;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Paragraph MakeP2( )
        {
            Paragraph paragraph3 = new Paragraph( ) { RsidParagraphMarkRevision = "00985895", RsidParagraphAddition = "00985895", RsidRunAdditionDefault = "00985895" };

            M.Paragraph paragraph4 = new M.Paragraph( );

            M.OfficeMath officeMath2 = new M.OfficeMath( );

            M.Run run3 = HansOpenDocx.MakeMathRun( "y=2+1" ); // new M.Run( );

            officeMath2.Append( run3 );

            M.Justification justification = new M.Justification( ) { Val = M.JustificationValues.Left };

            M.ParagraphProperties paraProperties = new M.ParagraphProperties( );
            paraProperties.Append( justification );

            paragraph4.Append( paraProperties );
            paragraph4.Append( officeMath2 );

            paragraph3.Append( paragraph4 );

            return paragraph3;
        }

        private Paragraph MakeP3( )
        {
            Paragraph paragraph3 = new Paragraph( ) { RsidParagraphMarkRevision = "00985895", RsidParagraphAddition = "00985895", RsidRunAdditionDefault = "00985895" };

            M.Paragraph paragraph4 = new M.Paragraph( );

            M.OfficeMath officeMath2 = new M.OfficeMath( );

            M.Run run3 = HansOpenDocx.MakeMathRun( "z=x+y=2.667" );

            officeMath2.Append( run3 );

            paragraph4.Append( officeMath2 );

            paragraph3.Append( paragraph4 );

            return paragraph3;
        }

        //.....................................................................
    }
}
