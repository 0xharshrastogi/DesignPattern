namespace IteratorPattern.SocialNetwork;

public class SocialNetworkProfile
{
    private Guid _userId;

    public Guid UserId
    {
        get
        {
            if (_userId == Guid.Empty)
                _userId = Guid.NewGuid();
            return _userId;
        }
    }

    public string Name { get; set; } = "NO_NAME";

    public override string ToString() => $"{Name} [{UserId}]";
}
