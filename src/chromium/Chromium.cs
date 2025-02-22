using Microsoft.Extensions.DependencyModel;
using NuGet.ProjectModel;

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
        var chromeFile = "chrome";
        if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            chromeFile += ".exe";

        // if we have no runtime graph (deps.json), we can't really do anything.
        if (DependencyContext.Default == null)
            return;

        foreach (var runtime in DependencyContext.Default.RuntimeGraph)
        {
            // In the local debug/run scenario, we will find the runtimes copied locally under the base directory
            var candidate = System.IO.Path.Combine(AppContext.BaseDirectory, "runtimes", runtime.Runtime, "native");
            if (Directory.Exists(candidate))
            {
                if (File.Exists(System.IO.Path.Combine(candidate, chromeFile)))
                {
                    Path = System.IO.Path.Combine(candidate, chromeFile);
                    break;
                }
            }
        }

        // In the installed tool scenario, we need to go up to the tool project restore root 
        // since it migtht be a trimmed tool package to avoid going over the nuget.org limit.
        // Just like we do in dotnet-chromium.
        var rootDir = AppContext.BaseDirectory;
        while (rootDir != null && !File.Exists(System.IO.Path.Combine(rootDir, "project.assets.json")))
            rootDir = new DirectoryInfo(rootDir).Parent?.FullName;

        if (rootDir != null && File.Exists(System.IO.Path.Combine(rootDir, "project.assets.json")))
        {
            var lockFile = new LockFileFormat().Read(System.IO.Path.Combine(rootDir, "project.assets.json"));

            // Search again but starting from each runtime dependency path, where the runtime matches the 
            // current dependency grap
            var nativeFiles = from runtime in DependencyContext.Default.RuntimeGraph
                              from target in lockFile.Targets
                              from lib in target.Libraries
                              from native in lib.RuntimeTargets
                              where native.Runtime == runtime.Runtime &&
                                    System.IO.Path.GetFileName(native.Path) == chromeFile &&
                                    !string.IsNullOrEmpty(lib.Name) && 
                                    lib.Version != null
                              let file = new FileInfo(System.IO.Path.Combine(rootDir, lib.Name!, lib.Version!.ToString(), native.Path))
                              where file.Exists
                              select file.FullName;

            Path = nativeFiles.FirstOrDefault();
        }
    }
}