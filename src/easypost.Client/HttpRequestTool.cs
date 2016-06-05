using System;
using System.Net;
using System.IO;

namespace easypost.Client
{
    public class HttpRequestTool
    {
        public bool IsVerbose = true;

        public HttpRequestTool ()
        {
        }

        public virtual string MakeGetRequest(string url)
        {
            if (IsVerbose) {
                Console.WriteLine ("Making HTTP GET request:");
                Console.WriteLine ("  " + url);
            }

            var output = String.Empty;

            var myRequest = WebRequest.CreateHttp(url);
            myRequest.Method = "GET";
            myRequest.UserAgent = "WebRequestDemo"; 

            using (var response = myRequest.GetResponse()) 
            {
                var dataStream = response.GetResponseStream();
                var reader = new StreamReader(dataStream);
                output = reader.ReadToEnd ();
                dataStream.Close();
                response.Close();
            }

            return output;
        }
    }
}

