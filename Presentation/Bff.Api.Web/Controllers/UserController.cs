using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Bff.Infrastructure.Authentications;
using Bff.Infrastructure.Const;
using Bff.Service;
using Bff.Service.LoginService;
using Bff.SharedObjects;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bff.Api.Web.Controllers;

[ApiController]
[Route("api/[controller]/[action]"), Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public class UserController : Controller
{
    private readonly IUserService _userService;
    private readonly ILoginService _loginService;

    public UserController(IUserService userService , ILoginService loginService)
    {
        this._userService = userService;
        this._loginService = loginService;
    }

    [HttpGet]
    [AuthBffAttribute(Source = SourceConst.ONLY_WEB)]
    public async Task<UserProfileViewModel> UserProfile() => await _userService.GetUserProfileDetail();

    [HttpGet]
    [AllowAnonymous]
    public IActionResult HealtCheck() => Ok();

    [HttpGet]
    [AllowAnonymous]
    public string CreateWebToken() => _loginService.CreateToken("web");
}