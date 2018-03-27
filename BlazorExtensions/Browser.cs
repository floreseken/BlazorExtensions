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

            RegisteredFunction.Invoke<object>("Alert", message);

        }

    }
}
