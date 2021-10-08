using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;
using Wp = DocumentFormat.OpenXml.Drawing.Wordprocessing;
using A = DocumentFormat.OpenXml.Drawing;
using Pic = DocumentFormat.OpenXml.Drawing.Pictures;
using A14 = DocumentFormat.OpenXml.Office2010.Drawing;


namespace Hans.Opxm
{
    /// <summary>
    /// 
    /// </summary>
    class TestDocxPicture3 : OpenDocxBase
    {
        // Creates an Document instance and adds its children.
        public Document GenerateDocument( )
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

            Paragraph paragraph1 = MakeParaHell01( );
            Paragraph paragraph2 = MakeParaImage01( );


            Paragraph paragraph4 = MakeParaHello02( );

            Paragraph paragraph6 = MakeParaImage02( );


            Paragraph paragraph8 = MakeParaHello03( );

            Paragraph emptypara = MakeParaEmpty( );

            Paragraph paragraph10 = MakeParaImage03( );

            //.............................................
            SectionProperties sectionProperties1 = new SectionProperties( ) { RsidR = "00F8033B" };
            PageSize pageSize1 = new PageSize( ) { Width = ( UInt32Value ) 11906U, Height = ( UInt32Value ) 16838U };
            PageMargin pageMargin1 = new PageMargin( ) { Top = 1440, Right = ( UInt32Value ) 1800U, Bottom = 1440, Left = ( UInt32Value ) 1800U, Header = ( UInt32Value ) 851U, Footer = ( UInt32Value ) 992U, Gutter = ( UInt32Value ) 0U };
            Columns columns1 = new Columns( ) { Space = "425" };
            DocGrid docGrid1 = new DocGrid( ) { Type = DocGridValues.Lines, LinePitch = 312 };

            sectionProperties1.Append( pageSize1 );
            sectionProperties1.Append( pageMargin1 );
            sectionProperties1.Append( columns1 );
            sectionProperties1.Append( docGrid1 );

            //.............................................
            body1.Append( paragraph1 );
            body1.Append( paragraph2 );

            
            body1.Append( paragraph4 );
            body1.Append( paragraph6 );

            body1.Append( paragraph8 );
            body1.Append( emptypara );
            body1.Append( paragraph10 );
            
            body1.Append( sectionProperties1 );

            document1.Append( body1 );

            return document1;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Paragraph MakeParaImage03( )
        {
            Paragraph paragraph10 = new Paragraph( ) { RsidParagraphAddition = "00F8033B", RsidRunAdditionDefault = "00F8033B" };

            ParagraphProperties paragraphProperties10 = new ParagraphProperties( );

            ParagraphMarkRunProperties paragraphMarkRunProperties10 = new ParagraphMarkRunProperties( );
            RunFonts runFonts15 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            paragraphMarkRunProperties10.Append( runFonts15 );

            paragraphProperties10.Append( paragraphMarkRunProperties10 );

            Run run6 = new Run( );

            RunProperties runProperties6 = new RunProperties( );
            RunFonts runFonts16 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };
            NoProof noProof3 = new NoProof( );

            runProperties6.Append( runFonts16 );
            runProperties6.Append( noProof3 );

            Drawing drawing3 = new Drawing( );

            Wp.Inline inline3 = new Wp.Inline( ) { DistanceFromTop = ( UInt32Value ) 0U, DistanceFromBottom = ( UInt32Value ) 0U, DistanceFromLeft = ( UInt32Value ) 0U, DistanceFromRight = ( UInt32Value ) 0U };
            Wp.Extent extent3 = new Wp.Extent( ) { Cx = 1943371L, Cy = 1991003L };
            Wp.EffectExtent effectExtent3 = new Wp.EffectExtent( ) { LeftEdge = 0L, TopEdge = 0L, RightEdge = 0L, BottomEdge = 9525L };
            Wp.DocProperties docProperties3 = new Wp.DocProperties( ) { Id = ( UInt32Value ) 4U, Name = "图片 4" };

