using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FunkyItemTrackerGUI
{
	internal static class Paths
	{
		public static readonly string RootDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

	}
}
