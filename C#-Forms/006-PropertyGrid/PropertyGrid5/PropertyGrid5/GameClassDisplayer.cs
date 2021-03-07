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
        /// 
        /// </summary>
        [DisplayName( "Choose your variant" )]
        [Description( "You can choose between Ê¯Í·, scissors, ²¼" )]
        [Category( "Choosing" )]
        [Editor( typeof( GameEditor ), typeof( UITypeEditor ) )]
        public GameValues DisplayGameValues { get; set; }

        //.....................................................................
    }
}
