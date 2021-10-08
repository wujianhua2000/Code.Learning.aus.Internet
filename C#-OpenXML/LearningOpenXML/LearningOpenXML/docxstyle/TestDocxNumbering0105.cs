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
    class TestDocxNumbering0105 : OpenDocxBase
    {
        public override Document GenerateDocument( )
        {
            Document document = this.NewDocument( );
            //---------------------------------------------
            Body body = new Body( );

            body.Append( this.MakeParagraphTitle01( "AAA01", 1 ) );
            body.Append( this.MakeParagraphTitle01( "BBB01", 1 ) );

            body.Append( this.MakeParagraphTitle02( "CCC02", 1 ) );
            body.Append( this.MakeParagraphTitle03( "DDD03", 1 ) );

            body.Append( this.MakeParagraphTitle02( "EEE02", 1 ) );
            body.Append( this.MakeParagraphTitle03( "DDD03", 1 ) );
            
            body.Append( this.MakeParagraphTitle02( "FF-02", 1 ) );
            body.Append( this.MakeParagraphTitle02( "FF-02", 1 ) );
            body.Append( this.MakeParagraphTitle02( "FF-02", 1 ) );
            body.Append( this.MakeParagraphTitle03( "DDD03", 1 ) );

            body.Append( this.MakeParagraphTitle04( "SSS444" ) );
            body.Append( this.MakeParagraphTitle05( "TTT555" ) );

            body.Append( this.MakeParagraphTitle01( "GG-01", 1 ) );

            body.Append( this.MakeDefaultSectionProperty( ) );

            document.Append( body );

            return document;
        }
         
        //.....................................................................
    }
}
