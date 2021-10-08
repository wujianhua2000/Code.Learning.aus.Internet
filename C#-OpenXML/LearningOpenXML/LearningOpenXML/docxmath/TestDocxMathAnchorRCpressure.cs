using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

using M = DocumentFormat.OpenXml.Math;

namespace Hans.Opxm
{
    //.....................................................................
    /// <summary>
    /// 设备基础局部受压的公式
    /// 
    /// 在锚栓部分。技术规范的 65/94, 7.2.2 section
    /// </summary>
    class TestDocxMathAnchorRCpressure : OpenDocxBase
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

            Paragraph paragraph1 = new Paragraph( ) { RsidParagraphMarkRevision = "009247D5", RsidParagraphAddition = "00632292", RsidRunAdditionDefault = "009247D5" };

            //---------------------------------------------
            M.Paragraph paragraph2 = new M.Paragraph( );

            M.OfficeMath officeMath1 = new M.OfficeMath( );

            //---------------------------------------------
            M.MathFunction mathFunction1 = MakeMath003_Function( );

            officeMath1.Append( OpenDocxMathExprs.MakeScriptLower( "N", "Rd,c" ) );
            officeMath1.Append( OpenDocxMathExprs.MakeMathRun( "=" ) );
            officeMath1.Append( OpenDocxMathExprs.MakeMathRun( "0.60" ) );
            officeMath1.Append( OpenDocxMathExprs.MakeMathRunNoteMult( ) );
            officeMath1.Append( mathFunction1 );
            officeMath1.Append( OpenDocxMathExprs.MakeMathRunNoteMult( ) );
            officeMath1.Append( OpenDocxMathExprs.MakeScriptLower( "f", "ck" ) );

            //---------------------------------------------
            paragraph2.Append( officeMath1 );

            paragraph1.Append( paragraph2 );

            //---------------------------------------------
            Paragraph paragraph3 = new Paragraph( ) { RsidParagraphMarkRevision = "009247D5", RsidParagraphAddition = "009247D5", RsidRunAdditionDefault = "009247D5" };

            ParagraphProperties paragraphProperties1 = new ParagraphProperties( );

            ParagraphMarkRunProperties paragraphMarkRunProperties1 = new ParagraphMarkRunProperties( );
            RunFonts runFonts20 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            paragraphMarkRunProperties1.Append( runFonts20 );

            paragraphProperties1.Append( paragraphMarkRunProperties1 );
            BookmarkStart bookmarkStart1 = new BookmarkStart( ) { Name = "_GoBack", Id = "0" };
            BookmarkEnd bookmarkEnd1 = new BookmarkEnd( ) { Id = "0" };

            paragraph3.Append( paragraphProperties1 );
            paragraph3.Append( bookmarkStart1 );
            paragraph3.Append( bookmarkEnd1 );
            Paragraph paragraph4 = new Paragraph( ) { RsidParagraphAddition = "00632292", RsidRunAdditionDefault = "00632292" };

            SectionProperties sectionProperties1 = new SectionProperties( ) { RsidR = "00632292" };
            PageSize pageSize1 = new PageSize( ) { Width = ( UInt32Value ) 11906U, Height = ( UInt32Value ) 16838U };
            PageMargin pageMargin1 = new PageMargin( ) { Top = 1440, Right = ( UInt32Value ) 1800U, Bottom = 1440, Left = ( UInt32Value ) 1800U, Header = ( UInt32Value ) 851U, Footer = ( UInt32Value ) 992U, Gutter = ( UInt32Value ) 0U };
            Columns columns1 = new Columns( ) { Space = "425" };
            DocGrid docGrid1 = new DocGrid( ) { Type = DocGridValues.Lines, LinePitch = 312 };

            sectionProperties1.Append( pageSize1 );
            sectionProperties1.Append( pageMargin1 );
            sectionProperties1.Append( columns1 );
            sectionProperties1.Append( docGrid1 );

            //---------------------------------------------
            body1.Append( paragraph1 );
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
        private M.MathFunction MakeMath003_Function( )
        {
            M.Subscript parm1 = OpenDocxMathExprs.MakeScriptLower( "A", "c,head" );

            M.Run parm2 = OpenDocxMathExprs.MakeMathRun( ";" );

            M.Subscript parm3 = OpenDocxMathExprs.MakeScriptLower( "A", "c,base" );

            M.Run parm4 = OpenDocxMathExprs.MakeMathRun( "*;" );

            M.Subscript parm5 = OpenDocxMathExprs.MakeScriptLower( "A", "c,base" );

            return OpenDocxMathExprs.MakeMathFunction( "min", parm1, parm2, parm3, parm4, parm5 );
        }

        //.....................................................................
    }
}
