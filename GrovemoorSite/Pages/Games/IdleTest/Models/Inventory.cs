namespace GrovemoorSite.Pages.Games.IdleTest.Models
{
    public class Inventory
    {
        public int Money { get; set; } = 5;
        public Dictionary<ItemType, int> Items { get; set; } = new();

        public void AddItem(ItemType item, int amount = 1)
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
    }
}
