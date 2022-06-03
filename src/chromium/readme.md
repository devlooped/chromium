## Usage

```csharp
if (Chromium.Path == null)
{
    Console.WriteLine($"Current runtime {System.Runtime.InteropServices.RuntimeInformation.RuntimeIdentifier} is not supported.");
    return;
}

Console.WriteLine($"Located compatible Chromium at {Chromium.Path}");
```

## Native Chromium

In order for the corresponding native binaries for the current platform to be located, you must 
reference the relevant nuget package for the platforms you intend to support, such as:

```xml
<PackageReference Include="chromium.linux-x64" Version="[VERSION]" />
```

Available chromium runtimes are:

* [chromium.linux-x64](https://nuget.org/packages/chromium.linux-x64)
* [chromium.linux-x86](https://nuget.org/packages/chromium.linux-x86)
* [chromium.win-x64](https://nuget.org/packages/chromium.win-x64)
* [chromium.win-x86](https://nuget.org/packages/chromium.win-x86)
* [chromium.osx-x64](https://nuget.org/packages/chromium.osx-x64)
* [chromium.osx-arm64](https://nuget.org/packages/chromium.osx-arm64)