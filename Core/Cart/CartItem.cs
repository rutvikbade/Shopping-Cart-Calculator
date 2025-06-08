using System;
using ShoppingCartCalculator.Models;
using ShoppingCartCalculator.Utils;

namespace ShoppingCartCalculator.Cart
{
    public class CartItem : Item
    {
        public double Tax { get; private set; }
        public int Quantity { get; private set; }
        public bool IsImported { get; set; } = false;
        public double TotalPrice => (Price * Quantity) + Tax;

        public CartItem(string name,  double price, int quantity, bool isImported)
            : base(name, price)
        {
            Console.WriteLine($"Creating CartItem: {name}, Price: {price}, Quantity: {quantity}, IsImported: {isImported}");
            Quantity = quantity;
            IsImported = isImported;
        }

        public void ApplyTax(double baseRate, double importRate, bool roundOff = false)
        {
            var tax = (Price * Quantity) * baseRate;

            if (IsImported)
                tax += (Price * Quantity) * importRate;

            Tax = RoundingHelper.RoundUpToNearest(tax);
        }

        public double GetTotalPrice()
        {
            return TotalPrice;
        }
    }
}
