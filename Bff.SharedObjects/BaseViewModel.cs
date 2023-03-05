using System;
namespace Bff.SharedObjects;

public class BaseViewModel
{
    public Guid Id { get; set; }
    public string Text { get; set; }
    public DateTime CreatedDate { get; set; }
    public User User { get; set; }
    public int LikeCount { get; set; }
    public int RetweetCount { get; set; }
    public int Activity { get; set; }
    public Ip Ip { get; set; }
    public string Country { get; set; }
    public string Lat { get; set; }
    public string Long { get; set; }
    public string MediaUrl { get; set; }
}

public sealed record class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string ProfilePhotoUrl { get; set; }
}

public sealed record class Ip
{
    public string Ipv4 { get; set; }
    public string Ipv6 { get; set; }
}