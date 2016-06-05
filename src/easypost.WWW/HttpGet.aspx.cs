using System;
using System.Web;
using System.Web.UI;
using System.IO;
using System.Configuration;

namespace easypost.WWW
{
	
	public partial class HttpGet : System.Web.UI.Page
	{
		public string TextData = "";
		public string FolderName = "";
		public string FileName = "";
		public string SecurityKey = "";
        public PostAction Action;

		public bool DidPublish;

		public string FileUrl = "";
        public string PostUrl = "";

		private void Page_Load(object sender, EventArgs e)
        {
            TextData = Request.QueryString ["text"];

            SecurityKey = Request.QueryString ["key"];

            FolderName = Request.QueryString ["folder"];

            FileName = Request.QueryString ["file"];

            Action = (PostAction)Enum.Parse (typeof(PostAction), Request.QueryString ["action"]);

            var dataFolder = ConfigurationSettings.AppSettings ["DataFolder"];

            var contentFolder = ConfigurationSettings.AppSettings ["ContentFolder"];

            if (!String.IsNullOrEmpty (TextData)) {
                var manager = new PostManager (dataFolder, contentFolder, FolderName, SecurityKey);
                    
                manager.Post (FileName, TextData, Action);

                CreateUrl (FolderName, FileName);

                DidPublish = true;
            }
        }

        private void CreateUrl(string folderName, string fileName)
        {
            FileUrl = HttpTool.Absolute("/content/" + folderName + "/" + fileName);

        }

        private void CreatePostUrl(string text, string folder, string file, string key, PostAction action)		
		{
			var url = String.Format ("~/HttpGet.aspx?folder={0}&file={1}&key={2}&action={3}&text={4}", HttpUtility.UrlEncode(folder), HttpUtility.UrlEncode(file), HttpUtility.UrlDecode(key), action, HttpUtility.UrlEncode(text));

			PostUrl = HttpTool.Absolute (url);
		}


	}
}

