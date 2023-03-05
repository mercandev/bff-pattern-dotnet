using System;
namespace Bff.Infrastructure.Jwt;

public class JwtModel
{
    public string Key { get; set; }
    public string Issuer { get; set; }
    public string Audience { get; set; }
}