using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace FunkyItemTrackerGUI.Objects
{
	public class Account
	{
		public string Name { get; set; }
		public List<Character> Characters { get; set; }
		public List<TrackedItem> StashedItems { get; set; }

		public Account()
		{
			Name = "";
			Characters = new List<Character>();
			StashedItems = new List<TrackedItem>();
		}
		public Account(string AccountName)
		{
			Name = AccountName;
			Characters = new List<Character>();
			StashedItems = new List<TrackedItem>();
		}

		public static void SerializeToXML(Account settings, string path)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Account));
			TextWriter textWriter = new StreamWriter(path);
			serializer.Serialize(textWriter, settings);
			textWriter.Close();
		}
		public static Account DeserializeFromXML(string path)
		{
			XmlSerializer deserializer = new XmlSerializer(typeof(Account));
			TextReader textReader = new StreamReader(path);
			Account settings;
			settings = (Account)deserializer.Deserialize(textReader);
			textReader.Close();
			return settings;
		}
	}
}
