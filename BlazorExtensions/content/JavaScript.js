
window.blazorExtensions = {

    ReadStorage: function (key) {

        return localStorage.getItem(key);
    },

    WriteStorage: function (key, value) {

        localStorage.setItem(key, value);
    },

    Alert: function (message) {
        alert(message); 
    },

    WriteCookie: function (name, value, days) {

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
    }
}
