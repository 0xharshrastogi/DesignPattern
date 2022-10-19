namespace FlyweightPattern.Forest;

public class TreeType
{
    public string Name { get; set; }

    public string Color { get; set; }

    public string Texture { get; set; }

    public TreeType(string name, string color, string texture)
    {
        Name = name;
        Color = color;
        Texture = texture;
    }

    public static void Draw(int coordX, int coordY) => Console.WriteLine($"CoordX {coordX}, CoordY {coordY}");
}
