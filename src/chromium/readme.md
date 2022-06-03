## Usage

```csharp
if (Chromium.Path == null)
{
    Console.WriteLine($"Current runtime {System.Runtime.InteropServices.RuntimeInformation.RuntimeIdentifier} is not supported.");
    return;
}

Console.WriteLine($"Located compatible Chromium at {Chromium.Path}");
```