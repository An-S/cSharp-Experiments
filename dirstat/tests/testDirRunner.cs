/*
 * Created by SharpDevelop.
 * User: MyAcer
 * Date: 04.12.2016
 * Time: 13:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

class MainClass
{
    static void prDir(DirectoryInfo di)
    {
        Console.WriteLine(di.FullName);
    }

    static void Main(string[] args)
    {
        DirectoryInfo di = new DirectoryInfo("dirtree");
        var fr = new DirUtil.DirRunner(ref di, prDir);
    }
}
