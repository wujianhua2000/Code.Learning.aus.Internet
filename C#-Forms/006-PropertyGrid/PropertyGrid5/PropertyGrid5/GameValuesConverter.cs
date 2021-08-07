using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Drawing;
using System.ComponentModel;
using System.Drawing.Design;
using System.Globalization;

namespace PropertyGrid5
{
    /// <summary>
    /// 
    /// </summary>
    class GameValuesConverter : EnumConverter
    {
        /// <summary>
        /// 
        /// </summary>
        private Type _enumType;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        public GameValuesConverter( Type type )
            : base( type )
        {
            _enumType = type;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="destType"></param>
        /// <returns></returns>
        public override bool CanConvertTo( ITypeDescriptorContext context, Type destType )
        {
            return destType == typeof( string );
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="culture"></param>
        /// <param name="value"></param>
        /// <param name="destType"></param>
        /// <returns></returns>
        public override object ConvertTo( ITypeDescriptorContext context, CultureInfo culture, object value, Type destType )
        {
            FieldInfo fi = _enumType.GetField( Enum.GetName( _enumType, value ) );

            DescriptionAttribute dna = ( DescriptionAttribute ) Attribute.GetCustomAttribute( fi, typeof( DescriptionAttribute ) );

            if ( dna != null ) return dna.Description;

            return value.ToString( );
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="srcType"></param>
        /// <returns></returns>
        public override bool CanConvertFrom( ITypeDescriptorContext context, Type srcType )
        {
            return srcType == typeof( string );
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="culture"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public override object ConvertFrom( ITypeDescriptorContext context, CultureInfo culture, object value )
        {
            foreach ( FieldInfo fi in _enumType.GetFields( ) )
            {
                DescriptionAttribute dna = ( DescriptionAttribute ) Attribute.GetCustomAttribute( fi, typeof( DescriptionAttribute ) );

                if ( ( dna != null ) && ( ( string ) value == dna.Description ) )
                    return Enum.Parse( _enumType, fi.Name );
            }

            return Enum.Parse( _enumType, ( string ) value );
        }

        //.....................................................................
    }

}

