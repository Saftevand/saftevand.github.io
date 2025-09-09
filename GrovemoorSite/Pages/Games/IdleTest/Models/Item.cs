namespace GrovemoorSite.Pages.Games.IdleTest.Models
{
    public class Item(ItemType type, string name, int buyPrice, string icon, int sellPrice = 0, int growTime = 200)
    {
        public ItemType Type { get; set; } = type;
        public string Name { get; set; } = name;
        public int BuyPrice { get; set; } = buyPrice;
        public int SellPrice { get; set; } = sellPrice;
        public string Icon { get; set; } = icon;
        public int GrowTime { get; set; } = growTime;
    }
}
