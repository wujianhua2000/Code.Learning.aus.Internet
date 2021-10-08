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
    class OpenDocxStylesPartEffect
    {
        //.....................................................................
        /// <summary>
        /// Generates content of stylesWithEffectsPart1.
        /// </summary>
        /// <param name="stylesWithEffectsPart1"></param>
        private void GenerateStylesWithEffectsPart1Content( StylesWithEffectsPart stylesWithEffectsPart1 )
        {
            Styles styles1 = new Styles( ) { MCAttributes = new MarkupCompatibilityAttributes( ) { Ignorable = "w14 wp14" } };
            styles1.AddNamespaceDeclaration( "wpc", "http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas" );
            styles1.AddNamespaceDeclaration( "mc", "http://schemas.openxmlformats.org/markup-compatibility/2006" );
            styles1.AddNamespaceDeclaration( "o", "urn:schemas-microsoft-com:office:office" );
            styles1.AddNamespaceDeclaration( "r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships" );
            styles1.AddNamespaceDeclaration( "m", "http://schemas.openxmlformats.org/officeDocument/2006/math" );
            styles1.AddNamespaceDeclaration( "v", "urn:schemas-microsoft-com:vml" );
            styles1.AddNamespaceDeclaration( "wp14", "http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing" );
            styles1.AddNamespaceDeclaration( "wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing" );
            styles1.AddNamespaceDeclaration( "w10", "urn:schemas-microsoft-com:office:word" );
            styles1.AddNamespaceDeclaration( "w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main" );
            styles1.AddNamespaceDeclaration( "w14", "http://schemas.microsoft.com/office/word/2010/wordml" );
            styles1.AddNamespaceDeclaration( "wpg", "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup" );
            styles1.AddNamespaceDeclaration( "wpi", "http://schemas.microsoft.com/office/word/2010/wordprocessingInk" );
            styles1.AddNamespaceDeclaration( "wne", "http://schemas.microsoft.com/office/word/2006/wordml" );
            styles1.AddNamespaceDeclaration( "wps", "http://schemas.microsoft.com/office/word/2010/wordprocessingShape" );

            DocDefaults docDefaults1 = new DocDefaults( );

            RunPropertiesDefault runPropertiesDefault1 = new RunPropertiesDefault( );

            RunPropertiesBaseStyle runPropertiesBaseStyle1 = new RunPropertiesBaseStyle( );
            RunFonts runFonts1 = new RunFonts( ) { AsciiTheme = ThemeFontValues.MinorHighAnsi, HighAnsiTheme = ThemeFontValues.MinorHighAnsi, EastAsiaTheme = ThemeFontValues.MinorEastAsia, ComplexScriptTheme = ThemeFontValues.MinorBidi };
            Kern kern1 = new Kern( ) { Val = ( UInt32Value ) 2U };
            FontSize fontSize1 = new FontSize( ) { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript1 = new FontSizeComplexScript( ) { Val = "22" };
            Languages languages1 = new Languages( ) { Val = "en-US", EastAsia = "zh-CN", Bidi = "ar-SA" };

            runPropertiesBaseStyle1.Append( runFonts1 );
            runPropertiesBaseStyle1.Append( kern1 );
            runPropertiesBaseStyle1.Append( fontSize1 );
            runPropertiesBaseStyle1.Append( fontSizeComplexScript1 );
            runPropertiesBaseStyle1.Append( languages1 );

            runPropertiesDefault1.Append( runPropertiesBaseStyle1 );
            ParagraphPropertiesDefault paragraphPropertiesDefault1 = new ParagraphPropertiesDefault( );

            docDefaults1.Append( runPropertiesDefault1 );
            docDefaults1.Append( paragraphPropertiesDefault1 );

            LatentStyles latentStyles1 = new LatentStyles( ) { DefaultLockedState = false, DefaultUiPriority = 99, DefaultSemiHidden = true, DefaultUnhideWhenUsed = true, DefaultPrimaryStyle = false, Count = 267 };
            LatentStyleExceptionInfo latentStyleExceptionInfo1 = new LatentStyleExceptionInfo( ) { Name = "Normal", UiPriority = 0, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo2 = new LatentStyleExceptionInfo( ) { Name = "heading 1", UiPriority = 9, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo3 = new LatentStyleExceptionInfo( ) { Name = "heading 2", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo4 = new LatentStyleExceptionInfo( ) { Name = "heading 3", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo5 = new LatentStyleExceptionInfo( ) { Name = "heading 4", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo6 = new LatentStyleExceptionInfo( ) { Name = "heading 5", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo7 = new LatentStyleExceptionInfo( ) { Name = "heading 6", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo8 = new LatentStyleExceptionInfo( ) { Name = "heading 7", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo9 = new LatentStyleExceptionInfo( ) { Name = "heading 8", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo10 = new LatentStyleExceptionInfo( ) { Name = "heading 9", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo11 = new LatentStyleExceptionInfo( ) { Name = "toc 1", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo12 = new LatentStyleExceptionInfo( ) { Name = "toc 2", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo13 = new LatentStyleExceptionInfo( ) { Name = "toc 3", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo14 = new LatentStyleExceptionInfo( ) { Name = "toc 4", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo15 = new LatentStyleExceptionInfo( ) { Name = "toc 5", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo16 = new LatentStyleExceptionInfo( ) { Name = "toc 6", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo17 = new LatentStyleExceptionInfo( ) { Name = "toc 7", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo18 = new LatentStyleExceptionInfo( ) { Name = "toc 8", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo19 = new LatentStyleExceptionInfo( ) { Name = "toc 9", UiPriority = 39 };
            LatentStyleExceptionInfo latentStyleExceptionInfo20 = new LatentStyleExceptionInfo( ) { Name = "caption", UiPriority = 35, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo21 = new LatentStyleExceptionInfo( ) { Name = "Title", UiPriority = 10, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo22 = new LatentStyleExceptionInfo( ) { Name = "Default Paragraph Font", UiPriority = 1 };
            LatentStyleExceptionInfo latentStyleExceptionInfo23 = new LatentStyleExceptionInfo( ) { Name = "Subtitle", UiPriority = 11, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo24 = new LatentStyleExceptionInfo( ) { Name = "Strong", UiPriority = 22, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo25 = new LatentStyleExceptionInfo( ) { Name = "Emphasis", UiPriority = 20, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo26 = new LatentStyleExceptionInfo( ) { Name = "Table Grid", UiPriority = 59, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo27 = new LatentStyleExceptionInfo( ) { Name = "Placeholder Text", UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo28 = new LatentStyleExceptionInfo( ) { Name = "No Spacing", UiPriority = 1, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo29 = new LatentStyleExceptionInfo( ) { Name = "Light Shading", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo30 = new LatentStyleExceptionInfo( ) { Name = "Light List", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo31 = new LatentStyleExceptionInfo( ) { Name = "Light Grid", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo32 = new LatentStyleExceptionInfo( ) { Name = "Medium Shading 1", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo33 = new LatentStyleExceptionInfo( ) { Name = "Medium Shading 2", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo34 = new LatentStyleExceptionInfo( ) { Name = "Medium List 1", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo35 = new LatentStyleExceptionInfo( ) { Name = "Medium List 2", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo36 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 1", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo37 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 2", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo38 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 3", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo39 = new LatentStyleExceptionInfo( ) { Name = "Dark List", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo40 = new LatentStyleExceptionInfo( ) { Name = "Colorful Shading", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo41 = new LatentStyleExceptionInfo( ) { Name = "Colorful List", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo42 = new LatentStyleExceptionInfo( ) { Name = "Colorful Grid", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo43 = new LatentStyleExceptionInfo( ) { Name = "Light Shading Accent 1", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo44 = new LatentStyleExceptionInfo( ) { Name = "Light List Accent 1", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo45 = new LatentStyleExceptionInfo( ) { Name = "Light Grid Accent 1", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo46 = new LatentStyleExceptionInfo( ) { Name = "Medium Shading 1 Accent 1", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo47 = new LatentStyleExceptionInfo( ) { Name = "Medium Shading 2 Accent 1", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo48 = new LatentStyleExceptionInfo( ) { Name = "Medium List 1 Accent 1", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo49 = new LatentStyleExceptionInfo( ) { Name = "Revision", UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo50 = new LatentStyleExceptionInfo( ) { Name = "List Paragraph", UiPriority = 34, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo51 = new LatentStyleExceptionInfo( ) { Name = "Quote", UiPriority = 29, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo52 = new LatentStyleExceptionInfo( ) { Name = "Intense Quote", UiPriority = 30, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo53 = new LatentStyleExceptionInfo( ) { Name = "Medium List 2 Accent 1", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo54 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 1 Accent 1", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo55 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 2 Accent 1", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo56 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 3 Accent 1", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo57 = new LatentStyleExceptionInfo( ) { Name = "Dark List Accent 1", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo58 = new LatentStyleExceptionInfo( ) { Name = "Colorful Shading Accent 1", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo59 = new LatentStyleExceptionInfo( ) { Name = "Colorful List Accent 1", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo60 = new LatentStyleExceptionInfo( ) { Name = "Colorful Grid Accent 1", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo61 = new LatentStyleExceptionInfo( ) { Name = "Light Shading Accent 2", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo62 = new LatentStyleExceptionInfo( ) { Name = "Light List Accent 2", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo63 = new LatentStyleExceptionInfo( ) { Name = "Light Grid Accent 2", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo64 = new LatentStyleExceptionInfo( ) { Name = "Medium Shading 1 Accent 2", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo65 = new LatentStyleExceptionInfo( ) { Name = "Medium Shading 2 Accent 2", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo66 = new LatentStyleExceptionInfo( ) { Name = "Medium List 1 Accent 2", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo67 = new LatentStyleExceptionInfo( ) { Name = "Medium List 2 Accent 2", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo68 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 1 Accent 2", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo69 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 2 Accent 2", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo70 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 3 Accent 2", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo71 = new LatentStyleExceptionInfo( ) { Name = "Dark List Accent 2", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo72 = new LatentStyleExceptionInfo( ) { Name = "Colorful Shading Accent 2", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo73 = new LatentStyleExceptionInfo( ) { Name = "Colorful List Accent 2", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo74 = new LatentStyleExceptionInfo( ) { Name = "Colorful Grid Accent 2", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo75 = new LatentStyleExceptionInfo( ) { Name = "Light Shading Accent 3", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo76 = new LatentStyleExceptionInfo( ) { Name = "Light List Accent 3", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo77 = new LatentStyleExceptionInfo( ) { Name = "Light Grid Accent 3", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo78 = new LatentStyleExceptionInfo( ) { Name = "Medium Shading 1 Accent 3", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo79 = new LatentStyleExceptionInfo( ) { Name = "Medium Shading 2 Accent 3", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo80 = new LatentStyleExceptionInfo( ) { Name = "Medium List 1 Accent 3", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo81 = new LatentStyleExceptionInfo( ) { Name = "Medium List 2 Accent 3", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo82 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 1 Accent 3", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo83 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 2 Accent 3", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo84 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 3 Accent 3", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo85 = new LatentStyleExceptionInfo( ) { Name = "Dark List Accent 3", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo86 = new LatentStyleExceptionInfo( ) { Name = "Colorful Shading Accent 3", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo87 = new LatentStyleExceptionInfo( ) { Name = "Colorful List Accent 3", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo88 = new LatentStyleExceptionInfo( ) { Name = "Colorful Grid Accent 3", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo89 = new LatentStyleExceptionInfo( ) { Name = "Light Shading Accent 4", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo90 = new LatentStyleExceptionInfo( ) { Name = "Light List Accent 4", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo91 = new LatentStyleExceptionInfo( ) { Name = "Light Grid Accent 4", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo92 = new LatentStyleExceptionInfo( ) { Name = "Medium Shading 1 Accent 4", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo93 = new LatentStyleExceptionInfo( ) { Name = "Medium Shading 2 Accent 4", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo94 = new LatentStyleExceptionInfo( ) { Name = "Medium List 1 Accent 4", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo95 = new LatentStyleExceptionInfo( ) { Name = "Medium List 2 Accent 4", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo96 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 1 Accent 4", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo97 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 2 Accent 4", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo98 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 3 Accent 4", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo99 = new LatentStyleExceptionInfo( ) { Name = "Dark List Accent 4", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo100 = new LatentStyleExceptionInfo( ) { Name = "Colorful Shading Accent 4", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo101 = new LatentStyleExceptionInfo( ) { Name = "Colorful List Accent 4", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo102 = new LatentStyleExceptionInfo( ) { Name = "Colorful Grid Accent 4", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo103 = new LatentStyleExceptionInfo( ) { Name = "Light Shading Accent 5", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo104 = new LatentStyleExceptionInfo( ) { Name = "Light List Accent 5", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo105 = new LatentStyleExceptionInfo( ) { Name = "Light Grid Accent 5", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo106 = new LatentStyleExceptionInfo( ) { Name = "Medium Shading 1 Accent 5", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo107 = new LatentStyleExceptionInfo( ) { Name = "Medium Shading 2 Accent 5", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo108 = new LatentStyleExceptionInfo( ) { Name = "Medium List 1 Accent 5", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo109 = new LatentStyleExceptionInfo( ) { Name = "Medium List 2 Accent 5", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo110 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 1 Accent 5", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo111 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 2 Accent 5", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo112 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 3 Accent 5", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo113 = new LatentStyleExceptionInfo( ) { Name = "Dark List Accent 5", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo114 = new LatentStyleExceptionInfo( ) { Name = "Colorful Shading Accent 5", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo115 = new LatentStyleExceptionInfo( ) { Name = "Colorful List Accent 5", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo116 = new LatentStyleExceptionInfo( ) { Name = "Colorful Grid Accent 5", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo117 = new LatentStyleExceptionInfo( ) { Name = "Light Shading Accent 6", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo118 = new LatentStyleExceptionInfo( ) { Name = "Light List Accent 6", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo119 = new LatentStyleExceptionInfo( ) { Name = "Light Grid Accent 6", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo120 = new LatentStyleExceptionInfo( ) { Name = "Medium Shading 1 Accent 6", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo121 = new LatentStyleExceptionInfo( ) { Name = "Medium Shading 2 Accent 6", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo122 = new LatentStyleExceptionInfo( ) { Name = "Medium List 1 Accent 6", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo123 = new LatentStyleExceptionInfo( ) { Name = "Medium List 2 Accent 6", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo124 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 1 Accent 6", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo125 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 2 Accent 6", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo126 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 3 Accent 6", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo127 = new LatentStyleExceptionInfo( ) { Name = "Dark List Accent 6", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo128 = new LatentStyleExceptionInfo( ) { Name = "Colorful Shading Accent 6", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo129 = new LatentStyleExceptionInfo( ) { Name = "Colorful List Accent 6", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo130 = new LatentStyleExceptionInfo( ) { Name = "Colorful Grid Accent 6", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            LatentStyleExceptionInfo latentStyleExceptionInfo131 = new LatentStyleExceptionInfo( ) { Name = "Subtle Emphasis", UiPriority = 19, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo132 = new LatentStyleExceptionInfo( ) { Name = "Intense Emphasis", UiPriority = 21, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo133 = new LatentStyleExceptionInfo( ) { Name = "Subtle Reference", UiPriority = 31, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo134 = new LatentStyleExceptionInfo( ) { Name = "Intense Reference", UiPriority = 32, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo135 = new LatentStyleExceptionInfo( ) { Name = "Book Title", UiPriority = 33, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo136 = new LatentStyleExceptionInfo( ) { Name = "Bibliography", UiPriority = 37 };
            LatentStyleExceptionInfo latentStyleExceptionInfo137 = new LatentStyleExceptionInfo( ) { Name = "TOC Heading", UiPriority = 39, PrimaryStyle = true };

            latentStyles1.Append( latentStyleExceptionInfo1 );
            latentStyles1.Append( latentStyleExceptionInfo2 );
            latentStyles1.Append( latentStyleExceptionInfo3 );
            latentStyles1.Append( latentStyleExceptionInfo4 );
            latentStyles1.Append( latentStyleExceptionInfo5 );
            latentStyles1.Append( latentStyleExceptionInfo6 );
            latentStyles1.Append( latentStyleExceptionInfo7 );
            latentStyles1.Append( latentStyleExceptionInfo8 );
            latentStyles1.Append( latentStyleExceptionInfo9 );
            latentStyles1.Append( latentStyleExceptionInfo10 );
            latentStyles1.Append( latentStyleExceptionInfo11 );
            latentStyles1.Append( latentStyleExceptionInfo12 );
            latentStyles1.Append( latentStyleExceptionInfo13 );
            latentStyles1.Append( latentStyleExceptionInfo14 );
            latentStyles1.Append( latentStyleExceptionInfo15 );
            latentStyles1.Append( latentStyleExceptionInfo16 );
            latentStyles1.Append( latentStyleExceptionInfo17 );
            latentStyles1.Append( latentStyleExceptionInfo18 );
            latentStyles1.Append( latentStyleExceptionInfo19 );
            latentStyles1.Append( latentStyleExceptionInfo20 );
            latentStyles1.Append( latentStyleExceptionInfo21 );
            latentStyles1.Append( latentStyleExceptionInfo22 );
            latentStyles1.Append( latentStyleExceptionInfo23 );
            latentStyles1.Append( latentStyleExceptionInfo24 );
            latentStyles1.Append( latentStyleExceptionInfo25 );
            latentStyles1.Append( latentStyleExceptionInfo26 );
            latentStyles1.Append( latentStyleExceptionInfo27 );
            latentStyles1.Append( latentStyleExceptionInfo28 );
            latentStyles1.Append( latentStyleExceptionInfo29 );
            latentStyles1.Append( latentStyleExceptionInfo30 );
            latentStyles1.Append( latentStyleExceptionInfo31 );
            latentStyles1.Append( latentStyleExceptionInfo32 );
            latentStyles1.Append( latentStyleExceptionInfo33 );
            latentStyles1.Append( latentStyleExceptionInfo34 );
            latentStyles1.Append( latentStyleExceptionInfo35 );
            latentStyles1.Append( latentStyleExceptionInfo36 );
            latentStyles1.Append( latentStyleExceptionInfo37 );
            latentStyles1.Append( latentStyleExceptionInfo38 );
            latentStyles1.Append( latentStyleExceptionInfo39 );
            latentStyles1.Append( latentStyleExceptionInfo40 );
            latentStyles1.Append( latentStyleExceptionInfo41 );
            latentStyles1.Append( latentStyleExceptionInfo42 );
            latentStyles1.Append( latentStyleExceptionInfo43 );
            latentStyles1.Append( latentStyleExceptionInfo44 );
            latentStyles1.Append( latentStyleExceptionInfo45 );
            latentStyles1.Append( latentStyleExceptionInfo46 );
            latentStyles1.Append( latentStyleExceptionInfo47 );
            latentStyles1.Append( latentStyleExceptionInfo48 );
            latentStyles1.Append( latentStyleExceptionInfo49 );
            latentStyles1.Append( latentStyleExceptionInfo50 );
            latentStyles1.Append( latentStyleExceptionInfo51 );
            latentStyles1.Append( latentStyleExceptionInfo52 );
            latentStyles1.Append( latentStyleExceptionInfo53 );
            latentStyles1.Append( latentStyleExceptionInfo54 );
            latentStyles1.Append( latentStyleExceptionInfo55 );
            latentStyles1.Append( latentStyleExceptionInfo56 );
            latentStyles1.Append( latentStyleExceptionInfo57 );
            latentStyles1.Append( latentStyleExceptionInfo58 );
            latentStyles1.Append( latentStyleExceptionInfo59 );
            latentStyles1.Append( latentStyleExceptionInfo60 );
            latentStyles1.Append( latentStyleExceptionInfo61 );
            latentStyles1.Append( latentStyleExceptionInfo62 );
            latentStyles1.Append( latentStyleExceptionInfo63 );
            latentStyles1.Append( latentStyleExceptionInfo64 );
            latentStyles1.Append( latentStyleExceptionInfo65 );
            latentStyles1.Append( latentStyleExceptionInfo66 );
            latentStyles1.Append( latentStyleExceptionInfo67 );
            latentStyles1.Append( latentStyleExceptionInfo68 );
            latentStyles1.Append( latentStyleExceptionInfo69 );
            latentStyles1.Append( latentStyleExceptionInfo70 );
            latentStyles1.Append( latentStyleExceptionInfo71 );
            latentStyles1.Append( latentStyleExceptionInfo72 );
            latentStyles1.Append( latentStyleExceptionInfo73 );
            latentStyles1.Append( latentStyleExceptionInfo74 );
            latentStyles1.Append( latentStyleExceptionInfo75 );
            latentStyles1.Append( latentStyleExceptionInfo76 );
            latentStyles1.Append( latentStyleExceptionInfo77 );
            latentStyles1.Append( latentStyleExceptionInfo78 );
            latentStyles1.Append( latentStyleExceptionInfo79 );
            latentStyles1.Append( latentStyleExceptionInfo80 );
            latentStyles1.Append( latentStyleExceptionInfo81 );
            latentStyles1.Append( latentStyleExceptionInfo82 );
            latentStyles1.Append( latentStyleExceptionInfo83 );
            latentStyles1.Append( latentStyleExceptionInfo84 );
            latentStyles1.Append( latentStyleExceptionInfo85 );
            latentStyles1.Append( latentStyleExceptionInfo86 );
            latentStyles1.Append( latentStyleExceptionInfo87 );
            latentStyles1.Append( latentStyleExceptionInfo88 );
            latentStyles1.Append( latentStyleExceptionInfo89 );
            latentStyles1.Append( latentStyleExceptionInfo90 );
            latentStyles1.Append( latentStyleExceptionInfo91 );
            latentStyles1.Append( latentStyleExceptionInfo92 );
            latentStyles1.Append( latentStyleExceptionInfo93 );
            latentStyles1.Append( latentStyleExceptionInfo94 );
            latentStyles1.Append( latentStyleExceptionInfo95 );
            latentStyles1.Append( latentStyleExceptionInfo96 );
            latentStyles1.Append( latentStyleExceptionInfo97 );
            latentStyles1.Append( latentStyleExceptionInfo98 );
            latentStyles1.Append( latentStyleExceptionInfo99 );
            latentStyles1.Append( latentStyleExceptionInfo100 );
            latentStyles1.Append( latentStyleExceptionInfo101 );
            latentStyles1.Append( latentStyleExceptionInfo102 );
            latentStyles1.Append( latentStyleExceptionInfo103 );
            latentStyles1.Append( latentStyleExceptionInfo104 );
            latentStyles1.Append( latentStyleExceptionInfo105 );
            latentStyles1.Append( latentStyleExceptionInfo106 );
            latentStyles1.Append( latentStyleExceptionInfo107 );
            latentStyles1.Append( latentStyleExceptionInfo108 );
            latentStyles1.Append( latentStyleExceptionInfo109 );
            latentStyles1.Append( latentStyleExceptionInfo110 );
            latentStyles1.Append( latentStyleExceptionInfo111 );
            latentStyles1.Append( latentStyleExceptionInfo112 );
            latentStyles1.Append( latentStyleExceptionInfo113 );
            latentStyles1.Append( latentStyleExceptionInfo114 );
            latentStyles1.Append( latentStyleExceptionInfo115 );
            latentStyles1.Append( latentStyleExceptionInfo116 );
            latentStyles1.Append( latentStyleExceptionInfo117 );
            latentStyles1.Append( latentStyleExceptionInfo118 );
            latentStyles1.Append( latentStyleExceptionInfo119 );
            latentStyles1.Append( latentStyleExceptionInfo120 );
            latentStyles1.Append( latentStyleExceptionInfo121 );
            latentStyles1.Append( latentStyleExceptionInfo122 );
            latentStyles1.Append( latentStyleExceptionInfo123 );
            latentStyles1.Append( latentStyleExceptionInfo124 );
            latentStyles1.Append( latentStyleExceptionInfo125 );
            latentStyles1.Append( latentStyleExceptionInfo126 );
            latentStyles1.Append( latentStyleExceptionInfo127 );
            latentStyles1.Append( latentStyleExceptionInfo128 );
            latentStyles1.Append( latentStyleExceptionInfo129 );
            latentStyles1.Append( latentStyleExceptionInfo130 );
            latentStyles1.Append( latentStyleExceptionInfo131 );
            latentStyles1.Append( latentStyleExceptionInfo132 );
            latentStyles1.Append( latentStyleExceptionInfo133 );
            latentStyles1.Append( latentStyleExceptionInfo134 );
            latentStyles1.Append( latentStyleExceptionInfo135 );
            latentStyles1.Append( latentStyleExceptionInfo136 );
            latentStyles1.Append( latentStyleExceptionInfo137 );

            Style style1 = new Style( ) { Type = StyleValues.Paragraph, StyleId = "a", Default = true };
            StyleName styleName1 = new StyleName( ) { Val = "Normal" };
            PrimaryStyle primaryStyle1 = new PrimaryStyle( );

            StyleParagraphProperties styleParagraphProperties1 = new StyleParagraphProperties( );
            WidowControl widowControl1 = new WidowControl( ) { Val = false };
            Justification justification1 = new Justification( ) { Val = JustificationValues.Both };

            styleParagraphProperties1.Append( widowControl1 );
            styleParagraphProperties1.Append( justification1 );

            style1.Append( styleName1 );
            style1.Append( primaryStyle1 );
            style1.Append( styleParagraphProperties1 );

            Style style2 = new Style( ) { Type = StyleValues.Paragraph, StyleId = "1" };
            StyleName styleName2 = new StyleName( ) { Val = "heading 1" };
            BasedOn basedOn1 = new BasedOn( ) { Val = "a" };
            NextParagraphStyle nextParagraphStyle1 = new NextParagraphStyle( ) { Val = "a" };
            LinkedStyle linkedStyle1 = new LinkedStyle( ) { Val = "1Char" };
            UIPriority uIPriority1 = new UIPriority( ) { Val = 9 };
            PrimaryStyle primaryStyle2 = new PrimaryStyle( );
            Rsid rsid3 = new Rsid( ) { Val = "006F111A" };

            StyleParagraphProperties styleParagraphProperties2 = new StyleParagraphProperties( );
            KeepNext keepNext1 = new KeepNext( );
            KeepLines keepLines1 = new KeepLines( );
            SpacingBetweenLines spacingBetweenLines1 = new SpacingBetweenLines( ) { Before = "340", After = "330", Line = "578", LineRule = LineSpacingRuleValues.Auto };
            OutlineLevel outlineLevel1 = new OutlineLevel( ) { Val = 0 };

            styleParagraphProperties2.Append( keepNext1 );
            styleParagraphProperties2.Append( keepLines1 );
            styleParagraphProperties2.Append( spacingBetweenLines1 );
            styleParagraphProperties2.Append( outlineLevel1 );

            StyleRunProperties styleRunProperties1 = new StyleRunProperties( );
            Bold bold1 = new Bold( );
            BoldComplexScript boldComplexScript1 = new BoldComplexScript( );
            Kern kern2 = new Kern( ) { Val = ( UInt32Value ) 44U };
            FontSize fontSize2 = new FontSize( ) { Val = "44" };
            FontSizeComplexScript fontSizeComplexScript2 = new FontSizeComplexScript( ) { Val = "44" };

            styleRunProperties1.Append( bold1 );
            styleRunProperties1.Append( boldComplexScript1 );
            styleRunProperties1.Append( kern2 );
            styleRunProperties1.Append( fontSize2 );
            styleRunProperties1.Append( fontSizeComplexScript2 );

            style2.Append( styleName2 );
            style2.Append( basedOn1 );
            style2.Append( nextParagraphStyle1 );
            style2.Append( linkedStyle1 );
            style2.Append( uIPriority1 );
            style2.Append( primaryStyle2 );
            style2.Append( rsid3 );
            style2.Append( styleParagraphProperties2 );
            style2.Append( styleRunProperties1 );

            Style style3 = new Style( ) { Type = StyleValues.Character, StyleId = "a0", Default = true };
            StyleName styleName3 = new StyleName( ) { Val = "Default Paragraph Font" };
            UIPriority uIPriority2 = new UIPriority( ) { Val = 1 };
            SemiHidden semiHidden1 = new SemiHidden( );
            UnhideWhenUsed unhideWhenUsed1 = new UnhideWhenUsed( );

            style3.Append( styleName3 );
            style3.Append( uIPriority2 );
            style3.Append( semiHidden1 );
            style3.Append( unhideWhenUsed1 );

            Style style4 = new Style( ) { Type = StyleValues.Table, StyleId = "a1", Default = true };
            StyleName styleName4 = new StyleName( ) { Val = "Normal Table" };
            UIPriority uIPriority3 = new UIPriority( ) { Val = 99 };
            SemiHidden semiHidden2 = new SemiHidden( );
            UnhideWhenUsed unhideWhenUsed2 = new UnhideWhenUsed( );

            StyleTableProperties styleTableProperties1 = new StyleTableProperties( );
            TableIndentation tableIndentation1 = new TableIndentation( ) { Width = 0, Type = TableWidthUnitValues.Dxa };

            TableCellMarginDefault tableCellMarginDefault1 = new TableCellMarginDefault( );
            TopMargin topMargin1 = new TopMargin( ) { Width = "0", Type = TableWidthUnitValues.Dxa };
            TableCellLeftMargin tableCellLeftMargin1 = new TableCellLeftMargin( ) { Width = 108, Type = TableWidthValues.Dxa };
            BottomMargin bottomMargin1 = new BottomMargin( ) { Width = "0", Type = TableWidthUnitValues.Dxa };
            TableCellRightMargin tableCellRightMargin1 = new TableCellRightMargin( ) { Width = 108, Type = TableWidthValues.Dxa };

            tableCellMarginDefault1.Append( topMargin1 );
            tableCellMarginDefault1.Append( tableCellLeftMargin1 );
            tableCellMarginDefault1.Append( bottomMargin1 );
            tableCellMarginDefault1.Append( tableCellRightMargin1 );

            styleTableProperties1.Append( tableIndentation1 );
            styleTableProperties1.Append( tableCellMarginDefault1 );

            style4.Append( styleName4 );
            style4.Append( uIPriority3 );
            style4.Append( semiHidden2 );
            style4.Append( unhideWhenUsed2 );
            style4.Append( styleTableProperties1 );

            Style style5 = new Style( ) { Type = StyleValues.Numbering, StyleId = "a2", Default = true };
            StyleName styleName5 = new StyleName( ) { Val = "No List" };
            UIPriority uIPriority4 = new UIPriority( ) { Val = 99 };
            SemiHidden semiHidden3 = new SemiHidden( );
            UnhideWhenUsed unhideWhenUsed3 = new UnhideWhenUsed( );

            style5.Append( styleName5 );
            style5.Append( uIPriority4 );
            style5.Append( semiHidden3 );
            style5.Append( unhideWhenUsed3 );

            Style style6 = new Style( ) { Type = StyleValues.Character, StyleId = "1Char", CustomStyle = true };
            StyleName styleName6 = new StyleName( ) { Val = "标题 1 Char" };
            BasedOn basedOn2 = new BasedOn( ) { Val = "a0" };
            LinkedStyle linkedStyle2 = new LinkedStyle( ) { Val = "1" };
            UIPriority uIPriority5 = new UIPriority( ) { Val = 9 };
            Rsid rsid4 = new Rsid( ) { Val = "006F111A" };

            StyleRunProperties styleRunProperties2 = new StyleRunProperties( );
            Bold bold2 = new Bold( );
            BoldComplexScript boldComplexScript2 = new BoldComplexScript( );
            Kern kern3 = new Kern( ) { Val = ( UInt32Value ) 44U };
            FontSize fontSize3 = new FontSize( ) { Val = "44" };
            FontSizeComplexScript fontSizeComplexScript3 = new FontSizeComplexScript( ) { Val = "44" };

            styleRunProperties2.Append( bold2 );
            styleRunProperties2.Append( boldComplexScript2 );
            styleRunProperties2.Append( kern3 );
            styleRunProperties2.Append( fontSize3 );
            styleRunProperties2.Append( fontSizeComplexScript3 );

            style6.Append( styleName6 );
            style6.Append( basedOn2 );
            style6.Append( linkedStyle2 );
            style6.Append( uIPriority5 );
            style6.Append( rsid4 );
            style6.Append( styleRunProperties2 );

            styles1.Append( docDefaults1 );
            styles1.Append( latentStyles1 );
            styles1.Append( style1 );
            styles1.Append( style2 );
            styles1.Append( style3 );
            styles1.Append( style4 );
            styles1.Append( style5 );
            styles1.Append( style6 );

            stylesWithEffectsPart1.Styles = styles1;

            return;
        }

        //.....................................................................
    }
}
