namespace GrovemoorSite.Pages.Games.IdleTest.Models
{
    public static class AutoLoad
    {
        public static Dictionary<ItemType, Item> Items = new()
        {
            { ItemType.Seed, new Item(ItemType.Seed, "Seed", 1, "potted_plant", 0) }
        };

        public static Dictionary<ItemType, Crop> Crops = new()
        {
            { ItemType.Tomato, new Crop(ItemType.Tomato, "Potato", 5, "nutrition", 0, 200) }
        };
    }
}
