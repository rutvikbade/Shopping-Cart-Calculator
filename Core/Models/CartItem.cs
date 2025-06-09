using System;
using ShoppingCartCalculator.Utils;

namespace ShoppingCartCalculator.Models
{
    public class CartItem : Item
    {
        public double Tax { get;  set; }
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

        public double GetTotalPrice()
        {
            return TotalPrice;
        }
    }
}
