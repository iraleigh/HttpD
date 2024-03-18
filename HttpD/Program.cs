// get command line arguments
using CommandLine;

internal class Program
{
    private static async Task Main(string[] args)
    {
        await Parser.Default.ParseArguments<Options>(args)
            .WithParsedAsync(async o =>
            {
                using HttpClient httpClient = new HttpClient();
                var res = await httpClient.GetAsync(o.Url);
                Console.WriteLine($"{o.Url} returned {res.StatusCode}");
            });
    }
}

class Options {
    [Option(Default = "http://www.google.com", HelpText = "Url to make an HTTP GET request to and collect diagnostics from")]
    public string Url { get; set; }
}