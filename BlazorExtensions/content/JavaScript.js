Blazor.registerFunction('BlazorExtensions.ReadStorage', (key) => { return localStorage.getItem(key); });

Blazor.registerFunction('BlazorExtensions.WriteStorage', (key, value) => { localStorage.setItem(key, value); });

Blazor.registerFunction('BlazorExtensions.Alert', (message) => { alert(message); });
