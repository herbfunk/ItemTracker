using System;
using FunkyItemTracker.Objects;
using Zeta.Common.Plugins;

namespace FunkyItemTracker
{
    public class ItemTracker : IPlugin
    {
		public string Author
		{
			get { return "HerbFunk"; }
		}

		public string Description
		{
			get { return "Dumps and Tracks Items on characters and accounts."; }
		}

		public System.Windows.Window DisplayWindow
		{
			get { return null; }
		}

		public string Name
		{
			get { return "FunkyItemTracker"; }
		}

		public void OnDisabled()
		{
			TabUi.RemoveTab();
		}

		public void OnEnabled()
		{
			TabUi.InstallTab();
		}

		public void OnInitialize()
		{
			
		}

		public void OnPulse()
		{
			
		}

		public void OnShutdown()
		{
			
		}

		public Version Version
		{
			get { return new Version(0, 0, 1, 0); }
		}

		public bool Equals(IPlugin other) { return (other.Name == Name) && (other.Version == Version); }
		
		
		internal static readonly log4net.ILog Logging = Zeta.Common.Logger.GetLoggerInstanceForType();
		internal static Account CurrentAccount { get; set; }
		internal static CurrentAccountDetails AccountDetails { get; set; }
	}
}
