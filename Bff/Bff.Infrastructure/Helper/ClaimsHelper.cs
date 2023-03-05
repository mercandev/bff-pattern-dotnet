using System;
using System.Security.Claims;
using Bff.Infrastructure.Const;

namespace Bff.Infrastructure.Helper;

public static class ClaimsHelper
{
    public static Claim[] CreateSourceClaims(string source)
    {
        return new[]
        {
            new Claim(ClaimsConst.ClaimsType, source),
        };
    }
}