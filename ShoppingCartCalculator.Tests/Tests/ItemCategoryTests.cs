using Xunit;
using ShoppingCartCalculator.Utils; // Or wherever your CategoryFactory lives

namespace ShoppingCartCalculator.Tests
{
    public class ItemCategoryTests
    {
        [Theory]
        [InlineData("book", ItemCategory.Book)]
        [InlineData("some book title", ItemCategory.Book)]
        [InlineData("imported chocolate bar", ItemCategory.Food)]
        [InlineData("box of chocolates", ItemCategory.Food)]
        [InlineData("packet of headache pills", ItemCategory.Medical)]
        [InlineData("random item", ItemCategory.Other)]
        [InlineData("", ItemCategory.Other)]
        [InlineData(null, ItemCategory.Other)]
        public void GetCategory_ShouldReturnExpectedCategory(string keyword, ItemCategory expectedCategory)
        {
            var category = CategoryFactory.GetCategory(keyword);
            Assert.Equal(expectedCategory, category);
        }

        [Theory]
        [InlineData("book", true)]
        [InlineData("chocolate bar", true)]
        [InlineData("packet of pills", true)]
        [InlineData("music CD", false)]
        [InlineData("perfume", false)]
        public void IsExempt_ShouldReturnCorrectExemptionStatus(string keyword, bool expected)
        {
            var result = CategoryFactory.IsExempt(keyword);
            Assert.Equal(expected, result);
        }
    }
}
