using System;
using NUnit.Framework;
using System.IO;
using System.Linq;

namespace easypost.Tests
{
	public abstract class BaseTestFixture
	{
		public string OriginalDirectory;

		public bool DeleteTemporaryDirectory = false;

		public BaseTestFixture ()
		{
		}

		[SetUp]
        public virtual void SetUp()
		{
			OriginalDirectory = Environment.CurrentDirectory;

			var tmpDir = new TemporaryDirectoryCreator ().Create ();

			Directory.SetCurrentDirectory (tmpDir);

            Console.WriteLine ("Original directory:");
            Console.WriteLine (" " + OriginalDirectory);
			Console.WriteLine ("Current directory:");
			Console.WriteLine (" " + tmpDir);
			Console.WriteLine ();
		}

		[TearDown]
		public virtual void TearDown()
		{
			var tmpDir = Environment.CurrentDirectory;

			Directory.SetCurrentDirectory (OriginalDirectory);

			if (DeleteTemporaryDirectory && tmpDir.ToLower().Contains(".tmp")) {
				Directory.Delete (tmpDir, true);
			}
		}

        public void CopyBinariesToTestEnvironment()
        {
            var files = (from f in Directory.GetFiles (OriginalDirectory)
                where Path.GetExtension (f) == ".exe"
                || Path.GetExtension (f) == ".dll"
                select f).ToArray ();

            foreach (var file in files) {
                var newPath = file.Replace (OriginalDirectory, Environment.CurrentDirectory);

                File.Copy (file, newPath);
            }
        }

	}
}

