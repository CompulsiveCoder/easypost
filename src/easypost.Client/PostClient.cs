using System;
using System.Net;
using System.IO;

namespace easypost.Client
{
    public class PostClient
    {
        public string Host { get; set; }
        public int Port { get; set; }

        public HttpRequestTool HttpRequests { get; set; }

        public PostClient (string host, int port)
        {
            Host = host;
            Port = port;
            HttpRequests = new HttpRequestTool ();
        }

        public void Post(string text, string fileName, string folderName, string securityKey)
        {
            var url = String.Format("http://{0}:{1}/HttpGet.aspx?text={2}&file={3}&folder={4}&key={5}&action={6}&quiet=true", Host, Port, text, fileName, folderName, securityKey, PostAction.Overwrite);

            var response = HttpRequests.MakeGetRequest (url);

            var isSuccessful = response.Contains ("Posted!");

            if (!isSuccessful)
                throw new Exception ("Invalid response");
        }

        public void Append(string content)
        {
            throw new NotImplementedException ();
        }

        public string Read(string fileName, string folderName)
        {
            var url = String.Format("http://{0}:{1}/content/{2}/{3}", Host, Port, folderName, fileName);

            var response = HttpRequests.MakeGetRequest (url);

            return response;
        }  

        public void Delete()
        {
            throw new NotImplementedException ();
        }
    }
}

