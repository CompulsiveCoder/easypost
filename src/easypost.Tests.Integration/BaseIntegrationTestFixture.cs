using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using NUnit.Framework;

namespace easypost.Tests.Integration
{
    public class BaseIntegrationTestFixture : BaseTestFixture
    {
        public WebApplicationStarter AppStarter;

        public BaseIntegrationTestFixture ()
        {
        }

        public Thread StartWebApplication()
        {
            CopyWebApplicationToTestEnvironment ();

            if (AppStarter == null)
                AppStarter = new WebApplicationStarter ();

            // TODO: Should WebApplicationStarter be stored as a property to allow dependency injection?
            AppStarter.Start ("www");

            return null;
        }

        public void CopyWebApplicationToTestEnvironment()
        {
            var wwwDir = Path.Combine (OriginalDirectory, "../../src/easypost.WWW");

            var newDir = Path.Combine (Environment.CurrentDirectory, "www");

            DirectoryCopier.Copy (wwwDir, newDir, true);
        }

        public void InsertKey(string folderName, string securityKey)
        {
            var dataDir = Path.GetFullPath ("www/.data/");

            var filePath = Path.Combine (dataDir, folderName);

            File.WriteAllText (filePath, securityKey);
        }

        public override void TearDown()
        {
            if (AppStarter != null
                && !String.IsNullOrEmpty(AppStarter.DockerContainerId))
                AppStarter.Stop ();

            base.TearDown ();
        }
    }
}

