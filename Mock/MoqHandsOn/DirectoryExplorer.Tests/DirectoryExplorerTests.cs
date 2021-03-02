using MagicFilesLib;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace DirectoryExplorer.Tests
{
    [TestFixture]
    public class DirectoryExplorerTests
    {
        private readonly string _file1 = "file.txt";
        private readonly string _file2 = "file2.txt";

        Mock<IDirectoryExplorer> _mock;
        DirectoryExplorerr directoryExplorer;

        [OneTimeSetUp]
        public void Init()
        {
            _mock = new Mock<IDirectoryExplorer>(MockBehavior.Strict);
            directoryExplorer = new DirectoryExplorerr(_mock.Object);
        }

        [Test]
        [TestCase("abc.txt")]
        [TestCase("abcd.txt")]
        [TestCase("def.txt")]
        public void GetFiles_WhenCalled_ReturnsAllContentFromFile(string filePath)
        {
            ICollection<string> collection = new List<string>();
            collection.Add(_file1);
            collection.Add(_file2);
            _mock.Setup(p => p.GetFiles(filePath)).Returns(collection);
            ICollection<string> result = directoryExplorer.GetFiles(filePath);

            Assert.That(result, Is.Not.Null);
            Assert.AreEqual(result.Count, 2);
         }
    }
}
