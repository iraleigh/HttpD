HttpClient httpClient = new HttpClient();

var res = await httpClient.GetAsync("http://www.google.com");
Console.WriteLine(res.StatusCode);