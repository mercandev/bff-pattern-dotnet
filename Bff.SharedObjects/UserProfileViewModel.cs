using System;
namespace Bff.SharedObjects;

public sealed class UserProfileViewModel
{
    public List<Media> Media { get; set; }
    public Profile Profile { get; set; }
    public List<Replies> Replies { get; set; }
    public List<Tweets> Tweets { get; set; }
}