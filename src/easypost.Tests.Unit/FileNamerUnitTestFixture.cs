using System;
using NUnit.Framework;
using easypost;
using System.IO;

namespace easypost.Tests
{
    [TestFixture]
    public class FileNamerUnitTestFixture
    {
        [Test]
        public void Test_GetFilePath()
        {
            Console.WriteLine ("");
            Console.WriteLine ("Preparing test");
            Console.WriteLine ("");

            var dataDirectory = Path.GetFullPath (".data");

            Directory.CreateDirectory (dataDirectory);

            var folderName = "TestFolder";

            var fileName = "TestFile.txt";

            var fileNamer = new FileNamer (dataDirectory);

            Console.WriteLine ("");
            Console.WriteLine ("Executing test");
            Console.WriteLine ("");

            var filePath = fileNamer.GetFilePath (folderName, fileName);

            Console.WriteLine (filePath);

            var expectedFilePath = Path.Combine (dataDirectory, folderName, fileName);

            Assert.AreEqual (expectedFilePath, filePath);

            //appender.Append (fileName, text);

        }
    }
}

