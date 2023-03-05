using System;
using Bff.SharedObjects;

namespace Bff.Service;

public interface IUserService
{
    Task<UserProfileViewModel> GetUserProfileDetail();
}