            Wp.NonVisualGraphicFrameDrawingProperties nonVisualGraphicFrameDrawingProperties3 = new Wp.NonVisualGraphicFrameDrawingProperties( );

            A.GraphicFrameLocks graphicFrameLocks3 = new A.GraphicFrameLocks( ) { NoChangeAspect = true };
            graphicFrameLocks3.AddNamespaceDeclaration( "a", "http://schemas.openxmlformats.org/drawingml/2006/main" );

            nonVisualGraphicFrameDrawingProperties3.Append( graphicFrameLocks3 );

            A.Graphic graphic3 = new A.Graphic( );
            graphic3.AddNamespaceDeclaration( "a", "http://schemas.openxmlformats.org/drawingml/2006/main" );

            A.GraphicData graphicData3 = new A.GraphicData( ) { Uri = "http://schemas.openxmlformats.org/drawingml/2006/picture" };

            Pic.Picture picture3 = new Pic.Picture( );
            picture3.AddNamespaceDeclaration( "pic", "http://schemas.openxmlformats.org/drawingml/2006/picture" );

            Pic.NonVisualPictureProperties nonVisualPictureProperties3 = new Pic.NonVisualPictureProperties( );
            Pic.NonVisualDrawingProperties nonVisualDrawingProperties3 = new Pic.NonVisualDrawingProperties( ) { Id = ( UInt32Value ) 0U, Name = "test-pic3.png" };
            Pic.NonVisualPictureDrawingProperties nonVisualPictureDrawingProperties3 = new Pic.NonVisualPictureDrawingProperties( );

            nonVisualPictureProperties3.Append( nonVisualDrawingProperties3 );
            nonVisualPictureProperties3.Append( nonVisualPictureDrawingProperties3 );

            Pic.BlipFill blipFill3 = new Pic.BlipFill( );

            A.Blip blip3 = new A.Blip( ) { Embed = "rId7" };

            A.BlipExtensionList blipExtensionList3 = new A.BlipExtensionList( );

            A.BlipExtension blipExtension3 = new A.BlipExtension( ) { Uri = "{28A0092B-C50C-407E-A947-70E740481C1C}" };

            A14.UseLocalDpi useLocalDpi3 = new A14.UseLocalDpi( ) { Val = false };
            useLocalDpi3.AddNamespaceDeclaration( "a14", "http://schemas.microsoft.com/office/drawing/2010/main" );

            blipExtension3.Append( useLocalDpi3 );

            blipExtensionList3.Append( blipExtension3 );

            blip3.Append( blipExtensionList3 );

            A.Stretch stretch3 = new A.Stretch( );
            A.FillRectangle fillRectangle3 = new A.FillRectangle( );

            stretch3.Append( fillRectangle3 );

            blipFill3.Append( blip3 );
            blipFill3.Append( stretch3 );

            Pic.ShapeProperties shapeProperties3 = new Pic.ShapeProperties( );

            A.Transform2D transform2D3 = new A.Transform2D( );
            A.Offset offset3 = new A.Offset( ) { X = 0L, Y = 0L };
            A.Extents extents3 = new A.Extents( ) { Cx = 1943371L, Cy = 1991003L };

            transform2D3.Append( offset3 );
            transform2D3.Append( extents3 );

