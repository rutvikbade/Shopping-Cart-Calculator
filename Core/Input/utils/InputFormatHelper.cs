using System;
using System.Text.Json;


namespace ShoppingCartCalculator.Input.Utils
{
    public static class InputFormatHelper
    {
        public static bool IsJson(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            try
            {
                JsonDocument.Parse(input);
                return true;
            }
            catch (JsonException)
            {
                return false;
            }
        }
}
}
