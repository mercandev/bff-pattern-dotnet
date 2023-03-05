using System;
namespace Bff.SharedObjects;

public sealed class Replies : BaseViewModel
{
    public Guid RepliesId { get; set; }
    public Guid TweetId { get; set; }
}