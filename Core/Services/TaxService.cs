using ShoppingCartCalculator.Cart;
using ShoppingCartCalculator.Input.Utils;
using ShoppingCartCalculator.Utils;
using ShoppingCartCalculator.Models;
using System.Collections.Generic;

namespace ShoppingCartCalculator.Services{
    public static class TaxService
    {
        public static void ApplyTaxes(List<CartItem> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine($"Processing item: {item.Name}");
                double baseRate = CategoryFactory.IsExempt(item.Name) ? 0.0d : 0.10d;
                double importRate = item.IsImported ? 0.05d : 0.0d;

                item.ApplyTax(baseRate, importRate);
            }
        }
    }
}