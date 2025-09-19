namespace GrovemoorSite.Pages.Games.IdleTest.Models
{
    public static class AutoLoad
    {
        public static Dictionary<ItemType, Item> Items = new()
        {
            { ItemType.Seed, new Item(ItemType.Seed, "Seed", 1, "potted_plant", 1) },
            { ItemType.Tomato, new Item(ItemType.Tomato, "Tomato", 5, "nutrition", 5, 20) }
        };
    }
}
