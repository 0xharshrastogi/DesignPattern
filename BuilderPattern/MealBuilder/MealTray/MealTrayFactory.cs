namespace BuilderPattern.MealBuilder.MealTray;

public class MealTrayFactory : ITrayFactory
{
    public Tray GetTray(MealTrayType trayType) => trayType switch
    {
        MealTrayType.Vegetarian => new VegetarianTray(),
        MealTrayType.NonVegetarian => new NonVegetarianTray(),
        _ => throw new NotImplementedException()
    };
}
