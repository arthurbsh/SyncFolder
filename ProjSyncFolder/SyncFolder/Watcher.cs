using SyncFolder;
using System;
using System.IO;
using System.Security.Permissions;
using System.Windows.Forms;

public class Watcher
{

    public static string sourceFolder;
    public static string targetFolder;

    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    public void Watch(string source, string target)
    {
        sourceFolder = source;
        targetFolder = target;

        // Create a new FileSystemWatcher and set its properties.
        FileSystemWatcher watcher = new FileSystemWatcher();
        watcher.Path = source;
        watcher.IncludeSubdirectories = true;

        /* Watch for changes in LastAccess and LastWrite times, and
           the renaming of files or directories. */
        watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
           | NotifyFilters.FileName | NotifyFilters.DirectoryName;


        // Adds a filter
        watcher.Filter = "*.*";

        // Add event handlers.
        watcher.Changed += new FileSystemEventHandler(OnChanged);
        watcher.Created += new FileSystemEventHandler(OnChanged);
        watcher.Deleted += new FileSystemEventHandler(OnChanged);
        watcher.Renamed += new RenamedEventHandler(OnRenamed);

        // Begin watching.
        watcher.EnableRaisingEvents = true;
    }

    // Define the event handlers. 
    private static void OnChanged(object source, FileSystemEventArgs e)
    {
        // Specify what is done when a file is changed, created, or deleted.
        //Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
        
        if (e.ChangeType.Equals(WatcherChangeTypes.Created))
        {
            FileManager.Copy(sourceFolder, targetFolder, e.Name);

        } else if (e.ChangeType.Equals(WatcherChangeTypes.Deleted))
        {
            FileManager.Delete(targetFolder, e.Name);

        } 
    }

    private static void OnRenamed(object source, RenamedEventArgs e)
    {
        // Specify what is done when a file is renamed.
        FileManager.Rename(targetFolder, e.OldName, e.Name);       
    }
}