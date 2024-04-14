using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorWebAppPrerenderingIssue.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            await builder.Build().RunAsync();
        }
    }
}
