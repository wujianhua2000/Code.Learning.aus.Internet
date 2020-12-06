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
    /// <summary>
    /// 
    /// </summary>
    class MathFunktion
    {
        public string FuncName;

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="funName"></param>
        public MathFunktion( string funName )
        {
            this.FuncName = funName;

            return;
        }

        //.....................................................................
    }
}
