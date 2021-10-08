using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

using OpxM = DocumentFormat.OpenXml.Math;

using M = DocumentFormat.OpenXml.Math;
using Ovml = DocumentFormat.OpenXml.Vml.Office;
using V = DocumentFormat.OpenXml.Vml;
using A = DocumentFormat.OpenXml.Drawing;

namespace Hans.Opxm
{
    class OpenDocxBase
    {
        /// <summary>
        /// 一个 CM 是多少个openXML 中的长度。
        /// </summary>
        public static double OPENXML_CM_LEN = 56.6866;

        /// <summary>
        /// 
        /// </summary>
        public string NamePath = "d:\\123-test-openxml";

        /// <summary>
        /// 
        /// </summary>
        public string NameDocx = "easy-table.docx";

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        public OpenDocxBase( )
        {
            bool miss = ( !Directory.Exists( this.NamePath ) );
            if ( miss ) Directory.CreateDirectory( this.NamePath );

            return;
        }

        /// <summary>
        /// 
        /// </summary>
        public WordprocessingDocument wordocument = null;

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        public void TestDocx( )
        {
            using ( this.wordocument = WordprocessingDocument.Create(
                                                    this.GetDocxName( ),
                                                    WordprocessingDocumentType.Document ) )
            {
                MainDocumentPart mainDocxPart = wordocument.AddMainDocumentPart( );

                //.............................................
                //DocumentSettingsPart settingsPART = mainDocxPart.AddNewPart<DocumentSettingsPart>( "rId3" );
                //GenerateSettingsPart( settingsPART );
                
                //DocumentSettingsPart settingsPART = mainDocxPart.AddNewPart<DocumentSettingsPart>( "rId3" );
                //OpenDocxSettingsPart.Generate( settingsPART );

                //.............................................
                //StylesWithEffectsPart stylesWithEffectsPart1 = mainDocxPart.AddNewPart<StylesWithEffectsPart>( "rId2" );
                //GenerateStylesWithEffectsPart1Content( stylesWithEffectsPart1 );

                //.............................................
                NumberingDefinitionsPart numberingPART = mainDocxPart.AddNewPart<NumberingDefinitionsPart>( "rId4" );
                OpenDocxNumbering.Generate( numberingPART );

                //NumberingDefinitionsPart numberingPART = mainDocxPart.AddNewPart<NumberingDefinitionsPart>( "rId4" );
                //GenerateNumberingDefinitionsPart1Content( numberingPART );

                //.............................................
                //StyleDefinitionsPart stylePART = mainDocxPart.AddNewPart<StyleDefinitionsPart>( "rId1" );
                //GenerateStyleDefinitionsPart1Content( stylePART );

                StyleDefinitionsPart stylePART = mainDocxPart.AddNewPart<StyleDefinitionsPart>( "rId1" );
                OpenDocxStylesPart.Generate( stylePART );

                //.............................................
                mainDocxPart.Document = this.GenerateDocument( );
                mainDocxPart.Document.Save( );
            }

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        public void OpenExistDocx( string docxname, bool editable = false )
        {
            //string docxname = "D:\\123-test-openxml\\wujianhua.docx";

            using ( this.wordocument = WordprocessingDocument.Open( docxname, editable ) )
            {
                MainDocumentPart mainDocxPart = wordocument.MainDocumentPart;

                //StylesWithEffectsPart stylesWithEffectsPart1 = mainDocxPart.AddNewPart<StylesWithEffectsPart>( "rId2" );
                //GenerateStylesWithEffectsPart1Content( stylesWithEffectsPart1 );

                StyleDefinitionsPart styleDefsPart = mainDocxPart.StyleDefinitionsPart;

                List<string> listing = new List<string>( );

                //foreach ( StyleName style in styleDefsPart.Styles.Descendants<StyleName>( ) )
                //{
                //    listing.Add( "".PadLeft( 80, '-' ) );
                //    listing.Add( "stylename val value" );
                //    listing.Add( style.Val.Value );
                //    listing.Add( "stylename parent" );
                //    listing.Add( style.Parent.OuterXml );
                //    listing.Add( string.Empty );
                //}

                foreach ( Style style in styleDefsPart.Styles.Descendants<Style>( ) )
                {
                    StyleName stylename = style.Descendants<StyleName>( ).FirstOrDefault( );

                    string stylenametype = stylename.Parent.GetAttribute( "type", stylename.NamespaceUri ).Value;

                    LinkedStyle stylelink = style.Descendants<LinkedStyle>( ).FirstOrDefault( );
                    
                    string stylelinkvalue = ( stylelink == null ) ? "" : stylelink.Val.Value;

                    listing.Add( "".PadLeft( 80, '-' ) );
                    listing.Add( "stylename val value" );
                    listing.Add( stylename.Val.Value );
                    listing.Add( "stylename parent" );
                    listing.Add( stylename.Parent.OuterXml );

                    listing.Add( "style type::" );
                    listing.Add( "== " + stylenametype );
                    
                    listing.Add( "style link val::" );
                    listing.Add( "== " + stylelinkvalue );
                    listing.Add( string.Empty );

                    ////Console.WriteLine( "style text = " + style.InnerText );
                }

                //StyleDefinitionsPart stylePART = mainDocxPart.AddNewPart<StyleDefinitionsPart>( "rId1" );
                //GenerateStylePart( stylePART );

                //mainDocxPart.Document = this.GenerateDocument( );
                //mainDocxPart.Document.Save( );

                File.WriteAllLines( "D:\\123-test-openxml\\style-listing.txt", listing.ToArray( ), Encoding.Default );
            }

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual Document GenerateDocument( )
        {
            throw new NotImplementedException( );
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static UInt32Value ToUint32V( int value )
        {
            return ( new UInt32Value( ( UInt32 ) value ) );
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static UInt32Value MM2Uint32V( double value )
        {
            double width = value * OPENXML_CM_LEN;

            return ( new UInt32Value( ( UInt32 ) width ) );
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string GetDocxName()
        {
            System.DateTime today = System.DateTime.Now;

            this.NameDocx = string.Format( "test-docx-{0}-{1}-{2}-{3}-{4}.docx",
                                            today.Year,
                                            today.Month,
                                            today.Day,
                                            today.Hour,
                                            today.Minute
                                            );

            string result = this.NamePath + "\\" + this.NameDocx;

            return result;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Document NewDocument( )
        {
            Document document = new Document( ) { MCAttributes = new MarkupCompatibilityAttributes( ) { Ignorable = "w14 wp14" } };

            document.AddNamespaceDeclaration( "wpc", "http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas" );
            document.AddNamespaceDeclaration( "mc", "http://schemas.openxmlformats.org/markup-compatibility/2006" );
            document.AddNamespaceDeclaration( "o", "urn:schemas-microsoft-com:office:office" );
            document.AddNamespaceDeclaration( "r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships" );
            document.AddNamespaceDeclaration( "m", "http://schemas.openxmlformats.org/officeDocument/2006/math" );
            document.AddNamespaceDeclaration( "v", "urn:schemas-microsoft-com:vml" );
            document.AddNamespaceDeclaration( "wp14", "http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing" );
            document.AddNamespaceDeclaration( "wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing" );
            document.AddNamespaceDeclaration( "w10", "urn:schemas-microsoft-com:office:word" );
            document.AddNamespaceDeclaration( "w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main" );
            document.AddNamespaceDeclaration( "w14", "http://schemas.microsoft.com/office/word/2010/wordml" );
            document.AddNamespaceDeclaration( "wpg", "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup" );
            document.AddNamespaceDeclaration( "wpi", "http://schemas.microsoft.com/office/word/2010/wordprocessingInk" );
            document.AddNamespaceDeclaration( "wne", "http://schemas.microsoft.com/office/word/2006/wordml" );
            document.AddNamespaceDeclaration( "wps", "http://schemas.microsoft.com/office/word/2010/wordprocessingShape" );

            return document;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SectionProperties MakeDefaultSectionProperty( )
        {
            PageSize pageSize1 = new PageSize( ) { Width = ( UInt32Value ) 11906U, Height = ( UInt32Value ) 16838U };

            PageMargin pageMargin1 = new PageMargin( ) { Top = 1440, Right = ( UInt32Value ) 1800U, Bottom = 1440, Left = ( UInt32Value ) 1800U, Header = ( UInt32Value ) 851U, Footer = ( UInt32Value ) 992U, Gutter = ( UInt32Value ) 0U };

            Columns columns1 = new Columns( ) { Space = "425" };

            DocGrid docGrid1 = new DocGrid( ) { Type = DocGridValues.Lines, LinePitch = 312 };

            SectionProperties sectionProperties1 = new SectionProperties( ) { RsidR = "006F111A" };

            sectionProperties1.Append( pageSize1 );
            sectionProperties1.Append( pageMargin1 );
            sectionProperties1.Append( columns1 );
            sectionProperties1.Append( docGrid1 );

            return sectionProperties1;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="txtline">标题的内容</param>
        /// <param name="numberingID">标题的一级序号</param>
        /// <returns></returns>
        public Paragraph MakeParagraphTitle01( string txtline, int numID = 1 )
        {
            return this.MontageParagraphTitle( txtline, 1, 0, numID );
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="txtline"></param>
        /// <returns></returns>
        public Paragraph MakeParagraphTitle02( string txtline, int numID = 1 )
        {
            return this.MontageParagraphTitle( txtline, 2, 1, numID );
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="txtline"></param>
        /// <returns></returns>
        public Paragraph MakeParagraphTitle03( string txtline, int numID = 1 )
        {
            return this.MontageParagraphTitle( txtline, 3, 2, numID );
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="txtline"></param>
        /// <param name="numID"></param>
        /// <returns></returns>
        public Paragraph MakeParagraphTitle04( string txtline, int numID = 1 )
        {
            return this.MontageParagraphTitle( txtline, 4, 3, numID );
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="txtline"></param>
        /// <param name="numID"></param>
        /// <returns></returns>
        public Paragraph MakeParagraphTitle05( string txtline, int numID = 1 )
        {
            return this.MontageParagraphTitle( txtline, 5, 4, numID );
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="txtline"></param>
        /// <param name="styleID"></param>
        /// <param name="numroot"></param>
        /// <param name="numleve"></param>
        /// <returns></returns>
        private Paragraph MontageParagraphTitle( string txtline, int styleID, int numroot, int numleve = 1 )
        {
            //  heading
            ParagraphStyleId paraStyleID = new ParagraphStyleId( );

            paraStyleID.Val = styleID.ToString( );

            //.............................................
            NumberingLevelReference numrefer = new NumberingLevelReference( ) { Val = numroot };
            NumberingId numID = new NumberingId( ) { Val = numleve };

            NumberingProperties numProperties = new NumberingProperties( );
            numProperties.Append( numrefer );
            numProperties.Append( numID );

            //.............................................
            ParagraphProperties paraProperties = new ParagraphProperties( );

            paraProperties.Append( paraStyleID );
            paraProperties.Append( numProperties );

            //.............................................
            Run txtrun = new Run( );
            txtrun.Append( new Text( ) { Text = txtline } );

            //.............................................
            Paragraph docpara = new Paragraph( );

            docpara.Append( paraProperties );
            docpara.Append( txtrun );

            return docpara;
        }

        //.....................................................................
    }
}
