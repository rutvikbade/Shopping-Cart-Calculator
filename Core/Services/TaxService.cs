using ShoppingCartCalculator.Input.Utils;
using ShoppingCartCalculator.Utils;
using ShoppingCartCalculator.Models;
using ShoppingCartCalculator.Interfaces;
using System.Collections.Generic;

namespace ShoppingCartCalculator.Services{
    public class TaxService
    {
        private readonly IEnumerable<ITaxRule> _taxRules;

        public TaxService(IEnumerable<ITaxRule> taxRules)
        {
            _taxRules = taxRules;
        }

        public double ApplyTaxes(List<CartItem> items)
        {
            double totalTax = 0d;
            
                foreach (var item in items)
                {
                    var rawItemTax = 0d;
                    foreach (var rule in _taxRules)
                    {
                        var tax = rule.CalculateTax(item);
                        rawItemTax += tax;
                    }
                    var netItemTax = RoundingHelper.RoundUpToNearest(rawItemTax);
                    item.Tax = netItemTax; 
                }

            return RoundingHelper.RoundUpToNearest(totalTax);
        }

    }
}