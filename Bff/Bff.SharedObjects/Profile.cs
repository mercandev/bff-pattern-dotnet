using System;
namespace Bff.SharedObjects;

public sealed class Profile
{
    public int UserId { get; set; }
    public string Username { get; set; }
    public string DisplayName { get; set; }
    public string Bio { get; set; }
    public string Location { get; set; }
    public string Url { get; set; }
    public string JoinedDate { get; set; }
}
