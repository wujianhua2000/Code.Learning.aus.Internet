﻿using System;
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
    class OpenDocxSettingsPart
    {
        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="settingsPART"></param>
        public static void Generate( DocumentSettingsPart SettingsPART )
        {
            OpenDocxSettingsPart openxml = new OpenDocxSettingsPart( );

            openxml.GenerateSettingsPart( SettingsPART );

            return;
        }

        //.....................................................................
        /// <summary>
        /// Generates content of settingsPART.
        /// </summary>
        /// <param name="settingsPART"></param>
        private void GenerateSettingsPart( DocumentSettingsPart settingsPART )
        {
            Settings settings1 = new Settings( ) { MCAttributes = new MarkupCompatibilityAttributes( ) { Ignorable = "w14" } };

            settings1.AddNamespaceDeclaration( "mc", "http://schemas.openxmlformats.org/markup-compatibility/2006" );
            settings1.AddNamespaceDeclaration( "o", "urn:schemas-microsoft-com:office:office" );
            settings1.AddNamespaceDeclaration( "r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships" );
            settings1.AddNamespaceDeclaration( "m", "http://schemas.openxmlformats.org/officeDocument/2006/math" );
            settings1.AddNamespaceDeclaration( "v", "urn:schemas-microsoft-com:vml" );
            settings1.AddNamespaceDeclaration( "w10", "urn:schemas-microsoft-com:office:word" );
            settings1.AddNamespaceDeclaration( "w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main" );
            settings1.AddNamespaceDeclaration( "w14", "http://schemas.microsoft.com/office/word/2010/wordml" );
            settings1.AddNamespaceDeclaration( "sl", "http://schemas.openxmlformats.org/schemaLibrary/2006/main" );
            
            Zoom zoom1 = new Zoom( ) { Percent = "130" };
            BordersDoNotSurroundHeader bordersDoNotSurroundHeader1 = new BordersDoNotSurroundHeader( );
            BordersDoNotSurroundFooter bordersDoNotSurroundFooter1 = new BordersDoNotSurroundFooter( );
            ProofState proofState1 = new ProofState( ) { Spelling = ProofingStateValues.Clean, Grammar = ProofingStateValues.Clean };
            DefaultTabStop defaultTabStop1 = new DefaultTabStop( ) { Val = 420 };
            DrawingGridVerticalSpacing drawingGridVerticalSpacing1 = new DrawingGridVerticalSpacing( ) { Val = "156" };
            DisplayHorizontalDrawingGrid displayHorizontalDrawingGrid1 = new DisplayHorizontalDrawingGrid( ) { Val = 0 };
            DisplayVerticalDrawingGrid displayVerticalDrawingGrid1 = new DisplayVerticalDrawingGrid( ) { Val = 2 };
            CharacterSpacingControl characterSpacingControl1 = new CharacterSpacingControl( ) { Val = CharacterSpacingValues.CompressPunctuation };

            Compatibility compatibility1 = new Compatibility( );
            SpaceForUnderline spaceForUnderline1 = new SpaceForUnderline( );
            BalanceSingleByteDoubleByteWidth balanceSingleByteDoubleByteWidth1 = new BalanceSingleByteDoubleByteWidth( );
            DoNotLeaveBackslashAlone doNotLeaveBackslashAlone1 = new DoNotLeaveBackslashAlone( );
            UnderlineTrailingSpaces underlineTrailingSpaces1 = new UnderlineTrailingSpaces( );
            DoNotExpandShiftReturn doNotExpandShiftReturn1 = new DoNotExpandShiftReturn( );
            AdjustLineHeightInTable adjustLineHeightInTable1 = new AdjustLineHeightInTable( );
            UseFarEastLayout useFarEastLayout1 = new UseFarEastLayout( );
            CompatibilitySetting compatibilitySetting1 = new CompatibilitySetting( ) { Name = CompatSettingNameValues.CompatibilityMode, Uri = "http://schemas.microsoft.com/office/word", Val = "14" };
            CompatibilitySetting compatibilitySetting2 = new CompatibilitySetting( ) { Name = CompatSettingNameValues.OverrideTableStyleFontSizeAndJustification, Uri = "http://schemas.microsoft.com/office/word", Val = "1" };
            CompatibilitySetting compatibilitySetting3 = new CompatibilitySetting( ) { Name = CompatSettingNameValues.EnableOpenTypeFeatures, Uri = "http://schemas.microsoft.com/office/word", Val = "1" };
            CompatibilitySetting compatibilitySetting4 = new CompatibilitySetting( ) { Name = CompatSettingNameValues.DoNotFlipMirrorIndents, Uri = "http://schemas.microsoft.com/office/word", Val = "1" };

            compatibility1.Append( spaceForUnderline1 );
            compatibility1.Append( balanceSingleByteDoubleByteWidth1 );
            compatibility1.Append( doNotLeaveBackslashAlone1 );
            compatibility1.Append( underlineTrailingSpaces1 );
            compatibility1.Append( doNotExpandShiftReturn1 );
            compatibility1.Append( adjustLineHeightInTable1 );
            compatibility1.Append( useFarEastLayout1 );
            compatibility1.Append( compatibilitySetting1 );
            compatibility1.Append( compatibilitySetting2 );
            compatibility1.Append( compatibilitySetting3 );
            compatibility1.Append( compatibilitySetting4 );

            Rsids rsids1 = new Rsids( );
            RsidRoot rsidRoot1 = new RsidRoot( ) { Val = "006F111A" };
            Rsid rsid1 = new Rsid( ) { Val = "006F111A" };
            Rsid rsid2 = new Rsid( ) { Val = "00C5114C" };

            rsids1.Append( rsidRoot1 );
            rsids1.Append( rsid1 );
            rsids1.Append( rsid2 );

            M.MathProperties mathProperties1 = new M.MathProperties( );

            M.MathFont mathFont1 = new M.MathFont( ) { Val = "Cambria Math" };
            M.BreakBinary breakBinary1 = new M.BreakBinary( ) { Val = M.BreakBinaryOperatorValues.Before };
            M.BreakBinarySubtraction breakBinarySubtraction1 = new M.BreakBinarySubtraction( ) { Val = M.BreakBinarySubtractionValues.MinusMinus };
            M.SmallFraction smallFraction1 = new M.SmallFraction( ) { Val = M.BooleanValues.Zero };
            M.DisplayDefaults displayDefaults1 = new M.DisplayDefaults( );
            M.LeftMargin leftMargin1 = new M.LeftMargin( ) { Val = ( UInt32Value ) 0U };
            M.RightMargin rightMargin1 = new M.RightMargin( ) { Val = ( UInt32Value ) 0U };
            M.DefaultJustification defaultJustification1 = new M.DefaultJustification( ) { Val = M.JustificationValues.CenterGroup };
            M.WrapIndent wrapIndent1 = new M.WrapIndent( ) { Val = ( UInt32Value ) 1440U };
            M.IntegralLimitLocation integralLimitLocation1 = new M.IntegralLimitLocation( ) { Val = M.LimitLocationValues.SubscriptSuperscript };
            M.NaryLimitLocation naryLimitLocation1 = new M.NaryLimitLocation( ) { Val = M.LimitLocationValues.UnderOver };

            mathProperties1.Append( mathFont1 );
            mathProperties1.Append( breakBinary1 );
            mathProperties1.Append( breakBinarySubtraction1 );
            mathProperties1.Append( smallFraction1 );
            mathProperties1.Append( displayDefaults1 );
            mathProperties1.Append( leftMargin1 );
            mathProperties1.Append( rightMargin1 );
            mathProperties1.Append( defaultJustification1 );
            mathProperties1.Append( wrapIndent1 );
            mathProperties1.Append( integralLimitLocation1 );
            mathProperties1.Append( naryLimitLocation1 );

            ThemeFontLanguages themeFontLanguages1 = new ThemeFontLanguages( ) { Val = "en-US", EastAsia = "zh-CN" };
            ColorSchemeMapping colorSchemeMapping1 = new ColorSchemeMapping( ) { Background1 = ColorSchemeIndexValues.Light1, Text1 = ColorSchemeIndexValues.Dark1, Background2 = ColorSchemeIndexValues.Light2, Text2 = ColorSchemeIndexValues.Dark2, Accent1 = ColorSchemeIndexValues.Accent1, Accent2 = ColorSchemeIndexValues.Accent2, Accent3 = ColorSchemeIndexValues.Accent3, Accent4 = ColorSchemeIndexValues.Accent4, Accent5 = ColorSchemeIndexValues.Accent5, Accent6 = ColorSchemeIndexValues.Accent6, Hyperlink = ColorSchemeIndexValues.Hyperlink, FollowedHyperlink = ColorSchemeIndexValues.FollowedHyperlink };

            ShapeDefaults shapeDefaults1 = new ShapeDefaults( );
            Ovml.ShapeDefaults shapeDefaults2 = new Ovml.ShapeDefaults( ) { Extension = V.ExtensionHandlingBehaviorValues.Edit, MaxShapeId = 1026 };

            Ovml.ShapeLayout shapeLayout1 = new Ovml.ShapeLayout( ) { Extension = V.ExtensionHandlingBehaviorValues.Edit };
            Ovml.ShapeIdMap shapeIdMap1 = new Ovml.ShapeIdMap( ) { Extension = V.ExtensionHandlingBehaviorValues.Edit, Data = "1" };

            shapeLayout1.Append( shapeIdMap1 );

            shapeDefaults1.Append( shapeDefaults2 );
            shapeDefaults1.Append( shapeLayout1 );

            DecimalSymbol decimalSymbol1 = new DecimalSymbol( ) { Val = "." };
            ListSeparator listSeparator1 = new ListSeparator( ) { Val = "," };

            settings1.Append( zoom1 );
            settings1.Append( bordersDoNotSurroundHeader1 );
            settings1.Append( bordersDoNotSurroundFooter1 );
            settings1.Append( proofState1 );
            settings1.Append( defaultTabStop1 );
            settings1.Append( drawingGridVerticalSpacing1 );
            settings1.Append( displayHorizontalDrawingGrid1 );
            settings1.Append( displayVerticalDrawingGrid1 );
            settings1.Append( characterSpacingControl1 );
            settings1.Append( compatibility1 );
            settings1.Append( rsids1 );
            settings1.Append( mathProperties1 );
            settings1.Append( themeFontLanguages1 );
            settings1.Append( colorSchemeMapping1 );
            settings1.Append( shapeDefaults1 );
            settings1.Append( decimalSymbol1 );
            settings1.Append( listSeparator1 );

            settingsPART.Settings = settings1;

            return;
        }

        //.....................................................................
    }
}
