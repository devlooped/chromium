using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Playwright;

if (args.Any(x => x == "--debug"))
    Debugger.Launch();

var chromium = Chromium.Path;

if (chromium == null)
{
    chromium = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
        ".nuget", "packages",
        $"chromium.{RuntimeInformation.RuntimeIdentifier}",
        ThisAssembly.Project.NativeVersion,
        "runtimes",
        RuntimeInformation.RuntimeIdentifier,
        "native");

    // Attempt to use dotnet restore to download it.
    if (!Directory.Exists(chromium))
        await DotNetMuxer.TryRestore();

    // If it still doesn't exist after an attempted restore, then we can't continue.
    if (!Directory.Exists(chromium))
    {
        Console.WriteLine($"Current runtime {RuntimeInformation.RuntimeIdentifier} is not supported.");
        return -1;
    }
}

#if DEBUG
Console.WriteLine($"Located compatible Chromium at {chromium}");
#endif

using var playwright = await Playwright.CreateAsync();
await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
{
    Args = args.Where(x => x.StartsWith("--") && x != "--debug"),
    ExecutablePath = chromium,
    Headless = args.Contains("--headless"),
});

var arg = args.FirstOrDefault(x => !x.StartsWith("--"));
var page = await browser.NewPageAsync();

// NOTE: showcases how to interact with the browser as it's navigating
page.FrameNavigated += async (sender, args) =>
{
    try
    {
        await page.WaitForLoadStateAsync(LoadState.NetworkIdle, new PageWaitForLoadStateOptions
        {
            Timeout = 0,
        });

        // Example of how to get the page body HTML
        Console.WriteLine(await page.InnerHTMLAsync("body"));
    }
    catch (PlaywrightException)
    {
        // Will be thrown when the app is shutting down, so ignore
        return;
    }   
};

if (arg != null)
{
    await page.GotoAsync(arg, new PageGotoOptions
    {
        Timeout = 0,
        WaitUntil = WaitUntilState.NetworkIdle
    });
    Console.WriteLine(await page.InnerHTMLAsync("body"));
}

Console.WriteLine("Press Enter to exit.");
Console.ReadLine();

return 0;