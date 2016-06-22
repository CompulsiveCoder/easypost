using System;

namespace easypost
{
    public class PostFolderCreator
    {
        public EmailVerifier Verifier { get; set; }

        public KeyGenerator Keys { get;set; }

        public PostFolderCreator (string host)
        {
            Verifier = new EmailVerifier (host);

            Keys = new KeyGenerator ();
        }

        public PostFolderInfo CreateFolder(string emailAddress)
        {
            // TODO: Is there a neater way to do this?
            var keySet = Keys.Generate ();

            var folder = new PostFolderInfo (emailAddress, keySet.FolderId, keySet.SecurityKey);

            throw new NotImplementedException ();
        }

        public void SendVerificationEmail(string email, string folderId)
        {
            Verifier.SendVerificationEmail (email, folderId);
        }
    }
}

