using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorExtensions
{
    public static class Browser
    {
        /// <summary>
        /// Trigger a browser alert('messsage') with your text.
        /// </summary>
        /// <param name="message">The message to display</param>
        public async static Task AlertAsync(string message)
        {
            var test = await JSRuntime.Current.InvokeAsync<object>("blazorExtensions.Alert", message);
        }

        /// <summary>
        /// Read a value from the browers localStorage.
        /// </summary>
        /// <param name="key">Key to read</param>
        public async static Task<string> ReadStorageAsync(string key)
        {
            return await JSRuntime.Current.InvokeAsync<string>("blazorExtensions.ReadStorage", key);
        }

        /// <summary>
        /// Write a value to the browers localStorage.
        /// </summary>
        /// <param name="key">Key to write</param>
        /// <param name="value">Value to store</param>
        public async static Task WriteStorageAsync(string key, string value)
        {
            var test = await JSRuntime.Current.InvokeAsync<object>("blazorExtensions.WriteStorage", key, value);
        }

        /// <summary>
        /// Write a cookie.
        /// </summary>
        /// <param name="name">name of cookie</param>
        /// <param name="value">Value to store</param>
        /// <param name="days">Number of days to be valid</param>
        public async static Task WriteCookieAsync(string name, string value, int days)
        {
            var test = await JSRuntime.Current.InvokeAsync<object>("blazorExtensions.WriteCookie", name, value, days);
        }
    }
}
