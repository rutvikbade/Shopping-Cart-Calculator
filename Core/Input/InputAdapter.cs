using System;
using System.Collections.Generic;
using ShoppingCartCalculator.Utils;
using ShoppingCartCalculator.Models;
using ShoppingCartCalculator.Input.Utils;
using System.Text.Json;

namespace ShoppingCartCalculator.Input
{
    public class InputAdapter
    {
        // Main entry point — returns a list of CartItem objects
        public static List<CartItem> ParseInput(string input)
        {
            input = input.Trim();
            List<LineItem> lineItems;

            if (InputFormatHelper.IsJson(input))
            {
                try
                {
                    lineItems = JsonConverter.FromJson<LineItem>(input);
                }
                catch
                {
                    throw new ArgumentException("Invalid JSON format.");
                }
            }
            else
            {
                var json = InputParser.ParseLineItemsToJson(input);
                lineItems = JsonConverter.FromJson<LineItem>(json);
            }
            string jsonString = JsonSerializer.Serialize(lineItems);


            Console.WriteLine($"Parsed {jsonString} line items from input.");
            return ConvertToCartItems(lineItems);
        }

        // Converts LineItem DTOs into full CartItem objects
        private static List<CartItem> ConvertToCartItems(List<LineItem> lineItems)
        {
            var cartItems = new List<CartItem>();

            foreach (var li in lineItems)
            {
                var cartItem = new CartItem(li.Name, li.Price, li.Quantity, li.IsImported);
                cartItems.Add(cartItem);
            }

            return cartItems;
        }
    }
}
