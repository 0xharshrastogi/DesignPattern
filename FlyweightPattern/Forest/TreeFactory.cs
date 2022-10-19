namespace FlyweightPattern.Forest;

public static class TreeFactory
{
    private static readonly object TreeTypeAdditionLock = new();
    private static readonly IList<TreeType> TreeTypes = new List<TreeType>();

    public static TreeType GetTreeType(string name, string color, string texture)
    {
        lock (TreeTypeAdditionLock!)
        {
            var type = TreeTypes.ToList().Find(treeType => treeType.Name == name
                                                   && treeType.Color == color
                                                   && treeType.Texture == texture);

            if (type is null)
            {
                type = new TreeType(name, color, texture);

                TreeTypes.Add(type);
            }

            return type;
        }
    }
}
