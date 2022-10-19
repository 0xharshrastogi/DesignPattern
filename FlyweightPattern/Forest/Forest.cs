namespace FlyweightPattern.Forest;

public class Forest
{
    private readonly List<Tree> _trees = new();

    public void PlantTree(int coordX, int coordY, string name, string color, string texture)
    {
        _trees.Add(new(coordX, coordY, TreeFactory.GetTreeType(name, color, texture)));
    }

    public void Draw()
    {
        foreach (var tree in _trees) tree.Draw();
    }
}
