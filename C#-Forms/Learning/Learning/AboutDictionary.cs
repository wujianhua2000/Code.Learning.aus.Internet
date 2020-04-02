using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Learning
{
    /// <summary>
    /// 
    /// </summary>
    class AboutDictionary
    {
        //.....................................................................
        /// <summary>
        /// 
        /// https://stackoverflow.com/questions/9276983/sort-a-dictionaryint-listint-by-keys-values-inside-list
        /// 
        /// </summary>
        public void Code20200219( )
        {
            // Creating test data
            var dictionary = new Dictionary<int, IList<int>>( );

            dictionary.Add( 1, new List<int> { 2, 1, 6 } );
            dictionary.Add( 5, new List<int> { 2, 1 } );
            dictionary.Add( 2, new List<int> { 2, 3 } );

            // Ordering as requested
            dictionary = dictionary.OrderBy( d => d.Key )
                                   .ToDictionary(
                                        d => d.Key,
                                        d => ( IList<int> ) d.Value.OrderBy( v => v ).ToList( )
                                   );

            // Displaying the results
            foreach ( var kv in dictionary )
            {
                Console.Write( "\n{0}", kv.Key );

                foreach ( var li in kv.Value ) Console.Write( "\t{0}", li );
            }

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// https://www.c-sharpcorner.com/UploadFile/mahesh/how-to-sort-a-dictionary-with-C-Sharp/
        /// 
        /// The following code snippet sorts a Dictionary by keys and by values. 
        /// </summary>

        public void SortDictionary( )
        {
            // Create a dictionary with string key and Int16 value pair
            //
            Dictionary<string, Int16> AuthorList = new Dictionary<string, Int16>( );
            
            AuthorList.Add( "Mahesh Chand", 35 );
            AuthorList.Add( "Mike Gold", 25 );
            AuthorList.Add( "Praveen Kumar", 29 );
            AuthorList.Add( "Raj Beniwal", 21 );
            AuthorList.Add( "Dinesh Beniwal", 84 );
            
            // Sorted by Key
            Console.WriteLine( "Sorted by Key" );
            Console.WriteLine( "=============" );
            
            foreach ( KeyValuePair<string, Int16> author in AuthorList.OrderBy( key => key.Key ) )
            {
                Console.WriteLine( "Key: {0}, Value: {1}", author.Key, author.Value );
            
            }
            Console.WriteLine( "=============" );
            
            // Sorted by Value
            Console.WriteLine( "Sorted by Value" );
            Console.WriteLine( "=============" );
            
            foreach ( KeyValuePair<string, Int16> author in AuthorList.OrderBy( key => key.Value ) )
            {
                Console.WriteLine( "Key: {0}, Value: {1}", author.Key, author.Value );
            }

            return;
        }

        ////.....................................................................
    }
}
