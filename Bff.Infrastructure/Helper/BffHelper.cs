using System;
using Newtonsoft.Json;

namespace Bff.Infrastructure.Helper;

public static class BffHelper
{
    public static async Task<T> GetService<T>(string url)
    {
        using var httpClient = new HttpClient();
        using var response = await httpClient.GetAsync(url);

        string result = await response.Content.ReadAsStringAsync();

        if (string.IsNullOrWhiteSpace(result) || !response.IsSuccessStatusCode)
        {
            response.EnsureSuccessStatusCode();
            return default(T);
        }

        return JsonConvert.DeserializeObject<T>(result);
    }
}