using System;
using NUnit.Framework;
using easypost.Tests;
using easypost.Tests.Integration;

namespace easypost.Client.Tests.Integration
{
    [TestFixture]
    public class PostClientIntegrationTestFixture : BaseIntegrationTestFixture
    {
        [Test]
        public void Test_PostAndRead()
        {
            StartWebApplication ();

            var folderName = "myFolder";
            var securityKey = "myKey";

            InsertKey (folderName, securityKey);

            var host = "localhost";
            var port = AppStarter.Port;

            var client = new PostClient (host, port);

            var content = "Hello world";

            var fileName = "TestFile.txt";

            client.Post (content, fileName, folderName, securityKey);

            var foundContent = client.Read (fileName, folderName);

            Assert.AreEqual (content, foundContent);
        }
    }
}

