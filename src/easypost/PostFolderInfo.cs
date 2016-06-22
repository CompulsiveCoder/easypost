using System;

namespace easypost
{
    public class PostFolderInfo
    {
        public string EmailAddress { get; set; }
        public string FolderId { get;set; }
        public string SecurityKey { get;set; }

        public PostFolderInfo (string emailAddress, string folderId, string securityKey)
        {
            EmailAddress = emailAddress;
            FolderId = folderId;
            SecurityKey = securityKey;
        }
    }
}

