using System;
using System.Security.Claims;

namespace Bff.Infrastructure.Jwt;

public interface IJwtSecurity
{
    string CreateJwtToken(Claim[] claims);
}