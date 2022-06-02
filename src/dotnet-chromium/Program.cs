using Microsoft.Playwright;

if (Chromium.Path == null)
{
    Console.WriteLine($"Current runtime {System.Runtime.InteropServices.RuntimeInformation.RuntimeIdentifier} is not supported.");
    return -1;
}

Console.WriteLine($"Located compatible Chromium at {Chromium.Path}");

using var playwright = await Playwright.CreateAsync();
await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
{
    Args = args.Where(x => x.StartsWith("--")),
    ExecutablePath = Chromium.Path,
    Headless = args.Contains("--headless"),
});

var arg = args.FirstOrDefault(x => !x.StartsWith("--"));
var page = await browser.NewPageAsync();

// NOTE: showcases how to interact with the browser as it's navigating
page.FrameNavigated += async (sender, args) =>
{
    await page.WaitForNavigationAsync(new PageWaitForNavigationOptions
    {
        Timeout = 0,
        WaitUntil = WaitUntilState.NetworkIdle
    });

    // Example of how to get the page body HTML
    Console.WriteLine(await page.InnerHTMLAsync("body"));
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