using BuilderPattern.MealBuilder.MealDrink;
using BuilderPattern.MealBuilder.MealTray;

namespace BuilderPattern.MealBuilder;

public class MealBuilder<T> : IMealBuilder<T> where T : Tray
{
    public T? Tray { get; set; }

    public IMealBuilder<T> AddDrink(Drink drink)
    {
        if (Tray is null)
            throw new Exception("Cannot add drink or meal, add Teay object using UseTray(Tray tray)");

        Tray.AddItem(drink);
        return this;
    }

    public IMealBuilder<T> AddMeal(Meal meal)
    {
        if (Tray is null)
            throw new Exception("Cannot add drink or meal, add Teay object using UseTray(Tray tray)");
        
        Tray.AddItem(meal);
        return this;
    }

    public IMealBuilder<T> UseTray(T tray)
    {
        Tray = tray;
        return this;
    }

    public T Build()
    {
        if(Tray is null)
            throw new ArgumentNullException(nameof(Tray), "Tray is not created");
        return Tray;
    }
}
