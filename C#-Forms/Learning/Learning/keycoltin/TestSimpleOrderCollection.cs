using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections.ObjectModel;
using System.IO;

namespace Learning
{
    public class TestSimpleOrderCollection
    {
        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        private List<string> Results = new List<string>( );

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        public void TestSimpleOrderRev1( )
        {
            SimpleOrderSm weekly = new SimpleOrderSm( );

            // The Add method, inherited from Collection, takes OrderItemSm.
            //
            weekly.Add( new OrderItemSm( 110072674, "Widget", 400, 45.17 ) );
            weekly.Add( new OrderItemSm( 110072675, "Sprocket", 27, 5.3 ) );
            weekly.Add( new OrderItemSm( 101030411, "Motor", 10, 237.5 ) );
            weekly.Add( new OrderItemSm( 110072684, "Gear", 175, 5.17 ) );

            DisplaySimpleOrder( weekly );

            // The Contains method of KeyedCollection takes the key, 
            // type, in this case int.
            //
            Console.WriteLine( "\nContains(101030411): {0}", weekly.Contains( 101030411 ) );

            // The default Item property of KeyedCollection takes a key.
            //
            Console.WriteLine( "\nweekly[101030411].Description: {0}", weekly[ 101030411 ].Description );

            // The Remove method of KeyedCollection takes a key.
            //
            Console.WriteLine( "\nRemove(101030411)" );

            weekly.Remove( 101030411 );
            DisplaySimpleOrder( weekly );

            // The Insert method, inherited from Collection, takes an 
            // index and an OrderItemSm.
            //
            Console.WriteLine( "\nInsert(2, New OrderItem(...))" );

            weekly.Insert( 2, new OrderItemSm( 111033401, "Nut", 10, .5 ) );
            
            DisplaySimpleOrder( weekly );

            // The default Item property is overloaded. One overload comes
            // from KeyedCollection<int, OrderItemSm>; that overload
            // is read-only, and takes Integer because it retrieves by key. 
            // The other overload comes from Collection<OrderItemSm>, the 
            // base class of KeyedCollection<int, OrderItemSm>; it 
            // retrieves by index, so it also takes an Integer. The compiler
            // uses the most-derived overload, from KeyedCollection, so the
            // only way to access SimpleOrderSm by index is to cast it to
            // Collection<OrderItemSm>. Otherwise the index is interpreted
            // as a key, and KeyNotFoundException is thrown.
            //
            Collection<OrderItemSm> coweekly = weekly;

            Console.WriteLine( "\ncoweekly[2].Description: {0}", coweekly[ 2 ].Description );

            Console.WriteLine( "\ncoweekly[2] = new OrderItem(...)" );

            coweekly[ 2 ] = new OrderItemSm( 127700026, "Crank", 27, 5.98 );

            OrderItemSm temp = coweekly[ 2 ];

            // The IndexOf method inherited from Collection<OrderItemSm> 
            // takes an OrderItemSm instead of a key
            // 
            Console.WriteLine( "\nIndexOf(temp): {0}", weekly.IndexOf( temp ) );

            // The inherited Remove method also takes an OrderItemSm.
            //
            Console.WriteLine( "\nRemove(temp)" );

            weekly.Remove( temp );
            DisplaySimpleOrder( weekly );

            Console.WriteLine( "\nRemoveAt(0)" );

            weekly.RemoveAt( 0 );
            DisplaySimpleOrder( weekly );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="order"></param>
        private void DisplaySimpleOrder( SimpleOrderSm order )
        {
            Console.WriteLine( );

            foreach ( OrderItemSm item in order )
            {
                Console.WriteLine( item );
            }

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        private void SaveListing( )
        {
            string pathname = "d:\\123-learning-CS-API";

            bool wantPATH = ( !Directory.Exists( pathname ) );
            if ( wantPATH ) Directory.CreateDirectory( pathname );

            string filename = pathname + "\\learning-CS-API-output.txt";

            File.WriteAllLines( filename, this.Results, Encoding.Default );

            Process.Start( "explorer.exe", pathname );

            return;
        }

        //.....................................................................
    }
}
