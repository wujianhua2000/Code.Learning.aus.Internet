using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Drawing.Design;
using System.Globalization;
using System.Reflection;

namespace PropertyGrid5
{
    class GameClassDisplayer
    {
        //.....................................................................
        /// <summary>
        /// [Description( "You can choose between 石头, scissors, 布" )]
        /// 
        /// </summary>
        [DisplayName( "Choose your variant" )]
        [Description( "You can choose between 石头, 剪刀, 布" )]
        [Category( "Choosing" )]
        [Editor( typeof( GameEditor ), typeof( UITypeEditor ) )]
        public EnumGame DisplayGameValues { get; set; }

        //.....................................................................
    }
}
