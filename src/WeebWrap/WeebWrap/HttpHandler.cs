using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WeebWrap
{
    public static class HttpHandler
    {
        private static HttpClient _httpClient = new HttpClient();

        internal static async Task<string> GetJsonStringAsync(string requestUrl)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);
            return await response.Content.ReadAsStringAsync();
        }

        internal static void GetJsonStringAsync(object p)
        {
            throw new NotImplementedException();
        }
    }
}
