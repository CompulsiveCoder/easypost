using System;
using System.IO;

namespace easypost
{
    public class PostFolderManager
    {
        public string DataDirectory { get; set; }

        public string ContentDirectory { get;set; }

        public string FolderId { get;set; }

        public string SecurityKey { get;set; }

        public FileOverwriter Overwriter { get; set; }

        public FileAppender Appender { get; set; }

        public KeyManager Keys { get;set; }

        public Authenticator Authentication { get; set; }

        public PostFolderManager (string dataDirectory, string contentDirectory, string folderName, string securityKey)
        {
            DataDirectory = dataDirectory;
            ContentDirectory = contentDirectory;
            FolderId = folderName;
            SecurityKey = securityKey;
            Overwriter = new FileOverwriter (contentDirectory, folderName, securityKey);
            Appender = new FileAppender (contentDirectory, folderName, securityKey);
            Keys = new KeyManager (dataDirectory);
            Authentication = new Authenticator (Keys);
        }

        public void Append(string filePath, string text)
        {
            Appender.Append (filePath, text);
        }

        public void Create(string filePath, string text)
        {
            // Use the overwrite process because it will create if it doesn't exist
            Overwrite(filePath, text);
        }

        public void Overwrite(string filePath, string text)
        {
            Authentication.Authenticate (FolderId, SecurityKey);

            throw new NotImplementedException ();
        }

        public void Post(string filePath, string text, PostAction action)
        {
            Authentication.Authenticate (FolderId, SecurityKey);

            if (action == PostAction.Overwrite)
                Overwriter.Overwrite(filePath, text);
            else
                Appender.AppendLine (filePath, text); // TODO: Should AppendLine or Append be used by default?
        }
    }
}

