using Chromely.CefSharp.Winapi.BrowserWindow;
using Chromely.Core;
using Chromely.Core.Infrastructure;
using Chromely.Core.Host;

namespace ChromelyExample
{
    class Program
    {
        static int Main(string[] args)
        {
            string startUrl = "local://app/sample.html";

            ChromelyConfiguration config = ChromelyConfiguration
                .Create()
                .WithHostMode(WindowState.Normal, true)
                .WithHostTitle("chromely")
                .WithAppArgs(args)
                .WithHostSize(1024, 768)
                .WithStartUrl(startUrl)
                .WithLogSeverity(LogSeverity.Verbose)
                .UseDefaultResourceSchemeHandler("local", string.Empty);

            using (var window = new CefSharpBrowserWindow(config))
            {
                return window.Run(args);
            }
        }
    }
}
