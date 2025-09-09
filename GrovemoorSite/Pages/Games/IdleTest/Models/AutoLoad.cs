namespace GrovemoorSite.Pages.Games.IdleTest.Models
{
    public static class AutoLoad
    {
        public static Dictionary<ItemType, Item> Items = new()
        {
            { ItemType.Seed, new Item(ItemType.Seed, "Seed", 1, "potted_plant", 0) },
            { ItemType.Tomato, new Item(ItemType.Tomato, "Potato", 5, "nutrition", 0) }
        };
    }
}
