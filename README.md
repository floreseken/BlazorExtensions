# BlazorExtensions
**Usefull extensions for working with blazor**

*Things I needed myself when expirimenting with Blazor 0.1 preview, will probably become obsolete in newer versions.*

<br/><br/>

There are currently 3 methods:

```void Browser.Alert(string message);```<br/>
 Trigger a browser alert('messsage') with your text.



```async Task<string> SendJsonAsyncRawResult(this HttpClient httpClient, HttpMethod httpMethod, string requestUri, object content)```<br/>
Sends an HTTP Post request to the specified URI, including the specified content in JSON-encoded format, and doed NOT parse the response body, just returns a string. Useful for requesting tokens

```async Task<T> GetJsonAsync<T>(this HttpClient httpClient, string requestUri, string bearer) ```<br/>
       Sends a GET request to the specified URI with an Auhtorization bearer in the header, and parses the JSON response body to create an object of the generic type.


```async Task<T> PostJsonAsync<T>(this HttpClient httpClient, string requestUri, object content, string bearer) ```<br/>
       Sends a POST request to the specified URI with an Auhtorization bearer in the header and the content object as JSON, and parses the JSON response body to create an object of the generic type.


To enable the browser methods please modify your app.cshtml like this:

```
@addTagHelper *, BlazorExtensions

<Router AppAssembly=typeof(Program).Assembly />

<BlazorExtensionScripts></BlazorExtensionScripts>
```

# Known issues
There is a timing issue when using browser extensions from the oninit of your startpage. That does not work.