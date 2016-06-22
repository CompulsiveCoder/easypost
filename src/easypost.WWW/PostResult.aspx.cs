using System;
using System.Web;
using System.Web.UI;

namespace easypost.WWW
{
    
    public partial class PostResult : System.Web.UI.Page
    {
        public string Action;
        public string TextData;
        public string FileName;
        public string FolderId;
        public string FolderTitle;
        public string FileContent;

        protected void Page_Load(object sender, EventArgs e)
        {
            Action = Request.QueryString ["action"];
            TextData = Request.QueryString ["text"];
            FileName = Request.QueryString ["file"];
            FolderId = Request.QueryString ["folder"];
        }
    }
}

