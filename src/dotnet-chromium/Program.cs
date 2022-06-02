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
if (arg != null)
{
    var page = await browser.NewPageAsync();
    await page.GotoAsync(arg);

    // Example of how to get the page body HTML
    //await page.GotoAsync(arg, new PageGotoOptions
    //{
    //    Timeout = 0,
    //    WaitUntil = WaitUntilState.NetworkIdle
    //});
    //var body = await page.QuerySelectorAsync("body");
    //var html = await body!.EvaluateAsync<string>("node => node.outerHTML");
    //Console.WriteLine(html);
}

Console.WriteLine("Press Enter to exit.");
Console.ReadLine();

return 0;