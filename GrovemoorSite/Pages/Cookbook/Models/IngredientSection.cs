public class IngredientSection(string sectionTitle, List<Ingredient> ingredients)
{
    public string SectionTitle { get; set; } = sectionTitle;
    public List<Ingredient> Ingredients { get; set; } = ingredients;
}