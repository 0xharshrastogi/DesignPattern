namespace BuilderPattern.MealBuilder.MealTray;

public abstract class Tray
{
    public int MaxWeightInGram { get; private set; }

    public int MaxDrinkSlot { get; private set; }

    public MealTrayType MealTrayType { get; private set; }

    public IDictionary<string, IList<ITrayItem>> TrayItemsCollection { get; }
        = new Dictionary<string, IList<ITrayItem>>();

    protected Tray(int maxWeightInGM, int maxDrinkSlot, MealTrayType mealTrayType)
    {
        MaxWeightInGram = maxWeightInGM;
        MaxDrinkSlot = maxDrinkSlot;
        MealTrayType = mealTrayType;
    }

    public void AddItem(ITrayItem item)
    {
        var currentWeightOfTray = TrayItemsCollection.Values.Sum(items => items.Sum(item => item.Weight));
        var canAddItem = item.Weight < (MaxWeightInGram - currentWeightOfTray);

        if (!canAddItem)
            throw new Exception("Cannot Add More Item To Tray");


        if(TrayItemsCollection.TryGetValue(item.Name, out var items))
        {
            items.Add(item);
            return;
        }

        TrayItemsCollection.Add(item.Name, new List<ITrayItem> { item });
    }
}
