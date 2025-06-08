public enum ItemCategory
{
    Book,
    Food,
    Medical,
    Other
}


// This can be optimized further by using a dictionary to map keywords to categories.
public static class CategoryFactory
{
    public static ItemCategory GetCategory(string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword)) return ItemCategory.Other;

        var lower = keyword.ToLower();

        foreach (var pair in CategoryKeywords.Keywords)
        {
            foreach (var kw in pair.Value)
            {
                if (lower.Contains(kw))
                    return pair.Key;
            }
        }

        return ItemCategory.Other;
    }

    public static bool IsExempt(string keyword)
    {
        var category = GetCategory(keyword);
        return category == ItemCategory.Book || category == ItemCategory.Food || category == ItemCategory.Medical;
    }
}

public static class CategoryKeywords
{
    public static readonly Dictionary<ItemCategory, string[]> Keywords = new Dictionary<ItemCategory, string[]>
    {
        { ItemCategory.Book, new[] { "book" } },
        { ItemCategory.Food, new[] { "chocolate", "chocolates", "chocolate bar" } },
        { ItemCategory.Medical, new[] { "pill", "pills" } }
    };
}