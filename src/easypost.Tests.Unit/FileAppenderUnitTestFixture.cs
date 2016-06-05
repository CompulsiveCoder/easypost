using System;
using NUnit.Framework;
using easypost;
using System.IO;

namespace easypost.Tests
{
    [TestFixture]
    public class FileAppenderUnitTestFixture : BaseUnitTestFixture
    {
        [Test]
        public void Test_Append_NewFile()
        {
            Console.WriteLine ("");
            Console.WriteLine ("Preparing test");
            Console.WriteLine ("");

            var dataDirectory = Path.GetFullPath (".data");

            var folderName = "TestFolder";

            var fileName = "TestFile.txt";

            var deviceKey = "deviceKey";

            var text = "Hello world!";

            var appender = new FileAppender (dataDirectory, folderName, deviceKey);

            Console.WriteLine ("");
            Console.WriteLine ("Executing test");
            Console.WriteLine ("");

            appender.Append (fileName, text);

            Console.WriteLine ("");
            Console.WriteLine ("Analysing test");
            Console.WriteLine ("");

            var filePath = Path.Combine (dataDirectory, folderName + "/" + fileName);

            var fileContents = File.ReadAllLines (filePath);

            Assert.AreEqual (1, fileContents.Length);
        }

        [Test]
        public void Test_Append_ExistingFile()
        {
            Console.WriteLine ("");
            Console.WriteLine ("Preparing test");
            Console.WriteLine ("");

            var dataDirectory = Path.GetFullPath (".data");

            Directory.CreateDirectory (dataDirectory);

            var folderName = "TestFolder";

            var folderPath = Path.Combine (dataDirectory, folderName);

            Directory.CreateDirectory (folderPath);

            var fileName = "TestFile.txt";

            var deviceKey = "deviceKey";

            var filePath = Path.Combine (dataDirectory, folderName + "/" + fileName);

            File.WriteAllText (filePath, "Line #1" + Environment.NewLine);

            var text = "Line #2";

            var appender = new FileAppender (dataDirectory, folderName, deviceKey);

            Console.WriteLine ("");
            Console.WriteLine ("Executing test");
            Console.WriteLine ("");

            appender.AppendLine (fileName, text);

            Console.WriteLine ("");
            Console.WriteLine ("Analysing test");
            Console.WriteLine ("");

            var fileContents = File.ReadAllLines (filePath);

            Assert.AreEqual (2, fileContents.Length);

            Assert.AreEqual (text, fileContents [1]);
        }
    }
}

