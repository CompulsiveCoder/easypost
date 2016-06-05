using System;
using System.Web;
using System.Web.UI;
using System.Configuration;

namespace easypost.WWW
{
	
	public partial class CreateKey : System.Web.UI.Page
	{
		public KeySet Keys;

        public void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString ["create"] == "true")
                Create ();
        }

		public void CreateKeyButton_Clicked(object sender, EventArgs e)
		{
            Create ();
		}

        public void Create()
        {
            var privateFolder = Server.MapPath (ConfigurationSettings.AppSettings["DataFolder"]);
            var publicFolder = Server.MapPath (ConfigurationSettings.AppSettings["ContentFolder"]);

            var keyManager = new KeyManager (privateFolder);

            Keys = keyManager.CreateKeySet ();

            var folderCreator = new UniqueFolderCreator (publicFolder);
            folderCreator.Create (Keys.FolderName);
        }
	}
}