            A.PresetGeometry presetGeometry3 = new A.PresetGeometry( ) { Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList3 = new A.AdjustValueList( );

            presetGeometry3.Append( adjustValueList3 );

            shapeProperties3.Append( transform2D3 );
            shapeProperties3.Append( presetGeometry3 );

            picture3.Append( nonVisualPictureProperties3 );
            picture3.Append( blipFill3 );
            picture3.Append( shapeProperties3 );

            graphicData3.Append( picture3 );

            graphic3.Append( graphicData3 );

            inline3.Append( extent3 );
            inline3.Append( effectExtent3 );
            inline3.Append( docProperties3 );
            inline3.Append( nonVisualGraphicFrameDrawingProperties3 );
            inline3.Append( graphic3 );

            drawing3.Append( inline3 );

            run6.Append( runProperties6 );
            run6.Append( drawing3 );

            paragraph10.Append( paragraphProperties10 );
            paragraph10.Append( run6 );
            return paragraph10;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Paragraph MakeParaEmpty( )
        {
            Paragraph paragraph9 = new Paragraph( ) { RsidParagraphAddition = "00F8033B", RsidRunAdditionDefault = "00F8033B" };

            ParagraphProperties paragraphProperties9 = new ParagraphProperties( );

            ParagraphMarkRunProperties paragraphMarkRunProperties9 = new ParagraphMarkRunProperties( );
            RunFonts runFonts14 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            paragraphMarkRunProperties9.Append( runFonts14 );

            paragraphProperties9.Append( paragraphMarkRunProperties9 );

            paragraph9.Append( paragraphProperties9 );

            return paragraph9;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Paragraph MakeParaHello03( )
        {
            Paragraph paragraph8 = new Paragraph( ) { RsidParagraphAddition = "00F8033B", RsidParagraphProperties = "00F8033B", RsidRunAdditionDefault = "00F8033B" };

            ParagraphProperties paragraphProperties8 = new ParagraphProperties( );

            ParagraphMarkRunProperties paragraphMarkRunProperties8 = new ParagraphMarkRunProperties( );
            RunFonts runFonts12 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            paragraphMarkRunProperties8.Append( runFonts12 );

            paragraphProperties8.Append( paragraphMarkRunProperties8 );

            Run run5 = new Run( );

            RunProperties runProperties5 = new RunProperties( );
            RunFonts runFonts13 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            runProperties5.Append( runFonts13 );
            Text text3 = new Text( );
            text3.Text = "HELLO3";

            run5.Append( runProperties5 );
            run5.Append( text3 );

            paragraph8.Append( paragraphProperties8 );
            paragraph8.Append( run5 );
            return paragraph8;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Paragraph MakeParaImage02( )
        {
            Paragraph paragraph6 = new Paragraph( ) { RsidParagraphAddition = "00F8033B", RsidRunAdditionDefault = "00F8033B" };

            ParagraphProperties paragraphProperties6 = new ParagraphProperties( );

            ParagraphMarkRunProperties paragraphMarkRunProperties6 = new ParagraphMarkRunProperties( );
            RunFonts runFonts9 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            paragraphMarkRunProperties6.Append( runFonts9 );

            paragraphProperties6.Append( paragraphMarkRunProperties6 );

            Run run4 = new Run( );

            RunProperties runProperties4 = new RunProperties( );
            RunFonts runFonts10 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };
            NoProof noProof2 = new NoProof( );

            runProperties4.Append( runFonts10 );
            runProperties4.Append( noProof2 );

            Drawing drawing2 = new Drawing( );

            Wp.Inline inline2 = new Wp.Inline( ) { DistanceFromTop = ( UInt32Value ) 0U, DistanceFromBottom = ( UInt32Value ) 0U, DistanceFromLeft = ( UInt32Value ) 0U, DistanceFromRight = ( UInt32Value ) 0U };
            Wp.Extent extent2 = new Wp.Extent( ) { Cx = 2534004L, Cy = 800212L };
            Wp.EffectExtent effectExtent2 = new Wp.EffectExtent( ) { LeftEdge = 0L, TopEdge = 0L, RightEdge = 0L, BottomEdge = 0L };
            Wp.DocProperties docProperties2 = new Wp.DocProperties( ) { Id = ( UInt32Value ) 3U, Name = "图片 3" };

            Wp.NonVisualGraphicFrameDrawingProperties nonVisualGraphicFrameDrawingProperties2 = new Wp.NonVisualGraphicFrameDrawingProperties( );

            A.GraphicFrameLocks graphicFrameLocks2 = new A.GraphicFrameLocks( ) { NoChangeAspect = true };
            graphicFrameLocks2.AddNamespaceDeclaration( "a", "http://schemas.openxmlformats.org/drawingml/2006/main" );

            nonVisualGraphicFrameDrawingProperties2.Append( graphicFrameLocks2 );

            A.Graphic graphic2 = new A.Graphic( );
            graphic2.AddNamespaceDeclaration( "a", "http://schemas.openxmlformats.org/drawingml/2006/main" );

            A.GraphicData graphicData2 = new A.GraphicData( ) { Uri = "http://schemas.openxmlformats.org/drawingml/2006/picture" };

            Pic.Picture picture2 = new Pic.Picture( );
            picture2.AddNamespaceDeclaration( "pic", "http://schemas.openxmlformats.org/drawingml/2006/picture" );

            Pic.NonVisualPictureProperties nonVisualPictureProperties2 = new Pic.NonVisualPictureProperties( );
            Pic.NonVisualDrawingProperties nonVisualDrawingProperties2 = new Pic.NonVisualDrawingProperties( ) { Id = ( UInt32Value ) 0U, Name = "test-pic2.png" };
            Pic.NonVisualPictureDrawingProperties nonVisualPictureDrawingProperties2 = new Pic.NonVisualPictureDrawingProperties( );

            nonVisualPictureProperties2.Append( nonVisualDrawingProperties2 );
            nonVisualPictureProperties2.Append( nonVisualPictureDrawingProperties2 );

            Pic.BlipFill blipFill2 = new Pic.BlipFill( );

            A.Blip blip2 = new A.Blip( ) { Embed = "rId6" };

            A.BlipExtensionList blipExtensionList2 = new A.BlipExtensionList( );

            A.BlipExtension blipExtension2 = new A.BlipExtension( ) { Uri = "{28A0092B-C50C-407E-A947-70E740481C1C}" };

            A14.UseLocalDpi useLocalDpi2 = new A14.UseLocalDpi( ) { Val = false };
            useLocalDpi2.AddNamespaceDeclaration( "a14", "http://schemas.microsoft.com/office/drawing/2010/main" );

            blipExtension2.Append( useLocalDpi2 );

            blipExtensionList2.Append( blipExtension2 );

            blip2.Append( blipExtensionList2 );

            A.Stretch stretch2 = new A.Stretch( );
            A.FillRectangle fillRectangle2 = new A.FillRectangle( );

            stretch2.Append( fillRectangle2 );

            blipFill2.Append( blip2 );
            blipFill2.Append( stretch2 );

            Pic.ShapeProperties shapeProperties2 = new Pic.ShapeProperties( );

            A.Transform2D transform2D2 = new A.Transform2D( );
            A.Offset offset2 = new A.Offset( ) { X = 0L, Y = 0L };
            A.Extents extents2 = new A.Extents( ) { Cx = 2534004L, Cy = 800212L };

            transform2D2.Append( offset2 );
            transform2D2.Append( extents2 );

            A.PresetGeometry presetGeometry2 = new A.PresetGeometry( ) { Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList2 = new A.AdjustValueList( );

            presetGeometry2.Append( adjustValueList2 );

            shapeProperties2.Append( transform2D2 );
            shapeProperties2.Append( presetGeometry2 );

            picture2.Append( nonVisualPictureProperties2 );
            picture2.Append( blipFill2 );
            picture2.Append( shapeProperties2 );

            graphicData2.Append( picture2 );

            graphic2.Append( graphicData2 );

            inline2.Append( extent2 );
            inline2.Append( effectExtent2 );
            inline2.Append( docProperties2 );
            inline2.Append( nonVisualGraphicFrameDrawingProperties2 );
            inline2.Append( graphic2 );

            drawing2.Append( inline2 );

            run4.Append( runProperties4 );
            run4.Append( drawing2 );

            paragraph6.Append( paragraphProperties6 );
            paragraph6.Append( run4 );
            return paragraph6;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Paragraph MakeParaHello02( )
        {
            Paragraph paragraph4 = new Paragraph( ) { RsidParagraphAddition = "00F8033B", RsidParagraphProperties = "00F8033B", RsidRunAdditionDefault = "00F8033B" };

            ParagraphProperties paragraphProperties4 = new ParagraphProperties( );

            ParagraphMarkRunProperties paragraphMarkRunProperties4 = new ParagraphMarkRunProperties( );
            RunFonts runFonts6 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            paragraphMarkRunProperties4.Append( runFonts6 );

            paragraphProperties4.Append( paragraphMarkRunProperties4 );

            Run run3 = new Run( );

            RunProperties runProperties3 = new RunProperties( );
            RunFonts runFonts7 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            runProperties3.Append( runFonts7 );
            Text text2 = new Text( );
            text2.Text = "HELLO2";

            run3.Append( runProperties3 );
            run3.Append( text2 );

            paragraph4.Append( paragraphProperties4 );
            paragraph4.Append( run3 );
            return paragraph4;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Paragraph MakeParaImage01( )
        {

            Paragraph paragraph2 = new Paragraph( ) { RsidParagraphAddition = "00F8033B", RsidRunAdditionDefault = "00F8033B" };

            ParagraphProperties paragraphProperties2 = new ParagraphProperties( );

            ParagraphMarkRunProperties paragraphMarkRunProperties2 = new ParagraphMarkRunProperties( );
            RunFonts runFonts3 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            paragraphMarkRunProperties2.Append( runFonts3 );

            paragraphProperties2.Append( paragraphMarkRunProperties2 );
            BookmarkStart bookmarkStart1 = new BookmarkStart( ) { Name = "_GoBack", Id = "0" };

            Run run2 = new Run( );

            RunProperties runProperties2 = new RunProperties( );
            RunFonts runFonts4 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };
            NoProof noProof1 = new NoProof( );

            runProperties2.Append( runFonts4 );
            runProperties2.Append( noProof1 );

            Drawing drawing1 = new Drawing( );

            Wp.Inline inline1 = new Wp.Inline( ) { DistanceFromTop = ( UInt32Value ) 0U, DistanceFromBottom = ( UInt32Value ) 0U, DistanceFromLeft = ( UInt32Value ) 0U, DistanceFromRight = ( UInt32Value ) 0U };
            Wp.Extent extent1 = new Wp.Extent( ) { Cx = 2048161L, Cy = 3029373L };
            Wp.EffectExtent effectExtent1 = new Wp.EffectExtent( ) { LeftEdge = 0L, TopEdge = 0L, RightEdge = 9525L, BottomEdge = 0L };
            Wp.DocProperties docProperties1 = new Wp.DocProperties( ) { Id = ( UInt32Value ) 2U, Name = "图片 2" };

            Wp.NonVisualGraphicFrameDrawingProperties nonVisualGraphicFrameDrawingProperties1 = new Wp.NonVisualGraphicFrameDrawingProperties( );

            A.GraphicFrameLocks graphicFrameLocks1 = new A.GraphicFrameLocks( ) { NoChangeAspect = true };
            graphicFrameLocks1.AddNamespaceDeclaration( "a", "http://schemas.openxmlformats.org/drawingml/2006/main" );

            nonVisualGraphicFrameDrawingProperties1.Append( graphicFrameLocks1 );

            A.Graphic graphic1 = new A.Graphic( );
            graphic1.AddNamespaceDeclaration( "a", "http://schemas.openxmlformats.org/drawingml/2006/main" );

            A.GraphicData graphicData1 = new A.GraphicData( ) { Uri = "http://schemas.openxmlformats.org/drawingml/2006/picture" };

            Pic.Picture picture1 = new Pic.Picture( );
            picture1.AddNamespaceDeclaration( "pic", "http://schemas.openxmlformats.org/drawingml/2006/picture" );

            Pic.NonVisualPictureProperties nonVisualPictureProperties1 = new Pic.NonVisualPictureProperties( );
            Pic.NonVisualDrawingProperties nonVisualDrawingProperties1 = new Pic.NonVisualDrawingProperties( ) { Id = ( UInt32Value ) 0U, Name = "test-pic1.png" };
            Pic.NonVisualPictureDrawingProperties nonVisualPictureDrawingProperties1 = new Pic.NonVisualPictureDrawingProperties( );

            nonVisualPictureProperties1.Append( nonVisualDrawingProperties1 );
            nonVisualPictureProperties1.Append( nonVisualPictureDrawingProperties1 );

            Pic.BlipFill blipFill1 = new Pic.BlipFill( );

            A.Blip blip1 = new A.Blip( ) { Embed = "rId5" };

            A.BlipExtensionList blipExtensionList1 = new A.BlipExtensionList( );

            A.BlipExtension blipExtension1 = new A.BlipExtension( ) { Uri = "{28A0092B-C50C-407E-A947-70E740481C1C}" };

            A14.UseLocalDpi useLocalDpi1 = new A14.UseLocalDpi( ) { Val = false };
            useLocalDpi1.AddNamespaceDeclaration( "a14", "http://schemas.microsoft.com/office/drawing/2010/main" );

            blipExtension1.Append( useLocalDpi1 );

            blipExtensionList1.Append( blipExtension1 );

            blip1.Append( blipExtensionList1 );

            A.Stretch stretch1 = new A.Stretch( );
            A.FillRectangle fillRectangle1 = new A.FillRectangle( );

            stretch1.Append( fillRectangle1 );

            blipFill1.Append( blip1 );
            blipFill1.Append( stretch1 );

            Pic.ShapeProperties shapeProperties1 = new Pic.ShapeProperties( );

            A.Transform2D transform2D1 = new A.Transform2D( );
            A.Offset offset1 = new A.Offset( ) { X = 0L, Y = 0L };
            A.Extents extents1 = new A.Extents( ) { Cx = 2048161L, Cy = 3029373L };

            transform2D1.Append( offset1 );
            transform2D1.Append( extents1 );

            A.PresetGeometry presetGeometry1 = new A.PresetGeometry( ) { Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList1 = new A.AdjustValueList( );

            presetGeometry1.Append( adjustValueList1 );

            shapeProperties1.Append( transform2D1 );
            shapeProperties1.Append( presetGeometry1 );

            picture1.Append( nonVisualPictureProperties1 );
            picture1.Append( blipFill1 );
            picture1.Append( shapeProperties1 );

            graphicData1.Append( picture1 );

            graphic1.Append( graphicData1 );

            inline1.Append( extent1 );
            inline1.Append( effectExtent1 );
            inline1.Append( docProperties1 );
            inline1.Append( nonVisualGraphicFrameDrawingProperties1 );
            inline1.Append( graphic1 );

            drawing1.Append( inline1 );

            run2.Append( runProperties2 );
            run2.Append( drawing1 );
            BookmarkEnd bookmarkEnd1 = new BookmarkEnd( ) { Id = "0" };

            paragraph2.Append( paragraphProperties2 );
            paragraph2.Append( bookmarkStart1 );
            paragraph2.Append( run2 );
            paragraph2.Append( bookmarkEnd1 );
            return paragraph2;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Paragraph MakeParaHell01( )
        {
            Paragraph paragraph1 = new Paragraph( ) { RsidParagraphAddition = "00E05CD0", RsidRunAdditionDefault = "00F8033B" };

            ParagraphProperties paragraphProperties1 = new ParagraphProperties( );

            ParagraphMarkRunProperties paragraphMarkRunProperties1 = new ParagraphMarkRunProperties( );
            RunFonts runFonts1 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            paragraphMarkRunProperties1.Append( runFonts1 );

            paragraphProperties1.Append( paragraphMarkRunProperties1 );

            Run run1 = new Run( );

            RunProperties runProperties1 = new RunProperties( );
            RunFonts runFonts2 = new RunFonts( ) { Hint = FontTypeHintValues.EastAsia };

            runProperties1.Append( runFonts2 );
            Text text1 = new Text( );
            text1.Text = "HELLO1";

            run1.Append( runProperties1 );
            run1.Append( text1 );

            paragraph1.Append( paragraphProperties1 );
            paragraph1.Append( run1 );
            return paragraph1;
        }

        //.....................................................................
    }
}
