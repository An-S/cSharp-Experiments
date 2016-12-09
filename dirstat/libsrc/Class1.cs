using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirUtil
{
    public class CreateDirInfo
    {
        public DirectoryInfo DInfo  { get ; set;}
        public bool dirExists { get; set; }
        public CreateDirInfo(String path)
        {
            DInfo = new DirectoryInfo(path);
            dirExists = FileSystemHelper.checkIfFileSystemObjExists(DInfo);
            if (!dirExists)
            {
                throw new FileNotFoundException("DirInfoPathInvalid");
            }
        }
    }
}

namespace mynamespace
{
    class Class2
    {
    }
}
