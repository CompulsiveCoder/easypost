using System;
using System.Web;
using System.Web.UI;

namespace easypost.WWW
{
    
    public partial class PostData : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            var file = "file.txt";

            if (Request.QueryString ["file"] != null)
                file = Request.QueryString ["file"];

            FileName.Text = file;
        }

        protected void PostButton_Click(object sender, EventArgs e)
        {
            Response.Redirect ("PostResult.aspx");
        }
    }
}

