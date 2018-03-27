using Microsoft.AspNetCore.Blazor;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlazorExtensions.Http
{
    /// <summary>
    /// Extension methods for working with JSON APIs.
    /// </summary>
    public static class BlazorHttpExtensions
    {
        /// <summary>
        /// Sends an HTTP Post request to the specified URI, including the specified <paramref name="content"/>
        /// in JSON-encoded format, and doed NOT parse the response body, just returns a string.
        /// Useful for requesting tokens
        /// </summary>
        /// <param name="httpClient">The <see cref="HttpClient"/>.</param>
        /// <param name="method">The HTTP method.</param>
        /// <param name="requestUri">The URI that the request will be sent to.</param>
        /// <param name="content">Content for the request body. This will be JSON-encoded and sent as a string.</param>
        /// <returns>The response as a string (unparsed)</returns>
        public static async Task<string> SendJsonAsyncRawResult(this HttpClient httpClient, HttpMethod httpMethod, string requestUri, object content)
        {
            var requestJson = JsonUtil.Serialize(content);
            var response = await httpClient.SendAsync(new HttpRequestMessage(httpMethod, requestUri)
            {
                Content = new StringContent(requestJson, Encoding.UTF8, "application/json")
            });

            return await response.Content.ReadAsStringAsync();

        }

        /// <summary>
        /// Sends a GET request to the specified URI, and parses the JSON response body
        /// to create an object of the generic type.
        /// </summary>
        /// <typeparam name="T">A type into which the response body can be JSON-deserialized.</typeparam>
        /// <param name="httpClient">The <see cref="HttpClient"/>.</param>
        /// <param name="requestUri">The URI that the request will be sent to.</param>
        /// <param name="bearer">Value to be added to the Authorization header as bearer.</param>
        /// <returns>The response parsed as an object of the generic type.</returns>
        public static async Task<T> GetJsonAsync<T>(this HttpClient httpClient, string requestUri, string bearer)
        {
            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, requestUri);
            req.Headers.Add("Authorization", $"bearer {bearer}");

            var test = await httpClient.SendAsync(req);

            return JsonUtil.Deserialize<T>(await test.Content.ReadAsStringAsync());

        }

    }
}
