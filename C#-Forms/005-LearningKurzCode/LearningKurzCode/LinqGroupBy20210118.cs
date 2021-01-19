using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningKurzCode
{
    /// <summary>
    /// 
    /// </summary>
    class Transaction
    {
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    class LinqGroupBy20210118
    {
        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        public static void Process( )
        {
            var transactions = new List<Transaction>
                    {
                    new Transaction { Category = "Saving Account", Amount = 56, Date = DateTime.Today.AddDays(1) },
                    new Transaction { Category = "Saving Account", Amount = 10, Date = DateTime.Today.AddDays(-10) },
                    new Transaction { Category = "Credit Card", Amount = 15, Date = DateTime.Today.AddDays(1) },
                    new Transaction { Category = "Credit Card", Amount = 56, Date = DateTime.Today },
                    new Transaction { Category = "Current Account", Amount = 100, Date = DateTime.Today.AddDays(5) },
                    };

            //If you want to calculate category wise sum of amount and count, you can use GroupBy as follows:

            var summaryApproach1 = transactions.GroupBy( t => t.Category )
                                        .Select( t => new
                                        {
                                            Category = t.Key,
                                            Count = t.Count( ),
                                            Amount = t.Sum( ta => ta.Amount ),
                                        } ).ToList( );

            Console.WriteLine( "-- Summary: Approach 1 --" );
            //delegate(String name)
            summaryApproach1.ForEach( row =>
                { Console.WriteLine( $"Category: {row.Category}, Amount: {row.Amount}, Count: {row.Count}" ); }
                );

            //Alternatively, you can do this in one step:

            var summaryApproach2 = transactions.GroupBy( t => t.Category, ( key, t ) =>
            {
                var transactionArray = t as Transaction[ ] ?? t.ToArray( );
                return new
                {
                    Category = key,
                    Count = transactionArray.Length,
                    Amount = transactionArray.Sum( ta => ta.Amount ),
                };
            } ).ToList( );

            Console.WriteLine( "-- Summary: Approach 2 --" );

            summaryApproach2.ForEach( row =>
                Console.WriteLine( $"Category: {row.Category}, Amount: {row.Amount}, Count: {row.Count}" ) 
                );

            return;
        }

        //.....................................................................
    }

}
