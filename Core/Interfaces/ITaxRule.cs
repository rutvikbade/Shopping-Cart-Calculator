
using ShoppingCartCalculator.Models;

namespace ShoppingCartCalculator.Interfaces
{
    /// <summary>
    /// Represents a tax rule that can be applied to items in a shopping cart.
    /// </summary>
    public interface ITaxRule
    {
        double CalculateTax(CartItem item);
    }
}