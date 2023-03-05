using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Bff.Infrastructure.Authentications;

public class AuthBffAttribute : Attribute, IAuthorizationFilter
{
    public string Source { get; set; }

    public void OnAuthorization(AuthorizationFilterContext context)
    {
        if (!context.HttpContext.User.Identity.IsAuthenticated)
        {
            context.Result = new UnauthorizedResult();
        }

        if (!string.IsNullOrWhiteSpace(Source))
        {
            var splitUser = Source.Trim().Split(",").ToArray();
            var claimPayload = context.HttpContext.User.Claims.Where(x => x.Type.Equals("Source")).Select(x => x.Value).ToArray();

            if (!claimPayload.Intersect(splitUser).Any())
            {
                context.Result = new ForbidResult();
            }
        }
    }
}