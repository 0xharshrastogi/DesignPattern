namespace FlyweightPattern.Forest;

public class Tree
{
    public int CoordX { get; set; }

    public int CoordY { get; set; }

    public TreeType TreeType { get; set; }

    public Tree(int coordX, int coordY, TreeType treeType)
    {
        CoordX = coordX;
        CoordY = coordY;
        TreeType = treeType;
    }

    public void Draw() => Console.WriteLine(this);

    public override string ToString() => $"Position: [{CoordX},{CoordY}] | Name: {TreeType.Color} | Color: {TreeType.Color} | Texture: {TreeType.Texture}";
}
