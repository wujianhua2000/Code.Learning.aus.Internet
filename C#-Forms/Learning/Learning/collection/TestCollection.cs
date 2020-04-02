using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using System.IO;
using System.Diagnostics;

namespace Learning
{
    class TestCollection
    {
        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        public static void DemoCollectionEasy( )
        {
            Collection<string> dinosaurs = new Collection<string>( );

            dinosaurs.Add( "Psitticosaurus" );
            dinosaurs.Add( "Caudipteryx" );
            dinosaurs.Add( "Compsognathus" );
            dinosaurs.Add( "Muttaburrasaurus" );

            List<string> listing = new List<string>( );

            listing.Add( string.Format( "{0} dinosaurs:", dinosaurs.Count ) );

            DisplayCollection( listing, dinosaurs );

            listing.Add( string.Format( "\nIndexOf(\"Muttaburrasaurus\"): {0}", dinosaurs.IndexOf( "Muttaburrasaurus" ) ) );

            listing.Add( string.Format( "\nContains(\"Caudipteryx\"): {0}", dinosaurs.Contains( "Caudipteryx" ) ) );
            
            listing.Add( "\nInsert(2, \"Nanotyrannus\")" );

            dinosaurs.Insert( 2, "Nanotyrannus" );

            DisplayCollection( listing, dinosaurs );

            listing.Add( string.Format( "\ndinosaurs[2]: {0}", dinosaurs[ 2 ] ) );
            
            listing.Add( "\ndinosaurs[2] = \"Microraptor\"" );

            dinosaurs[ 2 ] = "Microraptor";

            DisplayCollection( listing, dinosaurs );

            listing.Add( "\nRemove(\"Microraptor\")" );

            dinosaurs.Remove( "Microraptor" );

            DisplayCollection( listing, dinosaurs );

            listing.Add( "\nRemoveAt(0)" );

            dinosaurs.RemoveAt( 0 );
            DisplayCollection( listing, dinosaurs );

            listing.Add( "\ndinosaurs.Clear()" );

            dinosaurs.Clear( );

            listing.Add( string.Format( "Count: {0}", dinosaurs.Count ) );

            SaveListing( listing );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cs"></param>
        private static void DisplayCollection( List<string> result, Collection<string> cs )
        {
            //Console.WriteLine( );
            result.Add( string.Empty );

            foreach ( string item in cs ) result.Add( item );// Console.WriteLine( item );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        private static void SaveListing( List<string> listing )
        {
            string pathname = "d:\\123-learning-CS-API";

            bool wantPATH = ( !Directory.Exists( pathname ) );
            if ( wantPATH ) Directory.CreateDirectory( pathname );

            string filename = pathname + "\\learning-CS-API-output.txt";

            File.WriteAllLines( filename, listing, Encoding.Default );

            Process.Start( "explorer.exe", pathname );

            return;
        }

        //.....................................................................
    }
}
