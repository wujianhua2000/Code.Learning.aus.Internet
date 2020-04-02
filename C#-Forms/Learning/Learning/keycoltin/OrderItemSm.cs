using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Learning
{
    /// <summary>
    /// This class represents a simple line item in an order. All the 
    /// values are immutable except quantity.
    /// 一个简单的版本
    /// 
    /// </summary>
    public class OrderItemSm
    {
        public readonly int PartNumber;

        public readonly string Description;

        public readonly double UnitPrice;

        private int _quantity = 0;

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="partNumber"></param>
        /// <param name="description"></param>
        /// <param name="quantity"></param>
        /// <param name="unitPrice"></param>
        public OrderItemSm( int partNumber, string description, int quantity, double unitPrice )
        {
            this.PartNumber = partNumber;
            this.Description = description;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;

            return;
        }
        
        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if ( value < 0 )
                    throw new ArgumentException( "Quantity cannot be negative." );

                _quantity = value;
            }
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString( )
        {
            return String.Format( "{0,9} {1,6} {2,-12} at {3,8:#,###.00} = {4,10:###,###.00}",
                                  PartNumber, 
                                  _quantity, 
                                  Description, 
                                  UnitPrice,
                                  UnitPrice * _quantity 
                                  );
        }

        //.....................................................................
    }

}