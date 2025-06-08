using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text.Json;
using ShoppingCartCalculator.Input.Utils;

namespace ShoppingCartCalculator.Input
{
    public class InputParser
    {
        // Parses input string into a JSON string of line items
        public static string ParseLineItemsToJson(string input)
        {
            var result = new List<Dictionary<string, object>>();
            var lines = input.Split('\n');
            var pattern = @"^(\d+)\s+(.+)\s+at\s+([0-9]+\.[0-9]{2})$";

            foreach (var line in lines)
            {
                var trimmed = line.Trim();
                if (string.IsNullOrWhiteSpace(trimmed)) continue;

                var match = Regex.Match(trimmed, pattern);
                if (match.Success)
                {
                    int quantity = int.Parse(match.Groups[1].Value);
                    string item = match.Groups[2].Value.Trim();
                    double price = double.Parse(match.Groups[3].Value);
                    bool isImported = item.ToLower().Contains("imported");

                    var name = Regex.Replace(item, @"\bimported\b", "", RegexOptions.IgnoreCase).Trim();

                    Console.WriteLine($"Parsed item: {name}, Quantity: {quantity}, Price: {price}, Is Imported: {isImported}");
                    result.Add(new Dictionary<string, object>
                    {
                        { "name", name },
                        { "quantity", quantity },
                        { "price", price },
                        { "isImported", isImported }
                    });
                }
            }

            return JsonSerializer.Serialize(result);
        }
    }
}
