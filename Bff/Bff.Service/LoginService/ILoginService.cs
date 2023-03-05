using System;
namespace Bff.Service.LoginService;

public interface ILoginService
{
    string CreateToken(string source);
}