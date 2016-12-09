using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

[TestFixture]
public class testFileExists
{
    
    public class testDirRunner
    {
        [TestCase]
        public void TestCreateDirInfo()
        {
            String dirname = "test";
            DirUtil.CreateDirInfo di;
            try
            {
                di = new DirUtil.CreateDirInfo(dirname);
                Fail();
            }
            catch (IOException e)
            {
                Assert.AreEqual(dirname, di.DInfo.Name);
                Assert.AreEqual(false, di.dirExists);
            }
        }

        [TestCase]
        public void TestFObjExists()
        {
            var fi = new FileInfo("utestFileExists.dll");
            Assert.AreEqual(true, FileSystemHelper.checkIfFileSystemObjExists(fi));
            fi = new FileInfo("not a file");
            Assert.AreEqual(false, FileSystemHelper.checkIfFileSystemObjExists(fi));
        }
    }
}
