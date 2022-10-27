using System.Collections;

namespace IteratorPattern.SocialNetwork;

internal class FacebookEnumerator : IEnumerator<SocialNetworkProfile>
{
    private readonly Guid _profileId;

    private readonly string _type;

    private Dictionary<Guid, SocialNetworkProfile>? _cache;
    private Dictionary<Guid, SocialNetworkProfile> Cache => _cache ??= Facebook.SocialGraphRequest(_profileId, _type);

    private readonly IEnumerator<KeyValuePair<Guid, SocialNetworkProfile>>? _cacheEnumerator;
    private IEnumerator<KeyValuePair<Guid, SocialNetworkProfile>> CacheEnumerator => _cacheEnumerator ?? Cache.GetEnumerator();

    public SocialNetworkProfile Current => CacheEnumerator.Current.Value;
    object IEnumerator.Current => Current;

    public FacebookEnumerator(Guid profileId, string type)
    {
        _profileId = profileId;
        _type = type;
    }

    public bool MoveNext() => CacheEnumerator.MoveNext();
    public void Reset() => CacheEnumerator.Reset();
    public void Dispose() => CacheEnumerator.Dispose();
}
