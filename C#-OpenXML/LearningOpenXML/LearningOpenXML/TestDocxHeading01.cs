using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

using M = DocumentFormat.OpenXml.Math;

namespace LearningOpenXML
{
    class TestDocxHeading01 : TestOpenDocx
    {
        // Creates an Document instance and adds its children.
        public Document GenerateDocument( )
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

            //---------------------------------------------
            Body body1 = new Body( );

            Paragraph paragraph1 = new Paragraph( ) { RsidParagraphAddition = "00F1446E", RsidRunAdditionDefault = "00F1446E" };

            ParagraphProperties paragraphProperties1 = new ParagraphProperties( );

            ParagraphMarkRunProperties paragraphMarkRunProperties1 = new ParagraphMarkRunProperties( );
            RunFonts runFonts1 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            paragraphMarkRunProperties1.Append( runFonts1 );

            paragraphProperties1.Append( paragraphMarkRunProperties1 );

            paragraph1.Append( paragraphProperties1 );

            //---------------------------------------------
            Paragraph paragraph2 = new Paragraph( ) { RsidParagraphAddition = "00FE39AE", RsidParagraphProperties = "00FE39AE", RsidRunAdditionDefault = "00FE39AE" };

            ParagraphStyleId paragraphStyleId1 = new ParagraphStyleId( ) { Val = "1" };

            ParagraphProperties paragraphProperties2 = new ParagraphProperties( );
            paragraphProperties2.Append( paragraphStyleId1 );

            RunFonts runFonts2 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            RunProperties runProperties1 = new RunProperties( );
            runProperties1.Append( runFonts2 );

            Text text1 = new Text( );
            text1.Text = "Hello Word";

            Run run1 = new Run( );
            run1.Append( runProperties1 );
            run1.Append( text1 );

            //---------------------------------------------
            BookmarkStart bookmarkStart1 = new BookmarkStart( ) { Name = "_GoBack", Id = "0" };
            BookmarkEnd bookmarkEnd1 = new BookmarkEnd( ) { Id = "0" };

            paragraph2.Append( paragraphProperties2 );
            paragraph2.Append( run1 );
            paragraph2.Append( bookmarkStart1 );
            paragraph2.Append( bookmarkEnd1 );

            //---------------------------------------------

            SectionProperties sectionProperties1 = new SectionProperties( ) { RsidR = "00FE39AE" };
            PageSize pageSize1 = new PageSize( ) { Width = ( UInt32Value ) 11906U, Height = ( UInt32Value ) 16838U };
            PageMargin pageMargin1 = new PageMargin( ) { Top = 1440, Right = ( UInt32Value ) 1800U, Bottom = 1440, Left = ( UInt32Value ) 1800U, Header = ( UInt32Value ) 851U, Footer = ( UInt32Value ) 992U, Gutter = ( UInt32Value ) 0U };
            Columns columns1 = new Columns( ) { Space = "425" };
            DocGrid docGrid1 = new DocGrid( ) { Type = DocGridValues.Lines, LinePitch = 312 };

            sectionProperties1.Append( pageSize1 );
            sectionProperties1.Append( pageMargin1 );
            sectionProperties1.Append( columns1 );
            sectionProperties1.Append( docGrid1 );

            body1.Append( paragraph1 );
            body1.Append( paragraph2 );
            body1.Append( sectionProperties1 );

            document1.Append( body1 );

