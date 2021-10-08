using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace Hans.Opxm
{
    class TestDocxSectionHeader : OpenDocxBase
    {
        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override Document GenerateDocument( )
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

            Body body1 = new Body( );

            Paragraph paragraph1 = MakePara1( );


            Paragraph paragraph2 = MakePara_SECT_1( );

            Paragraph paragraph3 = new Paragraph( ) { RsidParagraphAddition = "0036679D", RsidParagraphProperties = "0036679D", RsidRunAdditionDefault = "0036679D" };

            Paragraph paragraph4 = MakePara4( );

            Paragraph paragraph5 = new Paragraph( ) { RsidParagraphAddition = "0036679D", RsidParagraphProperties = "0036679D", RsidRunAdditionDefault = "0036679D" };

            Paragraph paragraph6 = MakePara6( );

            Paragraph paragraph7 = MakePara7( );

            Paragraph paragraph8 = MakePara_SECT_2( );

            Paragraph paragraph9 = new Paragraph( ) { RsidParagraphAddition = "00043A09", RsidRunAdditionDefault = "00043A09" };
            
            Paragraph paragraph10 = new Paragraph( ) { RsidParagraphAddition = "00043A09", RsidRunAdditionDefault = "00043A09" };

            //---------------------------------------------
            Paragraph paragraph11 = MakePara11( );

            //---------------------------------------------
            Paragraph paragraph12 = MakePara12( );

            //---------------------------------------------
            Paragraph paragraph13 = MakePara_13( );
            
            BookmarkEnd bookmarkEnd1 = new BookmarkEnd( ) { Id = "0" };

            //---------------------------------------------
            Paragraph paragraph14 = new Paragraph( ) { RsidParagraphAddition = "00043A09", RsidRunAdditionDefault = "00043A09" };

            //---------------------------------------------
            SectionProperties sectionProperties4 = new SectionProperties( ) { RsidR = "00043A09", RsidSect = "00043A09" };
            SectionType sectionType2 = new SectionType( ) { Val = SectionMarkValues.Continuous };
            PageSize pageSize4 = new PageSize( ) { Width = ( UInt32Value ) 11906U, Height = ( UInt32Value ) 16838U };
            PageMargin pageMargin4 = new PageMargin( ) { Top = 1440, Right = ( UInt32Value ) 1800U, Bottom = 1440, Left = ( UInt32Value ) 1800U, Header = ( UInt32Value ) 851U, Footer = ( UInt32Value ) 992U, Gutter = ( UInt32Value ) 0U };
            Columns columns4 = new Columns( ) { Space = "425" };
            DocGrid docGrid4 = new DocGrid( ) { Type = DocGridValues.Lines, LinePitch = 312 };

            sectionProperties4.Append( sectionType2 );
            sectionProperties4.Append( pageSize4 );
            sectionProperties4.Append( pageMargin4 );
            sectionProperties4.Append( columns4 );
            sectionProperties4.Append( docGrid4 );

            //---------------------------------------------
            body1.Append( paragraph1 );
            body1.Append( paragraph2 );
            body1.Append( paragraph3 );
            body1.Append( paragraph4 );
            body1.Append( paragraph5 );
            body1.Append( paragraph6 );
            body1.Append( paragraph7 );
            body1.Append( paragraph8 );
            body1.Append( paragraph9 );
            body1.Append( paragraph10 );
            body1.Append( paragraph11 );
            body1.Append( paragraph12 );
            body1.Append( paragraph13 );
            body1.Append( bookmarkEnd1 );
            body1.Append( paragraph14 );
            body1.Append( sectionProperties4 );

            document1.Append( body1 );
            return document1;
        }

        private static Paragraph MakePara11( )
        {
            Paragraph paragraph11 = new Paragraph( ) { RsidParagraphAddition = "00043A09", RsidRunAdditionDefault = "00043A09" };

            ParagraphProperties paragraphProperties6 = new ParagraphProperties( );

            SectionProperties sectionProperties2 = new SectionProperties( ) { RsidR = "00043A09" };
            PageSize pageSize2 = new PageSize( ) { Width = ( UInt32Value ) 11906U, Height = ( UInt32Value ) 16838U };
            PageMargin pageMargin2 = new PageMargin( ) { Top = 1440, Right = ( UInt32Value ) 1800U, Bottom = 1440, Left = ( UInt32Value ) 1800U, Header = ( UInt32Value ) 851U, Footer = ( UInt32Value ) 992U, Gutter = ( UInt32Value ) 0U };
            Columns columns2 = new Columns( ) { Space = "425" };
            DocGrid docGrid2 = new DocGrid( ) { Type = DocGridValues.Lines, LinePitch = 312 };

            sectionProperties2.Append( pageSize2 );
            sectionProperties2.Append( pageMargin2 );
            sectionProperties2.Append( columns2 );
            sectionProperties2.Append( docGrid2 );

            paragraphProperties6.Append( sectionProperties2 );

            paragraph11.Append( paragraphProperties6 );
            return paragraph11;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Paragraph MakePara_13( )
        {
            Paragraph paragraph13 = new Paragraph( ) { RsidParagraphAddition = "00043A09", RsidParagraphProperties = "004B00FE", RsidRunAdditionDefault = "00043A09" };

            ParagraphStyleId paragraphStyleId4 = new ParagraphStyleId( ) { Val = "4" };

            ParagraphProperties paragraphProperties8 = new ParagraphProperties( );
            paragraphProperties8.Append( paragraphStyleId4 );

            BookmarkStart bookmarkStart1 = new BookmarkStart( ) { Name = "_GoBack", Id = "0" };

            //---------------------------------------------
            LastRenderedPageBreak lastRenderedPageBreak2 = new LastRenderedPageBreak( );
            
            Text text6 = new Text( );
            text6.Text = "第三节";

            Run run6 = new Run( );
            run6.Append( lastRenderedPageBreak2 );
            run6.Append( text6 );


            //---------------------------------------------
            RunFonts runFonts5 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            RunProperties runProperties4 = new RunProperties( );
            runProperties4.Append( runFonts5 );
            Text text7 = new Text( );
            text7.Text = "，";

            Run run7 = new Run( );
            run7.Append( runProperties4 );
            run7.Append( text7 );

            //---------------------------------------------
            Text text8 = new Text( );
            text8.Text = "连续";

            Run run8 = new Run( );
            run8.Append( text8 );

            //---------------------------------------------
            paragraph13.Append( paragraphProperties8 );
            paragraph13.Append( bookmarkStart1 );
            paragraph13.Append( run6 );
            paragraph13.Append( run7 );
            paragraph13.Append( run8 );
            
            return paragraph13;
        }

        private static Paragraph MakePara12( )
        {
            Paragraph paragraph12 = new Paragraph( ) { RsidParagraphAddition = "00043A09", RsidRunAdditionDefault = "00043A09" };

            ParagraphProperties paragraphProperties7 = new ParagraphProperties( );

            SectionProperties sectionProperties3 = new SectionProperties( ) { RsidR = "00043A09", RsidSect = "00043A09" };
            SectionType sectionType1 = new SectionType( ) { Val = SectionMarkValues.Continuous };
            PageSize pageSize3 = new PageSize( ) { Width = ( UInt32Value ) 11906U, Height = ( UInt32Value ) 16838U };
            PageMargin pageMargin3 = new PageMargin( ) { Top = 1440, Right = ( UInt32Value ) 1800U, Bottom = 1440, Left = ( UInt32Value ) 1800U, Header = ( UInt32Value ) 851U, Footer = ( UInt32Value ) 992U, Gutter = ( UInt32Value ) 0U };
            Columns columns3 = new Columns( ) { Space = "425" };
            DocGrid docGrid3 = new DocGrid( ) { Type = DocGridValues.Lines, LinePitch = 312 };

            sectionProperties3.Append( sectionType1 );
            sectionProperties3.Append( pageSize3 );
            sectionProperties3.Append( pageMargin3 );
            sectionProperties3.Append( columns3 );
            sectionProperties3.Append( docGrid3 );

            paragraphProperties7.Append( sectionProperties3 );

            paragraph12.Append( paragraphProperties7 );
            return paragraph12;
        }

        private static Paragraph MakePara1( )
        {
            Paragraph paragraph1 = new Paragraph( ) { RsidParagraphAddition = "004B00FE", RsidParagraphProperties = "0036679D", RsidRunAdditionDefault = "004B00FE" };

            ParagraphProperties paragraphProperties1 = new ParagraphProperties( );

            ParagraphMarkRunProperties paragraphMarkRunProperties1 = new ParagraphMarkRunProperties( );
            RunFonts runFonts1 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            paragraphMarkRunProperties1.Append( runFonts1 );

            paragraphProperties1.Append( paragraphMarkRunProperties1 );

            paragraph1.Append( paragraphProperties1 );
            return paragraph1;
        }

        private Paragraph MakePara_SECT_1( )
        {
            Paragraph paragraph2 = new Paragraph( ) { RsidParagraphAddition = "0036679D", RsidParagraphProperties = "004B00FE", RsidRunAdditionDefault = "0036679D" };

            ParagraphStyleId paragraphStyleId1 = new ParagraphStyleId( ) { Val = "1" };

            ParagraphProperties paragraphProperties2 = new ParagraphProperties( );
            paragraphProperties2.Append( paragraphStyleId1 );

            //---------------------------------------------
            Run run1 = new Run( );

            RunFonts runFonts2 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            RunProperties runProperties1 = new RunProperties( );
            runProperties1.Append( runFonts2 );

            Text text1 = new Text( );
            text1.Text = "第一节";

            run1.Append( runProperties1 );
            run1.Append( text1 );

            //---------------------------------------------
            paragraph2.Append( paragraphProperties2 );
            paragraph2.Append( run1 );
            
            return paragraph2;
        }

        private Paragraph MakePara4( )
        {
            Paragraph paragraph4 = new Paragraph( ) { RsidParagraphAddition = "0036679D", RsidParagraphProperties = "004B00FE", RsidRunAdditionDefault = "0036679D" };

            ParagraphProperties paragraphProperties3 = new ParagraphProperties( );
            ParagraphStyleId paragraphStyleId2 = new ParagraphStyleId( ) { Val = "2" };

            paragraphProperties3.Append( paragraphStyleId2 );

            //---------------------------------------------
            Run run2 = new Run( );

            RunProperties runProperties2 = new RunProperties( );
            RunFonts runFonts3 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            runProperties2.Append( runFonts3 );
            Text text2 = new Text( );
            text2.Text = "内容";

            run2.Append( runProperties2 );
            run2.Append( text2 );

            //---------------------------------------------
            ProofError proofError1 = new ProofError( ) { Type = ProofingErrorValues.GrammarStart };

            //---------------------------------------------
            Run run3 = new Run( );

            RunProperties runProperties3 = new RunProperties( );
            RunFonts runFonts4 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            runProperties3.Append( runFonts4 );
            Text text3 = new Text( );
            text3.Text = "内容";

            run3.Append( runProperties3 );
            run3.Append( text3 );

            //---------------------------------------------
            ProofError proofError2 = new ProofError( ) { Type = ProofingErrorValues.GrammarEnd };

            //---------------------------------------------
            paragraph4.Append( paragraphProperties3 );
            paragraph4.Append( run2 );
            //paragraph4.Append( proofError1 );
            paragraph4.Append( run3 );
            //paragraph4.Append( proofError2 );
            
            return paragraph4;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Paragraph MakePara_SECT_2( )
        {
            Paragraph paragraph8 = new Paragraph( ) { RsidParagraphAddition = "00043A09", RsidParagraphProperties = "004B00FE", RsidRunAdditionDefault = "00043A09" };

            ParagraphProperties paragraphProperties5 = new ParagraphProperties( );
            ParagraphStyleId paragraphStyleId3 = new ParagraphStyleId( ) { Val = "3" };

            paragraphProperties5.Append( paragraphStyleId3 );

            Run run5 = new Run( );
            LastRenderedPageBreak lastRenderedPageBreak1 = new LastRenderedPageBreak( );
            Text text5 = new Text( );
            text5.Text = "第二节";

            run5.Append( lastRenderedPageBreak1 );
            run5.Append( text5 );

            paragraph8.Append( paragraphProperties5 );
            paragraph8.Append( run5 );
            
            return paragraph8;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Paragraph MakePara7( )
        {
            Paragraph paragraph7 = new Paragraph( ) { RsidParagraphAddition = "00043A09", RsidRunAdditionDefault = "00043A09" };

            ParagraphProperties paragraphProperties4 = new ParagraphProperties( );

            SectionProperties sectionProperties1 = new SectionProperties( ) { RsidR = "00043A09" };
            PageSize pageSize1 = new PageSize( ) { Width = ( UInt32Value ) 11906U, Height = ( UInt32Value ) 16838U };
            PageMargin pageMargin1 = new PageMargin( ) { Top = 1440, Right = ( UInt32Value ) 1800U, Bottom = 1440, Left = ( UInt32Value ) 1800U, Header = ( UInt32Value ) 851U, Footer = ( UInt32Value ) 992U, Gutter = ( UInt32Value ) 0U };
            Columns columns1 = new Columns( ) { Space = "425" };
            DocGrid docGrid1 = new DocGrid( ) { Type = DocGridValues.Lines, LinePitch = 312 };

            sectionProperties1.Append( pageSize1 );
            sectionProperties1.Append( pageMargin1 );
            sectionProperties1.Append( columns1 );
            sectionProperties1.Append( docGrid1 );

            paragraphProperties4.Append( sectionProperties1 );

            paragraph7.Append( paragraphProperties4 );

            return paragraph7;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Paragraph MakePara6( )
        {
            Paragraph paragraph6 = new Paragraph( ) { RsidParagraphAddition = "0036679D", RsidParagraphProperties = "0036679D", RsidRunAdditionDefault = "0036679D" };

            Run run4 = new Run( );
            Text text4 = new Text( );
            text4.Text = "123";


            run4.Append( text4 );

            paragraph6.Append( run4 );
            return paragraph6;
        }

        //.....................................................................
    }
}
