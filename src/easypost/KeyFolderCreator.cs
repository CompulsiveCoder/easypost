using System;
using System.IO;

namespace easypost
{
	public class UniqueFolderCreator
	{
		public string DataFolder = "";

		public UniqueFolderCreator (string dataFolder)
		{
			DataFolder = dataFolder;
		}

		public void Create(string ipfsKey)
		{
			Directory.CreateDirectory (Path.Combine (DataFolder, ipfsKey));
		}
	}
}

