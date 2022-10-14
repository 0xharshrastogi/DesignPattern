namespace BuilderPattern.MealBuilder.MealTray;

public class NonVegetarianTray : Tray
{
    public NonVegetarianTray()
        : base(1_000, 20, MealTrayType.NonVegetarian)
    { }
}
