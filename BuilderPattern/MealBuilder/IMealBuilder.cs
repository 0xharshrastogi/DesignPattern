using BuilderPattern.MealBuilder.MealDrink;
using BuilderPattern.MealBuilder.MealTray;

namespace BuilderPattern.MealBuilder;

public interface IMealBuilder<T> where T : Tray
{
    IMealBuilder<T> UseTray(T tray);

    IMealBuilder<T> AddMeal(Meal meal);

    IMealBuilder<T> AddDrink(Drink drink);

    T Build();
}
