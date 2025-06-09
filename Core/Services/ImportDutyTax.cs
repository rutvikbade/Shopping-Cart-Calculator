
using ShoppingCartCalculator.Interfaces;
using ShoppingCartCalculator.Models;

namespace ShoppingCartCalculator.Services
{
    /// <summary>
    /// Represents a tax rule for import duty tax.
    /// </summary>
    public class ImportDutyTax : ITaxRule
    {
        private const double ImportDutyRate = 0.05d;

        public double CalculateTax(CartItem item)
        {
            if(!item.IsImported)
                return 0d;

            var tax = item.GetPrice() * item.Quantity * ImportDutyRate;
            return tax;
        }
    }
}