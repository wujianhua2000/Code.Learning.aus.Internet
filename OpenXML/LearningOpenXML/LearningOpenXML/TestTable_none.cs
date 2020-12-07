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
    class TestTable_none : TestOpenDocx
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

            //---------------------------------------------
            Table table1 = new Table( );

            TableProperties tableProperties1 = MakeTableProperties( );

            TableGrid tableGrid1 = MakeTableGrid( );

            TableRow tableRow1 = MakeRowLine1( );

            TableRow tableRow2 = MakeRowLine2( );

            table1.Append( tableProperties1 );
            table1.Append( tableGrid1 );
            table1.Append( tableRow1 );
            table1.Append( tableRow2 );

            //---------------------------------------------
            Paragraph paragraph7 = new Paragraph( ) { RsidParagraphAddition = "00762968", RsidRunAdditionDefault = "00762968" };

            Paragraph paragraph8 = MakeTextLine1( );

            Paragraph paragraph9 = MakeTextLine2( );

            //---------------------------------------------
            Paragraph paragraph10 = new Paragraph( ) { RsidParagraphAddition = "001A467D", RsidParagraphProperties = "001A467D", RsidRunAdditionDefault = "001A467D" };

            ParagraphProperties paragraphProperties4 = new ParagraphProperties( );
            WidowControl widowControl3 = new WidowControl( );
            Justification justification4 = new Justification( ) { Val = JustificationValues.Left };

            paragraphProperties4.Append( widowControl3 );
            paragraphProperties4.Append( justification4 );

            paragraph10.Append( paragraphProperties4 );

            //---------------------------------------------
            Paragraph paragraph11 = new Paragraph( ) { RsidParagraphAddition = "001A467D", RsidParagraphProperties = "001A467D", RsidRunAdditionDefault = "001A467D" };

            ParagraphProperties paragraphProperties5 = new ParagraphProperties( );
            WidowControl widowControl4 = new WidowControl( );
            Justification justification5 = new Justification( ) { Val = JustificationValues.Left };

            paragraphProperties5.Append( widowControl4 );
            paragraphProperties5.Append( justification5 );

            paragraph11.Append( paragraphProperties5 );

            SectionProperties sectionProperties1 = new SectionProperties( ) { RsidR = "001A467D" };
            PageSize pageSize1 = new PageSize( ) { Width = ( UInt32Value ) 11906U, Height = ( UInt32Value ) 16838U };
            PageMargin pageMargin1 = new PageMargin( ) { Top = 1440, Right = ( UInt32Value ) 1800U, Bottom = 1440, Left = ( UInt32Value ) 1800U, Header = ( UInt32Value ) 851U, Footer = ( UInt32Value ) 992U, Gutter = ( UInt32Value ) 0U };
            Columns columns1 = new Columns( ) { Space = "425" };
            DocGrid docGrid1 = new DocGrid( ) { Type = DocGridValues.Lines, LinePitch = 312 };

            sectionProperties1.Append( pageSize1 );
            sectionProperties1.Append( pageMargin1 );
            sectionProperties1.Append( columns1 );
            sectionProperties1.Append( docGrid1 );

            body1.Append( table1 );
            body1.Append( paragraph7 );
            body1.Append( paragraph8 );
            body1.Append( paragraph9 );
            body1.Append( paragraph10 );
            body1.Append( paragraph11 );
            body1.Append( sectionProperties1 );

            document1.Append( body1 );

            return document1;
        }

        private TableProperties MakeTableProperties( )
        {
            TableProperties tableProperties1 = new TableProperties( );

            TableStyle tableStyle1 = new TableStyle( ) { Val = "a3" };
            TableWidth tableWidth1 = new TableWidth( ) { Width = "0", Type = TableWidthUnitValues.Auto };
            TableLook tableLook1 = new TableLook( ) { Val = "04A0", FirstRow = true, LastRow = false, FirstColumn = true, LastColumn = false, NoHorizontalBand = false, NoVerticalBand = true };

            tableProperties1.Append( tableStyle1 );
            tableProperties1.Append( tableWidth1 );
            tableProperties1.Append( tableLook1 );
            return tableProperties1;
        }

        private TableGrid MakeTableGrid( )
        {
            TableGrid tableGrid1 = new TableGrid( );
            GridColumn gridColumn1 = new GridColumn( ) { Width = "2840" };
            GridColumn gridColumn2 = new GridColumn( ) { Width = "2841" };
            GridColumn gridColumn3 = new GridColumn( ) { Width = "2841" };

            tableGrid1.Append( gridColumn1 );
            tableGrid1.Append( gridColumn2 );
            tableGrid1.Append( gridColumn3 );
            return tableGrid1;
        }

        private TableRow MakeRowLine1( )
        {
            TableRow tableRow1 = new TableRow( ) { RsidTableRowAddition = "001A467D", RsidTableRowProperties = "00BC5CA7" };

            TableCell tableCell1 = new TableCell( );

            TableCellProperties tableCellProperties1 = new TableCellProperties( );
            TableCellWidth tableCellWidth1 = new TableCellWidth( ) { Width = "2840", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders1 = new TableCellBorders( );
            BottomBorder bottomBorder1 = new BottomBorder( ) { Val = BorderValues.Single, Color = "auto", Size = ( UInt32Value ) 48U, Space = ( UInt32Value ) 0U };
            RightBorder rightBorder1 = new RightBorder( ) { Val = BorderValues.Single, Color = "auto", Size = ( UInt32Value ) 18U, Space = ( UInt32Value ) 0U };

            tableCellBorders1.Append( bottomBorder1 );
            tableCellBorders1.Append( rightBorder1 );

            tableCellProperties1.Append( tableCellWidth1 );
            tableCellProperties1.Append( tableCellBorders1 );

            Paragraph paragraph1 = new Paragraph( ) { RsidParagraphAddition = "001A467D", RsidRunAdditionDefault = "001A467D" };

            Run run1 = new Run( );
            Text text1 = new Text( );
            text1.Text = "www";

            run1.Append( text1 );

            paragraph1.Append( run1 );

            tableCell1.Append( tableCellProperties1 );
            tableCell1.Append( paragraph1 );

            TableCell tableCell2 = new TableCell( );

            TableCellProperties tableCellProperties2 = new TableCellProperties( );
            TableCellWidth tableCellWidth2 = new TableCellWidth( ) { Width = "2841", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders2 = new TableCellBorders( );
            TopBorder topBorder1 = new TopBorder( ) { Val = BorderValues.Single, Color = "auto", Size = ( UInt32Value ) 18U, Space = ( UInt32Value ) 0U };
            LeftBorder leftBorder1 = new LeftBorder( ) { Val = BorderValues.Single, Color = "auto", Size = ( UInt32Value ) 18U, Space = ( UInt32Value ) 0U };
            BottomBorder bottomBorder2 = new BottomBorder( ) { Val = BorderValues.Single, Color = "auto", Size = ( UInt32Value ) 18U, Space = ( UInt32Value ) 0U };
            RightBorder rightBorder2 = new RightBorder( ) { Val = BorderValues.Single, Color = "auto", Size = ( UInt32Value ) 18U, Space = ( UInt32Value ) 0U };

            tableCellBorders2.Append( topBorder1 );
            tableCellBorders2.Append( leftBorder1 );
            tableCellBorders2.Append( bottomBorder2 );
            tableCellBorders2.Append( rightBorder2 );

            tableCellProperties2.Append( tableCellWidth2 );
            tableCellProperties2.Append( tableCellBorders2 );

            Paragraph paragraph2 = new Paragraph( ) { RsidParagraphAddition = "001A467D", RsidRunAdditionDefault = "001A467D" };

            Run run2 = new Run( );

            RunProperties runProperties1 = new RunProperties( );
            RunFonts runFonts1 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            runProperties1.Append( runFonts1 );
            Text text2 = new Text( );
            text2.Text = "1125489590";

            run2.Append( runProperties1 );
            run2.Append( text2 );

            paragraph2.Append( run2 );

            tableCell2.Append( tableCellProperties2 );
            tableCell2.Append( paragraph2 );

            TableCell tableCell3 = new TableCell( );

            TableCellProperties tableCellProperties3 = new TableCellProperties( );
            TableCellWidth tableCellWidth3 = new TableCellWidth( ) { Width = "2841", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders3 = new TableCellBorders( );
            TopBorder topBorder2 = new TopBorder( ) { Val = BorderValues.Single, Color = "auto", Size = ( UInt32Value ) 18U, Space = ( UInt32Value ) 0U };
            LeftBorder leftBorder2 = new LeftBorder( ) { Val = BorderValues.Single, Color = "auto", Size = ( UInt32Value ) 18U, Space = ( UInt32Value ) 0U };
            BottomBorder bottomBorder3 = new BottomBorder( ) { Val = BorderValues.Single, Color = "auto", Size = ( UInt32Value ) 18U, Space = ( UInt32Value ) 0U };
            RightBorder rightBorder3 = new RightBorder( ) { Val = BorderValues.Single, Color = "auto", Size = ( UInt32Value ) 18U, Space = ( UInt32Value ) 0U };

            tableCellBorders3.Append( topBorder2 );
            tableCellBorders3.Append( leftBorder2 );
            tableCellBorders3.Append( bottomBorder3 );
            tableCellBorders3.Append( rightBorder3 );

            tableCellProperties3.Append( tableCellWidth3 );
            tableCellProperties3.Append( tableCellBorders3 );

            Paragraph paragraph3 = new Paragraph( ) { RsidParagraphAddition = "001A467D", RsidRunAdditionDefault = "001A467D" };

            Run run3 = new Run( );

            RunProperties runProperties2 = new RunProperties( );
            RunFonts runFonts2 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            runProperties2.Append( runFonts2 );
            Text text3 = new Text( );
            text3.Text = "43";

            run3.Append( runProperties2 );
            run3.Append( text3 );

            Run run4 = new Run( );

            RunProperties runProperties3 = new RunProperties( );
            RunFonts runFonts3 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            runProperties3.Append( runFonts3 );
            Text text4 = new Text( );
            text4.Text = "几何";

            run4.Append( runProperties3 );
            run4.Append( text4 );

            Run run5 = new Run( );

            RunProperties runProperties4 = new RunProperties( );
            RunFonts runFonts4 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            runProperties4.Append( runFonts4 );
            Text text5 = new Text( );
            text5.Text = "8";

            run5.Append( runProperties4 );
            run5.Append( text5 );

            paragraph3.Append( run3 );
            paragraph3.Append( run4 );
            paragraph3.Append( run5 );

            tableCell3.Append( tableCellProperties3 );
            tableCell3.Append( paragraph3 );

            tableRow1.Append( tableCell1 );
            tableRow1.Append( tableCell2 );
            tableRow1.Append( tableCell3 );
            return tableRow1;
        }

        private TableRow MakeRowLine2( )
        {
            TableRow tableRow2 = new TableRow( ) { RsidTableRowAddition = "001A467D", RsidTableRowProperties = "00BC5CA7" };

            TableCell tableCell4 = new TableCell( );

            TableCellProperties tableCellProperties4 = new TableCellProperties( );
            TableCellWidth tableCellWidth4 = new TableCellWidth( ) { Width = "2840", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders4 = new TableCellBorders( );
            TopBorder topBorder3 = new TopBorder( ) { Val = BorderValues.Single, Color = "auto", Size = ( UInt32Value ) 48U, Space = ( UInt32Value ) 0U };
            LeftBorder leftBorder3 = new LeftBorder( ) { Val = BorderValues.Single, Color = "auto", Size = ( UInt32Value ) 48U, Space = ( UInt32Value ) 0U };
            BottomBorder bottomBorder4 = new BottomBorder( ) { Val = BorderValues.Nil };
            RightBorder rightBorder4 = new RightBorder( ) { Val = BorderValues.Nil };

            tableCellBorders4.Append( topBorder3 );
            tableCellBorders4.Append( leftBorder3 );
            tableCellBorders4.Append( bottomBorder4 );
            tableCellBorders4.Append( rightBorder4 );

            tableCellProperties4.Append( tableCellWidth4 );
            tableCellProperties4.Append( tableCellBorders4 );

            Paragraph paragraph4 = new Paragraph( ) { RsidParagraphAddition = "001A467D", RsidParagraphProperties = "001A467D", RsidRunAdditionDefault = "001A467D" };

            ParagraphProperties paragraphProperties1 = new ParagraphProperties( );
            Justification justification1 = new Justification( ) { Val = JustificationValues.Center };

            paragraphProperties1.Append( justification1 );

            Run run6 = new Run( );
            Text text6 = new Text( );
            text6.Text = "的空间打开";

            run6.Append( text6 );

            paragraph4.Append( paragraphProperties1 );
            paragraph4.Append( run6 );

            tableCell4.Append( tableCellProperties4 );
            tableCell4.Append( paragraph4 );

            TableCell tableCell5 = new TableCell( );

            TableCellProperties tableCellProperties5 = new TableCellProperties( );
            TableCellWidth tableCellWidth5 = new TableCellWidth( ) { Width = "2841", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders5 = new TableCellBorders( );
            TopBorder topBorder4 = new TopBorder( ) { Val = BorderValues.Single, Color = "auto", Size = ( UInt32Value ) 18U, Space = ( UInt32Value ) 0U };
            LeftBorder leftBorder4 = new LeftBorder( ) { Val = BorderValues.Nil };

            tableCellBorders5.Append( topBorder4 );
            tableCellBorders5.Append( leftBorder4 );

            tableCellProperties5.Append( tableCellWidth5 );
            tableCellProperties5.Append( tableCellBorders5 );

            Paragraph paragraph5 = new Paragraph( ) { RsidParagraphAddition = "001A467D", RsidRunAdditionDefault = "001A467D" };

            Run run7 = new Run( );

            RunProperties runProperties5 = new RunProperties( );
            RunFonts runFonts5 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            runProperties5.Append( runFonts5 );
            Text text7 = new Text( );
            text7.Text = "3489";

            run7.Append( runProperties5 );
            run7.Append( text7 );

            Run run8 = new Run( );

            RunProperties runProperties6 = new RunProperties( );
            RunFonts runFonts6 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            runProperties6.Append( runFonts6 );
            Text text8 = new Text( );
            text8.Text = "那就对方";

            run8.Append( runProperties6 );
            run8.Append( text8 );

            paragraph5.Append( run7 );
            paragraph5.Append( run8 );

            tableCell5.Append( tableCellProperties5 );
            tableCell5.Append( paragraph5 );

            TableCell tableCell6 = new TableCell( );

            TableCellProperties tableCellProperties6 = new TableCellProperties( );
            TableCellWidth tableCellWidth6 = new TableCellWidth( ) { Width = "2841", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders6 = new TableCellBorders( );
            TopBorder topBorder5 = new TopBorder( ) { Val = BorderValues.Single, Color = "auto", Size = ( UInt32Value ) 18U, Space = ( UInt32Value ) 0U };

            tableCellBorders6.Append( topBorder5 );

            tableCellProperties6.Append( tableCellWidth6 );
            tableCellProperties6.Append( tableCellBorders6 );

            Paragraph paragraph6 = new Paragraph( ) { RsidParagraphAddition = "001A467D", RsidRunAdditionDefault = "001A467D" };

            Run run9 = new Run( );
            Text text9 = new Text( );
            text9.Text = "大酒店";

            run9.Append( text9 );

            paragraph6.Append( run9 );

            tableCell6.Append( tableCellProperties6 );
            tableCell6.Append( paragraph6 );

            tableRow2.Append( tableCell4 );
            tableRow2.Append( tableCell5 );
            tableRow2.Append( tableCell6 );
            return tableRow2;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Paragraph MakeTextLine1( )
        {
            Paragraph paragraph8 = new Paragraph( ) { RsidParagraphAddition = "001A467D", RsidRunAdditionDefault = "001A467D" };

            ParagraphProperties paragraphProperties2 = new ParagraphProperties( );
            WidowControl widowControl1 = new WidowControl( );
            Justification justification2 = new Justification( ) { Val = JustificationValues.Left };

            paragraphProperties2.Append( widowControl1 );
            paragraphProperties2.Append( justification2 );

            Run run10 = new Run( );
            Break break1 = new Break( ) { Type = BreakValues.Page };

            run10.Append( break1 );
            BookmarkStart bookmarkStart1 = new BookmarkStart( ) { Name = "_GoBack", Id = "0" };
            BookmarkEnd bookmarkEnd1 = new BookmarkEnd( ) { Id = "0" };

            paragraph8.Append( paragraphProperties2 );
            paragraph8.Append( run10 );
            paragraph8.Append( bookmarkStart1 );
            paragraph8.Append( bookmarkEnd1 );
            return paragraph8;
        }

        private static Paragraph MakeTextLine2( )
        {
            string textlines =
"中华网财经12月5日讯，2020年，百年不遇的新冠疫情席卷全球，全球化遭遇严重打击，世界经济陷入衰退，价值和族群空前撕裂。" +
"面对百年未有之变局，由凤凰网、中国企业改革与发展研究会主办，人民日报出版社协办，凤凰网财经、" +
"中华网财经承办的“2020凤凰网财经峰会”在北京举办，" +
"本届峰会以“破局与新生”为主题，盛邀政商学界顶级嘉宾，围绕全球和中国经济发展建言献策，凝聚共识。" +

"All eyes are on Georgia ahead of Trump's rally and Senate debate																																									" +
"Updated 10:56 AM ET, Sat December 5, 2020                                                                                                                                                                                          " +
"(CNN) - The eyes of the political universe will turn to Georgia this weekend, as the voter registration deadline for January's Senate runoffs approaches.                                                                          " +
"Each side is desperately trying to motivate their party before the Monday deadline and early voting begins on December 14.                                                                                                         " +
"Former President Barack Obama and former state House minority leader Stacey Abrams held a virtual event for Democratic Senate challengers Jon Ossoff and Raphael Warnock on Friday,                                                " +
"while Vice President Mike Pence rallied for the Republicans.                                                                                                                                                                       " +
"Next in the frenzied rush is President Donald Trump's own rally on Saturday to elect Sens. David Perdue and Kelly Loeffler and protect the party's control of the chamber.                                                         " +
"Then on Sunday, Loeffler and Warnock will participate in a debate hosted by the Atlanta Press Club.                                                                                                                                " +
"The focus on Georgia comes as the state is ravaged by the coronavirus pandemic.                                                                                                                                                    " +
"It reported its highest number of cases in a single day on Friday -- 5,023 -- and saw the postponement of the Georgia-Vanderbilt football game partially because of Covid-19.                                                      " +
"Trump is faced with the task of motivating his own supporters to vote for the two Republican senators after he undermined their faith in the electoral process by falsely decrying that his election was rigged.                   " +
"Since his loss in Georgia to President-elect Joe Biden, Trump has attacked top Republican officials in the state, including Gov.                                                                                                   " +
"Brian Kemp and Georgia Secretary of State Brad Raffensperger. Kemp certified the results of Biden's victory, while Raffensperger has vociferously defended the state's election integrity.                                         " +
"The President's continued refusal to concede has worried Republicans determined to prevent Democratic control of the Senate. A group of prominent Georgia Republicans, including former Gov.                                       " +
"Nathan Deal and former Sens. Johnny Isakson and Saxby Chambliss, released a statement this week urging the party to unify, and shift its attention to electing Loeffler and Perdue.                                                " +
"But there is little evidence that Trump will stop his unceasing attacks on the democratic process and the state officials in charge of the election.                                                                               " +
"In the past few weeks, Trump publicly called Raffensperger an \"enemy of the people\" and privately called Kemp a \"moron\" and \"nut job,\" according to two sources.                                                             " +
"The President also asked in a recent phone call why Loeffler, who ran in a 20-person special election, did not secure a majority of votes on Election Day against Warnock, who received a plurality of the votes.                  " +
"After no Senate candidate received 50% of the vote in November, the races turned to particularly nasty runoffs.                                                                                                                    " +
"Democrats have charged that Perdue and Loeffler profited off the pandemic, saying their multi-million dollar stock trades drew the attention -- although no charges -- from the Justice Department.                                " +
"Meanwhile, the Republican senators have said they were cleared during the investigations, and have called Ossoff and Warnock socialists who will destroy America. Democrats have rejected those attacks as false fear-mongering.   " +
"Pence said on Friday that Republicans need to elect Perdue and Loeffler to defend the Trump administration's accomplishments over the past four years.                                                                             " +
"\"We need to send them back because the Republican Senate majority could be the last line of defense preserving all that we've done to defend this nation,                                                                         " +
"revive our economy, and preserve the god given liberties we hold dear,\" said Pence in Savannah.                                                                                                                                   " +
"While Biden narrowly won Georgia -- the first time for a Democratic presidential nominee since Bill Clinton in 1992 -- Republicans have a number of advantages in the two races.                                                   " +
"The state has not sent a Democrat to the Senate in 20 years. Last month, Perdue received tens of thousands of more votes than Ossoff. And Republicans are spending about $38 million more on ads than the Democrats,               " +
"according to Kantar Media/CMAG data.                                                                                                                                                                                               " +
"But Democrats are hopeful that the Republican intra-party fight, voter registration drives by Abrams and others and the state's rapidly diversifying suburbs will fuel their victories and flip the Senate.                        " +
"\"The special election in Georgia is going to determine, ultimately, the course of the Biden presidency,\" said Obama at the virtual event on Friday.                                                                              ";

            Paragraph paragraph9 = new Paragraph( ) { RsidParagraphAddition = "001A467D", RsidParagraphProperties = "001A467D", RsidRunAdditionDefault = "001A467D" };

            ParagraphProperties paragraphProperties3 = new ParagraphProperties( );
            WidowControl widowControl2 = new WidowControl( );
            Justification justification3 = new Justification( ) { Val = JustificationValues.Left };

            paragraphProperties3.Append( widowControl2 );
            paragraphProperties3.Append( justification3 );
            ProofError proofError1 = new ProofError( ) { Type = ProofingErrorValues.SpellStart };

            Run run11 = new Run( );
            LastRenderedPageBreak lastRenderedPageBreak1 = new LastRenderedPageBreak( );
            Text text10 = new Text( );
            text10.Text = textlines;

            run11.Append( lastRenderedPageBreak1 );
            run11.Append( text10 );

            //ProofError proofError2 = new ProofError( ) { Type = ProofingErrorValues.SpellEnd };

            //Run run12 = new Run( );
            //Text text11 = new Text( );
            //text11.Text = "得空可可可乐鄂温克";

            //run12.Append( text11 );
            //ProofError proofError3 = new ProofError( ) { Type = ProofingErrorValues.SpellStart };

            //Run run13 = new Run( );
            //Text text12 = new Text( );
            //text12.Text = "eelkeleked";

            //run13.Append( text12 );
            //ProofError proofError4 = new ProofError( ) { Type = ProofingErrorValues.SpellEnd };

            //Run run14 = new Run( );
            //Text text13 = new Text( );
            //text13.Text = "理论领料单是老老实实是理论上来说";

            //run14.Append( text13 );
            //ProofError proofError5 = new ProofError( ) { Type = ProofingErrorValues.GrammarStart };

            //Run run15 = new Run( );
            //Text text14 = new Text( );
            //text14.Text = "算了算了算了算了算了算了";

            //run15.Append( text14 );
            //ProofError proofError6 = new ProofError( ) { Type = ProofingErrorValues.GrammarEnd };

            //Run run16 = new Run( );
            //Text text15 = new Text( );
            //text15.Text = "网咯水利水电老地方说得出口的";

            //run16.Append( text15 );
            //ProofError proofError7 = new ProofError( ) { Type = ProofingErrorValues.GrammarStart };

            //Run run17 = new Run( );
            //Text text16 = new Text( );
            //text16.Text = "的";

            //run17.Append( text16 );
            //ProofError proofError8 = new ProofError( ) { Type = ProofingErrorValues.GrammarEnd };

            //Run run18 = new Run( );
            //Text text17 = new Text( );
            //text17.Text = "口袋里的";

            //run18.Append( text17 );

            //Run run19 = new Run( );

            //RunProperties runProperties7 = new RunProperties( );
            //RunFonts runFonts7 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            //runProperties7.Append( runFonts7 );
            //Text text18 = new Text( );
            //text18.Text = "；";

            //run19.Append( runProperties7 );
            //run19.Append( text18 );

            paragraph9.Append( paragraphProperties3 );
            paragraph9.Append( proofError1 );
            paragraph9.Append( run11 );
            
            //paragraph9.Append( proofError2 );
            //paragraph9.Append( run12 );
            //paragraph9.Append( proofError3 );
            //paragraph9.Append( run13 );
            //paragraph9.Append( proofError4 );
            //paragraph9.Append( run14 );
            //paragraph9.Append( proofError5 );
            //paragraph9.Append( run15 );
            //paragraph9.Append( proofError6 );
            //paragraph9.Append( run16 );
            //paragraph9.Append( proofError7 );
            //paragraph9.Append( run17 );
            //paragraph9.Append( proofError8 );
            //paragraph9.Append( run18 );
            //paragraph9.Append( run19 );

            return paragraph9;
        }

        //.....................................................................
    }
}
