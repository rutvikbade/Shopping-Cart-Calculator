using ShoppingCartCalculator.Services;
using ShoppingCartCalculator.Input;

class Program
{
    static void Main(string[] args)
    {
        var input = File.ReadAllText("input.txt");
        var items = InputAdapter.ParseInput(input);

        TaxService.ApplyTaxes(items);
        ReceiptService.PrintReceipt(items);
    }
}