            return document1;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// https://docs.microsoft.com/en-us/office/open-xml/how-to-apply-a-style-to-a-paragraph-in-a-word-processing-document
        /// 
        /// Create a new style with the specified styleid and stylename and add it to the specified
        /// style definitions part.
        /// 
        /// 追加一个新的额 STYLE , 样式。
        /// </summary>
        /// <param name="styleDefinitionsPart"></param>
        /// <param name="styleid"></param>
        /// <param name="stylename"></param>
        private static void AddNewStyle( StyleDefinitionsPart styleDefinitionsPart,            string styleid, string stylename )
        {
            // Get access to the root element of the styles part.
            //
            Styles styles = styleDefinitionsPart.Styles;

            // Create a new paragraph style and specify some of the properties.
            //
            Style style = new Style( )
            {
                Type = StyleValues.Paragraph,
                StyleId = styleid,
                CustomStyle = true
            };

            StyleName styleName1 = new StyleName( ) { Val = stylename };
            BasedOn basedOn1 = new BasedOn( ) { Val = "Normal" };

            NextParagraphStyle nextParagraphStyle1 = new NextParagraphStyle( ) { Val = "Normal" };

            style.Append( styleName1 );
            style.Append( basedOn1 );
            style.Append( nextParagraphStyle1 );

            //---------------------------------------------
            Bold bold1 = new Bold( );
            
            Color color1 = new Color( ) { ThemeColor = ThemeColorValues.Accent2 };
            
            RunFonts font1 = new RunFonts( ) { Ascii = "Lucida Console" };
            
            Italic italic1 = new Italic( );
            
            // Specify a 12 point size.
            FontSize fontSize1 = new FontSize( ) { Val = "24" };

            // Create the StyleRunProperties object and specify some of the run properties.
            StyleRunProperties styleRunProperties1 = new StyleRunProperties( );

            styleRunProperties1.Append( bold1 );
            styleRunProperties1.Append( color1 );
            styleRunProperties1.Append( font1 );
            styleRunProperties1.Append( fontSize1 );
            styleRunProperties1.Append( italic1 );

            //---------------------------------------------
            // Add the run properties to the style.
            style.Append( styleRunProperties1 );

            // Add the style to the styles part.
            styles.Append( style );

            return;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Style MakeStyle_Heading_1( )
        {
            Style headingStyle = new Style( ) { Type = StyleValues.Paragraph, StyleId = "1" };

            StyleName styleName2 = new StyleName( ) { Val = "heading 1" };

            BasedOn basedOn1 = new BasedOn( ) { Val = "a" };

            NextParagraphStyle nextParagraphStyle1 = new NextParagraphStyle( ) { Val = "a" };

            LinkedStyle linkedStyle1 = new LinkedStyle( ) { Val = "1Char" };

            UIPriority uIPriority1 = new UIPriority( ) { Val = 9 };

            PrimaryStyle primaryStyle2 = new PrimaryStyle( );

            Rsid rsid2 = new Rsid( ) { Val = "00FE39AE" };

            //---------------------------------------------
            //  1
            KeepNext keepNext1 = new KeepNext( );
            //  2
            KeepLines keepLines1 = new KeepLines( );

            //  3
            BottomBorder bottomBorder1 = new BottomBorder( ) { Val = BorderValues.Single, Color = "auto", Size = ( UInt32Value ) 18U, Space = ( UInt32Value ) 1U };

            ParagraphBorders paragraphBorders1 = new ParagraphBorders( );
            paragraphBorders1.Append( bottomBorder1 );

            //  4
            SpacingBetweenLines spacingBetweenLines2 = new SpacingBetweenLines( ) { Before = "200", After = "200", Line = "578", LineRule = LineSpacingRuleValues.Auto };
            
            //  5
            OutlineLevel outlineLevel1 = new OutlineLevel( ) { Val = 0 };

            StyleParagraphProperties styleParagraphProperties2 = new StyleParagraphProperties( );
            
            styleParagraphProperties2.Append( keepNext1 );
            styleParagraphProperties2.Append( keepLines1 );
            styleParagraphProperties2.Append( paragraphBorders1 );
            styleParagraphProperties2.Append( spacingBetweenLines2 );
            styleParagraphProperties2.Append( outlineLevel1 );

            //---------------------------------------------
            StyleRunProperties styleRunProperties1 = new StyleRunProperties( );
            Bold bold1 = new Bold( );
            BoldComplexScript boldComplexScript1 = new BoldComplexScript( );
            Kern kern2 = new Kern( ) { Val = ( UInt32Value ) 44U };
            FontSize fontSize2 = new FontSize( ) { Val = "36" };
            FontSizeComplexScript fontSizeComplexScript2 = new FontSizeComplexScript( ) { Val = "44" };

            styleRunProperties1.Append( bold1 );
            styleRunProperties1.Append( boldComplexScript1 );
            styleRunProperties1.Append( kern2 );
            styleRunProperties1.Append( fontSize2 );
            styleRunProperties1.Append( fontSizeComplexScript2 );

            headingStyle.Append( styleName2 );
            headingStyle.Append( basedOn1 );
            headingStyle.Append( nextParagraphStyle1 );
            headingStyle.Append( linkedStyle1 );
            headingStyle.Append( uIPriority1 );
            headingStyle.Append( primaryStyle2 );
            headingStyle.Append( rsid2 );
            headingStyle.Append( styleParagraphProperties2 );
            headingStyle.Append( styleRunProperties1 );

            return headingStyle;
        }

        //.....................................................................
    }
}
