using Microsoft.Extensions.DependencyModel;

/// <summary>
/// Provides access to the Chromium <see cref="Path"/> location, 
/// or <see langword="null"/> if not supported in the current platform.
/// </summary>
public static class Chromium
{
    public static string? Path { get; } = default;

    static Chromium()
    {
        // Locate proper runtime binaries
        var chromeDir = default(string);

        foreach (var runtime in DependencyContext.Default.RuntimeGraph)
        {
            // In the local debug/run scenario, we will find the runtimes copied locally under the base directory
            var candidate = System.IO.Path.Combine(AppContext.BaseDirectory, "runtimes", runtime.Runtime, "native");
            if (Directory.Exists(candidate))
                chromeDir = candidate;
        }

        if (chromeDir == null)
        {
            // In the installed tool scenario, we need to go up to the tool project restore root 
            // since it migtht be a trimmed tool package to avoid going over the nuget.org limit.
            // Just like we do in dotnet-chromium.
            var rootDir = AppContext.BaseDirectory;
            while (rootDir != null && !File.Exists(System.IO.Path.Combine(rootDir, "project.assets.json")))
                rootDir = new DirectoryInfo(rootDir).Parent?.FullName;

            if (rootDir != null && File.Exists(System.IO.Path.Combine(rootDir, "project.assets.json")))
            {
                // Search again but starting from each runtime dependency path, where the runtime matches the 
                // current dependency grap
                var dirs = from runtime in DependencyContext.Default.RuntimeGraph
                           from lib in DependencyContext.Default.RuntimeLibraries
                           where lib.NativeLibraryGroups.Any(g => g.Runtime == runtime.Runtime)
                           let candidate = System.IO.Path.Combine(rootDir, lib.Path, "runtimes", runtime.Runtime, "native")
                           where Directory.Exists(candidate)
                           select candidate;

                chromeDir = dirs.FirstOrDefault();
            }
        }

        if (chromeDir != null)
        {
            Path = System.IO.Path.Combine(chromeDir, "chrome");
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
                Path += ".exe";
        }
    }
}