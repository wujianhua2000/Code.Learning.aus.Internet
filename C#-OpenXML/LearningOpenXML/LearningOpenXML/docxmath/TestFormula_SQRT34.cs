using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

using M = DocumentFormat.OpenXml.Math;

namespace Hans.Opxm
{
    class TestFormula_SQRT34 :OpenDocxBase
    {
        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override Document GenerateDocument()
        {
            Document document1 = new Document(){ MCAttributes = new MarkupCompatibilityAttributes(){ Ignorable = "w14 wp14" }  };

            document1.AddNamespaceDeclaration("wpc", "http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas");
            document1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            document1.AddNamespaceDeclaration("o", "urn:schemas-microsoft-com:office:office");
            document1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            document1.AddNamespaceDeclaration("m", "http://schemas.openxmlformats.org/officeDocument/2006/math");
            document1.AddNamespaceDeclaration("v", "urn:schemas-microsoft-com:vml");
            document1.AddNamespaceDeclaration("wp14", "http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing");
            document1.AddNamespaceDeclaration("wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing");
            document1.AddNamespaceDeclaration("w10", "urn:schemas-microsoft-com:office:word");
            document1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            document1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            document1.AddNamespaceDeclaration("wpg", "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup");
            document1.AddNamespaceDeclaration("wpi", "http://schemas.microsoft.com/office/word/2010/wordprocessingInk");
            document1.AddNamespaceDeclaration("wne", "http://schemas.microsoft.com/office/word/2006/wordml");
            document1.AddNamespaceDeclaration("wps", "http://schemas.microsoft.com/office/word/2010/wordprocessingShape");

            Body body1 = new Body();

            Paragraph paragraph1 = new Paragraph(){ RsidParagraphMarkRevision = "00814392", RsidParagraphAddition = "00666F86", RsidRunAdditionDefault = "00814392" };

            //---------------------------------------------
            M.Paragraph paragraph2 = new M.Paragraph();

            M.OfficeMath officeMath1 = new M.OfficeMath();

            //---------------------------------------------
            M.Radical mathpart1 = OpenDocxMathExprs.MakeMathRadical( "x", "2" );

            M.Run mathpart2 = OpenDocxMathExprs.MakeMathRun( "+" );

            M.Radical mathpart3 = OpenDocxMathExprs.MakeMathRadical( "y", "4" );

            M.Run mathpart4 = OpenDocxMathExprs.MakeMathRun( "=w" );  

            //---------------------------------------------
            officeMath1.Append(mathpart1);
            officeMath1.Append(mathpart2);
            officeMath1.Append( mathpart3 );
            officeMath1.Append( mathpart4 );

            paragraph2.Append(officeMath1);

            paragraph1.Append(paragraph2);

            //---------------------------------------------
            Paragraph paragraph3 = new Paragraph(){ RsidParagraphMarkRevision = "00814392", RsidParagraphAddition = "00814392", RsidRunAdditionDefault = "00814392" };

            ParagraphProperties paragraphProperties1 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties1 = new ParagraphMarkRunProperties();
            RunFonts runFonts9 = new RunFonts(){ Hint = FontTypeHintValues.EastAsia };

            paragraphMarkRunProperties1.Append(runFonts9);

            paragraphProperties1.Append(paragraphMarkRunProperties1);
            BookmarkStart bookmarkStart1 = new BookmarkStart(){ Name = "_GoBack", Id = "0" };
            BookmarkEnd bookmarkEnd1 = new BookmarkEnd(){ Id = "0" };

            paragraph3.Append(paragraphProperties1);
            paragraph3.Append(bookmarkStart1);
            paragraph3.Append(bookmarkEnd1);

            SectionProperties sectionProperties1 = new SectionProperties(){ RsidRPr = "00814392", RsidR = "00814392" };
            PageSize pageSize1 = new PageSize(){ Width = (UInt32Value)11906U, Height = (UInt32Value)16838U };
            PageMargin pageMargin1 = new PageMargin(){ Top = 1440, Right = (UInt32Value)1800U, Bottom = 1440, Left = (UInt32Value)1800U, Header = (UInt32Value)851U, Footer = (UInt32Value)992U, Gutter = (UInt32Value)0U };
            Columns columns1 = new Columns(){ Space = "425" };
            DocGrid docGrid1 = new DocGrid(){ Type = DocGridValues.Lines, LinePitch = 312 };

            sectionProperties1.Append(pageSize1);
            sectionProperties1.Append(pageMargin1);
            sectionProperties1.Append(columns1);
            sectionProperties1.Append(docGrid1);

            body1.Append(paragraph1);
            body1.Append(paragraph3);
            body1.Append(sectionProperties1);

            document1.Append(body1);

            return document1;
        }


        //.....................................................................
    }
}
