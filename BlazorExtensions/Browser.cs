using Microsoft.AspNetCore.Blazor.Browser.Interop;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorExtensions
{
    public static class Browser
    {
        /// <summary>
        /// Trigger a browser alert('messsage') with your text.
        /// </summary>
        /// <param name="message">The message to display</param>
        public static void Alert(string message)
        {

            RegisteredFunction.Invoke<object>("BlazorExtensions.Alert", message);

        }

        /// <summary>
        /// Read a value from the browers localStorage.
        /// </summary>
        /// <param name="key">Key to read</param>
        public static string ReadStorage(string key)
        {
            return RegisteredFunction.Invoke<string>("BlazorExtensions.ReadStorage", key);
        }

        /// <summary>
        /// Write a value to the browers localStorage.
        /// </summary>
        /// <param name="key">Key to write</param>
        /// <param name="value">Value to store</param>
        public static void WriteStorage(string key, string value)
        {
            RegisteredFunction.Invoke<object>("BlazorExtensions.WriteStorage", key, value);
        }

    }
}
