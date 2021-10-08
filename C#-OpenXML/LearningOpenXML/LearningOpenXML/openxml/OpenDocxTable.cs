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
    class OpenDocxTable
    {
        /// <summary>
        /// 一个 CM 是多少个openXML 中的长度。
        /// </summary>
        public static double OPENXML_CM_LEN = 56.6866;

        public static double OPENXML_A4MM_USER = 150.00;

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        public Table Tisch = new Table( );

        /// <summary>
        /// 
        /// </summary>
        public int Colnum;

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="colnum"></param>
        /// <param name="wsizeP">磅宽度</param>
        public OpenDocxTable( int colnum, int wsizeP )
        {
            this.Colnum = colnum;

            this.Tisch.Append( this.MakeTableProperties( wsizeP ) );
            this.Tisch.Append( this.MakeTableGrid( colnum ) );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listing"></param>
        public void MakeTableRow( List<string> listing, double height )
        {
            int cellwidt = ( int ) ( OPENXML_A4MM_USER / this.Colnum );

            TableRow rowline = new TableRow( ) { RsidTableRowAddition = "005823AE", RsidTableRowProperties = "00226BAF" };

            TableRowHeight rowheight = new TableRowHeight( ) { Val = OpenDocxBase.MM2Uint32V( height ) };

            rowline.Append( rowheight );

            int idx = 0;
            foreach ( string line in listing )
            {
                idx++;
                int align = 1;
                if ( idx == 2 ) align = 2;
                if ( idx == 3 ) align = 3;

                rowline.Append( this.MakeTableCell( line, cellwidt, align ) );
            }

            this.Tisch.Append( rowline );
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="txtline"></param>
        /// <returns></returns>
        private TableCell MakeTableCell( string txtline, int widthMM, int align = 1 )
        {
            UInt32Value uint32ww = OpenDocxBase.MM2Uint32V( widthMM );

            //.............................................
            TableCellWidth zellwidth = new TableCellWidth( ) { Width = uint32ww.ToString(), /*widthMM.ToString( ),*/ Type = TableWidthUnitValues.Dxa };

            TableCellVerticalAlignment zellVertAlign = new TableCellVerticalAlignment( ) { Val = TableVerticalAlignmentValues.Center };

            TableCellProperties zellProperties = new TableCellProperties( );
            zellProperties.Append( zellwidth );
            zellProperties.Append( zellVertAlign );

            //.............................................
            Justification justRIGHT = new Justification( ) { Val = JustificationValues.Right };
            Justification justCENTER = new Justification( ) { Val = JustificationValues.Center };

            ParagraphProperties paraProperties = new ParagraphProperties( );
            if ( align == 2 ) paraProperties.Append( justCENTER );
            if ( align == 3 ) paraProperties.Append( justRIGHT );

            //.............................................

            RunFonts runFonts = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            RunProperties textRunProperties = new RunProperties( );
            textRunProperties.Append( runFonts );

            Run runOBJ = new Run( );

            runOBJ.Append( textRunProperties );
            runOBJ.Append( new Text( ) { Text = txtline } );

            //.............................................
            Paragraph paragraph = new Paragraph( ) { RsidParagraphAddition = "005823AE", RsidRunAdditionDefault = "005823AE" };

            paragraph.Append( paraProperties );
            paragraph.Append( runOBJ );

            //.............................................
            TableCell tableZELL = new TableCell( );

            tableZELL.Append( zellProperties );
            tableZELL.Append( paragraph );

            return tableZELL;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wsize">边框的宽度， 8 是一磅的宽度</param>
        /// <returns></returns>
        private TableProperties MakeTableProperties( int wsize )
        {
            TableProperties properties = new TableProperties( );

            TableStyle style = new TableStyle( ) { Val = "a3" };

            TableWidth width = new TableWidth( ) { Width = "0", Type = TableWidthUnitValues.Auto };

            TableLook look = new TableLook( ) { Val = "04A0", FirstRow = true, LastRow = false, FirstColumn = true, LastColumn = false, NoHorizontalBand = false, NoVerticalBand = true };

            properties.Append( style );
            properties.Append( width );
            properties.Append( look );

            if ( wsize < 1 ) return properties;

            properties.Append( this.MakeTableBorders( wsize ) );

            return properties;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="colnum"></param>
        /// <returns></returns>
        public TableGrid MakeTableGrid( int colnum )
        {
            //int w1 = ( int ) Math.Round( 30.0 * 56.6866, 0 );
            //int w2 = ( int ) Math.Round( 40.0 * 56.6866, 0 );
            //int w3 = ( int ) Math.Round( 50.0 * 56.6866, 0 );

            TableGrid docTableGrid = new TableGrid( );

            //GridColumn gridColumn1 = new GridColumn( ) { Width = w1.ToString() };
            //GridColumn gridColumn2 = new GridColumn( ) { Width = w2.ToString( ) };
            //GridColumn gridColumn3 = new GridColumn( ) { Width = w3.ToString( ) };

            for ( int idx = 0; idx < colnum; idx++ ) docTableGrid.Append( new GridColumn( ) );

            return docTableGrid;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="widthMM"></param>
        /// <returns></returns>
        public TableBorders MakeTableBorders( int borderLineWidth )
        {
            UInt32Value linWW = new UInt32Value( ( UInt32 ) borderLineWidth );

            TableBorders borders = new TableBorders( );

            TopBorder borderTOP = new TopBorder( );
            LeftBorder borderLFT = new LeftBorder( );
            BottomBorder borderBTM = new BottomBorder( );
            RightBorder borderRGT = new RightBorder( );

            InsideHorizontalBorder borderHHH = new InsideHorizontalBorder( );
            InsideVerticalBorder borderVVV = new InsideVerticalBorder( );

            this.WidthSize( borderTOP, linWW );
            this.WidthSize( borderLFT, linWW );
            this.WidthSize( borderBTM, linWW );
            this.WidthSize( borderRGT, linWW );

            this.WidthSize( borderHHH, linWW );
            this.WidthSize( borderVVV, linWW );

            borders.Append( borderTOP );
            borders.Append( borderLFT );
            borders.Append( borderBTM );
            borders.Append( borderRGT );

            borders.Append( borderHHH );
            borders.Append( borderVVV );
        
            return borders;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="boder"></param>
        /// <param name="wsizeP"></param>
        private void WidthSize( BorderType boder, UInt32Value wsize )
        {
            boder.Val = BorderValues.Single;
            boder.Color = "auto";
            boder.Size = wsize;
            boder.Space = ( UInt32Value ) 0U;

            return;
        }

        //.....................................................................
    }
}
