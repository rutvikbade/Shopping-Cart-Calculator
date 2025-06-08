
namespace ShoppingCartCalculator.Utils{
    
    public static class RoundingHelper
    {
        public static double RoundUpToNearest(double value)
        {
            return Math.Ceiling(value * 20) / 20;
        }
    }
}
