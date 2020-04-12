using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;  

namespace LearningKurzCode
{
    public partial class FormMain : Form
    {
        public FormMain( )
        {
            InitializeComponent( );
        }

        //.....................................................................
        /// <summary>
        /// 一个极佳的 LINQ GROUP BY 的例子
        /// 
        /// https://www.completecsharptutorial.com/linqtutorial/groupby-singlekey-multikey-sorting-grouping-linq-csharp-tutorial.php
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGroupBy_Click( object sender, EventArgs e )
        {
            KurzCode20200402.LingGroupBy20200402 test = new KurzCode20200402.LingGroupBy20200402( );

            //test.TestSingleKeyGrouping( );
            //test.TestMultiKeyGrouping( );
            //test.TestGroupingSorting( );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOpenXML_Click( object sender, EventArgs e )
        {
            //
            //  https://riptutorial.com/openxml/example/30262/hello-world
            //
            // Create a Wordprocessing document. 
            using ( WordprocessingDocument package = WordprocessingDocument.Create( 
                "d:\\HelloWorld.docx", 
                WordprocessingDocumentType.Document ) 
                )
            {
                // Add a new main document part. 
                package.AddMainDocumentPart( );

                // Create the Document DOM. 
                package.MainDocumentPart.Document =
                    new Document(
                        new Body(
                            new Paragraph(
                                new Run(
                                    new Text( "Hello World!" ) ) ) ) );

                // Save changes to the main document part. 
                package.MainDocumentPart.Document.Save( );
            }

            //
            //  https://docs.microsoft.com/en-us/dotnet/api/documentformat.openxml.packaging.wordprocessingdocument?view=openxml-2.8.1
            //
            // Apply the Heading 3 style to a paragraph.   
            string fileName = @"D:\WordProcessingEx.docx";

            using ( WordprocessingDocument myDocument = WordprocessingDocument.Open( fileName, true ) )
            {
                // Get the first paragraph.  
                Paragraph p = myDocument.MainDocumentPart.Document.Body.Elements<Paragraph>( ).First( );

                // If the paragraph has no ParagraphProperties object, create a new one.  
                if ( p.Elements<ParagraphProperties>( ).Count( ) == 0 )
                    p.PrependChild<ParagraphProperties>( new ParagraphProperties( ) );

                // Get the ParagraphProperties element of the paragraph.  
                ParagraphProperties pPr = p.Elements<ParagraphProperties>( ).First( );

                // Set the value of ParagraphStyleId to "Heading3".  
                pPr.ParagraphStyleId = new ParagraphStyleId( ) { Val = "Heading3" };
            }

            MessageBox.Show( "Alles in Ordnung!!!" );

            return;
        }

        //.....................................................................
    }
}
