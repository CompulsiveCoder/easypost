using System;

namespace easypost
{
    public class PostContext
    {
        public PostManager Manager { get; set; }

        public string DataDirectory { get;set; }

        public string ContentDirectory { get;set; }

        /*public PostContext (string dataDirectory, string  string folderName, string deviceKey)
        {
            Manager = new PostManager (dataDirectory, folderName, deviceKey);
        }*/
    }
}

