namespace BuilderPattern.MealBuilder.MealTray;

public class VegetarianTray : Tray
{
    public VegetarianTray()
        : base(1_000, 20, MealTrayType.Vegetarian)
    { }
}
