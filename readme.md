![Icon](https://raw.githubusercontent.com/devlooped/chromium/main/assets/img/icon.png) dotnet-chromium
============

[![Version](https://img.shields.io/nuget/v/dotnet-chromium.svg?color=royalblue)](https://www.nuget.org/packages/dotnet-chromium) 
[![Downloads](https://img.shields.io/nuget/dt/dotnet-chromium.svg?color=green)](https://www.nuget.org/packages/dotnet-chromium) 
[![License](https://img.shields.io/github/license/devlooped/chromium.svg?color=blue)](https://github.com/devlooped/chromium/blob/main/license.txt) 
[![Build](https://github.com/devlooped/chromium/actions/workflows/build.yml/badge.svg?branch=main)](https://github.com/devlooped/chromium/actions)

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
[![Clarius Org](https://avatars.githubusercontent.com/u/71888636?v=4&s=39 "Clarius Org")](https://github.com/clarius)
[![MFB Technologies, Inc.](https://avatars.githubusercontent.com/u/87181630?v=4&s=39 "MFB Technologies, Inc.")](https://github.com/MFB-Technologies-Inc)
[![SandRock](https://avatars.githubusercontent.com/u/321868?u=99e50a714276c43ae820632f1da88cb71632ec97&v=4&s=39 "SandRock")](https://github.com/sandrock)
[![DRIVE.NET, Inc.](https://avatars.githubusercontent.com/u/15047123?v=4&s=39 "DRIVE.NET, Inc.")](https://github.com/drivenet)
[![Keith Pickford](https://avatars.githubusercontent.com/u/16598898?u=64416b80caf7092a885f60bb31612270bffc9598&v=4&s=39 "Keith Pickford")](https://github.com/Keflon)
[![Thomas Bolon](https://avatars.githubusercontent.com/u/127185?u=7f50babfc888675e37feb80851a4e9708f573386&v=4&s=39 "Thomas Bolon")](https://github.com/tbolon)
[![Kori Francis](https://avatars.githubusercontent.com/u/67574?u=3991fb983e1c399edf39aebc00a9f9cd425703bd&v=4&s=39 "Kori Francis")](https://github.com/kfrancis)
[![Uno Platform](https://avatars.githubusercontent.com/u/52228309?v=4&s=39 "Uno Platform")](https://github.com/unoplatform)
[![Reuben Swartz](https://avatars.githubusercontent.com/u/724704?u=2076fe336f9f6ad678009f1595cbea434b0c5a41&v=4&s=39 "Reuben Swartz")](https://github.com/rbnswartz)
[![Jacob Foshee](https://avatars.githubusercontent.com/u/480334?v=4&s=39 "Jacob Foshee")](https://github.com/jfoshee)
[![](https://avatars.githubusercontent.com/u/33566379?u=bf62e2b46435a267fa246a64537870fd2449410f&v=4&s=39 "")](https://github.com/Mrxx99)
[![Eric Johnson](https://avatars.githubusercontent.com/u/26369281?u=41b560c2bc493149b32d384b960e0948c78767ab&v=4&s=39 "Eric Johnson")](https://github.com/eajhnsn1)
[![David JENNI](https://avatars.githubusercontent.com/u/3200210?v=4&s=39 "David JENNI")](https://github.com/davidjenni)
[![Jonathan ](https://avatars.githubusercontent.com/u/5510103?u=98dcfbef3f32de629d30f1f418a095bf09e14891&v=4&s=39 "Jonathan ")](https://github.com/Jonathan-Hickey)
[![Ken Bonny](https://avatars.githubusercontent.com/u/6417376?u=569af445b6f387917029ffb5129e9cf9f6f68421&v=4&s=39 "Ken Bonny")](https://github.com/KenBonny)
[![Simon Cropp](https://avatars.githubusercontent.com/u/122666?v=4&s=39 "Simon Cropp")](https://github.com/SimonCropp)
[![agileworks-eu](https://avatars.githubusercontent.com/u/5989304?v=4&s=39 "agileworks-eu")](https://github.com/agileworks-eu)
[![Zheyu Shen](https://avatars.githubusercontent.com/u/4067473?v=4&s=39 "Zheyu Shen")](https://github.com/arsdragonfly)
[![Vezel](https://avatars.githubusercontent.com/u/87844133?v=4&s=39 "Vezel")](https://github.com/vezel-dev)
[![ChilliCream](https://avatars.githubusercontent.com/u/16239022?v=4&s=39 "ChilliCream")](https://github.com/ChilliCream)
[![4OTC](https://avatars.githubusercontent.com/u/68428092?v=4&s=39 "4OTC")](https://github.com/4OTC)
[![Vincent Limo](https://avatars.githubusercontent.com/devlooped-user?s=39 "Vincent Limo")](https://github.com/v-limo)
[![domischell](https://avatars.githubusercontent.com/u/66068846?u=0a5c5e2e7d90f15ea657bc660f175605935c5bea&v=4&s=39 "domischell")](https://github.com/DominicSchell)
[![Adrian Alonso](https://avatars.githubusercontent.com/u/2027083?u=129cf516d99f5cb2fd0f4a0787a069f3446b7522&v=4&s=39 "Adrian Alonso")](https://github.com/adalon)
[![Michael Hagedorn](https://avatars.githubusercontent.com/u/61711586?u=8f653dfcb641e8c18cc5f78692ebc6bb3a0c92be&v=4&s=39 "Michael Hagedorn")](https://github.com/Eule02)
[![](https://avatars.githubusercontent.com/devlooped-user?s=39 "")](https://github.com/henkmartijn)
[![torutek](https://avatars.githubusercontent.com/u/33917059?v=4&s=39 "torutek")](https://github.com/torutek)
[![mccaffers](https://avatars.githubusercontent.com/u/16667079?u=739e110e62a75870c981640447efa5eb2cb3bc8f&v=4&s=39 "mccaffers")](https://github.com/mccaffers)
[![Cleosia](https://avatars.githubusercontent.com/u/85127128?u=3c889baa39bbe3607998c931490bd67c6ed854f2&v=4&s=39 "Cleosia")](https://github.com/cleosia)


<!-- sponsors.md -->
[![Sponsor this project](https://avatars.githubusercontent.com/devlooped-sponsor?s=118 "Sponsor this project")](https://github.com/sponsors/devlooped)

[Learn more about GitHub Sponsors](https://github.com/sponsors)

<!-- https://github.com/devlooped/sponsors/raw/main/footer.md -->
