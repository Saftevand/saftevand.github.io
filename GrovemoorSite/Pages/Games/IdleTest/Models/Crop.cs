namespace GrovemoorSite.Pages.Games.IdleTest.Models;

public class Crop(ItemType type, string name, int buyPrice, string icon, int sellPrice = 0, int growTime = 250) : Item(type, name, buyPrice, icon, sellPrice)
{
    public int GrowTime { get; set; } = growTime;
}