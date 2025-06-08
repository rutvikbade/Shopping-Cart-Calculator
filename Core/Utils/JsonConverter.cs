using System.Collections.Generic;
using System.Text.Json;

namespace ShoppingCartCalculator.Utils
{
    public static class JsonConverter
    {
        public static List<T> FromJson<T>(string json)
        {
            var items = JsonSerializer.Deserialize<List<JsonElement>>(json);
            var result = new List<T>();
            foreach (var item in items)
            {
                var obj = JsonSerializer.Deserialize<T>(item.GetRawText());
                result.Add(obj);
            }
            return result;
        }
    }
}
