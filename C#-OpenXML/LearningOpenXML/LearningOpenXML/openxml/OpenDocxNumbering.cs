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
    class OpenDocxNumbering
    {
        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numberingPART"></param>
        public static void Generate( NumberingDefinitionsPart numberingPART )
        {
            OpenDocxNumbering openxml = new OpenDocxNumbering( );
            
            openxml.GenerateNumbering( numberingPART );

            return;
        }

        //.....................................................................
        /// <summary>
        /// Generates content of numberingPART. 
        /// </summary>
        /// <param name="numberingPART"></param>
        public void GenerateNumbering( NumberingDefinitionsPart numberingPART )
        {
            AbstractNum abstractNum1 = this.MakeAbstractNum01( );
            AbstractNum abstractNum2 = this.MakeAbstractNum02( );
            AbstractNum abstractNum3 = this.MakeAbstractNum03( );
            AbstractNum abstractNum4 = this.MakeAbstractNum04( );
            AbstractNum abstractNum5 = this.MakeAbstractNum05( );
            AbstractNum abstractNum6 = this.MakeAbstractNum06( );
            AbstractNum abstractNum7 = this.MakeAbstractNum07( );
            AbstractNum abstractNum8 = this.MakeAbstractNum08( );

            //.............................................
            //
            NumberingInstance numberingInstance1 = new NumberingInstance( ) { NumberID = 1 };
            NumberingInstance numberingInstance2 = new NumberingInstance( ) { NumberID = 2 };
            NumberingInstance numberingInstance3 = new NumberingInstance( ) { NumberID = 3 };
            NumberingInstance numberingInstance4 = new NumberingInstance( ) { NumberID = 4 };
            NumberingInstance numberingInstance5 = new NumberingInstance( ) { NumberID = 5 };
            NumberingInstance numberingInstance6 = new NumberingInstance( ) { NumberID = 6 };
            NumberingInstance numberingInstance7 = new NumberingInstance( ) { NumberID = 7 };
            NumberingInstance numberingInstance8 = new NumberingInstance( ) { NumberID = 8 };

            //AbstractNumId abstractNumId1 = new AbstractNumId( ) { Val = 1 };
            //AbstractNumId abstractNumId2 = new AbstractNumId( ) { Val = 5 };
            //AbstractNumId abstractNumId3 = new AbstractNumId( ) { Val = 6 };
            //AbstractNumId abstractNumId4 = new AbstractNumId( ) { Val = 3 };
            //AbstractNumId abstractNumId5 = new AbstractNumId( ) { Val = 7 };
            //AbstractNumId abstractNumId6 = new AbstractNumId( ) { Val = 0 };
            //AbstractNumId abstractNumId7 = new AbstractNumId( ) { Val = 4 };
            //AbstractNumId abstractNumId8 = new AbstractNumId( ) { Val = 2 };

            AbstractNumId abstractNumId1 = new AbstractNumId( ) { Val = 0 };
            AbstractNumId abstractNumId2 = new AbstractNumId( ) { Val = 1 };
            AbstractNumId abstractNumId3 = new AbstractNumId( ) { Val = 2 };
            AbstractNumId abstractNumId4 = new AbstractNumId( ) { Val = 3 };
            AbstractNumId abstractNumId5 = new AbstractNumId( ) { Val = 4 };
            AbstractNumId abstractNumId6 = new AbstractNumId( ) { Val = 5 };
            AbstractNumId abstractNumId7 = new AbstractNumId( ) { Val = 6 };
            AbstractNumId abstractNumId8 = new AbstractNumId( ) { Val = 7 };

            numberingInstance1.Append( abstractNumId1 );
            numberingInstance2.Append( abstractNumId2 );
            numberingInstance3.Append( abstractNumId3 );
            numberingInstance4.Append( abstractNumId4 );
            numberingInstance5.Append( abstractNumId5 );
            numberingInstance6.Append( abstractNumId6 );
            numberingInstance7.Append( abstractNumId7 );
            numberingInstance8.Append( abstractNumId8 );

            Numbering numbering = this.NewNumbering( );

            numbering.Append( abstractNum1 );
            numbering.Append( abstractNum2 );
            numbering.Append( abstractNum3 );
            numbering.Append( abstractNum4 );
            numbering.Append( abstractNum5 );
            numbering.Append( abstractNum6 );
            numbering.Append( abstractNum7 );
            numbering.Append( abstractNum8 );

            numbering.Append( numberingInstance1 );
            numbering.Append( numberingInstance2 );
            numbering.Append( numberingInstance3 );
            numbering.Append( numberingInstance4 );
            numbering.Append( numberingInstance5 );
            numbering.Append( numberingInstance6 );
            numbering.Append( numberingInstance7 );
            numbering.Append( numberingInstance8 );

            numberingPART.Numbering = numbering;

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private AbstractNum MakeAbstractNum01( )
        {
            AbstractNum abstractNum1 = new AbstractNum( ) { AbstractNumberId = 0 };

            Nsid nsid1 = new Nsid( ) { Val = "022F7CA0" };

            MultiLevelType multiLevelType1 = new MultiLevelType( ) { Val = MultiLevelValues.Multilevel };

            TemplateCode templateCode1 = new TemplateCode( ) { Val = "8EDADCD0" };

            //.............................................
            Level level1 = new Level( ) { LevelIndex = 0 };
            StartNumberingValue startNumberingValue1 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat1 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText1 = new LevelText( ) { Val = "%1" };
            LevelJustification levelJustification1 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties1 = new PreviousParagraphProperties( );
            Indentation indentation1 = new Indentation( ) { Left = "425", Hanging = "425" };

            previousParagraphProperties1.Append( indentation1 );

            NumberingSymbolRunProperties numberingSymbolRunProperties1 = new NumberingSymbolRunProperties( );
            RunFonts runFonts7 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            numberingSymbolRunProperties1.Append( runFonts7 );

            level1.Append( startNumberingValue1 );
            level1.Append( numberingFormat1 );
            level1.Append( levelText1 );
            level1.Append( levelJustification1 );
            level1.Append( previousParagraphProperties1 );
            level1.Append( numberingSymbolRunProperties1 );

            //.............................................
            Level level2 = new Level( ) { LevelIndex = 1 };
            StartNumberingValue startNumberingValue2 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat2 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText2 = new LevelText( ) { Val = "%1.%2" };
            LevelJustification levelJustification2 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties2 = new PreviousParagraphProperties( );
            Indentation indentation2 = new Indentation( ) { Left = "992", Hanging = "567" };

            previousParagraphProperties2.Append( indentation2 );

            NumberingSymbolRunProperties numberingSymbolRunProperties2 = new NumberingSymbolRunProperties( );
            RunFonts runFonts8 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            numberingSymbolRunProperties2.Append( runFonts8 );

            level2.Append( startNumberingValue2 );
            level2.Append( numberingFormat2 );
            level2.Append( levelText2 );
            level2.Append( levelJustification2 );
            level2.Append( previousParagraphProperties2 );
            level2.Append( numberingSymbolRunProperties2 );

            //.............................................
            Level level3 = new Level( ) { LevelIndex = 2 };
            StartNumberingValue startNumberingValue3 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat3 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText3 = new LevelText( ) { Val = "%2.%1.%3" };
            LevelJustification levelJustification3 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties3 = new PreviousParagraphProperties( );
            Indentation indentation3 = new Indentation( ) { Left = "1418", Hanging = "567" };

            previousParagraphProperties3.Append( indentation3 );

            NumberingSymbolRunProperties numberingSymbolRunProperties3 = new NumberingSymbolRunProperties( );
            RunFonts runFonts9 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            numberingSymbolRunProperties3.Append( runFonts9 );

            level3.Append( startNumberingValue3 );
            level3.Append( numberingFormat3 );
            level3.Append( levelText3 );
            level3.Append( levelJustification3 );
            level3.Append( previousParagraphProperties3 );
            level3.Append( numberingSymbolRunProperties3 );

            //.............................................
            Level level4 = new Level( ) { LevelIndex = 3 };
            StartNumberingValue startNumberingValue4 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat4 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText4 = new LevelText( ) { Val = "%1.%2.%3.%4" };
            LevelJustification levelJustification4 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties4 = new PreviousParagraphProperties( );
            Indentation indentation4 = new Indentation( ) { Left = "1984", Hanging = "708" };

            previousParagraphProperties4.Append( indentation4 );

            NumberingSymbolRunProperties numberingSymbolRunProperties4 = new NumberingSymbolRunProperties( );
            RunFonts runFonts10 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            numberingSymbolRunProperties4.Append( runFonts10 );

            level4.Append( startNumberingValue4 );
            level4.Append( numberingFormat4 );
            level4.Append( levelText4 );
            level4.Append( levelJustification4 );
            level4.Append( previousParagraphProperties4 );
            level4.Append( numberingSymbolRunProperties4 );

            //.............................................
            Level level5 = new Level( ) { LevelIndex = 4 };
            StartNumberingValue startNumberingValue5 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat5 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText5 = new LevelText( ) { Val = "%1.%2.%3.%4.%5" };
            LevelJustification levelJustification5 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties5 = new PreviousParagraphProperties( );
            Indentation indentation5 = new Indentation( ) { Left = "2551", Hanging = "850" };

            previousParagraphProperties5.Append( indentation5 );

            NumberingSymbolRunProperties numberingSymbolRunProperties5 = new NumberingSymbolRunProperties( );
            RunFonts runFonts11 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            numberingSymbolRunProperties5.Append( runFonts11 );

            level5.Append( startNumberingValue5 );
            level5.Append( numberingFormat5 );
            level5.Append( levelText5 );
            level5.Append( levelJustification5 );
            level5.Append( previousParagraphProperties5 );
            level5.Append( numberingSymbolRunProperties5 );

            //.............................................
            Level level6 = new Level( ) { LevelIndex = 5 };
            StartNumberingValue startNumberingValue6 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat6 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText6 = new LevelText( ) { Val = "%1.%2.%3.%4.%5.%6" };
            LevelJustification levelJustification6 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties6 = new PreviousParagraphProperties( );
            Indentation indentation6 = new Indentation( ) { Left = "3260", Hanging = "1134" };

            previousParagraphProperties6.Append( indentation6 );

            NumberingSymbolRunProperties numberingSymbolRunProperties6 = new NumberingSymbolRunProperties( );
            RunFonts runFonts12 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            numberingSymbolRunProperties6.Append( runFonts12 );

            level6.Append( startNumberingValue6 );
            level6.Append( numberingFormat6 );
            level6.Append( levelText6 );
            level6.Append( levelJustification6 );
            level6.Append( previousParagraphProperties6 );
            level6.Append( numberingSymbolRunProperties6 );

            //.............................................
            Level level7 = new Level( ) { LevelIndex = 6 };
            StartNumberingValue startNumberingValue7 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat7 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText7 = new LevelText( ) { Val = "%1.%2.%3.%4.%5.%6.%7" };
            LevelJustification levelJustification7 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties7 = new PreviousParagraphProperties( );
            Indentation indentation7 = new Indentation( ) { Left = "3827", Hanging = "1276" };

            previousParagraphProperties7.Append( indentation7 );

            NumberingSymbolRunProperties numberingSymbolRunProperties7 = new NumberingSymbolRunProperties( );
            RunFonts runFonts13 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            numberingSymbolRunProperties7.Append( runFonts13 );

            level7.Append( startNumberingValue7 );
            level7.Append( numberingFormat7 );
            level7.Append( levelText7 );
            level7.Append( levelJustification7 );
            level7.Append( previousParagraphProperties7 );
            level7.Append( numberingSymbolRunProperties7 );

            //.............................................
            Level level8 = new Level( ) { LevelIndex = 7 };
            StartNumberingValue startNumberingValue8 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat8 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText8 = new LevelText( ) { Val = "%1.%2.%3.%4.%5.%6.%7.%8" };
            LevelJustification levelJustification8 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties8 = new PreviousParagraphProperties( );
            Indentation indentation8 = new Indentation( ) { Left = "4394", Hanging = "1418" };

            previousParagraphProperties8.Append( indentation8 );

            NumberingSymbolRunProperties numberingSymbolRunProperties8 = new NumberingSymbolRunProperties( );
            RunFonts runFonts14 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            numberingSymbolRunProperties8.Append( runFonts14 );

            level8.Append( startNumberingValue8 );
            level8.Append( numberingFormat8 );
            level8.Append( levelText8 );
            level8.Append( levelJustification8 );
            level8.Append( previousParagraphProperties8 );
            level8.Append( numberingSymbolRunProperties8 );

            //.............................................
            Level level9 = new Level( ) { LevelIndex = 8 };
            StartNumberingValue startNumberingValue9 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat9 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText9 = new LevelText( ) { Val = "%1.%2.%3.%4.%5.%6.%7.%8.%9" };
            LevelJustification levelJustification9 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties9 = new PreviousParagraphProperties( );
            Indentation indentation9 = new Indentation( ) { Left = "5102", Hanging = "1700" };

            previousParagraphProperties9.Append( indentation9 );

            NumberingSymbolRunProperties numberingSymbolRunProperties9 = new NumberingSymbolRunProperties( );
            RunFonts runFonts15 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            numberingSymbolRunProperties9.Append( runFonts15 );

            level9.Append( startNumberingValue9 );
            level9.Append( numberingFormat9 );
            level9.Append( levelText9 );
            level9.Append( levelJustification9 );
            level9.Append( previousParagraphProperties9 );
            level9.Append( numberingSymbolRunProperties9 );

            abstractNum1.Append( nsid1 );
            abstractNum1.Append( multiLevelType1 );
            abstractNum1.Append( templateCode1 );
            abstractNum1.Append( level1 );
            abstractNum1.Append( level2 );
            abstractNum1.Append( level3 );
            abstractNum1.Append( level4 );
            abstractNum1.Append( level5 );
            abstractNum1.Append( level6 );
            abstractNum1.Append( level7 );
            abstractNum1.Append( level8 );
            abstractNum1.Append( level9 );
            return abstractNum1;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private AbstractNum MakeAbstractNum02( )
        {
            AbstractNum abstractNum2 = new AbstractNum( ) { AbstractNumberId = 1 };

            Nsid nsid2 = new Nsid( ) { Val = "0935562F" };
            MultiLevelType multiLevelType2 = new MultiLevelType( ) { Val = MultiLevelValues.Multilevel };
            TemplateCode templateCode2 = new TemplateCode( ) { Val = "0409001D" };

            Level level10 = new Level( ) { LevelIndex = 0 };
            StartNumberingValue startNumberingValue10 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat10 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText10 = new LevelText( ) { Val = "%1" };
            LevelJustification levelJustification10 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties10 = new PreviousParagraphProperties( );
            Indentation indentation10 = new Indentation( ) { Left = "425", Hanging = "425" };

            previousParagraphProperties10.Append( indentation10 );

            level10.Append( startNumberingValue10 );
            level10.Append( numberingFormat10 );
            level10.Append( levelText10 );
            level10.Append( levelJustification10 );
            level10.Append( previousParagraphProperties10 );

            Level level11 = new Level( ) { LevelIndex = 1 };
            StartNumberingValue startNumberingValue11 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat11 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText11 = new LevelText( ) { Val = "%1.%2" };
            LevelJustification levelJustification11 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties11 = new PreviousParagraphProperties( );
            Indentation indentation11 = new Indentation( ) { Left = "992", Hanging = "567" };

            previousParagraphProperties11.Append( indentation11 );

            level11.Append( startNumberingValue11 );
            level11.Append( numberingFormat11 );
            level11.Append( levelText11 );
            level11.Append( levelJustification11 );
            level11.Append( previousParagraphProperties11 );

            Level level12 = new Level( ) { LevelIndex = 2 };
            StartNumberingValue startNumberingValue12 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat12 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText12 = new LevelText( ) { Val = "%1.%2.%3" };
            LevelJustification levelJustification12 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties12 = new PreviousParagraphProperties( );
            Indentation indentation12 = new Indentation( ) { Left = "1418", Hanging = "567" };

            previousParagraphProperties12.Append( indentation12 );

            level12.Append( startNumberingValue12 );
            level12.Append( numberingFormat12 );
            level12.Append( levelText12 );
            level12.Append( levelJustification12 );
            level12.Append( previousParagraphProperties12 );

            Level level13 = new Level( ) { LevelIndex = 3 };
            StartNumberingValue startNumberingValue13 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat13 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText13 = new LevelText( ) { Val = "%1.%2.%3.%4" };
            LevelJustification levelJustification13 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties13 = new PreviousParagraphProperties( );
            Indentation indentation13 = new Indentation( ) { Left = "1984", Hanging = "708" };

            previousParagraphProperties13.Append( indentation13 );

            level13.Append( startNumberingValue13 );
            level13.Append( numberingFormat13 );
            level13.Append( levelText13 );
            level13.Append( levelJustification13 );
            level13.Append( previousParagraphProperties13 );

            Level level14 = new Level( ) { LevelIndex = 4 };
            StartNumberingValue startNumberingValue14 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat14 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText14 = new LevelText( ) { Val = "%1.%2.%3.%4.%5" };
            LevelJustification levelJustification14 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties14 = new PreviousParagraphProperties( );
            Indentation indentation14 = new Indentation( ) { Left = "2551", Hanging = "850" };

            previousParagraphProperties14.Append( indentation14 );

            level14.Append( startNumberingValue14 );
            level14.Append( numberingFormat14 );
            level14.Append( levelText14 );
            level14.Append( levelJustification14 );
            level14.Append( previousParagraphProperties14 );

            Level level15 = new Level( ) { LevelIndex = 5 };
            StartNumberingValue startNumberingValue15 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat15 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText15 = new LevelText( ) { Val = "%1.%2.%3.%4.%5.%6" };
            LevelJustification levelJustification15 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties15 = new PreviousParagraphProperties( );
            Indentation indentation15 = new Indentation( ) { Left = "3260", Hanging = "1134" };

            previousParagraphProperties15.Append( indentation15 );

            level15.Append( startNumberingValue15 );
            level15.Append( numberingFormat15 );
            level15.Append( levelText15 );
            level15.Append( levelJustification15 );
            level15.Append( previousParagraphProperties15 );

            Level level16 = new Level( ) { LevelIndex = 6 };
            StartNumberingValue startNumberingValue16 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat16 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText16 = new LevelText( ) { Val = "%1.%2.%3.%4.%5.%6.%7" };
            LevelJustification levelJustification16 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties16 = new PreviousParagraphProperties( );
            Indentation indentation16 = new Indentation( ) { Left = "3827", Hanging = "1276" };

            previousParagraphProperties16.Append( indentation16 );

            level16.Append( startNumberingValue16 );
            level16.Append( numberingFormat16 );
            level16.Append( levelText16 );
            level16.Append( levelJustification16 );
            level16.Append( previousParagraphProperties16 );

            Level level17 = new Level( ) { LevelIndex = 7 };
            StartNumberingValue startNumberingValue17 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat17 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText17 = new LevelText( ) { Val = "%1.%2.%3.%4.%5.%6.%7.%8" };
            LevelJustification levelJustification17 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties17 = new PreviousParagraphProperties( );
            Indentation indentation17 = new Indentation( ) { Left = "4394", Hanging = "1418" };

            previousParagraphProperties17.Append( indentation17 );

            level17.Append( startNumberingValue17 );
            level17.Append( numberingFormat17 );
            level17.Append( levelText17 );
            level17.Append( levelJustification17 );
            level17.Append( previousParagraphProperties17 );

            Level level18 = new Level( ) { LevelIndex = 8 };
            StartNumberingValue startNumberingValue18 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat18 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText18 = new LevelText( ) { Val = "%1.%2.%3.%4.%5.%6.%7.%8.%9" };
            LevelJustification levelJustification18 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties18 = new PreviousParagraphProperties( );
            Indentation indentation18 = new Indentation( ) { Left = "5102", Hanging = "1700" };

            previousParagraphProperties18.Append( indentation18 );

            level18.Append( startNumberingValue18 );
            level18.Append( numberingFormat18 );
            level18.Append( levelText18 );
            level18.Append( levelJustification18 );
            level18.Append( previousParagraphProperties18 );

            abstractNum2.Append( nsid2 );
            abstractNum2.Append( multiLevelType2 );
            abstractNum2.Append( templateCode2 );
            abstractNum2.Append( level10 );
            abstractNum2.Append( level11 );
            abstractNum2.Append( level12 );
            abstractNum2.Append( level13 );
            abstractNum2.Append( level14 );
            abstractNum2.Append( level15 );
            abstractNum2.Append( level16 );
            abstractNum2.Append( level17 );
            abstractNum2.Append( level18 );

            return abstractNum2;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private AbstractNum MakeAbstractNum03( )
        {
            AbstractNum abstractNum3 = new AbstractNum( ) { AbstractNumberId = 2 };
            Nsid nsid3 = new Nsid( ) { Val = "0AB74251" };
            MultiLevelType multiLevelType3 = new MultiLevelType( ) { Val = MultiLevelValues.Multilevel };
            TemplateCode templateCode3 = new TemplateCode( ) { Val = "0409001D" };

            //.............................................
            Level level19 = new Level( ) { LevelIndex = 0 };
            StartNumberingValue startNumberingValue19 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat19 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText19 = new LevelText( ) { Val = "%1" };
            LevelJustification levelJustification19 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties19 = new PreviousParagraphProperties( );
            Indentation indentation19 = new Indentation( ) { Left = "425", Hanging = "425" };

            previousParagraphProperties19.Append( indentation19 );

            level19.Append( startNumberingValue19 );
            level19.Append( numberingFormat19 );
            level19.Append( levelText19 );
            level19.Append( levelJustification19 );
            level19.Append( previousParagraphProperties19 );

            //.............................................
            Level level20 = new Level( ) { LevelIndex = 1 };
            StartNumberingValue startNumberingValue20 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat20 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText20 = new LevelText( ) { Val = "%1.%2" };
            LevelJustification levelJustification20 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties20 = new PreviousParagraphProperties( );
            Indentation indentation20 = new Indentation( ) { Left = "992", Hanging = "567" };

            previousParagraphProperties20.Append( indentation20 );

            level20.Append( startNumberingValue20 );
            level20.Append( numberingFormat20 );
            level20.Append( levelText20 );
            level20.Append( levelJustification20 );
            level20.Append( previousParagraphProperties20 );

            //.............................................
            Level level21 = new Level( ) { LevelIndex = 2 };
            StartNumberingValue startNumberingValue21 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat21 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText21 = new LevelText( ) { Val = "%1.%2.%3" };
            LevelJustification levelJustification21 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties21 = new PreviousParagraphProperties( );
            Indentation indentation21 = new Indentation( ) { Left = "1418", Hanging = "567" };

            previousParagraphProperties21.Append( indentation21 );

            level21.Append( startNumberingValue21 );
            level21.Append( numberingFormat21 );
            level21.Append( levelText21 );
            level21.Append( levelJustification21 );
            level21.Append( previousParagraphProperties21 );

            //.............................................
            Level level22 = new Level( ) { LevelIndex = 3 };
            StartNumberingValue startNumberingValue22 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat22 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText22 = new LevelText( ) { Val = "%1.%2.%3.%4" };
            LevelJustification levelJustification22 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties22 = new PreviousParagraphProperties( );
            Indentation indentation22 = new Indentation( ) { Left = "1984", Hanging = "708" };

            previousParagraphProperties22.Append( indentation22 );

            level22.Append( startNumberingValue22 );
            level22.Append( numberingFormat22 );
            level22.Append( levelText22 );
            level22.Append( levelJustification22 );
            level22.Append( previousParagraphProperties22 );

            //.............................................
            Level level23 = new Level( ) { LevelIndex = 4 };
            StartNumberingValue startNumberingValue23 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat23 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText23 = new LevelText( ) { Val = "%1.%2.%3.%4.%5" };
            LevelJustification levelJustification23 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties23 = new PreviousParagraphProperties( );
            Indentation indentation23 = new Indentation( ) { Left = "2551", Hanging = "850" };

            previousParagraphProperties23.Append( indentation23 );

            level23.Append( startNumberingValue23 );
            level23.Append( numberingFormat23 );
            level23.Append( levelText23 );
            level23.Append( levelJustification23 );
            level23.Append( previousParagraphProperties23 );

            //.............................................
            Level level24 = new Level( ) { LevelIndex = 5 };
            StartNumberingValue startNumberingValue24 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat24 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText24 = new LevelText( ) { Val = "%1.%2.%3.%4.%5.%6" };
            LevelJustification levelJustification24 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties24 = new PreviousParagraphProperties( );
            Indentation indentation24 = new Indentation( ) { Left = "3260", Hanging = "1134" };

            previousParagraphProperties24.Append( indentation24 );

            level24.Append( startNumberingValue24 );
            level24.Append( numberingFormat24 );
            level24.Append( levelText24 );
            level24.Append( levelJustification24 );
            level24.Append( previousParagraphProperties24 );

            Level level25 = new Level( ) { LevelIndex = 6 };
            StartNumberingValue startNumberingValue25 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat25 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText25 = new LevelText( ) { Val = "%1.%2.%3.%4.%5.%6.%7" };
            LevelJustification levelJustification25 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties25 = new PreviousParagraphProperties( );
            Indentation indentation25 = new Indentation( ) { Left = "3827", Hanging = "1276" };

            previousParagraphProperties25.Append( indentation25 );

            level25.Append( startNumberingValue25 );
            level25.Append( numberingFormat25 );
            level25.Append( levelText25 );
            level25.Append( levelJustification25 );
            level25.Append( previousParagraphProperties25 );

            Level level26 = new Level( ) { LevelIndex = 7 };
            StartNumberingValue startNumberingValue26 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat26 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText26 = new LevelText( ) { Val = "%1.%2.%3.%4.%5.%6.%7.%8" };
            LevelJustification levelJustification26 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties26 = new PreviousParagraphProperties( );
            Indentation indentation26 = new Indentation( ) { Left = "4394", Hanging = "1418" };

            previousParagraphProperties26.Append( indentation26 );

            level26.Append( startNumberingValue26 );
            level26.Append( numberingFormat26 );
            level26.Append( levelText26 );
            level26.Append( levelJustification26 );
            level26.Append( previousParagraphProperties26 );

            Level level27 = new Level( ) { LevelIndex = 8 };
            StartNumberingValue startNumberingValue27 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat27 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText27 = new LevelText( ) { Val = "%1.%2.%3.%4.%5.%6.%7.%8.%9" };
            LevelJustification levelJustification27 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties27 = new PreviousParagraphProperties( );
            Indentation indentation27 = new Indentation( ) { Left = "5102", Hanging = "1700" };

            previousParagraphProperties27.Append( indentation27 );

            level27.Append( startNumberingValue27 );
            level27.Append( numberingFormat27 );
            level27.Append( levelText27 );
            level27.Append( levelJustification27 );
            level27.Append( previousParagraphProperties27 );

            abstractNum3.Append( nsid3 );
            abstractNum3.Append( multiLevelType3 );
            abstractNum3.Append( templateCode3 );
            abstractNum3.Append( level19 );
            abstractNum3.Append( level20 );
            abstractNum3.Append( level21 );
            abstractNum3.Append( level22 );
            abstractNum3.Append( level23 );
            abstractNum3.Append( level24 );
            abstractNum3.Append( level25 );
            abstractNum3.Append( level26 );
            abstractNum3.Append( level27 );
            return abstractNum3;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private AbstractNum MakeAbstractNum04( )
        {
            AbstractNum abstractNum4 = new AbstractNum( ) { AbstractNumberId = 3 };
            Nsid nsid4 = new Nsid( ) { Val = "18787621" };
            MultiLevelType multiLevelType4 = new MultiLevelType( ) { Val = MultiLevelValues.Multilevel };
            TemplateCode templateCode4 = new TemplateCode( ) { Val = "0409001D" };

            Level level28 = new Level( ) { LevelIndex = 0 };
            StartNumberingValue startNumberingValue28 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat28 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText28 = new LevelText( ) { Val = "%1" };
            LevelJustification levelJustification28 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties28 = new PreviousParagraphProperties( );
            Indentation indentation28 = new Indentation( ) { Left = "425", Hanging = "425" };

            previousParagraphProperties28.Append( indentation28 );

            level28.Append( startNumberingValue28 );
            level28.Append( numberingFormat28 );
            level28.Append( levelText28 );
            level28.Append( levelJustification28 );
            level28.Append( previousParagraphProperties28 );

            Level level29 = new Level( ) { LevelIndex = 1 };
            StartNumberingValue startNumberingValue29 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat29 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText29 = new LevelText( ) { Val = "%1.%2" };
            LevelJustification levelJustification29 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties29 = new PreviousParagraphProperties( );
            Indentation indentation29 = new Indentation( ) { Left = "992", Hanging = "567" };

            previousParagraphProperties29.Append( indentation29 );

            level29.Append( startNumberingValue29 );
            level29.Append( numberingFormat29 );
            level29.Append( levelText29 );
            level29.Append( levelJustification29 );
            level29.Append( previousParagraphProperties29 );

            Level level30 = new Level( ) { LevelIndex = 2 };
            StartNumberingValue startNumberingValue30 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat30 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText30 = new LevelText( ) { Val = "%1.%2.%3" };
            LevelJustification levelJustification30 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties30 = new PreviousParagraphProperties( );
            Indentation indentation30 = new Indentation( ) { Left = "1418", Hanging = "567" };

            previousParagraphProperties30.Append( indentation30 );

            level30.Append( startNumberingValue30 );
            level30.Append( numberingFormat30 );
            level30.Append( levelText30 );
            level30.Append( levelJustification30 );
            level30.Append( previousParagraphProperties30 );

            Level level31 = new Level( ) { LevelIndex = 3 };
            StartNumberingValue startNumberingValue31 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat31 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText31 = new LevelText( ) { Val = "%1.%2.%3.%4" };
            LevelJustification levelJustification31 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties31 = new PreviousParagraphProperties( );
            Indentation indentation31 = new Indentation( ) { Left = "1984", Hanging = "708" };

            previousParagraphProperties31.Append( indentation31 );

            level31.Append( startNumberingValue31 );
            level31.Append( numberingFormat31 );
            level31.Append( levelText31 );
            level31.Append( levelJustification31 );
            level31.Append( previousParagraphProperties31 );

            Level level32 = new Level( ) { LevelIndex = 4 };
            StartNumberingValue startNumberingValue32 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat32 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText32 = new LevelText( ) { Val = "%1.%2.%3.%4.%5" };
            LevelJustification levelJustification32 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties32 = new PreviousParagraphProperties( );
            Indentation indentation32 = new Indentation( ) { Left = "2551", Hanging = "850" };

            previousParagraphProperties32.Append( indentation32 );

            level32.Append( startNumberingValue32 );
            level32.Append( numberingFormat32 );
            level32.Append( levelText32 );
            level32.Append( levelJustification32 );
            level32.Append( previousParagraphProperties32 );

            Level level33 = new Level( ) { LevelIndex = 5 };
            StartNumberingValue startNumberingValue33 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat33 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText33 = new LevelText( ) { Val = "%1.%2.%3.%4.%5.%6" };
            LevelJustification levelJustification33 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties33 = new PreviousParagraphProperties( );
            Indentation indentation33 = new Indentation( ) { Left = "3260", Hanging = "1134" };

            previousParagraphProperties33.Append( indentation33 );

            level33.Append( startNumberingValue33 );
            level33.Append( numberingFormat33 );
            level33.Append( levelText33 );
            level33.Append( levelJustification33 );
            level33.Append( previousParagraphProperties33 );

            Level level34 = new Level( ) { LevelIndex = 6 };
            StartNumberingValue startNumberingValue34 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat34 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText34 = new LevelText( ) { Val = "%1.%2.%3.%4.%5.%6.%7" };
            LevelJustification levelJustification34 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties34 = new PreviousParagraphProperties( );
            Indentation indentation34 = new Indentation( ) { Left = "3827", Hanging = "1276" };

            previousParagraphProperties34.Append( indentation34 );

            level34.Append( startNumberingValue34 );
            level34.Append( numberingFormat34 );
            level34.Append( levelText34 );
            level34.Append( levelJustification34 );
            level34.Append( previousParagraphProperties34 );

            Level level35 = new Level( ) { LevelIndex = 7 };
            StartNumberingValue startNumberingValue35 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat35 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText35 = new LevelText( ) { Val = "%1.%2.%3.%4.%5.%6.%7.%8" };
            LevelJustification levelJustification35 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties35 = new PreviousParagraphProperties( );
            Indentation indentation35 = new Indentation( ) { Left = "4394", Hanging = "1418" };

            previousParagraphProperties35.Append( indentation35 );

            level35.Append( startNumberingValue35 );
            level35.Append( numberingFormat35 );
            level35.Append( levelText35 );
            level35.Append( levelJustification35 );
            level35.Append( previousParagraphProperties35 );

            Level level36 = new Level( ) { LevelIndex = 8 };
            StartNumberingValue startNumberingValue36 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat36 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText36 = new LevelText( ) { Val = "%1.%2.%3.%4.%5.%6.%7.%8.%9" };
            LevelJustification levelJustification36 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties36 = new PreviousParagraphProperties( );
            Indentation indentation36 = new Indentation( ) { Left = "5102", Hanging = "1700" };

            previousParagraphProperties36.Append( indentation36 );

            level36.Append( startNumberingValue36 );
            level36.Append( numberingFormat36 );
            level36.Append( levelText36 );
            level36.Append( levelJustification36 );
            level36.Append( previousParagraphProperties36 );

            abstractNum4.Append( nsid4 );
            abstractNum4.Append( multiLevelType4 );
            abstractNum4.Append( templateCode4 );
            abstractNum4.Append( level28 );
            abstractNum4.Append( level29 );
            abstractNum4.Append( level30 );
            abstractNum4.Append( level31 );
            abstractNum4.Append( level32 );
            abstractNum4.Append( level33 );
            abstractNum4.Append( level34 );
            abstractNum4.Append( level35 );
            abstractNum4.Append( level36 );
            return abstractNum4;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private AbstractNum MakeAbstractNum05( )
        {
            AbstractNum abstractNum5 = new AbstractNum( ) { AbstractNumberId = 4 };
            Nsid nsid5 = new Nsid( ) { Val = "5B7015BB" };
            MultiLevelType multiLevelType5 = new MultiLevelType( ) { Val = MultiLevelValues.Multilevel };
            TemplateCode templateCode5 = new TemplateCode( ) { Val = "0409001D" };

            Level level37 = new Level( ) { LevelIndex = 0 };
            StartNumberingValue startNumberingValue37 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat37 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText37 = new LevelText( ) { Val = "%1" };
            LevelJustification levelJustification37 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties37 = new PreviousParagraphProperties( );
            Indentation indentation37 = new Indentation( ) { Left = "425", Hanging = "425" };

            previousParagraphProperties37.Append( indentation37 );

            level37.Append( startNumberingValue37 );
            level37.Append( numberingFormat37 );
            level37.Append( levelText37 );
            level37.Append( levelJustification37 );
            level37.Append( previousParagraphProperties37 );

            Level level38 = new Level( ) { LevelIndex = 1 };
            StartNumberingValue startNumberingValue38 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat38 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText38 = new LevelText( ) { Val = "%1.%2" };
            LevelJustification levelJustification38 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties38 = new PreviousParagraphProperties( );
            Indentation indentation38 = new Indentation( ) { Left = "992", Hanging = "567" };

            previousParagraphProperties38.Append( indentation38 );

            level38.Append( startNumberingValue38 );
            level38.Append( numberingFormat38 );
            level38.Append( levelText38 );
            level38.Append( levelJustification38 );
            level38.Append( previousParagraphProperties38 );

            Level level39 = new Level( ) { LevelIndex = 2 };
            StartNumberingValue startNumberingValue39 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat39 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText39 = new LevelText( ) { Val = "%1.%2.%3" };
            LevelJustification levelJustification39 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties39 = new PreviousParagraphProperties( );
            Indentation indentation39 = new Indentation( ) { Left = "1418", Hanging = "567" };

            previousParagraphProperties39.Append( indentation39 );

            level39.Append( startNumberingValue39 );
            level39.Append( numberingFormat39 );
            level39.Append( levelText39 );
            level39.Append( levelJustification39 );
            level39.Append( previousParagraphProperties39 );

            Level level40 = new Level( ) { LevelIndex = 3 };
            StartNumberingValue startNumberingValue40 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat40 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText40 = new LevelText( ) { Val = "%1.%2.%3.%4" };
            LevelJustification levelJustification40 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties40 = new PreviousParagraphProperties( );
            Indentation indentation40 = new Indentation( ) { Left = "1984", Hanging = "708" };

            previousParagraphProperties40.Append( indentation40 );

            level40.Append( startNumberingValue40 );
            level40.Append( numberingFormat40 );
            level40.Append( levelText40 );
            level40.Append( levelJustification40 );
            level40.Append( previousParagraphProperties40 );

            Level level41 = new Level( ) { LevelIndex = 4 };
            StartNumberingValue startNumberingValue41 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat41 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText41 = new LevelText( ) { Val = "%1.%2.%3.%4.%5" };
            LevelJustification levelJustification41 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties41 = new PreviousParagraphProperties( );
            Indentation indentation41 = new Indentation( ) { Left = "2551", Hanging = "850" };

            previousParagraphProperties41.Append( indentation41 );

            level41.Append( startNumberingValue41 );
            level41.Append( numberingFormat41 );
            level41.Append( levelText41 );
            level41.Append( levelJustification41 );
            level41.Append( previousParagraphProperties41 );

            Level level42 = new Level( ) { LevelIndex = 5 };
            StartNumberingValue startNumberingValue42 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat42 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText42 = new LevelText( ) { Val = "%1.%2.%3.%4.%5.%6" };
            LevelJustification levelJustification42 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties42 = new PreviousParagraphProperties( );
            Indentation indentation42 = new Indentation( ) { Left = "3260", Hanging = "1134" };

            previousParagraphProperties42.Append( indentation42 );

            level42.Append( startNumberingValue42 );
            level42.Append( numberingFormat42 );
            level42.Append( levelText42 );
            level42.Append( levelJustification42 );
            level42.Append( previousParagraphProperties42 );

            Level level43 = new Level( ) { LevelIndex = 6 };
            StartNumberingValue startNumberingValue43 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat43 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText43 = new LevelText( ) { Val = "%1.%2.%3.%4.%5.%6.%7" };
            LevelJustification levelJustification43 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties43 = new PreviousParagraphProperties( );
            Indentation indentation43 = new Indentation( ) { Left = "3827", Hanging = "1276" };

            previousParagraphProperties43.Append( indentation43 );

            level43.Append( startNumberingValue43 );
            level43.Append( numberingFormat43 );
            level43.Append( levelText43 );
            level43.Append( levelJustification43 );
            level43.Append( previousParagraphProperties43 );

            Level level44 = new Level( ) { LevelIndex = 7 };
            StartNumberingValue startNumberingValue44 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat44 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText44 = new LevelText( ) { Val = "%1.%2.%3.%4.%5.%6.%7.%8" };
            LevelJustification levelJustification44 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties44 = new PreviousParagraphProperties( );
            Indentation indentation44 = new Indentation( ) { Left = "4394", Hanging = "1418" };

            previousParagraphProperties44.Append( indentation44 );

            level44.Append( startNumberingValue44 );
            level44.Append( numberingFormat44 );
            level44.Append( levelText44 );
            level44.Append( levelJustification44 );
            level44.Append( previousParagraphProperties44 );

            Level level45 = new Level( ) { LevelIndex = 8 };
            StartNumberingValue startNumberingValue45 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat45 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText45 = new LevelText( ) { Val = "%1.%2.%3.%4.%5.%6.%7.%8.%9" };
            LevelJustification levelJustification45 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties45 = new PreviousParagraphProperties( );
            Indentation indentation45 = new Indentation( ) { Left = "5102", Hanging = "1700" };

            previousParagraphProperties45.Append( indentation45 );

            level45.Append( startNumberingValue45 );
            level45.Append( numberingFormat45 );
            level45.Append( levelText45 );
            level45.Append( levelJustification45 );
            level45.Append( previousParagraphProperties45 );

            abstractNum5.Append( nsid5 );
            abstractNum5.Append( multiLevelType5 );
            abstractNum5.Append( templateCode5 );
            abstractNum5.Append( level37 );
            abstractNum5.Append( level38 );
            abstractNum5.Append( level39 );
            abstractNum5.Append( level40 );
            abstractNum5.Append( level41 );
            abstractNum5.Append( level42 );
            abstractNum5.Append( level43 );
            abstractNum5.Append( level44 );
            abstractNum5.Append( level45 );
            return abstractNum5;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private AbstractNum MakeAbstractNum06( )
        {
            AbstractNum abstractNum6 = new AbstractNum( ) { AbstractNumberId = 5 };
            Nsid nsid6 = new Nsid( ) { Val = "6E212BF4" };
            MultiLevelType multiLevelType6 = new MultiLevelType( ) { Val = MultiLevelValues.Multilevel };
            TemplateCode templateCode6 = new TemplateCode( ) { Val = "0409001D" };

            Level level46 = new Level( ) { LevelIndex = 0 };
            StartNumberingValue startNumberingValue46 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat46 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText46 = new LevelText( ) { Val = "%1" };
            LevelJustification levelJustification46 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties46 = new PreviousParagraphProperties( );
            Indentation indentation46 = new Indentation( ) { Left = "425", Hanging = "425" };

            previousParagraphProperties46.Append( indentation46 );

            level46.Append( startNumberingValue46 );
            level46.Append( numberingFormat46 );
            level46.Append( levelText46 );
            level46.Append( levelJustification46 );
            level46.Append( previousParagraphProperties46 );

            Level level47 = new Level( ) { LevelIndex = 1 };
            StartNumberingValue startNumberingValue47 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat47 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText47 = new LevelText( ) { Val = "%1.%2" };
            LevelJustification levelJustification47 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties47 = new PreviousParagraphProperties( );
            Indentation indentation47 = new Indentation( ) { Left = "992", Hanging = "567" };

            previousParagraphProperties47.Append( indentation47 );

            level47.Append( startNumberingValue47 );
            level47.Append( numberingFormat47 );
            level47.Append( levelText47 );
            level47.Append( levelJustification47 );
            level47.Append( previousParagraphProperties47 );

            Level level48 = new Level( ) { LevelIndex = 2 };
            StartNumberingValue startNumberingValue48 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat48 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText48 = new LevelText( ) { Val = "%1.%2.%3" };
            LevelJustification levelJustification48 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties48 = new PreviousParagraphProperties( );
            Indentation indentation48 = new Indentation( ) { Left = "1418", Hanging = "567" };

            previousParagraphProperties48.Append( indentation48 );

            level48.Append( startNumberingValue48 );
            level48.Append( numberingFormat48 );
            level48.Append( levelText48 );
            level48.Append( levelJustification48 );
            level48.Append( previousParagraphProperties48 );

            Level level49 = new Level( ) { LevelIndex = 3 };
            StartNumberingValue startNumberingValue49 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat49 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText49 = new LevelText( ) { Val = "%1.%2.%3.%4" };
            LevelJustification levelJustification49 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties49 = new PreviousParagraphProperties( );
            Indentation indentation49 = new Indentation( ) { Left = "1984", Hanging = "708" };

            previousParagraphProperties49.Append( indentation49 );

            level49.Append( startNumberingValue49 );
            level49.Append( numberingFormat49 );
            level49.Append( levelText49 );
            level49.Append( levelJustification49 );
            level49.Append( previousParagraphProperties49 );

            Level level50 = new Level( ) { LevelIndex = 4 };
            StartNumberingValue startNumberingValue50 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat50 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText50 = new LevelText( ) { Val = "%1.%2.%3.%4.%5" };
            LevelJustification levelJustification50 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties50 = new PreviousParagraphProperties( );
            Indentation indentation50 = new Indentation( ) { Left = "2551", Hanging = "850" };

            previousParagraphProperties50.Append( indentation50 );

            level50.Append( startNumberingValue50 );
            level50.Append( numberingFormat50 );
            level50.Append( levelText50 );
            level50.Append( levelJustification50 );
            level50.Append( previousParagraphProperties50 );

            Level level51 = new Level( ) { LevelIndex = 5 };
            StartNumberingValue startNumberingValue51 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat51 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText51 = new LevelText( ) { Val = "%1.%2.%3.%4.%5.%6" };
            LevelJustification levelJustification51 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties51 = new PreviousParagraphProperties( );
            Indentation indentation51 = new Indentation( ) { Left = "3260", Hanging = "1134" };

            previousParagraphProperties51.Append( indentation51 );

            level51.Append( startNumberingValue51 );
            level51.Append( numberingFormat51 );
            level51.Append( levelText51 );
            level51.Append( levelJustification51 );
            level51.Append( previousParagraphProperties51 );

            Level level52 = new Level( ) { LevelIndex = 6 };
            StartNumberingValue startNumberingValue52 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat52 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText52 = new LevelText( ) { Val = "%1.%2.%3.%4.%5.%6.%7" };
            LevelJustification levelJustification52 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties52 = new PreviousParagraphProperties( );
            Indentation indentation52 = new Indentation( ) { Left = "3827", Hanging = "1276" };

            previousParagraphProperties52.Append( indentation52 );

            level52.Append( startNumberingValue52 );
            level52.Append( numberingFormat52 );
            level52.Append( levelText52 );
            level52.Append( levelJustification52 );
            level52.Append( previousParagraphProperties52 );

            Level level53 = new Level( ) { LevelIndex = 7 };
            StartNumberingValue startNumberingValue53 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat53 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText53 = new LevelText( ) { Val = "%1.%2.%3.%4.%5.%6.%7.%8" };
            LevelJustification levelJustification53 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties53 = new PreviousParagraphProperties( );
            Indentation indentation53 = new Indentation( ) { Left = "4394", Hanging = "1418" };

            previousParagraphProperties53.Append( indentation53 );

            level53.Append( startNumberingValue53 );
            level53.Append( numberingFormat53 );
            level53.Append( levelText53 );
            level53.Append( levelJustification53 );
            level53.Append( previousParagraphProperties53 );

            Level level54 = new Level( ) { LevelIndex = 8 };
            StartNumberingValue startNumberingValue54 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat54 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText54 = new LevelText( ) { Val = "%1.%2.%3.%4.%5.%6.%7.%8.%9" };
            LevelJustification levelJustification54 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties54 = new PreviousParagraphProperties( );
            Indentation indentation54 = new Indentation( ) { Left = "5102", Hanging = "1700" };

            previousParagraphProperties54.Append( indentation54 );

            level54.Append( startNumberingValue54 );
            level54.Append( numberingFormat54 );
            level54.Append( levelText54 );
            level54.Append( levelJustification54 );
            level54.Append( previousParagraphProperties54 );

            abstractNum6.Append( nsid6 );
            abstractNum6.Append( multiLevelType6 );
            abstractNum6.Append( templateCode6 );
            abstractNum6.Append( level46 );
            abstractNum6.Append( level47 );
            abstractNum6.Append( level48 );
            abstractNum6.Append( level49 );
            abstractNum6.Append( level50 );
            abstractNum6.Append( level51 );
            abstractNum6.Append( level52 );
            abstractNum6.Append( level53 );
            abstractNum6.Append( level54 );
            return abstractNum6;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private AbstractNum MakeAbstractNum07( )
        {
            AbstractNum abstractNum7 = new AbstractNum( ) { AbstractNumberId = 6 };
            Nsid nsid7 = new Nsid( ) { Val = "75480A0E" };
            MultiLevelType multiLevelType7 = new MultiLevelType( ) { Val = MultiLevelValues.Multilevel };
            TemplateCode templateCode7 = new TemplateCode( ) { Val = "0409001D" };

            Level level55 = new Level( ) { LevelIndex = 0 };
            StartNumberingValue startNumberingValue55 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat55 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText55 = new LevelText( ) { Val = "%1" };
            LevelJustification levelJustification55 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties55 = new PreviousParagraphProperties( );
            Indentation indentation55 = new Indentation( ) { Left = "425", Hanging = "425" };

            previousParagraphProperties55.Append( indentation55 );

            level55.Append( startNumberingValue55 );
            level55.Append( numberingFormat55 );
            level55.Append( levelText55 );
            level55.Append( levelJustification55 );
            level55.Append( previousParagraphProperties55 );

            Level level56 = new Level( ) { LevelIndex = 1 };
            StartNumberingValue startNumberingValue56 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat56 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText56 = new LevelText( ) { Val = "%1.%2" };
            LevelJustification levelJustification56 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties56 = new PreviousParagraphProperties( );
            Indentation indentation56 = new Indentation( ) { Left = "992", Hanging = "567" };

            previousParagraphProperties56.Append( indentation56 );

            level56.Append( startNumberingValue56 );
            level56.Append( numberingFormat56 );
            level56.Append( levelText56 );
            level56.Append( levelJustification56 );
            level56.Append( previousParagraphProperties56 );

            Level level57 = new Level( ) { LevelIndex = 2 };
            StartNumberingValue startNumberingValue57 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat57 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText57 = new LevelText( ) { Val = "%1.%2.%3" };
            LevelJustification levelJustification57 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties57 = new PreviousParagraphProperties( );
            Indentation indentation57 = new Indentation( ) { Left = "1418", Hanging = "567" };

            previousParagraphProperties57.Append( indentation57 );

            level57.Append( startNumberingValue57 );
            level57.Append( numberingFormat57 );
            level57.Append( levelText57 );
            level57.Append( levelJustification57 );
            level57.Append( previousParagraphProperties57 );

            Level level58 = new Level( ) { LevelIndex = 3 };
            StartNumberingValue startNumberingValue58 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat58 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText58 = new LevelText( ) { Val = "%1.%2.%3.%4" };
            LevelJustification levelJustification58 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties58 = new PreviousParagraphProperties( );
            Indentation indentation58 = new Indentation( ) { Left = "1984", Hanging = "708" };

            previousParagraphProperties58.Append( indentation58 );

            level58.Append( startNumberingValue58 );
            level58.Append( numberingFormat58 );
            level58.Append( levelText58 );
            level58.Append( levelJustification58 );
            level58.Append( previousParagraphProperties58 );

            Level level59 = new Level( ) { LevelIndex = 4 };
            StartNumberingValue startNumberingValue59 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat59 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText59 = new LevelText( ) { Val = "%1.%2.%3.%4.%5" };
            LevelJustification levelJustification59 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties59 = new PreviousParagraphProperties( );
            Indentation indentation59 = new Indentation( ) { Left = "2551", Hanging = "850" };

            previousParagraphProperties59.Append( indentation59 );

            level59.Append( startNumberingValue59 );
            level59.Append( numberingFormat59 );
            level59.Append( levelText59 );
            level59.Append( levelJustification59 );
            level59.Append( previousParagraphProperties59 );

            Level level60 = new Level( ) { LevelIndex = 5 };
            StartNumberingValue startNumberingValue60 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat60 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText60 = new LevelText( ) { Val = "%1.%2.%3.%4.%5.%6" };
            LevelJustification levelJustification60 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties60 = new PreviousParagraphProperties( );
            Indentation indentation60 = new Indentation( ) { Left = "3260", Hanging = "1134" };

            previousParagraphProperties60.Append( indentation60 );

            level60.Append( startNumberingValue60 );
            level60.Append( numberingFormat60 );
            level60.Append( levelText60 );
            level60.Append( levelJustification60 );
            level60.Append( previousParagraphProperties60 );

            Level level61 = new Level( ) { LevelIndex = 6 };
            StartNumberingValue startNumberingValue61 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat61 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText61 = new LevelText( ) { Val = "%1.%2.%3.%4.%5.%6.%7" };
            LevelJustification levelJustification61 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties61 = new PreviousParagraphProperties( );
            Indentation indentation61 = new Indentation( ) { Left = "3827", Hanging = "1276" };

            previousParagraphProperties61.Append( indentation61 );

            level61.Append( startNumberingValue61 );
            level61.Append( numberingFormat61 );
            level61.Append( levelText61 );
            level61.Append( levelJustification61 );
            level61.Append( previousParagraphProperties61 );

            Level level62 = new Level( ) { LevelIndex = 7 };
            StartNumberingValue startNumberingValue62 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat62 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText62 = new LevelText( ) { Val = "%1.%2.%3.%4.%5.%6.%7.%8" };
            LevelJustification levelJustification62 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties62 = new PreviousParagraphProperties( );
            Indentation indentation62 = new Indentation( ) { Left = "4394", Hanging = "1418" };

            previousParagraphProperties62.Append( indentation62 );

            level62.Append( startNumberingValue62 );
            level62.Append( numberingFormat62 );
            level62.Append( levelText62 );
            level62.Append( levelJustification62 );
            level62.Append( previousParagraphProperties62 );

            Level level63 = new Level( ) { LevelIndex = 8 };
            StartNumberingValue startNumberingValue63 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat63 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText63 = new LevelText( ) { Val = "%1.%2.%3.%4.%5.%6.%7.%8.%9" };
            LevelJustification levelJustification63 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties63 = new PreviousParagraphProperties( );
            Indentation indentation63 = new Indentation( ) { Left = "5102", Hanging = "1700" };

            previousParagraphProperties63.Append( indentation63 );

            level63.Append( startNumberingValue63 );
            level63.Append( numberingFormat63 );
            level63.Append( levelText63 );
            level63.Append( levelJustification63 );
            level63.Append( previousParagraphProperties63 );

            abstractNum7.Append( nsid7 );
            abstractNum7.Append( multiLevelType7 );
            abstractNum7.Append( templateCode7 );
            abstractNum7.Append( level55 );
            abstractNum7.Append( level56 );
            abstractNum7.Append( level57 );
            abstractNum7.Append( level58 );
            abstractNum7.Append( level59 );
            abstractNum7.Append( level60 );
            abstractNum7.Append( level61 );
            abstractNum7.Append( level62 );
            abstractNum7.Append( level63 );
            return abstractNum7;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private AbstractNum MakeAbstractNum08( )
        {
            AbstractNum abstractNum8 = new AbstractNum( ) { AbstractNumberId = 7 };
            
            Nsid nsid8 = new Nsid( ) { Val = "7A6827C2" };
            
            MultiLevelType multiLevelType8 = new MultiLevelType( ) { Val = MultiLevelValues.Multilevel };

            TemplateCode templateCode8 = new TemplateCode( ) { Val = "0409001D" };

            Level level64 = new Level( ) { LevelIndex = 0 };
            StartNumberingValue startNumberingValue64 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat64 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText64 = new LevelText( ) { Val = "%1" };
            LevelJustification levelJustification64 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties64 = new PreviousParagraphProperties( );
            Indentation indentation64 = new Indentation( ) { Left = "425", Hanging = "425" };

            previousParagraphProperties64.Append( indentation64 );

            level64.Append( startNumberingValue64 );
            level64.Append( numberingFormat64 );
            level64.Append( levelText64 );
            level64.Append( levelJustification64 );
            level64.Append( previousParagraphProperties64 );

            Level level65 = new Level( ) { LevelIndex = 1 };
            StartNumberingValue startNumberingValue65 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat65 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText65 = new LevelText( ) { Val = "%1.%2" };
            LevelJustification levelJustification65 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties65 = new PreviousParagraphProperties( );
            Indentation indentation65 = new Indentation( ) { Left = "992", Hanging = "567" };

            previousParagraphProperties65.Append( indentation65 );

            level65.Append( startNumberingValue65 );
            level65.Append( numberingFormat65 );
            level65.Append( levelText65 );
            level65.Append( levelJustification65 );
            level65.Append( previousParagraphProperties65 );

            Level level66 = new Level( ) { LevelIndex = 2 };
            StartNumberingValue startNumberingValue66 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat66 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText66 = new LevelText( ) { Val = "%1.%2.%3" };
            LevelJustification levelJustification66 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties66 = new PreviousParagraphProperties( );
            Indentation indentation66 = new Indentation( ) { Left = "1418", Hanging = "567" };

            previousParagraphProperties66.Append( indentation66 );

            level66.Append( startNumberingValue66 );
            level66.Append( numberingFormat66 );
            level66.Append( levelText66 );
            level66.Append( levelJustification66 );
            level66.Append( previousParagraphProperties66 );

            Level level67 = new Level( ) { LevelIndex = 3 };
            StartNumberingValue startNumberingValue67 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat67 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText67 = new LevelText( ) { Val = "%1.%2.%3.%4" };
            LevelJustification levelJustification67 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties67 = new PreviousParagraphProperties( );
            Indentation indentation67 = new Indentation( ) { Left = "1984", Hanging = "708" };

            previousParagraphProperties67.Append( indentation67 );

            level67.Append( startNumberingValue67 );
            level67.Append( numberingFormat67 );
            level67.Append( levelText67 );
            level67.Append( levelJustification67 );
            level67.Append( previousParagraphProperties67 );

            Level level68 = new Level( ) { LevelIndex = 4 };
            StartNumberingValue startNumberingValue68 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat68 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText68 = new LevelText( ) { Val = "%1.%2.%3.%4.%5" };
            LevelJustification levelJustification68 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties68 = new PreviousParagraphProperties( );
            Indentation indentation68 = new Indentation( ) { Left = "2551", Hanging = "850" };

            previousParagraphProperties68.Append( indentation68 );

            level68.Append( startNumberingValue68 );
            level68.Append( numberingFormat68 );
            level68.Append( levelText68 );
            level68.Append( levelJustification68 );
            level68.Append( previousParagraphProperties68 );

            Level level69 = new Level( ) { LevelIndex = 5 };
            StartNumberingValue startNumberingValue69 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat69 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText69 = new LevelText( ) { Val = "%1.%2.%3.%4.%5.%6" };
            LevelJustification levelJustification69 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties69 = new PreviousParagraphProperties( );
            Indentation indentation69 = new Indentation( ) { Left = "3260", Hanging = "1134" };

            previousParagraphProperties69.Append( indentation69 );

            level69.Append( startNumberingValue69 );
            level69.Append( numberingFormat69 );
            level69.Append( levelText69 );
            level69.Append( levelJustification69 );
            level69.Append( previousParagraphProperties69 );

            Level level70 = new Level( ) { LevelIndex = 6 };
            StartNumberingValue startNumberingValue70 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat70 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText70 = new LevelText( ) { Val = "%1.%2.%3.%4.%5.%6.%7" };
            LevelJustification levelJustification70 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties70 = new PreviousParagraphProperties( );
            Indentation indentation70 = new Indentation( ) { Left = "3827", Hanging = "1276" };

            previousParagraphProperties70.Append( indentation70 );

            level70.Append( startNumberingValue70 );
            level70.Append( numberingFormat70 );
            level70.Append( levelText70 );
            level70.Append( levelJustification70 );
            level70.Append( previousParagraphProperties70 );

            Level level71 = new Level( ) { LevelIndex = 7 };
            StartNumberingValue startNumberingValue71 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat71 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText71 = new LevelText( ) { Val = "%1.%2.%3.%4.%5.%6.%7.%8" };
            LevelJustification levelJustification71 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties71 = new PreviousParagraphProperties( );
            Indentation indentation71 = new Indentation( ) { Left = "4394", Hanging = "1418" };

            previousParagraphProperties71.Append( indentation71 );

            level71.Append( startNumberingValue71 );
            level71.Append( numberingFormat71 );
            level71.Append( levelText71 );
            level71.Append( levelJustification71 );
            level71.Append( previousParagraphProperties71 );

            Level level72 = new Level( ) { LevelIndex = 8 };
            StartNumberingValue startNumberingValue72 = new StartNumberingValue( ) { Val = 1 };
            NumberingFormat numberingFormat72 = new NumberingFormat( ) { Val = NumberFormatValues.Decimal };
            LevelText levelText72 = new LevelText( ) { Val = "%1.%2.%3.%4.%5.%6.%7.%8.%9" };
            LevelJustification levelJustification72 = new LevelJustification( ) { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties72 = new PreviousParagraphProperties( );
            Indentation indentation72 = new Indentation( ) { Left = "5102", Hanging = "1700" };

            previousParagraphProperties72.Append( indentation72 );

            level72.Append( startNumberingValue72 );
            level72.Append( numberingFormat72 );
            level72.Append( levelText72 );
            level72.Append( levelJustification72 );
            level72.Append( previousParagraphProperties72 );

            abstractNum8.Append( nsid8 );
            abstractNum8.Append( multiLevelType8 );
            abstractNum8.Append( templateCode8 );
            abstractNum8.Append( level64 );
            abstractNum8.Append( level65 );
            abstractNum8.Append( level66 );
            abstractNum8.Append( level67 );
            abstractNum8.Append( level68 );
            abstractNum8.Append( level69 );
            abstractNum8.Append( level70 );
            abstractNum8.Append( level71 );
            abstractNum8.Append( level72 );
            return abstractNum8;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Numbering NewNumbering( )
        {
            Numbering numbering = new Numbering( ) { MCAttributes = new MarkupCompatibilityAttributes( ) { Ignorable = "w14 wp14" } };

            numbering.AddNamespaceDeclaration( "wpc", "http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas" );
            numbering.AddNamespaceDeclaration( "mc", "http://schemas.openxmlformats.org/markup-compatibility/2006" );
            numbering.AddNamespaceDeclaration( "o", "urn:schemas-microsoft-com:office:office" );
            numbering.AddNamespaceDeclaration( "r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships" );
            numbering.AddNamespaceDeclaration( "m", "http://schemas.openxmlformats.org/officeDocument/2006/math" );
            numbering.AddNamespaceDeclaration( "v", "urn:schemas-microsoft-com:vml" );
            numbering.AddNamespaceDeclaration( "wp14", "http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing" );
            numbering.AddNamespaceDeclaration( "wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing" );
            numbering.AddNamespaceDeclaration( "w10", "urn:schemas-microsoft-com:office:word" );
            numbering.AddNamespaceDeclaration( "w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main" );
            numbering.AddNamespaceDeclaration( "w14", "http://schemas.microsoft.com/office/word/2010/wordml" );
            numbering.AddNamespaceDeclaration( "wpg", "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup" );
            numbering.AddNamespaceDeclaration( "wpi", "http://schemas.microsoft.com/office/word/2010/wordprocessingInk" );
            numbering.AddNamespaceDeclaration( "wne", "http://schemas.microsoft.com/office/word/2006/wordml" );
            numbering.AddNamespaceDeclaration( "wps", "http://schemas.microsoft.com/office/word/2010/wordprocessingShape" );
            
            return numbering;
        }

        //.....................................................................
    }
}
