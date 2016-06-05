using System;
using System.IO;

namespace easypost
{
    public class FileOverwriter
    {
        public string DataDirectory { get; set; }
        public string FolderName { get;set; }
        public string SecurityKey { get;set; }
        public FileNamer Namer { get; set; }

        public FileOverwriter (string dataDirectory, string folderName, string securityKey)
        {
            DataDirectory = dataDirectory;
            FolderName = folderName;
            SecurityKey = securityKey;
            Namer = new FileNamer (dataDirectory);
        }

        public void Overwrite(string fileName, string text)
        {
            if (!Directory.Exists (DataDirectory))
                Directory.CreateDirectory (DataDirectory);

            var folderPath = Path.Combine(DataDirectory, FolderName);

            if (!Directory.Exists (folderPath))
                Directory.CreateDirectory (folderPath);

            var filePath = Namer.GetFilePath (FolderName, fileName);

            Console.WriteLine (filePath);

            File.WriteAllText (filePath, text);
        }
    }
}

