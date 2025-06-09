
using ShoppingCartCalculator.Interfaces;
using ShoppingCartCalculator.Models;

namespace ShoppingCartCalculator.Services
{
    /// <summary>
    /// Represents a tax rule for import duty tax.
    /// </summary>
    public class BaseTax : ITaxRule
    {
        private const double BaseTaxRate = 0.1d;

        public double CalculateTax(CartItem item)
        {
            if(CategoryFactory.IsExempt(item.Name))
               return 0d;

            var totalTax = item.Price * item.Quantity* BaseTaxRate;
            return totalTax;
        }
    }
}

