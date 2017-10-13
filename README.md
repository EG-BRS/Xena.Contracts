# How to use the Xena API

You can use this function to get data from the API:
```C#
public async Task<T> GetData<T>(string apiUrl, string route = "Api")
{
    apiUrl = _apiSetting.Url + $"/{route}/" + apiUrl;

    using (var handler = new HttpClientHandler { UseCookies = false })
    {
        using (var client = new HttpClient(handler) { BaseAddress = new Uri(apiUrl) })
        {
            var message = new HttpRequestMessage();

            client.SetBearerFromUser(_httpContextAccessor.HttpContext.User);

            var result = await client.SendAsync(message);
            var resultBody = await result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(resultBody);
        }
    }
}
```

Use this the POST data to the API:
```c#
public async Task<T> PostData<T>(object data, string apiUrl, string route = "Api")
{
    apiUrl = _apiSetting.Url + $"/{route}/" + apiUrl;
    var json = JsonConvert.SerializeObject(data);

    using (var handler = new HttpClientHandler { UseCookies = false })
    {
        using (var client = new HttpClient(handler) { BaseAddress = new Uri(apiUrl) })
        {
            var message = new HttpRequestMessage(HttpMethod.Post, "");
            message.Content = new StringContent(json, Encoding.UTF8, "application/json");
            message.Headers.Add("Accept", "application/json");

            client.SetBearerFromUser(_httpContextAccessor.HttpContext.User);

            var result = await client.SendAsync(message);

            var statusCodeHandler = new StatusCodeHandler();
            statusCodeHandler.HandleStatusCode(result);

            var resultBody = await result.Content.ReadAsStringAsync();

            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
            return JsonConvert.DeserializeObject<T>(resultBody, settings);
        }
    }
}
```

The functions are used like this:
```c#
var result = await _xena.GetData<PagedResultSet<PartnerResourceContextDto>>($"Fiscal/{FiscalId}/Resource");
```

Remember to use **PagedResultSet** when you request a list of stuff the the API.
