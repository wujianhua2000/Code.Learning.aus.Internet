using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Learning
{
    /// <summary>
    /// 
    /// https://blog.udemy.com/linq-select/
    /// 
    /// </summary>
    class TestLanguageIntegratedQuery
    {
        /// <summary>
        /// 打印显示的内容。
        /// </summary>
        private List<string> Listshow = new List<string>( );

        //.....................................................................
        /// <summary>
        /// Method syntax:
        /// 
        /// </summary>
        public void TestWhere( )
        {
            string[ ] countries1 = { "India", "Australia", "USA", "Argentina", "Peru", "China" };

            IEnumerable<string> result1 = countries1.Where( x => x.StartsWith( "A" ) );

            //.............................................
            //
            List<string> countries = new List<string>( );
            
            countries.Add( "India" );
            countries.Add( "US" );
            countries.Add( "Australia" );
            countries.Add( "Russia" );

            IEnumerable<string> result = countries.Select( x => x );

            //.............................................
            //
            int[ ] numbers = { 5, 10, 8, 3, 6, 12 };

            IEnumerable<int> numQuery2 = numbers.Where( num => num % 2 == 0 )
                                                .OrderBy( n => n );

            //.............................................
            //
            //  LINQ Method Syntax to Print Numbers Greater than 3
            //
            int[ ] Num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            IEnumerable<int> resultnum = Num.Where( n => n > 3 )
                                            .ToList( );

            //.............................................
            //
            var colors = new List<string>( ) { "red", "green", "blue", "black", "white" };
            
            var items1 = colors.Where( x => x.StartsWith( "b" ) );

            var items2 = colors.Where( x => x.Length > 3 && !x.StartsWith( "w" ) );

            //.............................................
            //
            var numbers2 = new List<int>( ) { 5, 10, 15, 20, 25 };

            var items = numbers2.Where( x => x > 5 )
                                .Where( x => x < 25 );

            return;
        }

        //.....................................................................
    }
}
