﻿using System;
using System.Web;
using System.Web.UI;
using System.Configuration;

namespace easypost.WWW
{
	
	public partial class Default : System.Web.UI.Page
	{
		public KeySet Keys;

		public void Page_Load(object sender, EventArgs e)
		{
			TextData.Text = "Hello world it's " + DateTime.Now.ToString ();
		}

		public void GoButton_Click (object sender, EventArgs args)
        {
            // TODO: Clean up
            //var url = String.Format ("Echo.aspx?text={0}&folder={1}&file={2}&key={3}&overwrite={4}", HttpUtility.UrlEncode(TextData.Text), HttpUtility.UrlEncode(Folder.Text), HttpUtility.UrlEncode(File.Text), HttpUtility.UrlDecode(Device.Text), Overwrite.Checked.ToString());
            var url = String.Format ("HttpGet.aspx?text={0}&folder={1}&file={2}&key={3}&action={4}", HttpUtility.UrlEncode(TextData.Text), HttpUtility.UrlEncode(FolderName.Text), HttpUtility.UrlEncode(File.Text), HttpUtility.UrlDecode(SecurityKey.Text), CommandOption.SelectedValue);

			Response.Redirect (url);
		}

		public void CreateKeyButton_Click (object sender, EventArgs args)
		{
            var privateFolder = Server.MapPath (ConfigurationSettings.AppSettings["DataFolder"]);
            var publicFolder = Server.MapPath (ConfigurationSettings.AppSettings["ContentFolder"]);

			var keyManager = new KeyManager (privateFolder);

			Keys = keyManager.CreateKeySet ();

			var folderCreator = new UniqueFolderCreator (publicFolder);
			folderCreator.Create (Keys.FolderName);

			FolderName.Text = Keys.FolderName;
            SecurityKey.Text = Keys.SecurityKey;
		}

	}
}

