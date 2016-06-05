using System;

namespace easypost
{
    public class Authenticator
    {
        public KeyManager Keys { get; set; }

            public Authenticator (KeyManager keys)
        {
            Keys = keys;
        }


        public bool IsAuthenticated(string folderName, string securityKey)
        {
            var isAuthenticated = Keys.CheckKeys (folderName, securityKey);
            return isAuthenticated;
        }

        public void Authenticate(string folderName, string securityKey)
        {
            if (!IsAuthenticated (folderName, securityKey))
                throw new UnauthorizedAccessException ();
        }
    }
}

