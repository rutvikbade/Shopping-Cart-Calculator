using Xunit;
using ShoppingCartCalculator.Models;
using ShoppingCartCalculator.Utils;
using System.Collections.Generic;

namespace ShoppingCartCalculator.Tests
{
    public class JsonConverterTests
    {
        [Fact]
        public void FromJson_ShouldDeserializeValidJson()
        {
            string json = @"[
                { ""name"": ""book"", ""price"": 12.49, ""quantity"": 1, ""isImported"": false }
            ]";

            var items = JsonConverter.FromJson<LineItem>(json);

            Assert.Single(items);
            Assert.Equal("book", items[0].Name);
        }
    }
}
