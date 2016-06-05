using System;
using System.IO;

namespace easypost
{
	public class KeyManager
	{
		public string PrivateDataFolder = "";

		public KeyManager (string privateDataFolder)
		{
			PrivateDataFolder = privateDataFolder;
		}

		public KeySet CreateKeySet()
		{
			var generator = new KeyGenerator ();
			var keys = generator.Generate ();

			var saver = new KeySaver (PrivateDataFolder);
			saver.Save (keys);

			return keys;
		}

        public bool CheckKeys(string folderName, string securityKey)
		{
			var filePath = Path.Combine(PrivateDataFolder, folderName);

			if (!File.Exists (filePath))
				return false;

			var content = File.ReadAllText (filePath);

            return content.Trim() == securityKey;
		}
	}
}

