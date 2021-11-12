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
    /// <summary>
    /// 
    /// </summary>
    class TestDocxSelectAllesText : OpenDocxBase
    {
        /// <summary>
        /// 
        /// </summary>
        public List<string> ListKeys = new List<string>( );

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        public void OpenExistDocx( string docxname,     bool editable = false )
        {
            //string docxname = "D:\\123-test-openxml\\select-alles-text.docx";

            using ( this.wordocument = WordprocessingDocument.Open( docxname, editable ) )
            {
                MainDocumentPart mainDocxPart = wordocument.MainDocumentPart;

                Document document = mainDocxPart.Document;

                IEnumerable<Paragraph> paralisting = document.Descendants<Paragraph>( );

                List<string> listing = new List<string>( );

                foreach ( Paragraph para in paralisting )
                {
                    IEnumerable<Text> textlisting = para.Descendants<Text>( );

                    StringBuilder buffer = new StringBuilder( );

                    foreach ( Text txtln in textlisting ) buffer.Append( txtln.Text );

                    listing.Add( buffer.ToString() );
                }

                bool miss = ( !Directory.Exists( this.NamePath ) );
                if ( miss ) Directory.CreateDirectory( this.NamePath );

                File.WriteAllLines( "D:\\123-test-openxml\\select-alles-text-listing.txt", listing.ToArray( ), Encoding.Default );
            }

            return;
        }

        //.....................................................................
    }
}
