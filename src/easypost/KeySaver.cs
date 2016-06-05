using System;
using System.IO;

namespace easypost
{
	public class KeySaver
	{
		public string DataFolder = "";

		public KeySaver (string dataFolder)
		{
			DataFolder = dataFolder;
		}

		public void Save(KeySet keys)
		{
			if (!Directory.Exists (DataFolder))
				Directory.CreateDirectory (DataFolder);

            var output = keys.SecurityKey;

			var filePath = GetKeySetFilePath (keys);

			File.WriteAllText (filePath, output);
		}

		public string GetKeySetFilePath(KeySet keys)
		{
			return Path.Combine (DataFolder, keys.FolderName);
		}
	}
}

