using System;
using Bff.Infrastructure.Helper;
using Bff.Infrastructure.Jwt;

namespace Bff.Service.LoginService;

public class LoginService : ILoginService
{
    private readonly IJwtSecurity _jwtSecurity;

    public LoginService(IJwtSecurity jwtSecurity) => this._jwtSecurity = jwtSecurity;

    public string CreateToken(string source)
    {
        return _jwtSecurity.CreateJwtToken(ClaimsHelper.CreateSourceClaims(source));
    }
}