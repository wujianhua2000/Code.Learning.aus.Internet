using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;

using Wp = DocumentFormat.OpenXml.Drawing.Wordprocessing;
using A = DocumentFormat.OpenXml.Drawing;
using Pic = DocumentFormat.OpenXml.Drawing.Pictures;
using A14 = DocumentFormat.OpenXml.Office2010.Drawing;

namespace Hans.Opxm
{
    class OpenDocxPicture
    {

        public void PlusImageInto( MainDocumentPart mainPart, Body body, string fileName )
        {
            ImagePart imagePart = mainPart.AddImagePart( ImagePartType.Jpeg );

            using ( FileStream stream = new FileStream( fileName, FileMode.Open ) )
            {
                imagePart.FeedData( stream );
            }

            Paragraph imagePRG = this.MakePictureParagraph( mainPart.GetIdOfPart( imagePart ) );

            //AddImageToBody(wordprocessingDocument, mainPart.GetIdOfPart(imagePart));

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Paragraph MakePictureParagraph( string imagedata )
        {
            Paragraph paragraph1 = new Paragraph( ) { RsidParagraphAddition = "000C43E4", RsidRunAdditionDefault = "00BC0E36" };
            
            //.............................................

            NoProof noProof1 = new NoProof( );
            RunProperties runProperties1 = new RunProperties( );

            runProperties1.Append( noProof1 );

            //.............................................
            //  [1]     inline1.Append( extent1 );
            //  [1]     inline1.Append( effectExtent1 );
            //  [1]     inline1.Append( docProperties1 );

            Wp.Extent extent1 = new Wp.Extent( ) { Cx = 5274310L, Cy = 8065770L };

            Wp.EffectExtent effectExtent1 = new Wp.EffectExtent( ) { LeftEdge = 0L, TopEdge = 0L, RightEdge = 2540L, BottomEdge = 0L };
            
            Wp.DocProperties docProperties1 = new Wp.DocProperties( ) { Id = ( UInt32Value ) 1U, Name = "图片 1" };

            //.............................................
            //  [2]
            A.GraphicFrameLocks graphicFrameLocks1 = new A.GraphicFrameLocks( ) { NoChangeAspect = true };
            graphicFrameLocks1.AddNamespaceDeclaration( "a", "http://schemas.openxmlformats.org/drawingml/2006/main" );

            //  [1]     inline1.Append( nonVisualGraphicFrameDrawingProperties1 );
            //
            Wp.NonVisualGraphicFrameDrawingProperties nonVisualGraphicFrameDrawingProperties1 = new Wp.NonVisualGraphicFrameDrawingProperties( );
            nonVisualGraphicFrameDrawingProperties1.Append( graphicFrameLocks1 );

            //.............................................
            //  [5]
            Pic.NonVisualDrawingProperties nonVisualDrawingProperties1 = new Pic.NonVisualDrawingProperties( ) { Id = ( UInt32Value ) 0U, Name = "81Vb+WNRQYL.jpg" };
            Pic.NonVisualPictureDrawingProperties nonVisualPictureDrawingProperties1 = new Pic.NonVisualPictureDrawingProperties( );

            //  [4]     picture1.Append( nonVisualPictureProperties1 );
            //
            Pic.NonVisualPictureProperties nonVisualPictureProperties1 = new Pic.NonVisualPictureProperties( );
            nonVisualPictureProperties1.Append( nonVisualDrawingProperties1 );
            nonVisualPictureProperties1.Append( nonVisualPictureDrawingProperties1 );

            //.............................................
            //  [8]
            A14.UseLocalDpi useLocalDpi1 = new A14.UseLocalDpi( ) { Val = false };
            useLocalDpi1.AddNamespaceDeclaration( "a14", "http://schemas.microsoft.com/office/drawing/2010/main" );

            //  [7]
            A.BlipExtension blipExtension1 = new A.BlipExtension( ) { Uri = "{28A0092B-C50C-407E-A947-70E740481C1C}" };
            blipExtension1.Append( useLocalDpi1 );

            //.............................................
            //  [6]
            A.BlipExtensionList blipExtensionList1 = new A.BlipExtensionList( );

            blipExtensionList1.Append( blipExtension1 );

            //.............................................
            //  [5]
            A.Blip blip1 = new A.Blip( ) { Embed = "rId5", CompressionState = A.BlipCompressionValues.Print };
            blip1.Append( blipExtensionList1 );

            //.............................................
            //  [6]
            A.FillRectangle fillRectangle1 = new A.FillRectangle( );

            //  [5]
            A.Stretch stretch1 = new A.Stretch( );
            stretch1.Append( fillRectangle1 );

            //.............................................
            //  [4]     picture1.Append( blipFill1 );
            //
            Pic.BlipFill blipFill1 = new Pic.BlipFill( );

            blipFill1.Append( blip1 );
            blipFill1.Append( stretch1 );

            //.............................................
            //  [6]
            A.Offset offset1 = new A.Offset( ) { X = 0L, Y = 0L };
            A.Extents extents1 = new A.Extents( ) { Cx = 5274310L, Cy = 8065770L };

            //  [5]     shapeProperties1.Append( transform2D1 );
            //
            A.Transform2D transform2D1 = new A.Transform2D( );
            transform2D1.Append( offset1 );
            transform2D1.Append( extents1 );

            //.............................................
            A.AdjustValueList adjustValueList1 = new A.AdjustValueList( );

            //  [5]     shapeProperties1.Append( presetGeometry1 );
            //
            A.PresetGeometry presetGeometry1 = new A.PresetGeometry( ) { Preset = A.ShapeTypeValues.Rectangle };
            presetGeometry1.Append( adjustValueList1 );

            //.............................................
            //  [4]     picture1.Append( shapeProperties1 );
            //
            Pic.ShapeProperties shapeProperties1 = new Pic.ShapeProperties( );

            shapeProperties1.Append( transform2D1 );
            shapeProperties1.Append( presetGeometry1 );

            //.............................................
            //  [3]     graphicData1.Append( picture1 );
            //

            Pic.Picture picture1 = new Pic.Picture( );
            picture1.AddNamespaceDeclaration( "pic", "http://schemas.openxmlformats.org/drawingml/2006/picture" );

            picture1.Append( nonVisualPictureProperties1 );
            picture1.Append( blipFill1 );
            picture1.Append( shapeProperties1 );

            //.............................................
            //  [2] graphic1.Append( graphicData1 );
            //
            A.GraphicData graphicData1 = new A.GraphicData( ) { Uri = "http://schemas.openxmlformats.org/drawingml/2006/picture" };

            graphicData1.Append( picture1 );

            //.............................................
            //  [1] inline1.Append( graphic1 );
            //
            A.Graphic graphic1 = new A.Graphic( );
            graphic1.AddNamespaceDeclaration( "a", "http://schemas.openxmlformats.org/drawingml/2006/main" );

            graphic1.Append( graphicData1 );

            //.............................................
            Wp.Inline inline1 = new Wp.Inline( ) { DistanceFromTop = ( UInt32Value ) 0U, DistanceFromBottom = ( UInt32Value ) 0U, DistanceFromLeft = ( UInt32Value ) 0U, DistanceFromRight = ( UInt32Value ) 0U };

            inline1.Append( extent1 );
            inline1.Append( effectExtent1 );
            inline1.Append( docProperties1 );
            inline1.Append( nonVisualGraphicFrameDrawingProperties1 );
            inline1.Append( graphic1 );

            //.............................................
            Drawing drawing1 = new Drawing( );

            drawing1.Append( inline1 );

            //.............................................
            Run run1 = new Run( );

            run1.Append( runProperties1 );
            run1.Append( drawing1 );

            //.............................................
            paragraph1.Append( run1 );

            return paragraph1;
        }


        //.....................................................................
    }
}
