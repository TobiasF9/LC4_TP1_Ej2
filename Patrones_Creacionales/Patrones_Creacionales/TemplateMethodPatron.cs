using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Creacionales
{
    abstract class OrderProcessor
    {
        public void ProcessOrder()
        {
            ValidateOrder();
            PrepareItems();
            CalculateTotal();
            ApplyDiscounts();
            ShipItems();
        }

        protected void ValidateOrder()
        {
            Console.WriteLine("OrderProcessor: Validating the order");
        }

        protected abstract void PrepareItems();

        protected abstract void CalculateTotal();

        protected virtual void ApplyDiscounts()
        {
            Console.WriteLine("OrderProcessor: Applying discounts if applicable");
        }

        protected abstract void ShipItems();
    }

    class OnlineOrderProcessor : OrderProcessor
    {
        protected override void PrepareItems()
        {
            Console.WriteLine("OnlineOrderProcessor: Preparing items for shipping");
        }

        protected override void CalculateTotal()
        {
            Console.WriteLine("OnlineOrderProcessor: Calculating total amount including taxes");
        }

        protected override void ShipItems()
        {
            Console.WriteLine("OnlineOrderProcessor: Shipping items to the customer's address");
        }
    }

    class InStoreOrderProcessor : OrderProcessor
    {
        protected override void PrepareItems()
        {
            Console.WriteLine("InStoreOrderProcessor: Assembling items for customer pickup");
        }

        protected override void CalculateTotal()
        {
            Console.WriteLine("InStoreOrderProcessor: Calculating total amount");
        }

        protected override void ApplyDiscounts()
        {
            Console.WriteLine("InStoreOrderProcessor: Applying in-store discounts");
        }

        protected override void ShipItems()
        {
            Console.WriteLine("InStoreOrderProcessor: Items are picked up by the customer");
        }
    }
}
