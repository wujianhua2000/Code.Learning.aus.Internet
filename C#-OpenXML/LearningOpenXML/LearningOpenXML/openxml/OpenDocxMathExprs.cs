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
    /// <summary>
    /// 
    /// </summary>
    class OpenDocxMathExprs
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

            properties.Append( OpenDocxMathExprs.MakeMathFont( ) );

            if ( plainstyle ) properties.Append( OpenDocxMathExprs.MakeMathFonStyle( ) );

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
            return OpenDocxMathExprs.MakeMathRun( "∙" );
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
            funcProperties.Append( OpenDocxMathExprs.MakeControlProperties( ) );

            //---------------------------------------------
            M.FunctionName funcNaming = OpenDocxMathExprs.MakeFunctionName( strTextName );

            //---------------------------------------------
            M.DelimiterProperties delimProperties = new M.DelimiterProperties( );
            delimProperties.Append( OpenDocxMathExprs.MakeControlProperties( true ) );

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

            propertiesRUN.Append( OpenDocxMathExprs.MakeMathFont() );

            if ( useItalic ) propertiesRUN.Append( OpenDocxMathExprs.MakeMathFontItalic() );

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

            M.Run funcRun = OpenDocxMathExprs.MakeMathRun( funcstr, true );

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

            properties.Append( OpenDocxMathExprs.MakeControlProperties( true ) );

            //---------------------------------------------
            M.Subscript subscript = new M.Subscript( );

            subscript.Append( properties );

            subscript.Append( OpenDocxMathExprs.MakeMathBase( matBase) );
            subscript.Append( OpenDocxMathExprs.MakeScriptArgumentLower(matSubn) );

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
            
            properties.Append( OpenDocxMathExprs.MakeControlProperties( true ) );

            //---------------------------------------------
            M.Superscript script = new M.Superscript( );

            script.Append( properties );

            script.Append( OpenDocxMathExprs.MakeMathBase( mathBase ) );
            script.Append( OpenDocxMathExprs.MakeScriptArgumentUpper( mathArgm ) );

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

            properties.Append( OpenDocxMathExprs.MakeControlProperties( true ) );

            script.Append( properties );

            script.Append( OpenDocxMathExprs.MakeMathBase( strBase ) );
            script.Append( OpenDocxMathExprs.MakeScriptArgumentLower( strLower ) );
            script.Append( OpenDocxMathExprs.MakeScriptArgumentUpper( strUpper ) );

            return script;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strBase"></param>
        /// <param name="strDegree"></param>
        /// <returns></returns>
        public static M.Radical MakeMathRadical( string strBase, string strDegree )
        {
            M.Radical radical = new M.Radical( );

            M.RadicalProperties properties = new M.RadicalProperties( );
            properties.Append( OpenDocxMathExprs.MakeControlProperties( true ) );

            M.Base mathBAS = OpenDocxMathExprs.MakeMathBase( strBase );

            M.Degree mathDEG = OpenDocxMathExprs.MakeMathDegree( strDegree );

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
            M.Run mathrun = OpenDocxMathExprs.MakeMathRun( value );

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

            mathbase.Append( OpenDocxMathExprs.MakeMathRun( value ) );

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
            
            result.Append( OpenDocxMathExprs.MakeMathRun( value ) );

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

            result.Append( OpenDocxMathExprs.MakeMathRun( value ) );

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
            
            properties.Append( OpenDocxMathExprs.MakeControlProperties() );

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

            fraction.Append( OpenDocxMathExprs.MakeFractionProperties( ) );
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
            upperNUM.Append( OpenDocxMathExprs.MakeMathRun( upper ) );

            M.Denominator lowerDEN = new M.Denominator( );
            lowerDEN.Append( OpenDocxMathExprs.MakeMathRun( lower ) );

            fraction.Append( OpenDocxMathExprs.MakeFractionProperties( ) );
            fraction.Append( upperNUM );
            fraction.Append( lowerDEN );

            return fraction;
        }

        //.....................................................................
    }
}

