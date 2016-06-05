using System;
using System.IO;

namespace easypost
{
    public class FileNamer
    {
        public string DataDirectory { get;set; }

        public FileNamer (string dataDirectory)
        {
            DataDirectory = dataDirectory;
        }

        public string GetFilePath(string folderName, string fileName)
        {
            var dir = Path.Combine (DataDirectory, folderName);
            var path = Path.Combine (dir, fileName);

            return path;
        }
    }
}

