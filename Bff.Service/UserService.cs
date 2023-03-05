using System;
using Bff.Infrastructure.Const;
using Bff.Infrastructure.Helper;
using Bff.SharedObjects;
using Microsoft.Extensions.Caching.Memory;

namespace Bff.Service;

public class UserService : IUserService
{
    private readonly IMemoryCache _memoryCache;

    public UserService(IMemoryCache memoryCache) => this._memoryCache = memoryCache;

    public async Task<UserProfileViewModel> GetUserProfileDetail()
    {
        var cacheResult = _memoryCache.Get<UserProfileViewModel>(CacheConst.MEMORY_CACHE_KEY);

        if (cacheResult is not null)
        {
            return cacheResult;
        }

        var mediaTaskResult   = BffHelper.GetService<List<Media>>(UrlConst.MEDIA); //media microservice
        var profileTaskResult = BffHelper.GetService<Profile>(UrlConst.PROFILE); //profile microservice
        var repliesTaskResult = BffHelper.GetService<List<Replies>>(UrlConst.REPLIES); //replies microservice
        var tweetsTaskResult  = BffHelper.GetService<List<Tweets>>(UrlConst.TWEETS); //tweets microservice

        await Task.WhenAll(mediaTaskResult , profileTaskResult , repliesTaskResult, tweetsTaskResult);

        var result = new UserProfileViewModel
        {
            Media = await mediaTaskResult,
            Profile = await profileTaskResult,
            Replies = await repliesTaskResult,
            Tweets = await tweetsTaskResult
        };

        _memoryCache.Set<UserProfileViewModel>(CacheConst.MEMORY_CACHE_KEY, result, TimeSpan.FromMinutes(10));

        return result;
    }
}