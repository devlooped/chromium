![Icon](https://raw.githubusercontent.com/devlooped/chromium/main/assets/img/icon.png) dotnet-chromium
============

[![Version](https://img.shields.io/nuget/v/dotnet-chromium.svg?color=royalblue)](https://www.nuget.org/packages/dotnet-chromium) 
[![Downloads](https://img.shields.io/nuget/dt/dotnet-chromium.svg?color=green)](https://www.nuget.org/packages/dotnet-chromium) 
[![License](https://img.shields.io/github/license/devlooped/chromium.svg?color=blue)](https://github.com/devlooped/chromium/blob/main/license.txt) 
[![Build](https://github.com/devlooped/chromium/workflows/build/badge.svg?branch=main)](https://github.com/devlooped/chromium/actions)

Chromium for .NET 6+.

This project allows running a portable embedded version of Chromium from 
either a .NET CLI tool or a regular .NET application without having to install 
it.

This can help automate a browser as part of your regular app 
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

The `url` is optional, and causes the browser to navigate immediately 
to that URL on open. 

The `switches` are optional, and are passed directly to Chromium. For 
example, you'd pass `-headless` to run the browser headless. See the 
[list of chromium switches](https://peter.sh/experiments/chromium-command-line-switches/) 
for more information.

### nuget package library reference

[![Version](https://img.shields.io/nuget/v/chromium.svg?color=royalblue)](https://www.nuget.org/packages/chromium) 
[![Downloads](https://img.shields.io/nuget/dt/chromium.svg?color=green)](https://www.nuget.org/packages/chromium) 

```
Install-Package chromium
```

```csharp
if (Chromium.Path != null)
    Console.WriteLine($"Found Chromium for current platform at {Chromium.Path}");
else
    Console.WriteLine($"Current runtime {System.Runtime.InteropServices.RuntimeInformation.RuntimeIdentifier} is not supported.");
```

This will provide the runtime lookup of the native binaries, but will *not* provide the binaries themselves. 
In other words, the `chromium` package is not a **metapackage**. Since NuGet does not provide a built-in 
mechanism to conditionally reference specific packages depending on the current runtime platform or library 
target's `RuntimeIdentifier(s)`, a metapackage is not practical since it would cause a restore of *all* 
platforms, which only bloats download and install size unnecessarily. If you know what platforms your app 
will run on, you can reference the relevant ones manually by adding package references to 
`chromium.[RID]` as necessary:

[![Linux-x64](https://img.shields.io/nuget/v/chromium.linux-x64.svg?label=chromium.linux-x64&color=royalblue)](https://www.nuget.org/packages/chromium.linux-x64) 
[![Win-x64](https://img.shields.io/nuget/v/chromium.win-x64.svg?label=chromium.win-x64&color=royalblue)](https://www.nuget.org/packages/chromium.win-x64) 
[![Win-x86](https://img.shields.io/nuget/v/chromium.win-x86.svg?label=chromium.win-x86&color=royalblue)](https://www.nuget.org/packages/chromium.win-x86) 

## Releasing

We run a [scheduled workflow](https://github.com/devlooped/chromium/actions/workflows/scheduled.yml) every other week 
which creates a new release versioned as `v[YYYY].[M].[D]`, which bundles the snapshots of that day.

It's also possible to create a new release on demand, versioned as `v[YYYY].[M].[D]` and the bundled binaries will be the 
snapshots of the day the release build runs.

We fetch binaries from:

* Win-x64: https://download-chromium.appspot.com/dl/Win_x64?type=snapshots
* Win-x86: https://download-chromium.appspot.com/dl/Win?type=snapshots
* Linux-x64: https://download-chromium.appspot.com/dl/Linux_x64?type=snapshots

<!-- #sponsors -->
<!-- include https://github.com/devlooped/sponsors/raw/main/footer.md -->
# Sponsors 

<!-- sponsors.md -->
[![Clarius Org](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/clarius.png "Clarius Org")](https://github.com/clarius)
[![MFB Technologies, Inc.](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/MFB-Technologies-Inc.png "MFB Technologies, Inc.")](https://github.com/MFB-Technologies-Inc)
[![Torutek](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/torutek-gh.png "Torutek")](https://github.com/torutek-gh)
[![DRIVE.NET, Inc.](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/drivenet.png "DRIVE.NET, Inc.")](https://github.com/drivenet)
[![Keith Pickford](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/Keflon.png "Keith Pickford")](https://github.com/Keflon)
[![Thomas Bolon](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/tbolon.png "Thomas Bolon")](https://github.com/tbolon)
[![Kori Francis](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/kfrancis.png "Kori Francis")](https://github.com/kfrancis)
[![Toni Wenzel](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/twenzel.png "Toni Wenzel")](https://github.com/twenzel)
[![Uno Platform](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/unoplatform.png "Uno Platform")](https://github.com/unoplatform)
[![Dan Siegel](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/dansiegel.png "Dan Siegel")](https://github.com/dansiegel)
[![Reuben Swartz](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/rbnswartz.png "Reuben Swartz")](https://github.com/rbnswartz)
[![Jacob Foshee](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/jfoshee.png "Jacob Foshee")](https://github.com/jfoshee)
[![](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/Mrxx99.png "")](https://github.com/Mrxx99)
[![Eric Johnson](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/eajhnsn1.png "Eric Johnson")](https://github.com/eajhnsn1)
[![Ix Technologies B.V.](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/IxTechnologies.png "Ix Technologies B.V.")](https://github.com/IxTechnologies)
[![David JENNI](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/davidjenni.png "David JENNI")](https://github.com/davidjenni)
[![Jonathan ](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/Jonathan-Hickey.png "Jonathan ")](https://github.com/Jonathan-Hickey)
[![Charley Wu](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/akunzai.png "Charley Wu")](https://github.com/akunzai)
[![Jakob Tikjøb Andersen](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/jakobt.png "Jakob Tikjøb Andersen")](https://github.com/jakobt)
[![Tino Hager](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/tinohager.png "Tino Hager")](https://github.com/tinohager)
[![Ken Bonny](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/KenBonny.png "Ken Bonny")](https://github.com/KenBonny)
[![Simon Cropp](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/SimonCropp.png "Simon Cropp")](https://github.com/SimonCropp)
[![agileworks-eu](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/agileworks-eu.png "agileworks-eu")](https://github.com/agileworks-eu)
[![sorahex](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/sorahex.png "sorahex")](https://github.com/sorahex)
[![Zheyu Shen](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/arsdragonfly.png "Zheyu Shen")](https://github.com/arsdragonfly)
[![Vezel](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/vezel-dev.png "Vezel")](https://github.com/vezel-dev)
[![ChilliCream](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/ChilliCream.png "ChilliCream")](https://github.com/ChilliCream)
[![4OTC](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/4OTC.png "4OTC")](https://github.com/4OTC)
[![Vincent Limo](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/v-limo.png "Vincent Limo")](https://github.com/v-limo)
[![Jordan S. Jones](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/jordansjones.png "Jordan S. Jones")](https://github.com/jordansjones)
[![domischell](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/DominicSchell.png "domischell")](https://github.com/DominicSchell)
[![Joseph Kingry](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/jkingry.png "Joseph Kingry")](https://github.com/jkingry)


<!-- sponsors.md -->

[![Sponsor this project](https://raw.githubusercontent.com/devlooped/sponsors/main/sponsor.png "Sponsor this project")](https://github.com/sponsors/devlooped)
&nbsp;

[Learn more about GitHub Sponsors](https://github.com/sponsors)

<!-- https://github.com/devlooped/sponsors/raw/main/footer.md -->
