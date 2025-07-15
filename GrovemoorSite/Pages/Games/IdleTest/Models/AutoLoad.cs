namespace GrovemoorSite.Pages.Games.IdleTest.Models
{
    public static class AutoLoad
    {
        public static Dictionary<ItemType, Item> Items = new()
        {
            { ItemType.Seed, new Item(ItemType.Seed, "Seed", 5, 0) }
        };
    }
}
