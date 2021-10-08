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
    class TestFormula_2 : OpenDocxBase
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

            Paragraph paragraph1 = new Paragraph( ) { RsidParagraphAddition = "007A2239", RsidRunAdditionDefault = "00017E9F" };

            //---------------------------------------------
            M.Paragraph paragraph2 = new M.Paragraph( );

            M.OfficeMath officeMath1 = new M.OfficeMath( );

            M.Fraction fraction1 = MakeRun3( );

            officeMath1.Append( OpenDocxMathExprs.MakeMathRun( "y", true ) );
            officeMath1.Append( OpenDocxMathExprs.MakeMathRun( "=" ) );
            officeMath1.Append( fraction1 );
            officeMath1.Append( OpenDocxMathExprs.MakeMathRun( "+4" ) );

            paragraph2.Append( officeMath1 );

            //---------------------------------------------
            BookmarkStart bookmarkStart1 = new BookmarkStart( ) { Name = "_GoBack", Id = "0" };
            BookmarkEnd bookmarkEnd1 = new BookmarkEnd( ) { Id = "0" };

            paragraph1.Append( paragraph2 );
            paragraph1.Append( bookmarkStart1 );
            paragraph1.Append( bookmarkEnd1 );

            SectionProperties sectionProperties1 = new SectionProperties( ) { RsidR = "007A2239" };
            PageSize pageSize1 = new PageSize( ) { Width = ( UInt32Value ) 11906U, Height = ( UInt32Value ) 16838U };
            PageMargin pageMargin1 = new PageMargin( ) { Top = 1440, Right = ( UInt32Value ) 1800U, Bottom = 1440, Left = ( UInt32Value ) 1800U, Header = ( UInt32Value ) 851U, Footer = ( UInt32Value ) 992U, Gutter = ( UInt32Value ) 0U };
            Columns columns1 = new Columns( ) { Space = "425" };
            DocGrid docGrid1 = new DocGrid( ) { Type = DocGridValues.Lines, LinePitch = 312 };

            sectionProperties1.Append( pageSize1 );
            sectionProperties1.Append( pageMargin1 );
            sectionProperties1.Append( columns1 );
            sectionProperties1.Append( docGrid1 );

            body1.Append( paragraph1 );
            body1.Append( sectionProperties1 );

            document1.Append( body1 );
            return document1;
        }

        private static M.Fraction MakeRun3( )
        {
            M.SubSuperscript upperSCR = MakeScriptBoth( );

            M.Superscript lowerSCR = OpenDocxMathExprs.MakeScriptUpper( "x", "3" );   //.ma MakeScriptUpper( );

            return OpenDocxMathExprs.MakeFraction( upperSCR, lowerSCR );

            //M.Fraction fraction1 = new M.Fraction( );

            //M.FractionProperties fractionProperties1 = HansOpenDocx.MakeFractionProperties( );

            //M.Numerator numerator1 = new M.Numerator( );
            //numerator1.Append( upperSCR );

            //M.Denominator denominator1 = new M.Denominator( );
            //denominator1.Append( lowerSCR );

            //fraction1.Append( fractionProperties1 );
            //fraction1.Append( numerator1 );
            //fraction1.Append( denominator1 );

            //return fraction1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static M.Superscript MakeScriptUpper( )
        {
            M.Superscript superscript1 = new M.Superscript( );

            M.SuperscriptProperties superscriptProperties1 = new M.SuperscriptProperties( );

            M.ControlProperties controlProperties3 = new M.ControlProperties( );

            RunProperties runProperties10 = new RunProperties( );
            RunFonts runFonts8 = new RunFonts( ) { Ascii = "Cambria Math", HighAnsi = "Cambria Math" };
            Italic italic2 = new Italic( );

            runProperties10.Append( runFonts8 );
            runProperties10.Append( italic2 );

            controlProperties3.Append( runProperties10 );

            superscriptProperties1.Append( controlProperties3 );

            M.Base base2 = new M.Base( );

            M.Run run6 = new M.Run( );

            RunProperties runProperties11 = new RunProperties( );
            RunFonts runFonts9 = new RunFonts( ) { Ascii = "Cambria Math", HighAnsi = "Cambria Math" };

            runProperties11.Append( runFonts9 );
            M.Text text6 = new M.Text( );
            text6.Text = "x";

            run6.Append( runProperties11 );
            run6.Append( text6 );

            base2.Append( run6 );

            M.SuperArgument superArgument2 = new M.SuperArgument( );

            M.Run run7 = new M.Run( );

            RunProperties runProperties12 = new RunProperties( );
            RunFonts runFonts10 = new RunFonts( ) { Ascii = "Cambria Math", HighAnsi = "Cambria Math" };

            runProperties12.Append( runFonts10 );
            M.Text text7 = new M.Text( );
            text7.Text = "3";

            run7.Append( runProperties12 );
            run7.Append( text7 );

            superArgument2.Append( run7 );

            superscript1.Append( superscriptProperties1 );
            superscript1.Append( base2 );
            superscript1.Append( superArgument2 );
            return superscript1;
        }

        private static M.SubSuperscript MakeScriptBoth( )
        {
            M.SubSuperscript subSuperscript1 = new M.SubSuperscript( );

            M.SubSuperscriptProperties subSuperscriptProperties1 = new M.SubSuperscriptProperties( );

            subSuperscriptProperties1.Append( OpenDocxMathExprs.MakeControlProperties( true ) );

            M.Base base1 = OpenDocxMathExprs.MakeMathBase( "A" );    // new M.Base( );

            //---------------------------------------------
            M.SubArgument subArgument1 = OpenDocxMathExprs.MakeScriptArgumentLower( "i" );

            M.SuperArgument superArgument1 = OpenDocxMathExprs.MakeScriptArgumentUpper( "w" );

            //---------------------------------------------
            subSuperscript1.Append( subSuperscriptProperties1 );
            subSuperscript1.Append( base1 );
            subSuperscript1.Append( subArgument1 );
            subSuperscript1.Append( superArgument1 );

            return subSuperscript1;
        }

        //.....................................................................
    }
}
