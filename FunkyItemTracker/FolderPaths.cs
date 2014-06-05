using System.IO;
using System.Reflection;

namespace FunkyItemTracker
{
	public static class FolderPaths
	{
		internal static void CheckFolderExists(string path)
		{
			if (!Directory.Exists(path))
			{
				ItemTracker.Logging.DebugFormat("Creating new Folder @ {0}", path);
				Directory.CreateDirectory(path);
			}
		}

		internal static string DemonBuddyPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
		internal static string ItemTrackerFolderPath
		{
			get
			{
				string folderpath = Path.Combine(DemonBuddyPath, "ItemTracker");
				CheckFolderExists(folderpath);
				return folderpath;
			}
		}

		internal static string ItemTrackerCurrentAccountFilePath
		{
			get
			{
				string folderpath = Path.Combine(ItemTrackerFolderPath, ItemTracker.AccountDetails.BattleTag + ".xml");
				return folderpath;
			}
		}
	}
}
