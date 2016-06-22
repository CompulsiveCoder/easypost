using System;
using System.Web;
using System.Web.UI;
using System.Configuration;

namespace easypost.WWW
{
    
    public partial class CreateFolder : System.Web.UI.Page
    {
        protected void CreateButton_Click(object sender, EventArgs e)
        {
            CreateButton.Enabled = false;

            /*var dataFolder = ConfigurationSettings.AppSettings ["DataFolder"];

            var contentFolder = ConfigurationSettings.AppSettings ["ContentFolder"];

            //var keys = new PostFolderManager (dataFolder, contentFolder).Keys.CreateKeySet ();

            var host = Request.Url.Host;

            var creator = new PostFolderCreator (host);

            var folder = creator.CreateFolder (emailAddress);

            creator.SendVerificationEmail(EmailAddress.Text, folder.FolderId);
*/
            throw new NotImplementedException ();
          /*  FolderId.Text = keys.FolderId;
            SecurityKey.Text = keys.SecurityKey;*/
        }

        protected void NextButton_Click(object sender, EventArgs e)
        {
            Response.Redirect ("Folder.aspx");
        }
    }
}

