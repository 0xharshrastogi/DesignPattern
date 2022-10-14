namespace BuilderPattern.MealBuilder.MealTray;

interface ITrayFactory
{
    Tray GetTray(MealTrayType trayType);
}
