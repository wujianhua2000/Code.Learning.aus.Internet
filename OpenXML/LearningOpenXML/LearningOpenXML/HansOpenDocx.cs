using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

using M = DocumentFormat.OpenXml.Math;

namespace LearningOpenXML
{
    class HansOpenDocx
    {

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static RunFonts MakeMathFont( )
        {
            RunFonts font = new RunFonts( ) { Ascii = "Cambria Math", HighAnsi = "Cambria Math" };

            return font;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static M.Style MakeMathFonStyle( )
        {
            M.Style fontstyle = new M.Style( ) { Val = M.StyleValues.Plain };
            
            return fontstyle;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Italic MakeMathFontItalic( )
        {
            Italic fontItalic = new Italic( );
            
            return fontItalic;
        }

        //.....................................................................
        /// <summary>
        /// 公式中名称是正文样式，没有斜体
        /// </summary>
        /// <param name="mathlin"></param>
        /// <returns></returns>
        public static M.Run MakeMathRun( string mathlin, bool plainstyle = false )
        {
            //M.Style fontstyle = new M.Style( ) { Val = M.StyleValues.Plain };
            //RunFonts fonts = new RunFonts( ) { Ascii = "Cambria Math", HighAnsi = "Cambria Math" };

            RunProperties properties = new RunProperties( );

            properties.Append( HansOpenDocx.MakeMathFont( ) );

            if ( plainstyle ) properties.Append( HansOpenDocx.MakeMathFonStyle( ) );

            //---------------------------------------------
            M.Text mathtext = new M.Text( );
            mathtext.Text = mathlin;

            //---------------------------------------------
            M.Run mathrun = new M.Run( );
            mathrun.Append( properties );
            mathrun.Append( mathtext );
            
            return mathrun;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static M.Run MakeMathRunNoteMult( )
        {
            return HansOpenDocx.MakeMathRun( "∙" );
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strTextName"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public static M.MathFunction MakeMathFunction( string strTextName, params OpenXmlElement[] parameter )
        {
            M.MathFunction mathFunc = new M.MathFunction( );

            //---------------------------------------------
            M.FunctionProperties funcProperties = new M.FunctionProperties( );
            funcProperties.Append( HansOpenDocx.MakeControlProperties( ) );

            //---------------------------------------------
            M.FunctionName funcNaming = HansOpenDocx.MakeFunctionName( strTextName );

            //---------------------------------------------
            M.DelimiterProperties delimProperties = new M.DelimiterProperties( );
            delimProperties.Append( HansOpenDocx.MakeControlProperties( true ) );

            M.Base mathBaseParms = new M.Base( );
            foreach ( OpenXmlElement value in parameter ) mathBaseParms.Append( value );

            M.Delimiter delimiter = new M.Delimiter( );
            delimiter.Append( delimProperties );
            delimiter.Append( mathBaseParms );

            M.Base funcBase = new M.Base( );
            funcBase.Append( delimiter );

            //---------------------------------------------
            mathFunc.Append( funcProperties );
            mathFunc.Append( funcNaming );
            mathFunc.Append( funcBase );

            return mathFunc;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="useItalic"></param>
        /// <returns></returns>
        public static M.ControlProperties MakeControlProperties( bool useItalic = false )
        {
            RunProperties propertiesRUN = new RunProperties( );

            propertiesRUN.Append( HansOpenDocx.MakeMathFont() );

            if ( useItalic ) propertiesRUN.Append( HansOpenDocx.MakeMathFontItalic() );

            //---------------------------------------------
            M.ControlProperties propertiesCTRL = new M.ControlProperties( );
            
            propertiesCTRL.Append( propertiesRUN );

            return propertiesCTRL;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static M.FunctionName MakeFunctionName( string funcstr )
        {
            M.FunctionName funcName = new M.FunctionName( );

            M.Run funcRun = HansOpenDocx.MakeMathRun( funcstr, true );

            funcName.Append( funcRun );

            return funcName;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="matBase"></param>
        /// <param name="matSubn"></param>
        /// <returns></returns>
        public static M.Subscript MakeScriptLower( string matBase, string matSubn )
        {
            M.SubscriptProperties properties = new M.SubscriptProperties( );

            properties.Append( HansOpenDocx.MakeControlProperties( true ) );

            //---------------------------------------------
            M.Subscript subscript = new M.Subscript( );

            subscript.Append( properties );

            subscript.Append( HansOpenDocx.MakeMathBase( matBase) );
            subscript.Append( HansOpenDocx.MakeScriptArgumentLower(matSubn) );

            return subscript;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static M.Superscript MakeScriptUpper( string mathBase, string mathArgm )
        {
            M.SuperscriptProperties properties = new M.SuperscriptProperties( );
            
            properties.Append( HansOpenDocx.MakeControlProperties( true ) );

            //---------------------------------------------
            M.Superscript script = new M.Superscript( );

            script.Append( properties );

            script.Append( HansOpenDocx.MakeMathBase( mathBase ) );
            script.Append( HansOpenDocx.MakeScriptArgumentUpper( mathArgm ) );

            return script;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static M.SubSuperscript MakeScriptBoth( string strBase, string strUpper, string strLower )
        {
            M.SubSuperscript script = new M.SubSuperscript( );

            M.SubSuperscriptProperties properties = new M.SubSuperscriptProperties( );

            properties.Append( HansOpenDocx.MakeControlProperties( true ) );

            script.Append( properties );

            script.Append( HansOpenDocx.MakeMathBase( strBase ) );
            script.Append( HansOpenDocx.MakeScriptArgumentLower( strLower ) );
            script.Append( HansOpenDocx.MakeScriptArgumentUpper( strUpper ) );

            return script;
        }

        public static M.Radical MakeMathRadical( string strBase, string strDegree )
        {
            M.Radical radical = new M.Radical( );

            M.RadicalProperties properties = new M.RadicalProperties( );
            properties.Append( HansOpenDocx.MakeControlProperties( true ) );

            M.Base mathBAS = HansOpenDocx.MakeMathBase( strBase );

            M.Degree mathDEG = HansOpenDocx.MakeMathDegree( strDegree );

            radical.Append( properties );
            radical.Append( mathBAS );
            radical.Append( mathDEG );

            return radical;
        }

        //.....................................................................
        /// <summary>
        /// 开方 的 2 3 4 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static M.Degree MakeMathDegree( string value )
        {
            M.Run mathrun = HansOpenDocx.MakeMathRun( value );

            M.Degree degree = new M.Degree( );
            degree.Append( mathrun );

            return degree;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static M.Base MakeMathBase( string value )
        {
            M.Base mathbase = new M.Base( );

            mathbase.Append( HansOpenDocx.MakeMathRun( value ) );

            return mathbase;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static M.SuperArgument MakeScriptArgumentUpper( string value )
        {
            M.SuperArgument result = new M.SuperArgument( );
            
            result.Append( HansOpenDocx.MakeMathRun( value ) );

            return result;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static M.SubArgument MakeScriptArgumentLower( string value )
        {
            M.SubArgument result = new M.SubArgument( );

            result.Append( HansOpenDocx.MakeMathRun( value ) );

            return result;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static M.FractionProperties MakeFractionProperties( )
        {
            M.FractionProperties properties = new M.FractionProperties( );
            
            properties.Append( HansOpenDocx.MakeControlProperties() );

            return properties;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="upper"></param>
        /// <param name="lower"></param>
        /// <returns></returns>
        public static M.Fraction MakeFraction( OpenXmlElement upper, OpenXmlElement lower )
        {
            M.Fraction fraction = new M.Fraction( );

            M.Numerator upperNUM = new M.Numerator( );
            upperNUM.Append( upper );

            M.Denominator lowerDEN = new M.Denominator( );
            lowerDEN.Append( lower );

            fraction.Append( HansOpenDocx.MakeFractionProperties( ) );
            fraction.Append( upperNUM );
            fraction.Append( lowerDEN );

            return fraction;
        }

        //.....................................................................
        /// <summary>
        /// 使用常规的字符串生成一个分式（标准的、上下格式）
        /// </summary>
        /// <param name="upper"></param>
        /// <param name="lower"></param>
        /// <returns></returns>
        public static M.Fraction MakeFraction( string upper, string lower )
        {
            M.Fraction fraction = new M.Fraction( );

            M.Numerator upperNUM = new M.Numerator( );
            upperNUM.Append( HansOpenDocx.MakeMathRun( upper ) );

            M.Denominator lowerDEN = new M.Denominator( );
            lowerDEN.Append( HansOpenDocx.MakeMathRun( lower ) );

            fraction.Append( HansOpenDocx.MakeFractionProperties( ) );
            fraction.Append( upperNUM );
            fraction.Append( lowerDEN );

            return fraction;
        }

        //.....................................................................
    }
}

