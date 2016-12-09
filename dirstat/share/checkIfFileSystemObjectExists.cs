using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FileSystemHelper {
    public static bool checkIfFileSystemObjExists(FileSystemInfo fi){
        if (fi.Exists) return true;
        Console.WriteLine("Error: File/Dir \"{0}\" does not exists!", fi.Name);
        return false;
    }
    FileSystemHelper(FileSystemInfo fi)
    {
    }
}
