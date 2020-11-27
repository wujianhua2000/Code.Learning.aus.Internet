using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace LearningOpenXML
{
    class TestMoreParagraph
    {
        /// <summary>
        /// 
        /// </summary>
        private string NamePath = "d:\\123-test-openxml";

        /// <summary>
        /// 
        /// </summary>
        private string NameDocx = "more-paragraph.docx";

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        public TestMoreParagraph( )
        {
            bool miss = ( !Directory.Exists( this.NamePath ) );
            if ( miss ) Directory.CreateDirectory( this.NamePath );

            return;
        }

        //.....................................................................
        /// <summary>
        ///  Creates the new instance of the WordprocessingDocument class 
        ///  from the specified file
        ///  
        ///  WordprocessingDocument.Open(String, Boolean) method Parameters:
        ///  
        ///     string docxfile - docxfile is a string which contains the docxfile of the wordocument
        ///     
        ///     bool isEditable
        /// 
        /// </summary>
        public void Process( )
        {
            string docxfile = this.NamePath + "\\" + this.NameDocx;

            using ( WordprocessingDocument wordocument = WordprocessingDocument.Create( docxfile, WordprocessingDocumentType.Document ) )
            {
                // Defines the MainDocumentPart            
                MainDocumentPart mainDocxPart = wordocument.AddMainDocumentPart( );
                mainDocxPart.Document = new Document( );

                Body docxbody = mainDocxPart.Document.AppendChild( new Body( ) );

                this.Para1( docxbody );

                this.ParagraphMore( docxbody );

                mainDocxPart.Document.Save( );
            }

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="docxbody"></param>
        private void Para1( Body docxbody )
        {
            string text =
                "123\n"+
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                    "Praesent quam augue, tempus id metus in, laoreet viverra quam. " +
                    "Sed vulputate risus lacus, et dapibus orci porttitor non.";

            Paragraph docpara = new Paragraph( );

            Run docrun = new Run( );

            Text doctext = new Text( text );

            docrun.Append( doctext );
            docpara.Append( docrun );

            docxbody.Append( docpara );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="docBody"></param>
        private void ParagraphMore( Body docBody )
        {
            Paragraph docxpara = new Paragraph( );

            Run docxrun1 = new Run( );
            Run docxrun2 = new Run( );
            Run docxrun3 = new Run( );
            Run docxrun4 = new Run( );
            Run docxrun5 = new Run( );
            Run docxrun6 = new Run( );
            Run docxrun7 = new Run( );
            Run docxrun8 = new Run( );
            Run docxrun9 = new Run( );

            RunProperties propertyBOLD = new RunProperties( );
            propertyBOLD.Bold = new Bold( );

            RunProperties propertyITALIC = new RunProperties( );
            propertyITALIC.Italic = new Italic( );

            // Run 6 – Italic , bold and underlined
            RunProperties propertyFONTS = new RunProperties( );

            propertyFONTS.Italic = new Italic( );
            propertyFONTS.Bold = new Bold( );
            propertyFONTS.Underline = new Underline( );

            // Run 8 – Red color
            RunProperties propertyRED = new RunProperties( );
            propertyRED.Color = new Color( ) { Val = "FF0000" };

            // Always add properties first
            docxrun2.Append( propertyBOLD );

            // Always add properties first
            docxrun4.Append( propertyITALIC );

            // Always add properties first
            docxrun6.Append( propertyFONTS );

            // Always add properties first
            docxrun8.Append( propertyRED );

            Text t1 = new Text( "Pellentesque " );          //{ Space = SpaceProcessingModeValues.Preserve };
            Text t2 = new Text( "commodo " );               //{ Space = SpaceProcessingModeValues.Preserve };
            Text t3 = new Text( "rhoncus " );               //{ Space = SpaceProcessingModeValues.Preserve };
            Text t4 = new Text( "mauris" );                 //{ Space = SpaceProcessingModeValues.Preserve };
            Text t5 = new Text( ", sit " );                 //{ Space = SpaceProcessingModeValues.Preserve };
            Text t6 = new Text( "amet " );                  //{ Space = SpaceProcessingModeValues.Preserve };
            Text t7 = new Text( "faucibus arcu " );         //{ Space = SpaceProcessingModeValues.Preserve };
            Text t8 = new Text( "porttitor " );             //{ Space = SpaceProcessingModeValues.Preserve };
            Text t9 = new Text( "pharetra. Maecenas quis erat quis eros iaculis placerat ut at mauris." );

            t1.Space = SpaceProcessingModeValues.Preserve;
            t2.Space = SpaceProcessingModeValues.Preserve;
            t3.Space = SpaceProcessingModeValues.Preserve;

            t4.Space = SpaceProcessingModeValues.Default;

            t5.Space = SpaceProcessingModeValues.Preserve;
            t6.Space = SpaceProcessingModeValues.Preserve;
            t7.Space = SpaceProcessingModeValues.Preserve;
            t8.Space = SpaceProcessingModeValues.Preserve;
            t9.Space = SpaceProcessingModeValues.Preserve;

            docxrun1.Append( t1 );
            docxrun2.Append( t2 );
            docxrun3.Append( t3 );
            docxrun4.Append( t4 );
            docxrun5.Append( t5 );
            docxrun6.Append( t6 );
            docxrun7.Append( t7 );
            docxrun8.Append( t8 );
            docxrun9.Append( t9 );

            docxpara.Append( docxrun1 );
            docxpara.Append( docxrun2 );
            docxpara.Append( docxrun3 );
            docxpara.Append( docxrun4 );
            docxpara.Append( docxrun5 );
            docxpara.Append( docxrun6 );
            docxpara.Append( docxrun7 );
            docxpara.Append( docxrun8 );
            docxpara.Append( docxrun9 );

            // Add your paragraph to docx body
            docBody.Append( docxpara );

            return;
        }

        //    }
        //.....................................................................
        ///// <summary>
        ///// 
        ///// </summary>
        //public void Process( )
        //{
        //    //// Create Stream
        //    //using ( MemoryStream mem = new MemoryStream( ) )
        //    //{
        //    //    // Create Document
        //    //    using ( WordprocessingDocument wordDocument = WordprocessingDocument.Create( mem, WordprocessingDocumentType.Document, true ) )
        //    //    {
        //    //        // Add a main document part. 
        //    //        MainDocumentPart mainPart = wordDocument.AddMainDocumentPart( );

        //    //        // Create the document structure and add some text.
        //    //        mainPart.Document = new Document( );
        //    //        Body docBody = new Body( );

        //    //        // Add your docx content here
        //    //    }

        //        //// Download File
        //        //Context.Response.AppendHeader( "Content-Disposition", String.Format( "attachment;filename=\"0}.docx\"", MyDocxTitle ) );
        //        //mem.Position = 0;
        //        //mem.CopyTo( Context.Response.OutputStream );
        //    //    //Context.Response.Flush( );
        //    //    //Context.Response.End( );
        //    //}

        //    return;
        //}

        //.....................................................................
    }
}
