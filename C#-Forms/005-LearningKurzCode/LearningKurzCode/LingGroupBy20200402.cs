using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KurzCode20200402
{
    //.....................................................................
    /// <summary>
    /// 
    /// </summary>
    class ProductStore
    {
        public int category { get; set; }
     
        public string productName { get; set; }

        public string type { get; set; }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string ToCSV( )
        {
            StringBuilder buffer = new StringBuilder( );

            buffer.AppendFormat( "{0},{1},{2}", 
                                 this.category.ToString( ).PadLeft( 5 ),
                                 this.productName.PadLeft( 20 ),
                                 this.type.PadLeft( 20 )
                                 );

            return buffer.ToString( );
        }


        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string ToKurz( )
        {
            StringBuilder buffer = new StringBuilder( );

            buffer.AppendFormat( "\tProduct Name: {0} | Type: {1}",
                                 this.productName.PadLeft( 20 ),
                                 this.type.PadLeft( 20 )
                                 );

            return buffer.ToString( );
        }

        //.....................................................................
    }

    //.....................................................................
    /// <summary>
    /// 很棒的例子
    /// 
    /// https://www.completecsharptutorial.com/linqtutorial/groupby-singlekey-multikey-sorting-grouping-linq-csharp-tutorial.php
    /// 
    /// LINQ (C#): GroupBy - SingleKey, MultiKey and Grouping with Sorting
    /// 
    /// In this tutorial, you will learn: 
    /// 
    /// 1.What is GroupBy Operator in LINQ?
    /// 
    /// 2.How to use GroupBy to grouping data?
    /// 
    /// 3.Single Key Grouping with Example
    /// 
    /// 4.Multi Key Grouping with Example
    /// 
    /// 5.Grouping with Sorting
    /// 
    /// 6.Programming Example
    /// 
    /// GroupBy operator projects data in groups based on common attribute or key. 
    /// It is a great tool when you want to see the summarize result based on group. 
    /// In this article, I have written several programs that is easy to understand 
    /// and will help you to understand GropuBy operator.
    /// 
    /// </summary>
    class LingGroupBy20200402
    {
        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        private IList<ProductStore> ListData = new List<ProductStore>( );

        /// <summary>
        /// 
        /// </summary>
        private IList<string> ListLine = new List<string>( );

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        public LingGroupBy20200402( )
        {
            this.ListData.Add( new ProductStore { category = 1, productName = "Hard Disk", type = "MEMORY" } );
            this.ListData.Add( new ProductStore { category = 2, productName = "Monitor", type = "DISPLAY" } );
            this.ListData.Add( new ProductStore { category = 1, productName = "SSD Disk", type = "MEMORY" } );
            this.ListData.Add( new ProductStore { category = 1, productName = "RAM", type = "MEMORY" } );
            this.ListData.Add( new ProductStore { category = 2, productName = "Processor", type = "CPU" } );
            this.ListData.Add( new ProductStore { category = 1, productName = "Bluetooth", type = "Accessories" } );
            this.ListData.Add( new ProductStore { category = 2, productName = "Keyboard & Mouse", type = "Accessories" } );

            foreach ( ProductStore pro in ListData ) this.ListLine.Add( pro.ToCSV( ) );

            this.TestSingleKeyGrouping( );
            this.TestMultiKeyGrouping( );
            this.TestGroupingSorting( );

            foreach ( string lin in this.ListLine ) Console.WriteLine( lin );

            return;
        }

        //.....................................................................
        /// <summary>
        /// Single key Grouping
        /// 
        /// In Single Key Grouping, the data is organized based on the single key input.
        /// 
        /// </summary>
        public void TestSingleKeyGrouping( )
        {
            //// Creating List
            //IList<ProductStore> ListData = new List<ProductStore>( );

            //ListData.Add( new ProductStore { category = 1, productName = "Hard Disk", type = "MEMORY" } );
            //ListData.Add( new ProductStore { category = 2, productName = "Monitor", type = "DISPLAY" } );
            //ListData.Add( new ProductStore { category = 1, productName = "SSD Disk", type = "MEMORY" } );
            //ListData.Add( new ProductStore { category = 1, productName = "RAM", type = "MEMORY" } );
            //ListData.Add( new ProductStore { category = 2, productName = "Processor", type = "CPU" } );
            //ListData.Add( new ProductStore { category = 1, productName = "Bluetooth", type = "Accessories" } );
            //ListData.Add( new ProductStore { category = 2, productName = "Keyboard & Mouse", type = "Accessories" } );

            //foreach ( ProductStore pro in ListData ) Console.WriteLine( pro.ToCSV( ) );

            //Query Syntax
            //var result = from product in ListData
            //             group product by product.category;

            //Method Syntax. Uncomment it to see the output 
            var result = ListData.GroupBy(p => p.category);

            foreach ( var group in result )
            {
                //Console.WriteLine( string.Format( "Category: {0}", group.Key ) );
                this.ListLine.Add( string.Format( "Category: {0}", group.Key ) );

                foreach ( var name in group )
                {
                    //Console.WriteLine( string.Format( "\tProduct Name: {0} | Type: {1}", name.productName, name.type ) );
                    this.ListLine.Add( name.ToKurz( ) );
                }

                this.ListLine.Add( string.Empty );
            }

            return;
        }

        //.....................................................................
        /// <summary>
        /// Multi Key Grouping
        /// 
        /// In multi key grouping, you can use more than one key to summarize and grouping data. 
        /// Here, in this example, I will use category and type as a key to grouping data.
        /// 
        /// </summary>
        public void TestMultiKeyGrouping( )
        {
            //// Creating List
            //IList<ProductStore> ListData = new List<ProductStore>( );

            //ListData.Add( new ProductStore { category = 1, productName = "Hard Disk", type = "MEMORY" } );
            //ListData.Add( new ProductStore { category = 2, productName = "Monitor", type = "DISPLAY" } );
            //ListData.Add( new ProductStore { category = 1, productName = "SSD Disk", type = "MEMORY" } );
            //ListData.Add( new ProductStore { category = 1, productName = "RAM", type = "MEMORY" } );
            //ListData.Add( new ProductStore { category = 2, productName = "Processor", type = "CPU" } );
            //ListData.Add( new ProductStore { category = 1, productName = "Bluetooth", type = "Accessories" } );
            //ListData.Add( new ProductStore { category = 2, productName = "Keyboard & Mouse", type = "Accessories" } );

            //Query Syntax
            //var result = from product in ListData
            //             group product by new { product.category, product.type };

            //Method Syntax. Uncomment it to see the output 
            var result = ListData.GroupBy(p => new { p.category, p.type });

            foreach ( var group in result )
            {
                //Console.WriteLine( string.Format( "Category: {0} | Type: {1}", group.Key.category, group.Key.type ) );
                this.ListLine.Add( string.Format( "Category: {0} | Type: {1}", group.Key.category, group.Key.type ) );

                foreach ( var name in group )
                {
                    //  Console.WriteLine( string.Format( "\tProduct Name: {0} | Type: {1}", name.productName, name.type ) );
                    this.ListLine.Add( name.ToKurz( ) );
                }

                this.ListLine.Add( string.Empty );
            }

            return;
        }

        //.....................................................................
        /// <summary>
        /// Grouping with Sorting
        ///     
        /// You can also do both Grouping and Sorting simultaneously. To do that, you need to understand following programming example.
        ///     
        /// </summary>
        public void TestGroupingSorting( )
        {
            //// Creating List
            //IList<ProductStore> ListData = new List<ProductStore>( );

            //ListData.Add( new ProductStore { category = 1, productName = "Hard Disk", type = "MEMORY" } );
            //ListData.Add( new ProductStore { category = 2, productName = "Monitor", type = "DISPLAY" } );
            //ListData.Add( new ProductStore { category = 1, productName = "SSD Disk", type = "MEMORY" } );
            //ListData.Add( new ProductStore { category = 1, productName = "RAM", type = "MEMORY" } );
            //ListData.Add( new ProductStore { category = 2, productName = "Processor", type = "CPU" } );
            //ListData.Add( new ProductStore { category = 1, productName = "Bluetooth", type = "Accessories" } );
            //ListData.Add( new ProductStore { category = 2, productName = "Keyboard & Mouse", type = "Accessories" } );

            //Query Syntax
            //var result = from product in ListData
            //             group product by new { product.category, product.type } into pgroup
            //             orderby pgroup.Key.category
            //             select pgroup;


            //Method Syntax. Uncomment it to see the output 
            var result = ListData.GroupBy( p => new { p.category, p.type } )
                                    .OrderBy( p => p.Key.category );

            foreach ( var group in result )
            {
                //Console.WriteLine( string.Format( "Category: {0} | Type: {1}", group.Key.category, group.Key.type ) );
                this.ListLine.Add( string.Format( "Category: {0} | Type: {1}", group.Key.category, group.Key.type ) );
                
                foreach ( var name in group )
                {
                    //Console.WriteLine( string.Format( "\tProduct Name: {0} | Type: {1}", name.productName, name.type ) );
                    this.ListLine.Add( name.ToKurz( ) );
                }

                this.ListLine.Add( string.Empty );
            }

            return;
        }

        //.....................................................................
    }
}
