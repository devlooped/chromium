![Icon](https://raw.githubusercontent.com/devlooped/chromium/main/assets/img/icon.png) dotnet-chromium
============

[![Version](https://img.shields.io/nuget/v/dotnet-chromium.svg?color=royalblue)](https://www.nuget.org/packages/dotnet-chromium) 
[![Downloads](https://img.shields.io/nuget/dt/dotnet-chromium.svg?color=green)](https://www.nuget.org/packages/dotnet-chromium) 
[![License](https://img.shields.io/github/license/devlooped/chromium.svg?color=blue)](https://github.com/devlooped/chromium/blob/main/license.txt) 
[![Build](https://github.com/devlooped/chromium/workflows/build/badge.svg?branch=main)](https://github.com/devlooped/chromium/actions)

Chromium for .NET 6.

This project allows running a portable embedded version of Chromium from 
either a .NET CLI tool or a regular .NET application without having to install 
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

This will provide the runtime lookup of the native binaries, but will *not* provide the binaries themselves. 
In other words, the `chromium` package is not a **metapackage**. Since NuGet does not provide a built-in 
mechanism to conditionally reference specific packages depending on the current runtime platform or library 
target's `RuntimeIdentifier(s)`, a metapackage is not practical since it would cause a restore of *all* 
platforms, which only bloats download and install size unnecessarily. If you know what platforms your app 
will run on, you can simply reference the relevant ones manually by adding package references to 
`chromium.[RID]` as necessary:

[![Linux-x64](https://img.shields.io/nuget/v/chromium.linux-x64.svg?label=chromium.linux-x64&color=royalblue)](https://www.nuget.org/packages/chromium.linux-x64) 
[![Win-x64](https://img.shields.io/nuget/v/chromium.win-x64.svg?label=chromium.win-x64&color=royalblue)](https://www.nuget.org/packages/chromium.win-x64) 
[![Win-x86](https://img.shields.io/nuget/v/chromium.win-x86.svg?label=chromium.win-x86&color=royalblue)](https://www.nuget.org/packages/chromium.win-x86) 

## Releasing

Create a new release versioned as `v[YYYY].[M].[D]` and the bundled binaries will be the 
snapshots of the day the release build runs, fetched from:

* Win-x64: https://download-chromium.appspot.com/dl/Win_x64?type=snapshots
* Win-x86: https://download-chromium.appspot.com/dl/Win?type=snapshots
* Linux-x64: https://download-chromium.appspot.com/dl/Linux_x64?type=snapshots


<!-- #sponsors -->
<!-- include https://github.com/devlooped/sponsors/raw/main/footer.md -->
# Sponsors 

<!-- sponsors.md -->
[![Clarius Org](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/clarius.png "Clarius Org")](https://github.com/clarius)
[![Kirill Osenkov](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/KirillOsenkov.png "Kirill Osenkov")](https://github.com/KirillOsenkov)
[![MFB Technologies, Inc.](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/MFB-Technologies-Inc.png "MFB Technologies, Inc.")](https://github.com/MFB-Technologies-Inc)
[![Stephen Shaw](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/decriptor.png "Stephen Shaw")](https://github.com/decriptor)
[![Torutek](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/torutek-gh.png "Torutek")](https://github.com/torutek-gh)
[![DRIVE.NET, Inc.](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/drivenet.png "DRIVE.NET, Inc.")](https://github.com/drivenet)
[![Daniel Gnägi](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/dgnaegi.png "Daniel Gnägi")](https://github.com/dgnaegi)
[![Ashley Medway](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/AshleyMedway.png "Ashley Medway")](https://github.com/AshleyMedway)
[![Keith Pickford](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/Keflon.png "Keith Pickford")](https://github.com/Keflon)
[![Thomas Bolon](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/tbolon.png "Thomas Bolon")](https://github.com/tbolon)
[![Kori Francis](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/kfrancis.png "Kori Francis")](https://github.com/kfrancis)
[![Toni Wenzel](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/twenzel.png "Toni Wenzel")](https://github.com/twenzel)
[![Giorgi Dalakishvili](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/Giorgi.png "Giorgi Dalakishvili")](https://github.com/Giorgi)
[![Mike James](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/MikeCodesDotNET.png "Mike James")](https://github.com/MikeCodesDotNET)
[![Dan Siegel](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/dansiegel.png "Dan Siegel")](https://github.com/dansiegel)
[![Reuben Swartz](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/rbnswartz.png "Reuben Swartz")](https://github.com/rbnswartz)
[![Jacob Foshee](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/jfoshee.png "Jacob Foshee")](https://github.com/jfoshee)
[![](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/Mrxx99.png "")](https://github.com/Mrxx99)
[![Eric Johnson](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/eajhnsn1.png "Eric Johnson")](https://github.com/eajhnsn1)
[![Norman Mackay](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/mackayn.png "Norman Mackay")](https://github.com/mackayn)
[![Certify The Web](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/certifytheweb.png "Certify The Web")](https://github.com/certifytheweb)
[![Rich Lee](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/richlee.png "Rich Lee")](https://github.com/richlee)
[![](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/nietras.png "")](https://github.com/nietras)
[![Ix Technologies B.V.](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/IxTechnologies.png "Ix Technologies B.V.")](https://github.com/IxTechnologies)
[![David JENNI](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/davidjenni.png "David JENNI")](https://github.com/davidjenni)
[![Jonathan ](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/Jonathan-Hickey.png "Jonathan ")](https://github.com/Jonathan-Hickey)
[![Oleg Kyrylchuk](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/okyrylchuk.png "Oleg Kyrylchuk")](https://github.com/okyrylchuk)
[![Mariusz Kogut](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/MariuszKogut.png "Mariusz Kogut")](https://github.com/MariuszKogut)
[![Charley Wu](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/akunzai.png "Charley Wu")](https://github.com/akunzai)
[![Jakob Tikjøb Andersen](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/jakobt.png "Jakob Tikjøb Andersen")](https://github.com/jakobt)
[![Seann Alexander](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/seanalexander.png "Seann Alexander")](https://github.com/seanalexander)
[![Tino Hager](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/tinohager.png "Tino Hager")](https://github.com/tinohager)
[![Mark Seemann](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/ploeh.png "Mark Seemann")](https://github.com/ploeh)
[![Angelo Belchior](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/angelobelchior.png "Angelo Belchior")](https://github.com/angelobelchior)
[![Blauhaus Technology (Pty) Ltd](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/BlauhausTechnology.png "Blauhaus Technology (Pty) Ltd")](https://github.com/BlauhausTechnology)
[![Ken Bonny](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/KenBonny.png "Ken Bonny")](https://github.com/KenBonny)
[![Simon Cropp](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/SimonCropp.png "Simon Cropp")](https://github.com/SimonCropp)
[![agileworks-eu](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/agileworks-eu.png "agileworks-eu")](https://github.com/agileworks-eu)
[![](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/sorahex.png "")](https://github.com/sorahex)
[![](https://raw.githubusercontent.com/devlooped/sponsors/main/.github/avatars/wjgthb.png "")](https://github.com/wjgthb)


<!-- sponsors.md -->

[![Sponsor this project](https://raw.githubusercontent.com/devlooped/sponsors/main/sponsor.png "Sponsor this project")](https://github.com/sponsors/devlooped)
&nbsp;

[Learn more about GitHub Sponsors](https://github.com/sponsors)

<!-- https://github.com/devlooped/sponsors/raw/main/footer.md -->
