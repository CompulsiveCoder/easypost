using System;
using NUnit.Framework;
using System.IO;
using System.Net;
using System.Threading;

namespace easypost.Tests.Integration
{
    [TestFixture]
    public class WebApplicationStarterIntegrationTestFixture : BaseIntegrationTestFixture
    {
        [Test]
        public void Test_Start()
        {
            Console.WriteLine("");
            Console.WriteLine("Preparing test");
            Console.WriteLine("");

            var html = "<html><body>Example Page</body></html>";
            var htmlFilePath = Path.GetFullPath ("www/index.html");

            Directory.CreateDirectory (Path.GetFullPath ("www"));

            File.WriteAllText (htmlFilePath, html);

            var applicationStarter = new WebApplicationStarter ();

            Console.WriteLine("");
            Console.WriteLine("Executing test");
            Console.WriteLine("");

            applicationStarter.Start ("www");

            Console.WriteLine("");
            Console.WriteLine("Analysing test");
            Console.WriteLine("");

            var url = "http://localhost:" + applicationStarter.Port + "/index.html";

            Console.WriteLine ("Url: " + url);

            var myRequest = WebRequest.CreateHttp(url);
            myRequest.Method = "GET";
            myRequest.UserAgent = "WebRequestDemo"; 

            var output = "";

            using (var response = myRequest.GetResponse()) 
            {
                var dataStream = response.GetResponseStream();
                var reader = new StreamReader(dataStream);
                output = reader.ReadToEnd ();
                dataStream.Close();
                response.Close();
            }

            Assert.IsTrue (output.Contains("Example Page"));
        }
    }
}

