namespace GrovemoorSite.Pages.Games.IdleTest.Models
{
    public static class Inventory
    {
        public static int Money { get; set; } = 5;
        public static Dictionary<ItemType, int> Items { get; set; } = new();

        public static void AddItem(ItemType item, int amount = 1)
        {
            if (Items.ContainsKey(item))
            {
                Items[item] += amount;
            }
            else
            {
                Items.Add(item, amount);
            }
        }

        public static void RemoveItem(ItemType item, int amount = 1)
        {
            Items[item] -= amount;
        }
    }
}
