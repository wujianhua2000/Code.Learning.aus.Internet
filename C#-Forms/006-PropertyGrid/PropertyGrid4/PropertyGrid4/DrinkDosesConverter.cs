using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Drawing.Design;
using System.Globalization;
using System.Reflection;

namespace PropertyGrid4
{
    class DrinkDosesConverter : EnumConverter
    {
        private Type _enumType;

        //.....................................................................
        /// <summary>Initializing instance</summary>
        /// <param name="type">type Enum</param>
        ///this is only one function, that you must 
        ///to change. All another functions for enums 
        ///you can use by Ctrl+C/Ctrl+V
        public DrinkDosesConverter( Type type )            : base( type )
        {
            _enumType = type;
        }

        //.....................................................................
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
        public override bool CanConvertFrom( ITypeDescriptorContext context,
            Type srcType )
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
