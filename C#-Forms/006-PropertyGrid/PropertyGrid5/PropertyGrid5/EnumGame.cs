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
        [Description( "ʯͷ" )]
        Stone,

        //[Description( "Scissors" )]
        [Description( "����" )]
        Scissors,

        [Description( "��" )]
        Paper
    }
}
