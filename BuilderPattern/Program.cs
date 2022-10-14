using BuilderPattern.MealBuilder;
using BuilderPattern.MealBuilder.MealDrink;
using BuilderPattern.MealBuilder.MealTray;

var trayFactory = new MealTrayFactory();

var mangoDrink = new Drink("Mango Syrup", 20);
var tea = new Drink("Tea", 30);
var coffee = new Drink("Coffee", 40);


var mealBuilder = new MealBuilder<VegetarianTray>();

var meal = mealBuilder
    .UseTray((VegetarianTray)trayFactory.GetTray(MealTrayType.Vegetarian))
    .AddDrink(mangoDrink)
    .AddDrink(coffee)
    .AddMeal(new Meal("Chicken", 999))
    .Build();

var total = meal.TrayItemsCollection.Values.Sum(items => items.Sum(item => item.Weight));
Console.WriteLine(total);



