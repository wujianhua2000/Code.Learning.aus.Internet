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
    class OpenDocxStylesPart
    {
        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numberingPART"></param>
        public static void Generate( StyleDefinitionsPart stylePART )
        {
            OpenDocxStylesPart openxml = new OpenDocxStylesPart( );

            openxml.GenerateStylePart( stylePART );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stylePART"></param>
        public void GenerateStylePart( StyleDefinitionsPart stylePART )
        {
            Styles stylelisting = this.NewStyles( );

            //.............................................
            DocDefaults docDefaults2 = this.MakeStyleDocDefaults( );

            //.....................................................................
            LatentStyles latentStyles2 = this.MakeStyleLatent( );

            //.............................................
            Style styleTXT = this.MakeStyleTextNormal( );

            Style style09 = this.MakeStyleDefaultFont( );
            Style style10 = this.MakeStyleNormalTable( );
            Style style11 = this.MakeStyleNoList( );
            Style style12 = this.MakeStyleHeading01Han( );

            //.............................................
            stylelisting.Append( docDefaults2 );
            stylelisting.Append( latentStyles2 );

            stylelisting.Append( styleTXT );

            stylelisting.Append( this.MakeStyleHeading001( ) );
            stylelisting.Append( this.MakeStyleHeading002( ) );
            stylelisting.Append( this.MakeStyleHeading003( ) );
            stylelisting.Append( this.MakeStyleHeading004( ) );
            stylelisting.Append( this.MakeStyleHeading005( ) );

            stylelisting.Append( this.MakeStyleHeading01Han( ) );
            stylelisting.Append( this.MakeStyleHeading02Han( ) );
            stylelisting.Append( this.MakeStyleHeading03Han( ) );
            stylelisting.Append( this.MakeStyleHeading04Han( ) );
            stylelisting.Append( this.MakeStyleHeading05Han( ) );

            stylelisting.Append( style09 );
            stylelisting.Append( style10 );
            stylelisting.Append( style11 );
            stylelisting.Append( style12 );

            //.............................................
            stylePART.Styles = stylelisting;

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Styles NewStyles( )
        {
            Styles stylelisting = new Styles( ) { MCAttributes = new MarkupCompatibilityAttributes( ) { Ignorable = "w14" } };

            stylelisting.AddNamespaceDeclaration( "mc", "http://schemas.openxmlformats.org/markup-compatibility/2006" );
            stylelisting.AddNamespaceDeclaration( "r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships" );
            stylelisting.AddNamespaceDeclaration( "w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main" );
            stylelisting.AddNamespaceDeclaration( "w14", "http://schemas.microsoft.com/office/word/2010/wordml" );
            
            return stylelisting;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private DocDefaults MakeStyleDocDefaults( )
        {
            DocDefaults docDefaults2 = new DocDefaults( );

            RunPropertiesDefault runPropertiesDefault2 = new RunPropertiesDefault( );

            RunFonts runFonts2 = new RunFonts( ) { AsciiTheme = ThemeFontValues.MinorHighAnsi, HighAnsiTheme = ThemeFontValues.MinorHighAnsi, EastAsiaTheme = ThemeFontValues.MinorEastAsia, ComplexScriptTheme = ThemeFontValues.MinorBidi };
            Kern kern4 = new Kern( ) { Val = ( UInt32Value ) 2U };
            FontSize fontSize4 = new FontSize( ) { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript4 = new FontSizeComplexScript( ) { Val = "22" };
            Languages languages2 = new Languages( ) { Val = "en-US", EastAsia = "zh-CN", Bidi = "ar-SA" };

            RunPropertiesBaseStyle runPropertiesBaseStyle2 = new RunPropertiesBaseStyle( );
            runPropertiesBaseStyle2.Append( runFonts2 );
            runPropertiesBaseStyle2.Append( kern4 );
            runPropertiesBaseStyle2.Append( fontSize4 );
            runPropertiesBaseStyle2.Append( fontSizeComplexScript4 );
            runPropertiesBaseStyle2.Append( languages2 );

            runPropertiesDefault2.Append( runPropertiesBaseStyle2 );

            ParagraphPropertiesDefault paragraphPropertiesDefault2 = new ParagraphPropertiesDefault( );

            docDefaults2.Append( runPropertiesDefault2 );
            docDefaults2.Append( paragraphPropertiesDefault2 );

            return docDefaults2;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private LatentStyles MakeStyleLatent( )
        {
            LatentStyles latentStyles2 = new LatentStyles( ) { DefaultLockedState = false, DefaultUiPriority = 99, DefaultSemiHidden = true, DefaultUnhideWhenUsed = true, DefaultPrimaryStyle = false, Count = 267 };

            LatentStyleExceptionInfo latentStyleExceptionInfo138 = new LatentStyleExceptionInfo( ) { Name = "Normal", UiPriority = 0, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo139 = new LatentStyleExceptionInfo( ) { Name = "heading 1", UiPriority = 9, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo140 = new LatentStyleExceptionInfo( ) { Name = "heading 2", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo141 = new LatentStyleExceptionInfo( ) { Name = "heading 3", UiPriority = 9, PrimaryStyle = true };
            LatentStyleExceptionInfo latentStyleExceptionInfo142 = new LatentStyleExceptionInfo( ) { Name = "heading 4", UiPriority = 9, PrimaryStyle = true };
            //LatentStyleExceptionInfo latentStyleExceptionInfo143 = new LatentStyleExceptionInfo( ) { Name = "heading 5", UiPriority = 9, PrimaryStyle = true };
            //LatentStyleExceptionInfo latentStyleExceptionInfo144 = new LatentStyleExceptionInfo( ) { Name = "heading 6", UiPriority = 9, PrimaryStyle = true };
            //LatentStyleExceptionInfo latentStyleExceptionInfo145 = new LatentStyleExceptionInfo( ) { Name = "heading 7", UiPriority = 9, PrimaryStyle = true };
            //LatentStyleExceptionInfo latentStyleExceptionInfo146 = new LatentStyleExceptionInfo( ) { Name = "heading 8", UiPriority = 9, PrimaryStyle = true };
            //LatentStyleExceptionInfo latentStyleExceptionInfo147 = new LatentStyleExceptionInfo( ) { Name = "heading 9", UiPriority = 9, PrimaryStyle = true };
            //LatentStyleExceptionInfo latentStyleExceptionInfo148 = new LatentStyleExceptionInfo( ) { Name = "toc 1", UiPriority = 39 };
            //LatentStyleExceptionInfo latentStyleExceptionInfo149 = new LatentStyleExceptionInfo( ) { Name = "toc 2", UiPriority = 39 };
            //LatentStyleExceptionInfo latentStyleExceptionInfo150 = new LatentStyleExceptionInfo( ) { Name = "toc 3", UiPriority = 39 };
            //LatentStyleExceptionInfo latentStyleExceptionInfo151 = new LatentStyleExceptionInfo( ) { Name = "toc 4", UiPriority = 39 };
            //LatentStyleExceptionInfo latentStyleExceptionInfo152 = new LatentStyleExceptionInfo( ) { Name = "toc 5", UiPriority = 39 };
            //LatentStyleExceptionInfo latentStyleExceptionInfo153 = new LatentStyleExceptionInfo( ) { Name = "toc 6", UiPriority = 39 };
            //LatentStyleExceptionInfo latentStyleExceptionInfo154 = new LatentStyleExceptionInfo( ) { Name = "toc 7", UiPriority = 39 };
            //LatentStyleExceptionInfo latentStyleExceptionInfo155 = new LatentStyleExceptionInfo( ) { Name = "toc 8", UiPriority = 39 };
            //LatentStyleExceptionInfo latentStyleExceptionInfo156 = new LatentStyleExceptionInfo( ) { Name = "toc 9", UiPriority = 39 };
            //LatentStyleExceptionInfo latentStyleExceptionInfo157 = new LatentStyleExceptionInfo( ) { Name = "caption", UiPriority = 35, PrimaryStyle = true };
            //LatentStyleExceptionInfo latentStyleExceptionInfo158 = new LatentStyleExceptionInfo( ) { Name = "Title", UiPriority = 10, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            //LatentStyleExceptionInfo latentStyleExceptionInfo159 = new LatentStyleExceptionInfo( ) { Name = "Default Paragraph Font", UiPriority = 1 };
            //LatentStyleExceptionInfo latentStyleExceptionInfo160 = new LatentStyleExceptionInfo( ) { Name = "Subtitle", UiPriority = 11, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            //LatentStyleExceptionInfo latentStyleExceptionInfo161 = new LatentStyleExceptionInfo( ) { Name = "Strong", UiPriority = 22, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            //LatentStyleExceptionInfo latentStyleExceptionInfo162 = new LatentStyleExceptionInfo( ) { Name = "Emphasis", UiPriority = 20, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            //LatentStyleExceptionInfo latentStyleExceptionInfo163 = new LatentStyleExceptionInfo( ) { Name = "Table Grid", UiPriority = 59, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo164 = new LatentStyleExceptionInfo( ) { Name = "Placeholder Text", UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo165 = new LatentStyleExceptionInfo( ) { Name = "No Spacing", UiPriority = 1, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            //LatentStyleExceptionInfo latentStyleExceptionInfo166 = new LatentStyleExceptionInfo( ) { Name = "Light Shading", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo167 = new LatentStyleExceptionInfo( ) { Name = "Light List", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo168 = new LatentStyleExceptionInfo( ) { Name = "Light Grid", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo169 = new LatentStyleExceptionInfo( ) { Name = "Medium Shading 1", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo170 = new LatentStyleExceptionInfo( ) { Name = "Medium Shading 2", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo171 = new LatentStyleExceptionInfo( ) { Name = "Medium List 1", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo172 = new LatentStyleExceptionInfo( ) { Name = "Medium List 2", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo173 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 1", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo174 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 2", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo175 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 3", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo176 = new LatentStyleExceptionInfo( ) { Name = "Dark List", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo177 = new LatentStyleExceptionInfo( ) { Name = "Colorful Shading", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo178 = new LatentStyleExceptionInfo( ) { Name = "Colorful List", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo179 = new LatentStyleExceptionInfo( ) { Name = "Colorful Grid", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo180 = new LatentStyleExceptionInfo( ) { Name = "Light Shading Accent 1", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo181 = new LatentStyleExceptionInfo( ) { Name = "Light List Accent 1", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo182 = new LatentStyleExceptionInfo( ) { Name = "Light Grid Accent 1", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo183 = new LatentStyleExceptionInfo( ) { Name = "Medium Shading 1 Accent 1", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo184 = new LatentStyleExceptionInfo( ) { Name = "Medium Shading 2 Accent 1", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo185 = new LatentStyleExceptionInfo( ) { Name = "Medium List 1 Accent 1", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo186 = new LatentStyleExceptionInfo( ) { Name = "Revision", UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo187 = new LatentStyleExceptionInfo( ) { Name = "List Paragraph", UiPriority = 34, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            //LatentStyleExceptionInfo latentStyleExceptionInfo188 = new LatentStyleExceptionInfo( ) { Name = "Quote", UiPriority = 29, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            //LatentStyleExceptionInfo latentStyleExceptionInfo189 = new LatentStyleExceptionInfo( ) { Name = "Intense Quote", UiPriority = 30, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            //LatentStyleExceptionInfo latentStyleExceptionInfo190 = new LatentStyleExceptionInfo( ) { Name = "Medium List 2 Accent 1", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo191 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 1 Accent 1", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo192 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 2 Accent 1", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo193 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 3 Accent 1", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo194 = new LatentStyleExceptionInfo( ) { Name = "Dark List Accent 1", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo195 = new LatentStyleExceptionInfo( ) { Name = "Colorful Shading Accent 1", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo196 = new LatentStyleExceptionInfo( ) { Name = "Colorful List Accent 1", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo197 = new LatentStyleExceptionInfo( ) { Name = "Colorful Grid Accent 1", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo198 = new LatentStyleExceptionInfo( ) { Name = "Light Shading Accent 2", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo199 = new LatentStyleExceptionInfo( ) { Name = "Light List Accent 2", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo200 = new LatentStyleExceptionInfo( ) { Name = "Light Grid Accent 2", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo201 = new LatentStyleExceptionInfo( ) { Name = "Medium Shading 1 Accent 2", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo202 = new LatentStyleExceptionInfo( ) { Name = "Medium Shading 2 Accent 2", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo203 = new LatentStyleExceptionInfo( ) { Name = "Medium List 1 Accent 2", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo204 = new LatentStyleExceptionInfo( ) { Name = "Medium List 2 Accent 2", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo205 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 1 Accent 2", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo206 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 2 Accent 2", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo207 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 3 Accent 2", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo208 = new LatentStyleExceptionInfo( ) { Name = "Dark List Accent 2", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo209 = new LatentStyleExceptionInfo( ) { Name = "Colorful Shading Accent 2", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo210 = new LatentStyleExceptionInfo( ) { Name = "Colorful List Accent 2", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo211 = new LatentStyleExceptionInfo( ) { Name = "Colorful Grid Accent 2", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo212 = new LatentStyleExceptionInfo( ) { Name = "Light Shading Accent 3", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo213 = new LatentStyleExceptionInfo( ) { Name = "Light List Accent 3", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo214 = new LatentStyleExceptionInfo( ) { Name = "Light Grid Accent 3", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo215 = new LatentStyleExceptionInfo( ) { Name = "Medium Shading 1 Accent 3", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo216 = new LatentStyleExceptionInfo( ) { Name = "Medium Shading 2 Accent 3", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo217 = new LatentStyleExceptionInfo( ) { Name = "Medium List 1 Accent 3", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo218 = new LatentStyleExceptionInfo( ) { Name = "Medium List 2 Accent 3", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo219 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 1 Accent 3", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo220 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 2 Accent 3", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo221 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 3 Accent 3", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo222 = new LatentStyleExceptionInfo( ) { Name = "Dark List Accent 3", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo223 = new LatentStyleExceptionInfo( ) { Name = "Colorful Shading Accent 3", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo224 = new LatentStyleExceptionInfo( ) { Name = "Colorful List Accent 3", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo225 = new LatentStyleExceptionInfo( ) { Name = "Colorful Grid Accent 3", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo226 = new LatentStyleExceptionInfo( ) { Name = "Light Shading Accent 4", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo227 = new LatentStyleExceptionInfo( ) { Name = "Light List Accent 4", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo228 = new LatentStyleExceptionInfo( ) { Name = "Light Grid Accent 4", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo229 = new LatentStyleExceptionInfo( ) { Name = "Medium Shading 1 Accent 4", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo230 = new LatentStyleExceptionInfo( ) { Name = "Medium Shading 2 Accent 4", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo231 = new LatentStyleExceptionInfo( ) { Name = "Medium List 1 Accent 4", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo232 = new LatentStyleExceptionInfo( ) { Name = "Medium List 2 Accent 4", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo233 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 1 Accent 4", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo234 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 2 Accent 4", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo235 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 3 Accent 4", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo236 = new LatentStyleExceptionInfo( ) { Name = "Dark List Accent 4", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo237 = new LatentStyleExceptionInfo( ) { Name = "Colorful Shading Accent 4", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo238 = new LatentStyleExceptionInfo( ) { Name = "Colorful List Accent 4", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo239 = new LatentStyleExceptionInfo( ) { Name = "Colorful Grid Accent 4", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo240 = new LatentStyleExceptionInfo( ) { Name = "Light Shading Accent 5", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo241 = new LatentStyleExceptionInfo( ) { Name = "Light List Accent 5", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo242 = new LatentStyleExceptionInfo( ) { Name = "Light Grid Accent 5", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo243 = new LatentStyleExceptionInfo( ) { Name = "Medium Shading 1 Accent 5", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo244 = new LatentStyleExceptionInfo( ) { Name = "Medium Shading 2 Accent 5", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo245 = new LatentStyleExceptionInfo( ) { Name = "Medium List 1 Accent 5", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo246 = new LatentStyleExceptionInfo( ) { Name = "Medium List 2 Accent 5", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo247 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 1 Accent 5", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo248 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 2 Accent 5", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo249 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 3 Accent 5", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo250 = new LatentStyleExceptionInfo( ) { Name = "Dark List Accent 5", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo251 = new LatentStyleExceptionInfo( ) { Name = "Colorful Shading Accent 5", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo252 = new LatentStyleExceptionInfo( ) { Name = "Colorful List Accent 5", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo253 = new LatentStyleExceptionInfo( ) { Name = "Colorful Grid Accent 5", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo254 = new LatentStyleExceptionInfo( ) { Name = "Light Shading Accent 6", UiPriority = 60, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo255 = new LatentStyleExceptionInfo( ) { Name = "Light List Accent 6", UiPriority = 61, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo256 = new LatentStyleExceptionInfo( ) { Name = "Light Grid Accent 6", UiPriority = 62, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo257 = new LatentStyleExceptionInfo( ) { Name = "Medium Shading 1 Accent 6", UiPriority = 63, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo258 = new LatentStyleExceptionInfo( ) { Name = "Medium Shading 2 Accent 6", UiPriority = 64, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo259 = new LatentStyleExceptionInfo( ) { Name = "Medium List 1 Accent 6", UiPriority = 65, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo260 = new LatentStyleExceptionInfo( ) { Name = "Medium List 2 Accent 6", UiPriority = 66, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo261 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 1 Accent 6", UiPriority = 67, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo262 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 2 Accent 6", UiPriority = 68, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo263 = new LatentStyleExceptionInfo( ) { Name = "Medium Grid 3 Accent 6", UiPriority = 69, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo264 = new LatentStyleExceptionInfo( ) { Name = "Dark List Accent 6", UiPriority = 70, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo265 = new LatentStyleExceptionInfo( ) { Name = "Colorful Shading Accent 6", UiPriority = 71, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo266 = new LatentStyleExceptionInfo( ) { Name = "Colorful List Accent 6", UiPriority = 72, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo267 = new LatentStyleExceptionInfo( ) { Name = "Colorful Grid Accent 6", UiPriority = 73, SemiHidden = false, UnhideWhenUsed = false };
            //LatentStyleExceptionInfo latentStyleExceptionInfo268 = new LatentStyleExceptionInfo( ) { Name = "Subtle Emphasis", UiPriority = 19, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            //LatentStyleExceptionInfo latentStyleExceptionInfo269 = new LatentStyleExceptionInfo( ) { Name = "Intense Emphasis", UiPriority = 21, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            //LatentStyleExceptionInfo latentStyleExceptionInfo270 = new LatentStyleExceptionInfo( ) { Name = "Subtle Reference", UiPriority = 31, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            //LatentStyleExceptionInfo latentStyleExceptionInfo271 = new LatentStyleExceptionInfo( ) { Name = "Intense Reference", UiPriority = 32, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            //LatentStyleExceptionInfo latentStyleExceptionInfo272 = new LatentStyleExceptionInfo( ) { Name = "Book Title", UiPriority = 33, SemiHidden = false, UnhideWhenUsed = false, PrimaryStyle = true };
            //LatentStyleExceptionInfo latentStyleExceptionInfo273 = new LatentStyleExceptionInfo( ) { Name = "Bibliography", UiPriority = 37 };
            //LatentStyleExceptionInfo latentStyleExceptionInfo274 = new LatentStyleExceptionInfo( ) { Name = "TOC Heading", UiPriority = 39, PrimaryStyle = true };

            latentStyles2.Append( latentStyleExceptionInfo138 );
            latentStyles2.Append( latentStyleExceptionInfo139 );
            latentStyles2.Append( latentStyleExceptionInfo140 );
            latentStyles2.Append( latentStyleExceptionInfo141 );
            latentStyles2.Append( latentStyleExceptionInfo142 );
            //latentStyles2.Append( latentStyleExceptionInfo143 );
            //latentStyles2.Append( latentStyleExceptionInfo144 );
            //latentStyles2.Append( latentStyleExceptionInfo145 );
            //latentStyles2.Append( latentStyleExceptionInfo146 );
            //latentStyles2.Append( latentStyleExceptionInfo147 );
            //latentStyles2.Append( latentStyleExceptionInfo148 );
            //latentStyles2.Append( latentStyleExceptionInfo149 );
            //latentStyles2.Append( latentStyleExceptionInfo150 );
            //latentStyles2.Append( latentStyleExceptionInfo151 );
            //latentStyles2.Append( latentStyleExceptionInfo152 );
            //latentStyles2.Append( latentStyleExceptionInfo153 );
            //latentStyles2.Append( latentStyleExceptionInfo154 );
            //latentStyles2.Append( latentStyleExceptionInfo155 );
            //latentStyles2.Append( latentStyleExceptionInfo156 );
            //latentStyles2.Append( latentStyleExceptionInfo157 );
            //latentStyles2.Append( latentStyleExceptionInfo158 );
            //latentStyles2.Append( latentStyleExceptionInfo159 );
            //latentStyles2.Append( latentStyleExceptionInfo160 );
            //latentStyles2.Append( latentStyleExceptionInfo161 );
            //latentStyles2.Append( latentStyleExceptionInfo162 );
            //latentStyles2.Append( latentStyleExceptionInfo163 );
            //latentStyles2.Append( latentStyleExceptionInfo164 );
            //latentStyles2.Append( latentStyleExceptionInfo165 );
            //latentStyles2.Append( latentStyleExceptionInfo166 );
            //latentStyles2.Append( latentStyleExceptionInfo167 );
            //latentStyles2.Append( latentStyleExceptionInfo168 );
            //latentStyles2.Append( latentStyleExceptionInfo169 );
            //latentStyles2.Append( latentStyleExceptionInfo170 );
            //latentStyles2.Append( latentStyleExceptionInfo171 );
            //latentStyles2.Append( latentStyleExceptionInfo172 );
            //latentStyles2.Append( latentStyleExceptionInfo173 );
            //latentStyles2.Append( latentStyleExceptionInfo174 );
            //latentStyles2.Append( latentStyleExceptionInfo175 );
            //latentStyles2.Append( latentStyleExceptionInfo176 );
            //latentStyles2.Append( latentStyleExceptionInfo177 );
            //latentStyles2.Append( latentStyleExceptionInfo178 );
            //latentStyles2.Append( latentStyleExceptionInfo179 );
            //latentStyles2.Append( latentStyleExceptionInfo180 );
            //latentStyles2.Append( latentStyleExceptionInfo181 );
            //latentStyles2.Append( latentStyleExceptionInfo182 );
            //latentStyles2.Append( latentStyleExceptionInfo183 );
            //latentStyles2.Append( latentStyleExceptionInfo184 );
            //latentStyles2.Append( latentStyleExceptionInfo185 );
            //latentStyles2.Append( latentStyleExceptionInfo186 );
            //latentStyles2.Append( latentStyleExceptionInfo187 );
            //latentStyles2.Append( latentStyleExceptionInfo188 );
            //latentStyles2.Append( latentStyleExceptionInfo189 );
            //latentStyles2.Append( latentStyleExceptionInfo190 );
            //latentStyles2.Append( latentStyleExceptionInfo191 );
            //latentStyles2.Append( latentStyleExceptionInfo192 );
            //latentStyles2.Append( latentStyleExceptionInfo193 );
            //latentStyles2.Append( latentStyleExceptionInfo194 );
            //latentStyles2.Append( latentStyleExceptionInfo195 );
            //latentStyles2.Append( latentStyleExceptionInfo196 );
            //latentStyles2.Append( latentStyleExceptionInfo197 );
            //latentStyles2.Append( latentStyleExceptionInfo198 );
            //latentStyles2.Append( latentStyleExceptionInfo199 );
            //latentStyles2.Append( latentStyleExceptionInfo200 );
            //latentStyles2.Append( latentStyleExceptionInfo201 );
            //latentStyles2.Append( latentStyleExceptionInfo202 );
            //latentStyles2.Append( latentStyleExceptionInfo203 );
            //latentStyles2.Append( latentStyleExceptionInfo204 );
            //latentStyles2.Append( latentStyleExceptionInfo205 );
            //latentStyles2.Append( latentStyleExceptionInfo206 );
            //latentStyles2.Append( latentStyleExceptionInfo207 );
            //latentStyles2.Append( latentStyleExceptionInfo208 );
            //latentStyles2.Append( latentStyleExceptionInfo209 );
            //latentStyles2.Append( latentStyleExceptionInfo210 );
            //latentStyles2.Append( latentStyleExceptionInfo211 );
            //latentStyles2.Append( latentStyleExceptionInfo212 );
            //latentStyles2.Append( latentStyleExceptionInfo213 );
            //latentStyles2.Append( latentStyleExceptionInfo214 );
            //latentStyles2.Append( latentStyleExceptionInfo215 );
            //latentStyles2.Append( latentStyleExceptionInfo216 );
            //latentStyles2.Append( latentStyleExceptionInfo217 );
            //latentStyles2.Append( latentStyleExceptionInfo218 );
            //latentStyles2.Append( latentStyleExceptionInfo219 );
            //latentStyles2.Append( latentStyleExceptionInfo220 );
            //latentStyles2.Append( latentStyleExceptionInfo221 );
            //latentStyles2.Append( latentStyleExceptionInfo222 );
            //latentStyles2.Append( latentStyleExceptionInfo223 );
            //latentStyles2.Append( latentStyleExceptionInfo224 );
            //latentStyles2.Append( latentStyleExceptionInfo225 );
            //latentStyles2.Append( latentStyleExceptionInfo226 );
            //latentStyles2.Append( latentStyleExceptionInfo227 );
            //latentStyles2.Append( latentStyleExceptionInfo228 );
            //latentStyles2.Append( latentStyleExceptionInfo229 );
            //latentStyles2.Append( latentStyleExceptionInfo230 );
            //latentStyles2.Append( latentStyleExceptionInfo231 );
            //latentStyles2.Append( latentStyleExceptionInfo232 );
            //latentStyles2.Append( latentStyleExceptionInfo233 );
            //latentStyles2.Append( latentStyleExceptionInfo234 );
            //latentStyles2.Append( latentStyleExceptionInfo235 );
            //latentStyles2.Append( latentStyleExceptionInfo236 );
            //latentStyles2.Append( latentStyleExceptionInfo237 );
            //latentStyles2.Append( latentStyleExceptionInfo238 );
            //latentStyles2.Append( latentStyleExceptionInfo239 );
            //latentStyles2.Append( latentStyleExceptionInfo240 );
            //latentStyles2.Append( latentStyleExceptionInfo241 );
            //latentStyles2.Append( latentStyleExceptionInfo242 );
            //latentStyles2.Append( latentStyleExceptionInfo243 );
            //latentStyles2.Append( latentStyleExceptionInfo244 );
            //latentStyles2.Append( latentStyleExceptionInfo245 );
            //latentStyles2.Append( latentStyleExceptionInfo246 );
            //latentStyles2.Append( latentStyleExceptionInfo247 );
            //latentStyles2.Append( latentStyleExceptionInfo248 );
            //latentStyles2.Append( latentStyleExceptionInfo249 );
            //latentStyles2.Append( latentStyleExceptionInfo250 );
            //latentStyles2.Append( latentStyleExceptionInfo251 );
            //latentStyles2.Append( latentStyleExceptionInfo252 );
            //latentStyles2.Append( latentStyleExceptionInfo253 );
            //latentStyles2.Append( latentStyleExceptionInfo254 );
            //latentStyles2.Append( latentStyleExceptionInfo255 );
            //latentStyles2.Append( latentStyleExceptionInfo256 );
            //latentStyles2.Append( latentStyleExceptionInfo257 );
            //latentStyles2.Append( latentStyleExceptionInfo258 );
            //latentStyles2.Append( latentStyleExceptionInfo259 );
            //latentStyles2.Append( latentStyleExceptionInfo260 );
            //latentStyles2.Append( latentStyleExceptionInfo261 );
            //latentStyles2.Append( latentStyleExceptionInfo262 );
            //latentStyles2.Append( latentStyleExceptionInfo263 );
            //latentStyles2.Append( latentStyleExceptionInfo264 );
            //latentStyles2.Append( latentStyleExceptionInfo265 );
            //latentStyles2.Append( latentStyleExceptionInfo266 );
            //latentStyles2.Append( latentStyleExceptionInfo267 );
            //latentStyles2.Append( latentStyleExceptionInfo268 );
            //latentStyles2.Append( latentStyleExceptionInfo269 );
            //latentStyles2.Append( latentStyleExceptionInfo270 );
            //latentStyles2.Append( latentStyleExceptionInfo271 );
            //latentStyles2.Append( latentStyleExceptionInfo272 );
            //latentStyles2.Append( latentStyleExceptionInfo273 );
            //latentStyles2.Append( latentStyleExceptionInfo274 );
            return latentStyles2;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Style MakeStyleDefaultFont( )
        {
            Style style9 = new Style( ) { Type = StyleValues.Character, StyleId = "a0", Default = true };
            StyleName styleName9 = new StyleName( ) { Val = "Default Paragraph Font" };
            UIPriority uIPriority7 = new UIPriority( ) { Val = 1 };
            SemiHidden semiHidden4 = new SemiHidden( );
            UnhideWhenUsed unhideWhenUsed4 = new UnhideWhenUsed( );

            style9.Append( styleName9 );
            style9.Append( uIPriority7 );
            style9.Append( semiHidden4 );
            style9.Append( unhideWhenUsed4 );
            return style9;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Style MakeStyleNormalTable( )
        {
            Style style10 = new Style( ) { Type = StyleValues.Table, StyleId = "a1", Default = true };
            StyleName styleName10 = new StyleName( ) { Val = "Normal Table" };
            UIPriority uIPriority8 = new UIPriority( ) { Val = 99 };
            SemiHidden semiHidden5 = new SemiHidden( );
            UnhideWhenUsed unhideWhenUsed5 = new UnhideWhenUsed( );

            StyleTableProperties styleTableProperties2 = new StyleTableProperties( );
            TableIndentation tableIndentation2 = new TableIndentation( ) { Width = 0, Type = TableWidthUnitValues.Dxa };

            TableCellMarginDefault tableCellMarginDefault2 = new TableCellMarginDefault( );
            TopMargin topMargin2 = new TopMargin( ) { Width = "0", Type = TableWidthUnitValues.Dxa };
            TableCellLeftMargin tableCellLeftMargin2 = new TableCellLeftMargin( ) { Width = 108, Type = TableWidthValues.Dxa };
            BottomMargin bottomMargin2 = new BottomMargin( ) { Width = "0", Type = TableWidthUnitValues.Dxa };
            TableCellRightMargin tableCellRightMargin2 = new TableCellRightMargin( ) { Width = 108, Type = TableWidthValues.Dxa };

            tableCellMarginDefault2.Append( topMargin2 );
            tableCellMarginDefault2.Append( tableCellLeftMargin2 );
            tableCellMarginDefault2.Append( bottomMargin2 );
            tableCellMarginDefault2.Append( tableCellRightMargin2 );

            styleTableProperties2.Append( tableIndentation2 );
            styleTableProperties2.Append( tableCellMarginDefault2 );

            style10.Append( styleName10 );
            style10.Append( uIPriority8 );
            style10.Append( semiHidden5 );
            style10.Append( unhideWhenUsed5 );
            style10.Append( styleTableProperties2 );
            return style10;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Style MakeStyleNoList( )
        {
            Style style11 = new Style( ) { Type = StyleValues.Numbering, StyleId = "a2", Default = true };
            StyleName styleName11 = new StyleName( ) { Val = "No List" };
            UIPriority uIPriority9 = new UIPriority( ) { Val = 99 };
            SemiHidden semiHidden6 = new SemiHidden( );
            UnhideWhenUsed unhideWhenUsed6 = new UnhideWhenUsed( );

            style11.Append( styleName11 );
            style11.Append( uIPriority9 );
            style11.Append( semiHidden6 );
            style11.Append( unhideWhenUsed6 );
            return style11;
        }

        //.....................................................................
        /// <summary>
        /// 正文样式
        /// </summary>
        /// <returns></returns>
        private Style MakeStyleTextNormal( )
        {
            StyleName styleName7 = new StyleName( ) { Val = "Normal" };

            PrimaryStyle primaryStyle3 = new PrimaryStyle( );

            //.............................................
            WidowControl widowControl2 = new WidowControl( ) { Val = false };
            Justification justification2 = new Justification( ) { Val = JustificationValues.Both };

            StyleParagraphProperties styleParagraphProperties3 = new StyleParagraphProperties( );
            styleParagraphProperties3.Append( widowControl2 );
            styleParagraphProperties3.Append( justification2 );

            //.............................................
            Style styleTXT = new Style( ) { Type = StyleValues.Paragraph, StyleId = "a", Default = true };
            styleTXT.Append( styleName7 );
            styleTXT.Append( primaryStyle3 );
            styleTXT.Append( styleParagraphProperties3 );

            return styleTXT;
        }

        //.............................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Style MakeStyleHeading001( )
        {
            StyleName styleName8 = new StyleName( ) { Val = "heading 1" };

            BasedOn basedOn3 = new BasedOn( ) { Val = "a" };

            NextParagraphStyle nextParagraphStyle2 = new NextParagraphStyle( ) { Val = "a" };

            LinkedStyle linkedStyle3 = new LinkedStyle( ) { Val = "1Char" };

            UIPriority uIPriority6 = new UIPriority( ) { Val = 9 };

            PrimaryStyle primaryStyle4 = new PrimaryStyle( );

            Rsid rsid5 = new Rsid( ) { Val = "006F111A" };

            //.............................................
            KeepNext keepNext2 = new KeepNext( );
            KeepLines keepLines2 = new KeepLines( );
            SpacingBetweenLines spacingBetweenLines2 = new SpacingBetweenLines( ) { Before = "340", After = "330", Line = "578", LineRule = LineSpacingRuleValues.Auto };
            OutlineLevel outlineLevel2 = new OutlineLevel( ) { Val = 0 };

            StyleParagraphProperties styleParagraphProperties4 = new StyleParagraphProperties( );
            styleParagraphProperties4.Append( keepNext2 );
            styleParagraphProperties4.Append( keepLines2 );
            styleParagraphProperties4.Append( spacingBetweenLines2 );
            styleParagraphProperties4.Append( outlineLevel2 );

            //.............................................
            Bold bold3 = new Bold( );
            BoldComplexScript boldComplexScript3 = new BoldComplexScript( );
            Kern kern5 = new Kern( ) { Val = ( UInt32Value ) 44U };
            FontSize fontSize5 = new FontSize( ) { Val = "44" };
            FontSizeComplexScript fontSizeComplexScript5 = new FontSizeComplexScript( ) { Val = "44" };

            StyleRunProperties styleRunProperties3 = new StyleRunProperties( );
            styleRunProperties3.Append( bold3 );
            styleRunProperties3.Append( boldComplexScript3 );
            styleRunProperties3.Append( kern5 );
            styleRunProperties3.Append( fontSize5 );
            styleRunProperties3.Append( fontSizeComplexScript5 );

            //.............................................
            Style styleH1 = new Style( ) { Type = StyleValues.Paragraph, StyleId = "1" };

            styleH1.Append( styleName8 );
            styleH1.Append( basedOn3 );
            styleH1.Append( nextParagraphStyle2 );
            styleH1.Append( linkedStyle3 );
            styleH1.Append( uIPriority6 );
            styleH1.Append( primaryStyle4 );
            styleH1.Append( rsid5 );

            styleH1.Append( styleParagraphProperties4 );
            styleH1.Append( styleRunProperties3 );

            return styleH1;
        }

        //.....................................................................
        /// <summary>
        /// Creates an Style instance and adds its children.
        /// </summary>
        /// <returns></returns>
        public Style MakeStyleHeading002( )
        {
            Style style1 = new Style( ) { Type = StyleValues.Paragraph, StyleId = "2" };

            StyleName styleName1 = new StyleName( ) { Val = "heading 2" };
            BasedOn basedOn1 = new BasedOn( ) { Val = "a" };
            NextParagraphStyle nextParagraphStyle1 = new NextParagraphStyle( ) { Val = "a" };
            LinkedStyle linkedStyle1 = new LinkedStyle( ) { Val = "2Char" };
            UIPriority uIPriority1 = new UIPriority( ) { Val = 9 };
            UnhideWhenUsed unhideWhenUsed1 = new UnhideWhenUsed( );
            PrimaryStyle primaryStyle1 = new PrimaryStyle( );

            //Rsid rsid1 = new Rsid( ) { Val = "00FD4466" };

            StyleParagraphProperties styleParagraphProperties1 = new StyleParagraphProperties( );
            KeepNext keepNext1 = new KeepNext( );
            KeepLines keepLines1 = new KeepLines( );
            SpacingBetweenLines spacingBetweenLines1 = new SpacingBetweenLines( ) { Before = "260", After = "260", Line = "416", LineRule = LineSpacingRuleValues.Auto };
            OutlineLevel outlineLevel1 = new OutlineLevel( ) { Val = 1 };

            styleParagraphProperties1.Append( keepNext1 );
            styleParagraphProperties1.Append( keepLines1 );
            styleParagraphProperties1.Append( spacingBetweenLines1 );
            styleParagraphProperties1.Append( outlineLevel1 );

            StyleRunProperties styleRunProperties1 = new StyleRunProperties( );
            RunFonts runFonts1 = new RunFonts( ) { AsciiTheme = ThemeFontValues.MajorHighAnsi, HighAnsiTheme = ThemeFontValues.MajorHighAnsi, EastAsiaTheme = ThemeFontValues.MajorEastAsia, ComplexScriptTheme = ThemeFontValues.MajorBidi };
            Bold bold1 = new Bold( );
            BoldComplexScript boldComplexScript1 = new BoldComplexScript( );
            FontSize fontSize1 = new FontSize( ) { Val = "32" };
            FontSizeComplexScript fontSizeComplexScript1 = new FontSizeComplexScript( ) { Val = "32" };

            styleRunProperties1.Append( runFonts1 );
            styleRunProperties1.Append( bold1 );
            styleRunProperties1.Append( boldComplexScript1 );
            styleRunProperties1.Append( fontSize1 );
            styleRunProperties1.Append( fontSizeComplexScript1 );

            style1.Append( styleName1 );
            style1.Append( basedOn1 );
            style1.Append( nextParagraphStyle1 );
            style1.Append( linkedStyle1 );
            style1.Append( uIPriority1 );
            style1.Append( unhideWhenUsed1 );
            style1.Append( primaryStyle1 );

            //style1.Append( rsid1 );

            style1.Append( styleParagraphProperties1 );
            style1.Append( styleRunProperties1 );

            return style1;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Style MakeStyleHeading003( )
        {
            Style style1 = new Style( ) { Type = StyleValues.Paragraph, StyleId = "3" };

            StyleName styleName1 = new StyleName( ) { Val = "heading 3" };
            BasedOn basedOn1 = new BasedOn( ) { Val = "a" };
            NextParagraphStyle nextParagraphStyle1 = new NextParagraphStyle( ) { Val = "a" };
            LinkedStyle linkedStyle1 = new LinkedStyle( ) { Val = "3Char" };
            UIPriority uIPriority1 = new UIPriority( ) { Val = 9 };
            UnhideWhenUsed unhideWhenUsed1 = new UnhideWhenUsed( );
            PrimaryStyle primaryStyle1 = new PrimaryStyle( );
            Rsid rsid1 = new Rsid( ) { Val = "00CA7AD3" };

            StyleParagraphProperties styleParagraphProperties1 = new StyleParagraphProperties( );
            KeepNext keepNext1 = new KeepNext( );
            KeepLines keepLines1 = new KeepLines( );
            SpacingBetweenLines spacingBetweenLines1 = new SpacingBetweenLines( ) { Before = "260", After = "260", Line = "416", LineRule = LineSpacingRuleValues.Auto };
            OutlineLevel outlineLevel1 = new OutlineLevel( ) { Val = 2 };

            styleParagraphProperties1.Append( keepNext1 );
            styleParagraphProperties1.Append( keepLines1 );
            styleParagraphProperties1.Append( spacingBetweenLines1 );
            styleParagraphProperties1.Append( outlineLevel1 );

            StyleRunProperties styleRunProperties1 = new StyleRunProperties( );
            Bold bold1 = new Bold( );
            BoldComplexScript boldComplexScript1 = new BoldComplexScript( );
            FontSize fontSize1 = new FontSize( ) { Val = "32" };
            FontSizeComplexScript fontSizeComplexScript1 = new FontSizeComplexScript( ) { Val = "32" };

            styleRunProperties1.Append( bold1 );
            styleRunProperties1.Append( boldComplexScript1 );
            styleRunProperties1.Append( fontSize1 );
            styleRunProperties1.Append( fontSizeComplexScript1 );

            style1.Append( styleName1 );
            style1.Append( basedOn1 );
            style1.Append( nextParagraphStyle1 );
            style1.Append( linkedStyle1 );
            style1.Append( uIPriority1 );
            style1.Append( unhideWhenUsed1 );
            style1.Append( primaryStyle1 );
            style1.Append( rsid1 );
            style1.Append( styleParagraphProperties1 );
            style1.Append( styleRunProperties1 );

            return style1;
        }

        //.....................................................................
        /// <summary>
        /// Creates an Style instance and adds its children.
        /// </summary>
        /// <returns></returns>
        public Style MakeStyleHeading004( )
        {
            Style style1 = new Style( ) { Type = StyleValues.Paragraph, StyleId = "4" };

            StyleName styleName1 = new StyleName( ) { Val = "heading 4" };
            BasedOn basedOn1 = new BasedOn( ) { Val = "a" };
            NextParagraphStyle nextParagraphStyle1 = new NextParagraphStyle( ) { Val = "a" };
            LinkedStyle linkedStyle1 = new LinkedStyle( ) { Val = "4Char" };
            UIPriority uIPriority1 = new UIPriority( ) { Val = 9 };
            UnhideWhenUsed unhideWhenUsed1 = new UnhideWhenUsed( );
            PrimaryStyle primaryStyle1 = new PrimaryStyle( );
            Rsid rsid1 = new Rsid( ) { Val = "00FC2A40" };

            StyleParagraphProperties styleParagraphProperties1 = new StyleParagraphProperties( );
            KeepNext keepNext1 = new KeepNext( );
            KeepLines keepLines1 = new KeepLines( );
            SpacingBetweenLines spacingBetweenLines1 = new SpacingBetweenLines( ) { Before = "280", After = "290", Line = "376", LineRule = LineSpacingRuleValues.Auto };
            OutlineLevel outlineLevel1 = new OutlineLevel( ) { Val = 3 };

            styleParagraphProperties1.Append( keepNext1 );
            styleParagraphProperties1.Append( keepLines1 );
            styleParagraphProperties1.Append( spacingBetweenLines1 );
            styleParagraphProperties1.Append( outlineLevel1 );

            StyleRunProperties styleRunProperties1 = new StyleRunProperties( );
            RunFonts runFonts1 = new RunFonts( ) { AsciiTheme = ThemeFontValues.MajorHighAnsi, HighAnsiTheme = ThemeFontValues.MajorHighAnsi, EastAsiaTheme = ThemeFontValues.MajorEastAsia, ComplexScriptTheme = ThemeFontValues.MajorBidi };
            Bold bold1 = new Bold( );
            BoldComplexScript boldComplexScript1 = new BoldComplexScript( );
            FontSize fontSize1 = new FontSize( ) { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript1 = new FontSizeComplexScript( ) { Val = "28" };

            styleRunProperties1.Append( runFonts1 );
            styleRunProperties1.Append( bold1 );
            styleRunProperties1.Append( boldComplexScript1 );
            styleRunProperties1.Append( fontSize1 );
            styleRunProperties1.Append( fontSizeComplexScript1 );

            style1.Append( styleName1 );
            style1.Append( basedOn1 );
            style1.Append( nextParagraphStyle1 );
            style1.Append( linkedStyle1 );
            style1.Append( uIPriority1 );
            style1.Append( unhideWhenUsed1 );
            style1.Append( primaryStyle1 );
            style1.Append( rsid1 );
            style1.Append( styleParagraphProperties1 );
            style1.Append( styleRunProperties1 );

            return style1;
        }

        //.....................................................................
        /// <summary>
        /// Creates an Style instance and adds its children.
        /// </summary>
        /// <returns></returns>
        public Style MakeStyleHeading005( )
        {
            Style style1 = new Style( ) { Type = StyleValues.Paragraph, StyleId = "5" };

            StyleName styleName1 = new StyleName( ) { Val = "heading 5" };
            BasedOn basedOn1 = new BasedOn( ) { Val = "a" };
            NextParagraphStyle nextParagraphStyle1 = new NextParagraphStyle( ) { Val = "a" };
            LinkedStyle linkedStyle1 = new LinkedStyle( ) { Val = "5Char" };
            UIPriority uIPriority1 = new UIPriority( ) { Val = 9 };
            UnhideWhenUsed unhideWhenUsed1 = new UnhideWhenUsed( );
            PrimaryStyle primaryStyle1 = new PrimaryStyle( );
            Rsid rsid1 = new Rsid( ) { Val = "00B3026C" };

            StyleParagraphProperties styleParagraphProperties1 = new StyleParagraphProperties( );
            KeepNext keepNext1 = new KeepNext( );
            KeepLines keepLines1 = new KeepLines( );
            SpacingBetweenLines spacingBetweenLines1 = new SpacingBetweenLines( ) { Before = "280", After = "290", Line = "376", LineRule = LineSpacingRuleValues.Auto };
            OutlineLevel outlineLevel1 = new OutlineLevel( ) { Val = 4 };

            styleParagraphProperties1.Append( keepNext1 );
            styleParagraphProperties1.Append( keepLines1 );
            styleParagraphProperties1.Append( spacingBetweenLines1 );
            styleParagraphProperties1.Append( outlineLevel1 );

            StyleRunProperties styleRunProperties1 = new StyleRunProperties( );
            Bold bold1 = new Bold( );
            BoldComplexScript boldComplexScript1 = new BoldComplexScript( );
            FontSize fontSize1 = new FontSize( ) { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript1 = new FontSizeComplexScript( ) { Val = "28" };

            styleRunProperties1.Append( bold1 );
            styleRunProperties1.Append( boldComplexScript1 );
            styleRunProperties1.Append( fontSize1 );
            styleRunProperties1.Append( fontSizeComplexScript1 );

            style1.Append( styleName1 );
            style1.Append( basedOn1 );
            style1.Append( nextParagraphStyle1 );
            style1.Append( linkedStyle1 );
            style1.Append( uIPriority1 );
            style1.Append( unhideWhenUsed1 );
            style1.Append( primaryStyle1 );
            style1.Append( rsid1 );
            style1.Append( styleParagraphProperties1 );
            style1.Append( styleRunProperties1 );

            return style1;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Style MakeStyleHeading01Han( )
        {
            Style style12 = new Style( ) { Type = StyleValues.Character, StyleId = "1Char", CustomStyle = true };

            StyleName styleName12 = new StyleName( ) { Val = "标题 1 Char" };
            BasedOn basedOn4 = new BasedOn( ) { Val = "a0" };
            LinkedStyle linkedStyle4 = new LinkedStyle( ) { Val = "1" };
            UIPriority uIPriority10 = new UIPriority( ) { Val = 9 };
            Rsid rsid6 = new Rsid( ) { Val = "006F111A" };

            StyleRunProperties styleRunProperties4 = new StyleRunProperties( );
            Bold bold4 = new Bold( );
            BoldComplexScript boldComplexScript4 = new BoldComplexScript( );
            Kern kern6 = new Kern( ) { Val = ( UInt32Value ) 44U };
            FontSize fontSize6 = new FontSize( ) { Val = "44" };
            FontSizeComplexScript fontSizeComplexScript6 = new FontSizeComplexScript( ) { Val = "44" };

            styleRunProperties4.Append( bold4 );
            styleRunProperties4.Append( boldComplexScript4 );
            styleRunProperties4.Append( kern6 );
            styleRunProperties4.Append( fontSize6 );
            styleRunProperties4.Append( fontSizeComplexScript6 );

            style12.Append( styleName12 );
            style12.Append( basedOn4 );
            style12.Append( linkedStyle4 );
            style12.Append( uIPriority10 );
            style12.Append( rsid6 );
            style12.Append( styleRunProperties4 );

            return style12;
        }

        //.....................................................................
        /// <summary>
        /// Creates an Style instance and adds its children.
        /// </summary>
        /// <returns></returns>
        public Style MakeStyleHeading02Han( )
        {
            Style style1 = new Style( ) { Type = StyleValues.Character, StyleId = "2Char", CustomStyle = true };

            StyleName styleName1 = new StyleName( ) { Val = "标题 2 Char" };
            BasedOn basedOn1 = new BasedOn( ) { Val = "a0" };
            LinkedStyle linkedStyle1 = new LinkedStyle( ) { Val = "2" };
            UIPriority uIPriority1 = new UIPriority( ) { Val = 9 };
            Rsid rsid1 = new Rsid( ) { Val = "00CA7AD3" };

            StyleRunProperties styleRunProperties1 = new StyleRunProperties( );
            RunFonts runFonts1 = new RunFonts( ) { AsciiTheme = ThemeFontValues.MajorHighAnsi, HighAnsiTheme = ThemeFontValues.MajorHighAnsi, EastAsiaTheme = ThemeFontValues.MajorEastAsia, ComplexScriptTheme = ThemeFontValues.MajorBidi };
            Bold bold1 = new Bold( );
            BoldComplexScript boldComplexScript1 = new BoldComplexScript( );
            FontSize fontSize1 = new FontSize( ) { Val = "32" };
            FontSizeComplexScript fontSizeComplexScript1 = new FontSizeComplexScript( ) { Val = "32" };

            styleRunProperties1.Append( runFonts1 );
            styleRunProperties1.Append( bold1 );
            styleRunProperties1.Append( boldComplexScript1 );
            styleRunProperties1.Append( fontSize1 );
            styleRunProperties1.Append( fontSizeComplexScript1 );

            style1.Append( styleName1 );
            style1.Append( basedOn1 );
            style1.Append( linkedStyle1 );
            style1.Append( uIPriority1 );
            style1.Append( rsid1 );
            style1.Append( styleRunProperties1 );

            return style1;
        }

        //.....................................................................
        /// <summary>
        /// Creates an Style instance and adds its children.
        /// </summary>
        /// <returns></returns>
        public Style MakeStyleHeading03Han( )
        {
            Style style1 = new Style( ) { Type = StyleValues.Character, StyleId = "3Char", CustomStyle = true };
            StyleName styleName1 = new StyleName( ) { Val = "标题 3 Char" };
            BasedOn basedOn1 = new BasedOn( ) { Val = "a0" };
            LinkedStyle linkedStyle1 = new LinkedStyle( ) { Val = "3" };
            UIPriority uIPriority1 = new UIPriority( ) { Val = 9 };
            Rsid rsid1 = new Rsid( ) { Val = "00CA7AD3" };

            StyleRunProperties styleRunProperties1 = new StyleRunProperties( );
            Bold bold1 = new Bold( );
            BoldComplexScript boldComplexScript1 = new BoldComplexScript( );
            FontSize fontSize1 = new FontSize( ) { Val = "32" };
            FontSizeComplexScript fontSizeComplexScript1 = new FontSizeComplexScript( ) { Val = "32" };

            styleRunProperties1.Append( bold1 );
            styleRunProperties1.Append( boldComplexScript1 );
            styleRunProperties1.Append( fontSize1 );
            styleRunProperties1.Append( fontSizeComplexScript1 );

            style1.Append( styleName1 );
            style1.Append( basedOn1 );
            style1.Append( linkedStyle1 );
            style1.Append( uIPriority1 );
            style1.Append( rsid1 );
            style1.Append( styleRunProperties1 );

            return style1;
        }

        //.....................................................................
        /// <summary>
        /// Creates an Style instance and adds its children.
        /// </summary>
        /// <returns></returns>
        public Style MakeStyleHeading04Han( )
        {
            Style style1 = new Style( ) { Type = StyleValues.Character, StyleId = "4Char", CustomStyle = true };

            StyleName styleName1 = new StyleName( ) { Val = "标题 4 Char" };
            BasedOn basedOn1 = new BasedOn( ) { Val = "a0" };
            LinkedStyle linkedStyle1 = new LinkedStyle( ) { Val = "4" };
            UIPriority uIPriority1 = new UIPriority( ) { Val = 9 };
            Rsid rsid1 = new Rsid( ) { Val = "00FC2A40" };

            StyleRunProperties styleRunProperties1 = new StyleRunProperties( );
            RunFonts runFonts1 = new RunFonts( ) { AsciiTheme = ThemeFontValues.MajorHighAnsi, HighAnsiTheme = ThemeFontValues.MajorHighAnsi, EastAsiaTheme = ThemeFontValues.MajorEastAsia, ComplexScriptTheme = ThemeFontValues.MajorBidi };
            Bold bold1 = new Bold( );
            BoldComplexScript boldComplexScript1 = new BoldComplexScript( );
            FontSize fontSize1 = new FontSize( ) { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript1 = new FontSizeComplexScript( ) { Val = "28" };

            styleRunProperties1.Append( runFonts1 );
            styleRunProperties1.Append( bold1 );
            styleRunProperties1.Append( boldComplexScript1 );
            styleRunProperties1.Append( fontSize1 );
            styleRunProperties1.Append( fontSizeComplexScript1 );

            style1.Append( styleName1 );
            style1.Append( basedOn1 );
            style1.Append( linkedStyle1 );
            style1.Append( uIPriority1 );
            style1.Append( rsid1 );
            style1.Append( styleRunProperties1 );

            return style1;
        }

        //.....................................................................
        /// <summary>
        /// Creates an Style instance and adds its children.
        /// </summary>
        /// <returns></returns>
        public Style MakeStyleHeading05Han( )
        {
            Style style1 = new Style( ) { Type = StyleValues.Character, StyleId = "5Char", CustomStyle = true };

            StyleName styleName1 = new StyleName( ) { Val = "标题 5 Char" };
            BasedOn basedOn1 = new BasedOn( ) { Val = "a0" };
            LinkedStyle linkedStyle1 = new LinkedStyle( ) { Val = "5" };
            UIPriority uIPriority1 = new UIPriority( ) { Val = 9 };
            Rsid rsid1 = new Rsid( ) { Val = "00B3026C" };

            StyleRunProperties styleRunProperties1 = new StyleRunProperties( );
            Bold bold1 = new Bold( );
            BoldComplexScript boldComplexScript1 = new BoldComplexScript( );
            FontSize fontSize1 = new FontSize( ) { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript1 = new FontSizeComplexScript( ) { Val = "28" };

            styleRunProperties1.Append( bold1 );
            styleRunProperties1.Append( boldComplexScript1 );
            styleRunProperties1.Append( fontSize1 );
            styleRunProperties1.Append( fontSizeComplexScript1 );

            style1.Append( styleName1 );
            style1.Append( basedOn1 );
            style1.Append( linkedStyle1 );
            style1.Append( uIPriority1 );
            style1.Append( rsid1 );
            style1.Append( styleRunProperties1 );
        
            return style1;
        }

        //.....................................................................
    }
}
