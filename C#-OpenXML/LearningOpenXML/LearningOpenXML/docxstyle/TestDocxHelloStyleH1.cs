using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

using M = DocumentFormat.OpenXml.Math;

namespace Hans.Opxm
{
    class TestDocxHelloStyleH1 : OpenDocxBase
    {
        // Creates an Document instance and adds its children.
        public override Document GenerateDocument()
        {
            //this.MakeNewStyleH1( );

            Document document1 = this.NewDocument( );

            Body body1 = new Body();

            //.............................................
            Paragraph paragraph1 = new Paragraph(){ RsidParagraphAddition = "00C5114C", RsidParagraphProperties = "006F111A", RsidRunAdditionDefault = "006F111A" };

            ParagraphStyleId paragraphStyleId1 = new ParagraphStyleId( ) { Val = "2" };

            //.............................................
            RunFonts runFonts1 = new RunFonts(){ Hint = FontTypeHintValues.EastAsia };

            ParagraphMarkRunProperties paragraphMarkRunProperties1 = new ParagraphMarkRunProperties( );
            paragraphMarkRunProperties1.Append( runFonts1 );

            ParagraphProperties paragraphProperties1 = new ParagraphProperties( );
            paragraphProperties1.Append( paragraphStyleId1 );
            paragraphProperties1.Append(paragraphMarkRunProperties1);

            //.............................................
            RunFonts runFonts2 = new RunFonts(){ Hint = FontTypeHintValues.EastAsia };

            RunProperties runProperties1 = new RunProperties( );
            runProperties1.Append( runFonts2 );

            Text text1 = new Text();
            text1.Text = "HELLO";

            Run run1 = new Run( );

            run1.Append( runProperties1 );
            run1.Append(text1);

            //.............................................
            //BookmarkStart bookmarkStart1 = new BookmarkStart(){ Name = "_GoBack", Id = "0" };
            //BookmarkEnd bookmarkEnd1 = new BookmarkEnd(){ Id = "0" };

            paragraph1.Append(paragraphProperties1);
            paragraph1.Append(run1);

            //docpara.Append(bookmarkStart1);
            //docpara.Append(bookmarkEnd1);

            //.............................................
            //Paragraph paragraph2 = new Paragraph(){ RsidParagraphAddition = "006F111A", RsidRunAdditionDefault = "006F111A" };

            SectionProperties sectionProperties1 = this.MakeDefaultSectionProperty( );

            body1.Append(paragraph1);
            //body1.Append(paragraph2);
            body1.Append(sectionProperties1);

            document1.Append(body1);

            return document1;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        private void MakeNewStyleH1( )
        {
            string stylename = "heading";

            //create styles definitions wbookpart
            StyleDefinitionsPart styleDefinitions = this.wordocument
                                                        .MainDocumentPart
                                                        .AddNewPart<StyleDefinitionsPart>( );

            //create style
            var style = new Style( )
            {
                Type = StyleValues.Paragraph,
                StyleId = stylename + "1",
                CustomStyle = true,
                Default = false
            };

            style.Append( new StyleName( ) { Val = stylename + " 1" } );

            var styleRunProperties = new StyleRunProperties( );

            styleRunProperties.Append( new Bold( ) );
            styleRunProperties.Append( new RunFonts( ) { Ascii = "Arial" } );
            styleRunProperties.Append( new FontSize( ) { Val = "24" } );

            style.Append( styleRunProperties );

            //create styles
            var styles = new Styles( );
            styles.Save( styleDefinitions );
            styles = styleDefinitions.Styles;

            styles.Append( style );

            return;
        }

        //.....................................................................
    }
}
