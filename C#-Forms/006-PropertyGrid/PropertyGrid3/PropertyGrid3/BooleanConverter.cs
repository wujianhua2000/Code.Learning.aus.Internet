using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Globalization;

namespace PropertyGrid3
{
    class DrinkerClassConverter : BooleanConverter
    {
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
            return ( bool ) value ?              "Yes" : "Yes, of course";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="culture"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public override object ConvertFrom( ITypeDescriptorContext context, CultureInfo culture, object value )
        {
            return ( string ) value == "Yes";
        }

        //.....................................................................
    }
}
