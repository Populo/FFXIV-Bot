using System.Runtime.InteropServices;
using Velopack;

namespace XIVBot.Services;

public static class UpdateService
{
    private static UpdateManager? _updateManager;

    public static async Task<UpdateInfo?> CheckForUpdatesAsync()
    {
        try
        {
            _updateManager = new UpdateManager("https://ffxiv.populo.dev/releases");

            // Check if there's an update available
            var updateInfo = await _updateManager.CheckForUpdatesAsync();
            return updateInfo;

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Update check failed: {ex.Message}");
            return null;
        }
    }

    public static async Task UpdateAppAsync(UpdateInfo? updateInfo)
    {
        _updateManager = new UpdateManager("https://ffxiv.populo.dev/releases");
        
        if (null == updateInfo)
        {
            // Check if there's an update available
            updateInfo = await _updateManager.CheckForUpdatesAsync();
        
            if (updateInfo == null)
            {
                Console.WriteLine("No updates available");
                return;
            }
        }
        
        // Download and install the update
        await _updateManager.DownloadUpdatesAsync(updateInfo);
            
        // Apply the update and restart
        _updateManager.ApplyUpdatesAndRestart(updateInfo);
    }
    
    private static string GetPlatformPath()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            return RuntimeInformation.ProcessArchitecture switch
            {
                Architecture.X64 => "win-x64",
                Architecture.X86 => "win-x86",
                Architecture.Arm64 => "win-arm64",
                _ => "win-x64"
            };
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            return RuntimeInformation.ProcessArchitecture == Architecture.Arm64 ? "osx-arm64" : "osx-x64";
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            return RuntimeInformation.ProcessArchitecture == Architecture.Arm64 ? "linux-arm64" : "linux-x64";
        }
            
        return "win-x64"; // fallback
    }

}