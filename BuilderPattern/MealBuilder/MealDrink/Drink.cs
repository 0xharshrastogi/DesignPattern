using BuilderPattern.MealBuilder.MealTray;

namespace BuilderPattern.MealBuilder.MealDrink;

public class Drink : ITrayItem
{
    public string Name { get; set; }
    public int Weight { get; set; }

    public Drink(string name, int weight)
    {
        Name = name;
        Weight = weight;
    }
}
