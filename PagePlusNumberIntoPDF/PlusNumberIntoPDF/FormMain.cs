using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Diagnostics;

using iTextSharp.text;
using iTextSharp.text.pdf;

namespace PlusNumberIntoPDF
{
    public partial class FormMain : Form
    {
        public FormMain( )
        {
            InitializeComponent( );
        }

        //.....................................................................
        /// <summary>
        /// ColumnText.ShowTextAligned
        ///     568f,  15f, 0      for text.pdf
        ///     550f, 820f, 0      for .net developer.pdf
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click( object sender, EventArgs e )
        {
            if ( this.DialogFile.ShowDialog( ) != System.Windows.Forms.DialogResult.OK ) return;

            string filename = this.DialogFile.FileName;

            byte[ ] bytes = File.ReadAllBytes( filename );

            iTextSharp.text.Font blackFont = FontFactory.GetFont( 
                                                    "Arial", 12, 
                                                    iTextSharp.text.Font.NORMAL, 
                                                    BaseColor.BLACK );

            using ( MemoryStream stream = new MemoryStream( ) )
            {
                PdfReader reader = new PdfReader( bytes );

                using ( PdfStamper stamper = new PdfStamper( reader, stream ) )
                {
                    int pages = reader.NumberOfPages;

                    for ( int i = 1; i <= pages; i++ )
                    {
                        string pageNm = "Page : " + i.ToString( ).PadLeft( 3, '0' );

                        ColumnText.ShowTextAligned( stamper.GetUnderContent( i ),
                                                    Element.ALIGN_RIGHT,
                                                    new Phrase( pageNm, blackFont ),
                                                    //  568f, 15f, 0      
                                                    550f, 820f, 0       
                                                    );
                    }
                }

                bytes = stream.ToArray( );
            }

            FileInfo fileinfo = new FileInfo( filename );

            File.WriteAllBytes( fileinfo.DirectoryName + "\\page-number.pdf", bytes );

            Process.Start( "explorer.exe", fileinfo.DirectoryName );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static iTextSharp.text.Font GetTahoma( )
        {
            var fontName = "Tahoma";
            
            if ( !FontFactory.IsRegistered( fontName ) )
            {
                var fontPath = Environment.GetEnvironmentVariable( "SystemRoot" ) + "\\fonts\\tahoma.ttf";
                FontFactory.Register( fontPath );
            }
        
            return FontFactory.GetFont( fontName, BaseFont.IDENTITY_H, BaseFont.EMBEDDED );
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        public void ShowAnchorPoints( string pathname )
        {
            string dest = pathname + "showAnchorPoints.pdf";

            using ( Document document = new Document( ) )
            {
                PdfWriter writer = PdfWriter.GetInstance( document, new FileStream( dest, FileMode.Create, FileAccess.Write ) );
                document.Open( );

                PdfContentByte canvas = writer.DirectContent;

                canvas.MoveTo( 300, 100 );
                canvas.LineTo( 300, 700 );
                canvas.MoveTo( 100, 300 );
                canvas.LineTo( 500, 300 );
                canvas.MoveTo( 100, 400 );
                canvas.LineTo( 500, 400 );
                canvas.MoveTo( 100, 500 );
                canvas.LineTo( 500, 500 );
                canvas.Stroke( );

                ColumnText.ShowTextAligned( canvas, Element.ALIGN_LEFT, new Phrase( "Left aligned" ), 300, 500, 0 );
                ColumnText.ShowTextAligned( canvas, Element.ALIGN_CENTER, new Phrase( "Center aligned" ), 300, 400, 0 );
                ColumnText.ShowTextAligned( canvas, Element.ALIGN_RIGHT, new Phrase( "Right aligned" ), 300, 300, 0 );
            }

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAlignment_Click( object sender, EventArgs e )
        {
            if ( this.DialogPath.ShowDialog( ) != System.Windows.Forms.DialogResult.OK ) return;

            string pathname = this.DialogPath.SelectedPath;     // @"D:\123-temp\pdf-num\";

            this.ShowAnchorPoints( pathname );

            Process.Start( "explorer.exe", pathname );

            return;
        }

        //.....................................................................
    }
}
