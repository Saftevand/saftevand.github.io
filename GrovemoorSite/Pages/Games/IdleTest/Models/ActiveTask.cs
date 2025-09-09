namespace GrovemoorSite.Pages.Games.IdleTest.Models;

public class ActiveTask(string title, int ticksTotal, Action onTaskComplete)
{
    public string Title { get; set; } = title;
    public int TicksTotal { get; set; } = ticksTotal;
    public int TickCounter { get; set; } = ticksTotal;
    public Action OnTaskComplete { get; set; } = onTaskComplete;
}