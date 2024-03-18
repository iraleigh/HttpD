// get command line arguments
var arguments = Environment.GetCommandLineArgs();
var url = "http://www.google.com";

if (arguments.Length > 1) {
    url = arguments[1];
}

HttpClient httpClient = new HttpClient();

var res = await httpClient.GetAsync(url);
Console.WriteLine($"{url} returned {res.StatusCode}");