namespace IteratorPattern.SocialNetwork;

public class Facebook : ISocialNetwork
{
    public static Dictionary<Guid, SocialNetworkProfile> SocialGraphRequest(Guid profileId, string type) => new()
    {
        [profileId] = new SocialNetworkProfile()
    };

    public IEnumerator<SocialNetworkProfile> GetCoWorkersEnumerator() => new FacebookEnumerator(Guid.NewGuid(), "friends");

    public IEnumerator<SocialNetworkProfile> GetFriendsEnumerator() => new FacebookEnumerator(Guid.NewGuid(), "coworkers");
}
