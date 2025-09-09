namespace GrovemoorSite.Pages.Games.IdleTest.Models;

public class ActiveTask(string title, int ticksTotal, Action onTaskComplete, Dictionary<ItemType, int> cost, bool repeatable = true)
{
    public string Title { get; set; } = title;
    public int TicksTotal { get; set; } = ticksTotal;
    public int TickCounter { get; set; } = ticksTotal;
    public Action OnTaskComplete { get; set; } = onTaskComplete;
    public bool Repeatable { get; set; } = repeatable;
    
    public Dictionary<ItemType, int> Cost { get; set; } = cost;

    public bool IsAffordable()
    {
        foreach (var item in Cost.Keys)
        {
            if (!Inventory.Items.ContainsKey(item))
            {
                return false;
            }

            if (Inventory.Items[item] < Cost[item])
            {
                return false;
            }
        }
        return true;
    }

    public bool StartTask()
    {
        if (!IsAffordable())
        {
            return false;
        }
        foreach (var item in Cost.Keys)
        {
            Inventory.RemoveItem(item,  Cost[item]);
        }
        return true;
    }
}