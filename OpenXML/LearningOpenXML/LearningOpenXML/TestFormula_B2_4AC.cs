using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

using OpxM = DocumentFormat.OpenXml.Math;

namespace LearningOpenXML
{
    /// <summary>
    /// 
    /// </summary>
    class TestFormula_B2_4AC : TestOpenDocx
    {
        ///// <summary>
        ///// 
        ///// </summary>
        //private string NamePath = "d:\\123-test-openxml";

        ///// <summary>
        ///// 
        ///// </summary>
        //private string NameDocx = "easy-table.docx";

        ////.....................................................................
        ///// <summary>
        ///// 
        ///// </summary>
        //public void MakeWord( )
        //{
        //    string docxfile = this.NamePath + "\\" + this.NameDocx;

        //    // Creates the new instance of the WordprocessingDocument class from the specified file
        //    // WordprocessingDocument.Open(String, Boolean) method
        //    // Parameters:
        //    // string docxfile - docxfile is a string which contains the docxfile of the wordocument
        //    // bool isEditable

        //    using ( WordprocessingDocument wordocument = WordprocessingDocument.Create( docxfile, WordprocessingDocumentType.Document ) )
        //    {
        //        // Defines the MainDocumentPart            
        //        MainDocumentPart mainDocxPart = wordocument.AddMainDocumentPart( );

        //        mainDocxPart.Document = this.GenerateDocument( );

        //        //mainDocxPart.Document = new Document( );
        //        //Body docxbody = mainDocxPart.Document.AppendChild( new Body( ) );
        //        //// Create a new table
        //        //Table docxtable = new Table( );
        //        //// Add the table to the docxbody
        //        //docxbody.AppendChild( docxtable );

        //        mainDocxPart.Document.Save( );
        //    }

        //    return;
        //}

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

            Body docxBody = new Body( );

            Paragraph normParagraph = new Paragraph( ) { RsidParagraphAddition = "0037253E", RsidRunAdditionDefault = "0078119C" };

            //---------------------------------------------
            OpxM.Paragraph mathParagraph = new OpxM.Paragraph( );

            OpxM.OfficeMath mathOffice = new OpxM.OfficeMath( );

            //---------------------------------------------
            OpxM.Run run1 = mathX( );
            OpxM.Run run2 = mathEQ( );

            mathOffice.Append( run1 );
            mathOffice.Append( run2 );

            //---------------------------------------------
            OpxM.Fraction fraction1 = new OpxM.Fraction( );

            OpxM.FractionProperties fractionProperties1 = MakeFractionProperties( );

            OpxM.Numerator numerator1 = mathNumer_B_B2_4AC( );

            OpxM.Denominator denominator1 = mathDenom_2_A( );

            fraction1.Append( fractionProperties1 );
            fraction1.Append( numerator1 );
            fraction1.Append( denominator1 );

            mathOffice.Append( fraction1 );

            //---------------------------------------------
            mathParagraph.Append( mathOffice );

            //---------------------------------------------
            BookmarkStart bookmarkStart1 = new BookmarkStart( ) { Name = "_GoBack", Id = "0" };
            BookmarkEnd bookmarkEnd1 = new BookmarkEnd( ) { Id = "0" };

            normParagraph.Append( mathParagraph );
            
            normParagraph.Append( bookmarkStart1 );
            normParagraph.Append( bookmarkEnd1 );

            SectionProperties sectionProperties1 = new SectionProperties( ) { RsidR = "0037253E" };
            
            PageSize pageSize1 = new PageSize( ) { Width = ( UInt32Value ) 11906U, Height = ( UInt32Value ) 16838U };
            
            PageMargin pageMargin1 = new PageMargin( ) { Top = 1440, Right = ( UInt32Value ) 1800U, Bottom = 1440, Left = ( UInt32Value ) 1800U, Header = ( UInt32Value ) 851U, Footer = ( UInt32Value ) 992U, Gutter = ( UInt32Value ) 0U };
            
            Columns columns1 = new Columns( ) { Space = "425" };
            
            DocGrid docGrid1 = new DocGrid( ) { Type = DocGridValues.Lines, LinePitch = 312 };

            sectionProperties1.Append( pageSize1 );
            sectionProperties1.Append( pageMargin1 );
            sectionProperties1.Append( columns1 );
            sectionProperties1.Append( docGrid1 );

            docxBody.Append( normParagraph );
            docxBody.Append( sectionProperties1 );

            document1.Append( docxBody );

            return document1;
        }

