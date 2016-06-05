using System;
using System.IO;

namespace easypost
{
    public class FileAppender
    {
        public string DataDirectory { get; set; }
        public string FolderName { get;set; }
        public string SecurityKey { get;set; }
        public FileNamer Namer { get; set; }

        public FileAppender (string dataDirectory, string folderName, string securityKey)
        {
            DataDirectory = dataDirectory;
            FolderName = folderName;
            SecurityKey = securityKey;
            Namer = new FileNamer (dataDirectory);
        }

        public void AppendLine(string fileName, string text)
        {
            Append (fileName, text + Environment.NewLine);
        }

        public void Append(string fileName, string text)
        {
            if (!Directory.Exists (DataDirectory))
                Directory.CreateDirectory (DataDirectory);

            var folderPath = Path.Combine(DataDirectory, FolderName);

            if (!Directory.Exists (folderPath))
                Directory.CreateDirectory (folderPath);

            var filePath = Namer.GetFilePath (FolderName, fileName);

            Console.WriteLine (filePath);

            if (!File.Exists (filePath))
                File.WriteAllText (filePath, text);
            else
                File.AppendAllText (filePath, text);
        }
    }
}

