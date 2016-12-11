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
        //define method with optional param.
        //If not given it is auto populated with the current filename
        /*public static String getFilename([CallerFilePath] string file = "")
        {
            return Path.GetFileName(file);
        }*/

        private static DirUtil.CreateDirInfo getDir(string path)
        {
            var di = new DirUtil.CreateDirInfo(path);
            return di;
        }

        [TestCase]
        public void TestInitializationOfDirUtil_CreateDirInfo()
        {
            String dirname = MainClass.ProvideValidFilename();
            var cdi = getDir(dirname);
            var di = new DirectoryInfo(dirname);

            Assert.AreEqual(cdi.dirExists, cdi.DInfo.Exists);
            Assert.AreEqual(di, cdi.DInfo);
        }

        [TestCase]
        public void TestCreateDirInfoThrowsNotOnValidPath()
        {
            //Some dirname unlikely to be found
            String dirname = MainClass.ProvideValidFilename();
            Console.WriteLine(dirname);
            DirUtil.CreateDirInfo cdi;

            Assert.DoesNotThrow(
                delegate { cdi = getDir(dirname); }
            );

        }

        [TestCase]
        //[ExpectedException(typeof(FileNotFoundException))]
        public void TestCreateDirInfoThrowsOnInvalidPath()
        {
            //Some dirname unlikely to be found
            String dirname = "loiu324ghcb 34";
            DirUtil.CreateDirInfo cdi;

            Assert.Throws<FileNotFoundException>(
                delegate { cdi = getDir(dirname);}
            );
            
        }

        [TestCase]
        public void TestFObjExists()
        {
            var di = new DirectoryInfo(".");
            var fi = new FileInfo(di.GetFiles()[0].Name);
            Assert.AreEqual(true, FileSystemHelper.checkIfFileSystemObjExists(fi));
            fi = new FileInfo("not a file");
            Assert.AreEqual(false, FileSystemHelper.checkIfFileSystemObjExists(fi));
        }
    }
}
