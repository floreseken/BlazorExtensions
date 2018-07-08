Blazor.registerFunction('BlazorExtensions.ReadStorage', (key) => { return localStorage.getItem(key); });

Blazor.registerFunction('BlazorExtensions.WriteStorage', (key, value) => { localStorage.setItem(key, value); });

Blazor.registerFunction('BlazorExtensions.Alert', (message) => { alert(message); });

Blazor.registerFunction('BlazorExtensions.WriteCookie', (name, value, days) => {

    var expires;
    if (days) {
        var date = new Date();
        date.setTime(date.getTime() + (days * 24 * 60 * 60 * 1000));
        expires = "; expires=" + date.toGMTString();
    }
    else {
        expires = "";
    }
    document.cookie = name + "=" + value + expires + "; path=/";
});