        //.....................................................................
        /// <summary>
        /// 分子
        /// </summary>
        /// <returns></returns>
        private OpxM.Numerator mathNumer_B_B2_4AC( )
        {
            OpxM.Numerator numerator1 = new OpxM.Numerator( );

            OpxM.Run run3 = mathMINUS( );

            OpxM.Run run4 = mathB( );
            OpxM.Run run5 = mathPM( );

            //.....................................................................
            OpxM.Radical radical1 = new OpxM.Radical( );

            OpxM.RadicalProperties radicalProperties1 = new OpxM.RadicalProperties( );

            OpxM.HideDegree hideDegree1 = new OpxM.HideDegree( ) { Val = OpxM.BooleanValues.One };

            OpxM.ControlProperties controlProperties2 = new OpxM.ControlProperties( );
            //RunProperties runProperties10 = CambriaFont2( );
            controlProperties2.Append( CambriaFont2( ) );

            radicalProperties1.Append( hideDegree1 );
            radicalProperties1.Append( controlProperties2 );

            //---------------------------------------------
            OpxM.Degree degree1 = new OpxM.Degree( );

            OpxM.Base base1 = new OpxM.Base( );

            OpxM.Superscript superscript1 = new OpxM.Superscript( );

            OpxM.SuperscriptProperties superscriptProperties1 = new OpxM.SuperscriptProperties( );

            OpxM.ControlProperties controlProperties3 = new OpxM.ControlProperties( );

            //RunProperties runProperties11 = new RunProperties( );
            //RunFonts runFonts = new RunFonts( ) { Ascii = "Cambria Math", HighAnsi = "Cambria Math", EastAsia = "Cambria Math" };
            //runProperties11.Append( runFonts );

            controlProperties3.Append( this.CambriaFont2( ) );

            superscriptProperties1.Append( controlProperties3 );

            OpxM.Base base2 = new OpxM.Base( );

            //---------------------------------------------
            OpxM.Run run6 = mathB2( );

            base2.Append( run6 );

            OpxM.SuperArgument superArgument1 = new OpxM.SuperArgument( );

            //---------------------------------------------
            OpxM.Run run7 = mathCP2( );

            //---------------------------------------------
            superArgument1.Append( run7 );

            superscript1.Append( superscriptProperties1 );
            superscript1.Append( base2 );
            superscript1.Append( superArgument1 );

            OpxM.Run run8 = mathCN4( );
            OpxM.Run run9 = mathAC( );

            //---------------------------------------------
            base1.Append( superscript1 );

            base1.Append( run8 );
            base1.Append( run9 );

            radical1.Append( radicalProperties1 );
            radical1.Append( degree1 );
            radical1.Append( base1 );

            numerator1.Append( run3 );
            numerator1.Append( run4 );
            numerator1.Append( run5 );
            numerator1.Append( radical1 );
            
            return numerator1;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private OpxM.Denominator mathDenom_2_A( )
        {
            OpxM.Denominator denominator1 = new OpxM.Denominator( );

            OpxM.Run run10 = mathNumP002( );
            OpxM.Run run11 = mathA( );

            denominator1.Append( HansOpenDocx.MakeMathRun( "2a") );
            denominator1.Append( run11 );

            return denominator1;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private OpxM.FractionProperties MakeFractionProperties( )
        {
            OpxM.FractionProperties fractionProperties1 = new OpxM.FractionProperties( );

            OpxM.ControlProperties controlProperties1 = new OpxM.ControlProperties( );

            //RunProperties runProperties4 = new RunProperties( );
            //RunFonts runFonts3 = new RunFonts( ) { Ascii = "Cambria Math", HighAnsi = "Cambria Math", EastAsia = "Cambria Math" };
            //runProperties4.Append( runFonts3 );

            controlProperties1.Append( this.CambriaFont2( ) );

            fractionProperties1.Append( controlProperties1 );

            return fractionProperties1;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private OpxM.Run mathX( )
        {
            OpxM.Run run1 = new OpxM.Run( );

            run1.Append( this.CambriaFont( ) );
            run1.Append( this.SimpleMathText( "x" ) );
            return run1;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private OpxM.Run mathEQ( )
        {
            OpxM.Run mathrun = new OpxM.Run( );

            mathrun.Append( this.PlainStyleValue( ) );
            mathrun.Append( this.CambriaFont( ) );
            mathrun.Append( this.SimpleMathText( "=" ) );
            
            return mathrun;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private OpxM.Run mathB2( )
        {
            OpxM.Run mathrun = new OpxM.Run( );

            mathrun.Append( this.CambriaFont( ) );
            mathrun.Append( this.SimpleMathText( "b" ) );
            return mathrun;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private OpxM.Run mathCP2( )
        {
            OpxM.Run mathrun = new OpxM.Run( );

            mathrun.Append( this.PlainStyleValue( ) );
            mathrun.Append( this.CambriaFont( ) );
            mathrun.Append( this.SimpleMathText( "2" ) );
            
            return mathrun;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private OpxM.Run mathCN4( )
        {
            OpxM.Run mathrun = new OpxM.Run( );

            mathrun.Append( this.PlainStyleValue( ) );
            mathrun.Append( this.CambriaFont( ) );
            mathrun.Append( this.SimpleMathText( "-4" ) );
            
            return mathrun;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private OpxM.Run mathAC( )
        {
            OpxM.Run mathrun = new OpxM.Run( );

            mathrun.Append( this.CambriaFont( ) );
            mathrun.Append( this.SimpleMathText( "ac" ) );
            
            return mathrun;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private OpxM.Run mathA( )
        {
            OpxM.Run run11 = new OpxM.Run( );

            run11.Append( this.CambriaFont( ) );
            run11.Append( SimpleMathText( "a" ) );

            return run11;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private OpxM.Run mathNumP002( )
        {
            OpxM.Run run10 = new OpxM.Run( );

            //OpxM.RunProperties runProperties18 = PlainStyleValue( );
            //RunProperties runProperties19 = this.CambriaFont( );

            //OpxM.Text text10 = new OpxM.Text( );
            //text10.Text = "2";

            run10.Append( this.PlainStyleValue( ) );
            run10.Append( this.CambriaFont( ) );
            run10.Append( this.SimpleMathText( "2" ) );

            return run10;
        }

        //---------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private RunProperties CambriaFont2( )
        {
            RunProperties properties = new RunProperties( );
            
            RunFonts font = new RunFonts( ) { Ascii = "Cambria Math", HighAnsi = "Cambria Math", EastAsia = "Cambria Math" };
            
            properties.Append( font );
         
            return properties;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private OpxM.Run mathPM( )
        {
            OpxM.Run mathrun = new OpxM.Run( );

            //OpxM.RunProperties runProperties8 = new OpxM.RunProperties( );
            //OpxM.Style style3 = new OpxM.Style( ) { Val = OpxM.StyleValues.Plain };
            //runProperties8.Append( style3 );

            //RunProperties propertiesRUN = new RunProperties( );
            //RunFonts runFonts6 = new RunFonts( ) { Ascii = "Cambria Math", HighAnsi = "Cambria Math", EastAsia = "Cambria Math", ComplexScript = "Cambria Math" };
            //propertiesRUN.Append( runFonts6 );

            //OpxM.Text text5 = new OpxM.Text( );
            //text5.Text = "±";

            mathrun.Append( this.PlainStyleValue( ) );
            mathrun.Append( this.CambriaFont( ) );
            mathrun.Append( this.SimpleMathText( "±" ) );

            return mathrun;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private OpxM.Run mathB( )
        {
            OpxM.Run mathrun = new OpxM.Run( );

            //RunProperties runProperties7 = new RunProperties( );
            //RunFonts runFonts = new RunFonts( ) { Ascii = "Cambria Math", HighAnsi = "Cambria Math", EastAsia = "Cambria Math", ComplexScript = "Cambria Math" };
            //runProperties7.Append( runFonts );

            //OpxM.Text text4 = new OpxM.Text( );
            //text4.Text = "b";

            mathrun.Append( this.CambriaFont( ) );
            mathrun.Append( this.SimpleMathText( "b" ) );

            return mathrun;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private OpxM.Run mathMINUS( )
        {
            OpxM.Run mathrun = new OpxM.Run( );

            //OpxM.RunProperties propertiesRUN = new OpxM.RunProperties( );
            //OpxM.Style style2 = new OpxM.Style( ) { Val = OpxM.StyleValues.Plain };
            //propertiesRUN.Append( style2 );

            //RunProperties runProperties6 = new RunProperties( );
            //RunFonts runFonts4 = new RunFonts( ) { Ascii = "Cambria Math", HighAnsi = "Cambria Math", EastAsia = "Cambria Math", ComplexScript = "Cambria Math" };
            //runProperties6.Append( runFonts4 );

            //OpxM.Text text3 = new OpxM.Text( );
            //text3.Text = "-";

            mathrun.Append( this.PlainStyleValue( ) );
            mathrun.Append( this.CambriaFont( ) );
            mathrun.Append( this.SimpleMathText( "-" ) );
            
            return mathrun;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private OpxM.RunProperties PlainStyleValue( )
        {
            OpxM.RunProperties properties = new OpxM.RunProperties( );

            OpxM.Style style = new OpxM.Style( ) { Val = OpxM.StyleValues.Plain };
            
            properties.Append( style );

            return properties;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="textln"></param>
        /// <returns></returns>
        private OpxM.Text SimpleMathText( string textln )
        {
            OpxM.Text mathtext = new OpxM.Text( );
            
            mathtext.Text = textln;

            return mathtext;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private RunProperties CambriaFont( )
        {
            RunProperties properties = new RunProperties( );
            
            RunFonts runFont = new RunFonts( ) 
                { 
                    Ascii = "Cambria Math", 
                    HighAnsi = "Cambria Math", 
                    EastAsia = "Cambria Math", 
                    ComplexScript = "Cambria Math" 
                };
            
            properties.Append( runFont );

            return properties;
        }

        //.....................................................................
    }
}
