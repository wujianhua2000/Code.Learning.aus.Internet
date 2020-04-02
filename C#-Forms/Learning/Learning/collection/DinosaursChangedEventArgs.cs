using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Learning
{
    //.....................................................................
    /// <summary>
    /// Event argument for the Changed event.
    /// </summary>
    public class DinosaursChangedEventArgs : EventArgs
    {
        public readonly string ChangedItem;

        public readonly ChangeType ChangeType;

        public readonly string ReplacedWith;

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="change"></param>
        /// <param name="item"></param>
        /// <param name="replacement"></param>
        public DinosaursChangedEventArgs( ChangeType change, string item, string replacement )
        {
            this.ChangeType = change;
            this.ChangedItem = item;
            this.ReplacedWith = replacement;

            return;
        }

        //.....................................................................
    }

    //.....................................................................
    /// <summary>
    /// 
    /// </summary>
    public enum ChangeType
    {
        Added,
        Removed,
        Replaced,
        Cleared
    };

    //.....................................................................
}
