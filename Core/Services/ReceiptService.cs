using ShoppingCartCalculator.Models;

namespace ShoppingCartCalculator.Services{
    public static class ReceiptService
    {
        public static void PrintReceipt(List<CartItem> items)
        {
            double totalTax = 0;
            double total = 0;

            foreach (var item in items)
            {
                Console.WriteLine($"{item.Quantity}]: {item.TotalPrice:F2}");
                totalTax += item.Tax;
                total += item.TotalPrice;
            }

            Console.WriteLine($"Sales Taxes: {totalTax:F2}");
            Console.WriteLine($"Total: {total:F2}");
        }
    }
}