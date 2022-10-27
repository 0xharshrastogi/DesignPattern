using IteratorPattern.SocialNetwork;

var facebook = new Facebook();
var friendsEnumerator = facebook.GetFriendsEnumerator();

while (friendsEnumerator.MoveNext())
{
    var profile = friendsEnumerator.Current;
    Console.WriteLine(profile);
}
