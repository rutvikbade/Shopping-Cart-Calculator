using ShoppingCartCalculator.Services;
using ShoppingCartCalculator.Input;
using ShoppingCartCalculator.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        var input = File.ReadAllText("input.txt");
        var items = InputAdapter.ParseInput(input);

        List<ITaxRule> taxRules = new List<ITaxRule>
        {
            new BaseTax(),
            new ImportDutyTax()
        };
        TaxService taxService = new TaxService(taxRules);
        
        taxService.ApplyTaxes(items);
        ReceiptService.PrintReceipt(items);
    }
}