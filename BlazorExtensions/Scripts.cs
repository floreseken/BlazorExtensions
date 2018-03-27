using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorExtensions
{
    /// <summary>
    /// Scripts needed to run some broser actions.
    /// Please add this tag to your app.cshtml
    /// </summary>
    public class BlazorExtensionScripts : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {

        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "script");
            builder.AddContent(1, "Blazor.registerFunction('Alert', (message) => { alert(message); });");
            builder.CloseElement();

        }

    }
}
