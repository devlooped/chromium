# dotnet chromium

Chromium for .NET 6.

This project allows running a portable embedded version of Chromium from 
either a .NET tool or a regular .NET application without having to install 
it.

This can be helpful for automating a browser as part of your regular app 
normal behavior, such as using [Microsoft.Playwright](https://playwright.dev/dotnet/).

## Usage

The project provides two main ways to consume it:
- As a dotnet global tool
- As a regular nuget package library reference.

### dotnet global tool

Install with:

```
dotnet tool install -g dotnet-chromium
```

Run with:

```
chromium [url] [switches]
```

The `url` is optional, and causes the browser to immediately navigate 
to that URL on open. 

The `switches` are optional, and are passed directly to Chromium. For 
example, to run the browser headless, you'd pass `--headless`. See the 
[list of chromium switches](https://peter.sh/experiments/chromium-command-line-switches/) 
for more information.

### nuget package library reference

```
Install-Package chromium
```

```csharp
if (Chromium.Path != null)
    Console.WriteLine($"Found Chromium for current platform at {Chromium.Path}");
else
    Console.WriteLine($"Current runtime {System.Runtime.InteropServices.RuntimeInformation.RuntimeIdentifier} is not supported.");
```
```

## Sponsors

[![sponsored](https://raw.githubusercontent.com/devlooped/oss/main/assets/images/sponsors.svg)](https://github.com/sponsors/devlooped) [![clarius](https://raw.githubusercontent.com/clarius/branding/main/logo/byclarius.svg)](https://github.com/clarius)[![clarius](https://raw.githubusercontent.com/clarius/branding/main/logo/logo.svg)](https://github.com/clarius)

*[get mentioned here too](https://github.com/sponsors/devlooped)!*
