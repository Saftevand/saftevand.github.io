public class Ingredient(string name, int amount, MeaseringUnit measeringUnit, bool optional = false, string note = "")
{
    public string Name { get; set; } = name;
    public MeaseringUnit Unit { get; set; } = measeringUnit;
    public int Amount { get; set; } = amount;
    public bool Optional { get; set; } = optional;
    public string Note { get; set; } = note;


    public override string ToString()
    {
        return $"{Amount} {(Unit != MeaseringUnit.None ? Unit.ToString() + " " : "")} {Name}{(Unit == MeaseringUnit.None ? "s" : "")}{(Note != "" ? " (" + Note + ")" : "")}";
    }
}