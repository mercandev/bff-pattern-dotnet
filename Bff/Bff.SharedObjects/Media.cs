using System;
namespace Bff.SharedObjects;

public sealed class Media : BaseViewModel
{
    public Guid Repliesid { get; set; }
    public Guid TweetId { get; set; }
}