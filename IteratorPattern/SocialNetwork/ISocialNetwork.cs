namespace IteratorPattern.SocialNetwork;

internal interface ISocialNetwork
{
    IEnumerator<SocialNetworkProfile> GetFriendsEnumerator();

    IEnumerator<SocialNetworkProfile> GetCoWorkersEnumerator();
}
