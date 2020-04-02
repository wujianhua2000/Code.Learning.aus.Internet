using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using System.IO;
using System.Diagnostics;

namespace Learning
{
    public class TestCollectionHith
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
        public void DemoDinosaurs( )
        {
            Dinosaurs dinosaurs = new Dinosaurs( );

            dinosaurs.Changed += ChangedHandler;

            dinosaurs.Add( "Psitticosaurus" );
            dinosaurs.Add( "Caudipteryx" );
            dinosaurs.Add( "Compsognathus" );
            dinosaurs.Add( "Muttaburrasaurus" );

            this.DisplayCollection( dinosaurs );

            this.Results.Add( string.Format( "\nIndexOf(\"Muttaburrasaurus\"): {0}", dinosaurs.IndexOf( "Muttaburrasaurus" ) ) );

            this.Results.Add( string.Format( "\nContains(\"Caudipteryx\"): {0}", dinosaurs.Contains( "Caudipteryx" ) ) );

            this.Results.Add( "\nInsert(2, \"Nanotyrannus\")" );

            dinosaurs.Insert( 2, "Nanotyrannus" );

            this.Results.Add( string.Format( "\ndinosaurs[2]: {0}", dinosaurs[ 2 ] ) );

            this.Results.Add(  "\ndinosaurs[2] = \"Microraptor\"" );

            dinosaurs[ 2 ] = "Microraptor";

            this.Results.Add( "\nRemove(\"Microraptor\")" );

            dinosaurs.Remove( "Microraptor" );

            this.Results.Add(  "\nRemoveAt(0)" );

            dinosaurs.RemoveAt( 0 );

            this.DisplayCollection( dinosaurs );

            this.SaveListing( );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cs"></param>
        private void DisplayCollection( Collection<string> cs )
        {
            this.Results.Add( string.Empty );
            this.Results.Add( ".".PadRight( 80, '.' ) );
            this.Results.Add( "***** L i s t i n g" );
            this.Results.Add( string.Empty );

            foreach ( string item in cs ) this.Results.Add( item );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void ChangedHandler( object source, DinosaursChangedEventArgs e )
        {
            switch ( e.ChangeType )
            {
                case ChangeType.Replaced:
                    this.Results.Add( string.Format( "{0} was replaced with {1}", e.ChangedItem, e.ReplacedWith ) );
                    break;

                case ChangeType.Cleared:
                    this.Results.Add( "The dinosaur list was cleared." );
                    break;

                default:
                    this.Results.Add( string.Format( "{0} was {1}.", e.ChangedItem, e.ChangeType ) );
                    break;
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
