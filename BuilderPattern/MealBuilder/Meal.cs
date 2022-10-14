using BuilderPattern.MealBuilder.MealTray;

namespace BuilderPattern.MealBuilder;

public class Meal : ITrayItem
{
    public string Name { get; set; }

    public int Weight { get; set; }

    public Meal(string name, int weight)
    {
        Name = name;
        Weight = weight;
    }
}
