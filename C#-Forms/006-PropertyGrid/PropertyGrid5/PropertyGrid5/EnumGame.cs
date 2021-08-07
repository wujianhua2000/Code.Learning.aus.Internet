using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Drawing.Design;

namespace PropertyGrid5
{
    /// <summary>
    /// 
    /// </summary>
    enum EnumGame
    {
        [Description( "Ê¯Í·" )]
        Stone,

        //[Description( "Scissors" )]
        [Description( "¼ôµ¶" )]
        Scissors,

        [Description( "²¼" )]
        Paper
    }
}
