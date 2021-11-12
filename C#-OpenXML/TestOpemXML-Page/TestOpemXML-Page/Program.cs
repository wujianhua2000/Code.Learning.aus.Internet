﻿
    /// <summary>
    /// 使用OpenXml SDK向Word文档中添加页、段落、页眉和页脚
    /// 2011年12月14日 16:50:52 songpengpeng20100202 阅读数 5139 
    ///
    /// 1. 创建word文档作为模版
    /// 2. 以下代码实现需求
    /// 
    /// </summary>

using DocumentFormat.OpenXml.Packaging;
using System.IO;
using DocumentFormat.OpenXml.Wordprocessing;

namespace OpenXmlAddParagraphsToNewPage
{
    class Program
    {
        static void Main( string[ ] args )
        {
            if ( File.Exists( "copy.docx" ) )
            {
                File.Delete( "copy.docx" );
            }

            File.Copy( "InsertNewPageAndParagraphs.docx", "copy.docx" );
            using ( WordprocessingDocument doc = WordprocessingDocument.Open( "copy.docx", true ) )
            {
                var body = doc.MainDocumentPart.Document.Body;

                Paragraph newPara = new Paragraph( new Run
                     ( new Break( ) { Type = BreakValues.Page },
                     new Text( "text on the new page" ) ) );

                body.Append( newPara );

                AddHeader( doc );
                AddFooter( doc );
                doc.MainDocumentPart.Document.Save( );
            }
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="doc"></param>
        private static void AddFooter( WordprocessingDocument doc )
        {
            // Declare a string for the header text.
            string newFooterText =
              "New footer via Open XML Format SDK 2.0 classes";

            // Get the main document part.
            MainDocumentPart mainDocPart = doc.MainDocumentPart;

            // Delete the existing footer parts.
            mainDocPart.DeleteParts( mainDocPart.FooterParts );

            // Create a new footer part and get its relationship id.
            FooterPart newFooterPart = mainDocPart.AddNewPart<FooterPart>( );
            string rId = mainDocPart.GetIdOfPart( newFooterPart );

            // Call the GeneratePageFooterPart helper method, passing in
            // the footer text, to create the footer markup and then save
            // that markup to the footer part.
            GeneratePageFooterPart( newFooterText ).Save( newFooterPart );

            // Loop through all section properties in the document
            // which is where footer references are defined.
            foreach ( SectionProperties sectProperties in mainDocPart.Document.Descendants<SectionProperties>( ) )
            {
                //  Delete any existing references to footers.
                foreach ( FooterReference footerReference in
                  sectProperties.Descendants<FooterReference>( ) )
                    sectProperties.RemoveChild( footerReference );

                //  Create a new footer reference that points to the new
                // footer part and add it to the section properties.
                FooterReference newFooterReference = new FooterReference( ) { Id = rId, Type = HeaderFooterValues.Default };

                sectProperties.Append( newFooterReference );
            }

            //  Save the changes to the main document part.
            mainDocPart.Document.Save( );
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="doc"></param>
        private static void AddHeader( WordprocessingDocument doc )
        {
            // Declare a string for the header text.
            string newHeaderText =
              "New header via Open XML Format SDK 2.0 classes";

            // Get the main document part.
            MainDocumentPart mainDocPart = doc.MainDocumentPart;

            // Delete the existing header parts.
            mainDocPart.DeleteParts( mainDocPart.HeaderParts );

            // Create a new header part and get its relationship id.
            HeaderPart newHeaderPart = mainDocPart.AddNewPart<HeaderPart>( );
            string rId = mainDocPart.GetIdOfPart( newHeaderPart );

            // Call the GeneratePageHeaderPart helper method, passing in
            // the header text, to create the header markup and then save
            // that markup to the header part.
            GeneratePageHeaderPart( newHeaderText ).Save( newHeaderPart );

            // Loop through all section properties in the document
            // which is where header references are defined.
            foreach ( SectionProperties sectProperties in mainDocPart.Document.Descendants<SectionProperties>( ) )
            {
                //  Delete any existing references to headers.
                foreach ( HeaderReference headerReference in
                  sectProperties.Descendants<HeaderReference>( ) )
                    sectProperties.RemoveChild( headerReference );

                //  Create a new header reference that points to the new
                // header part and add it to the section properties.
                HeaderReference newHeaderReference = new HeaderReference( ) 
                { 
                    Id = rId, Type = HeaderFooterValues.Default 
                };

                sectProperties.Append( newHeaderReference );
            }

            //  Save the changes to the main document part.
            //mainDocPart.Document.Save();
        }

        //.....................................................................
        /// <summary>
        /// Creates an header instance and adds its children.
        /// </summary>
        /// <param name="HeaderText"></param>
        /// <returns></returns>
        private static Header GeneratePageHeaderPart( string HeaderText )
        {
            // set the position to be the center
            PositionalTab pTab = new PositionalTab( )
            {
                Alignment = AbsolutePositionTabAlignmentValues.Center,
                RelativeTo = AbsolutePositionTabPositioningBaseValues.Margin,
                Leader = AbsolutePositionTabLeaderCharValues.None
            };

            var element = new Header(
                            new Paragraph(
                            new ParagraphProperties(
                            new ParagraphStyleId( ) { Val = "Header" } ),
                            new Run( pTab,
                            new Text( HeaderText ) )
                            )
                            );

            return element;
        }

        //.....................................................................
        /// <summary>
        /// Creates an Footer instance and adds its children.
        /// </summary>
        /// <param name="FooterText"></param>
        /// <returns></returns>
        private static Footer GeneratePageFooterPart( string FooterText )
        {
            PositionalTab pTab = new PositionalTab( )
            {
                Alignment = AbsolutePositionTabAlignmentValues.Center,
                RelativeTo = AbsolutePositionTabPositioningBaseValues.Margin,
                Leader = AbsolutePositionTabLeaderCharValues.None
            };

            var elment = new Footer(
                            new Paragraph(
                            new ParagraphProperties(
                            new ParagraphStyleId( ) { Val = "Footer" } ),
                            new Run( pTab,
                            new Text( FooterText ) )
                            )
                            );
            return elment;
        }

        //.....................................................................
    }

}

