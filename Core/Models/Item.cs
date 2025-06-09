using System;
using System.Text.Json.Serialization;

namespace ShoppingCartCalculator.Models
{

    // Represents a line item in the shopping cart
    // Contains properties for quantity, item name, price, and whether the item is imported
    public struct LineItem
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("price")]
        public double Price { get; set; }

        [JsonPropertyName("isImported")]
        public bool IsImported { get; set; }
    }

    public class Item
    {
        public string Name;
        public double Price;

        public Item(string name,  double price)
        {
            Name = name;
            Price = price;
        }

        public string GetName()
        {
            return Name;
        }

        public double GetPrice()
        {
            return Price;
        }
    }
    
}
