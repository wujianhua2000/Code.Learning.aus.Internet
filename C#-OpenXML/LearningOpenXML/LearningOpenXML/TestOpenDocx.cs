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
    class TestOpenDocx
    {
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
        public TestOpenDocx( )
        {
            bool miss = ( !Directory.Exists( this.NamePath ) );
            if ( miss ) Directory.CreateDirectory( this.NamePath );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        public void TestDocx( )
        {
            using ( WordprocessingDocument wordocument = WordprocessingDocument.Create( this.GetDocxName(), 
                                                                                        WordprocessingDocumentType.Document ) )
            {
                MainDocumentPart mainDocxPart = wordocument.AddMainDocumentPart( );

                mainDocxPart.Document = this.GenerateDocument( );

                mainDocxPart.Document.Save( );
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
    }
}
