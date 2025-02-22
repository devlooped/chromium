using System.Diagnostics;

namespace System;

partial class DotNetMuxer
{
    public static async Task<int> TryRestore()
    {
        var info = MuxerPath != null ?
        new ProcessStartInfo
        {
            FileName = MuxerPath,
            ArgumentList =
            {
                "restore",
                "runtimes.msbuild",
                $"-p:NativeVersion={ThisAssembly.Project.NativeVersion}"
            },
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true,
            WorkingDirectory = AppContext.BaseDirectory
        } :
        new ProcessStartInfo
        {
            FileName = MuxerPathOrDefault(),
            ArgumentList =
            {
                "restore",
                "runtimes.msbuild",
                $"-p:NativeVersion={ThisAssembly.Project.NativeVersion}"
            },
            UseShellExecute = true,
            CreateNoWindow = true,
            WorkingDirectory = AppContext.BaseDirectory
        };

        // Try by doing a dotnet restore.
        var process = Process.Start(info);
        if (process != null)
        {
            await process.WaitForExitAsync();
            if (process.ExitCode != 0 && info.RedirectStandardOutput)
            {
                Debugger.Log(0, "", process.StandardOutput.ReadToEnd());
            }
        }

        return process?.ExitCode ?? -1;
    }
}
