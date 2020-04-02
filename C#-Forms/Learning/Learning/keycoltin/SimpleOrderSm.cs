using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Learning
{

    /// <summary>
    /// This class represents a very simple keyed list of OrderItems,
    /// inheriting most of its behavior from the KeyedCollection and 
    /// Collection classes. The immediate base class is the constructed
    /// type KeyedCollection<int, OrderItemSm>. When you inherit
    /// from KeyedCollection, the second generic type argument is the 
    /// type that you want to store in the collection -- in this case
    /// OrderItemSm. The first type argument is the type that you want
    /// to use as a key. Its values must be calculated from OrderItemSm; 
    /// in this case it is the int field PartNumber, so SimpleOrderSm
    /// inherits KeyedCollection<int, OrderItemSm>.
    /// 
    /// 一个简单的版本
    /// </summary>
    public class SimpleOrderSm : KeyedCollection<int, OrderItemSm>
    {
        //.....................................................................
        // This is the only method that absolutely must be overridden,
        // because without it the KeyedCollection cannot extract the
        // keys from the items. The input parameter type is the 
        // second generic type argument, in this case OrderItemSm, and 
        // the return value type is the first generic type argument,
        // in this case int.
        //
        protected override int GetKeyForItem( OrderItemSm item )
        {
            // In this example, the key is the part number.
            return item.PartNumber;
        }

        //.....................................................................
    }

}