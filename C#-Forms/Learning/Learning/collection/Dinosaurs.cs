using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Learning
{
    /// <summary>
    /// 
    /// </summary>
    public class Dinosaurs : Collection<string>
    {
        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        public event EventHandler<DinosaursChangedEventArgs> Changed;

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="newItem"></param>
        protected override void InsertItem( int index, string newItem )
        {
            base.InsertItem( index, newItem );

            EventHandler<DinosaursChangedEventArgs> handler = Changed;
            if ( handler == null ) return;

            handler( this, new DinosaursChangedEventArgs( ChangeType.Added, newItem, null ) );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="newItem"></param>
        protected override void SetItem( int index, string newItem )
        {
            string replaced = Items[ index ];
            
            base.SetItem( index, newItem );

            EventHandler<DinosaursChangedEventArgs> handler = Changed;

            if ( handler == null ) return;

            handler( this, new DinosaursChangedEventArgs( ChangeType.Replaced, replaced, newItem ) );
            
            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        protected override void RemoveItem( int index )
        {
            string removedItem = Items[ index ];

            base.RemoveItem( index );

            EventHandler<DinosaursChangedEventArgs> handler = Changed;

            if ( handler == null ) return;

            handler( this, new DinosaursChangedEventArgs( ChangeType.Removed, removedItem, null ) );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        protected override void ClearItems( )
        {
            base.ClearItems( );

            EventHandler<DinosaursChangedEventArgs> handler = Changed;

            if ( handler == null ) return;

            handler( this, new DinosaursChangedEventArgs( ChangeType.Cleared, null, null ) );
            
            return;
        }

        //.....................................................................
    }

}
