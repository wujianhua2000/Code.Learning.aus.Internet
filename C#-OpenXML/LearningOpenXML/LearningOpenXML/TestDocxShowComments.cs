using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;

namespace Hans.Opxm
{
    class TestDocxShowComments
    {
        //.....................................................................
        /// <summary>
        /// https://docs.microsoft.com/zh-cn/dotnet/api/documentformat.openxml.packaging.maindocumentpart?view=openxml-2.8.1
        /// 
        /// </summary>
        /// <param name="docxname"></param>
        public void ShowComments( string docxname )
        {
            //string docxname = @"C:\Users\Public\Documents\MainDocumentPartEx.docx";
            string comments = null;

            //List<string> listing = new List<string>( );

            // Open the file read-only.  
            using ( WordprocessingDocument wordprocessingDocument = WordprocessingDocument.Open( docxname, false ) )
            {
                MainDocumentPart mainPart = wordprocessingDocument.MainDocumentPart;

                WordprocessingCommentsPart docxprocCommentsPart = mainPart.WordprocessingCommentsPart;

                // Read the comments using a stream reader.  
                using ( StreamReader streamReader = new StreamReader( docxprocCommentsPart.GetStream( ) ) )
                {
                    comments = streamReader.ReadToEnd( );
                }
            }

            FileInfo fileinfo = new FileInfo( docxname );
            string msgname = fileinfo.FullName + "-comments.txt";

            File.WriteAllText( msgname, comments, Encoding.Default );

            //Console.WriteLine( comments );
            //Console.ReadKey( );

            return;
        }

        //.....................................................................
    }
}
