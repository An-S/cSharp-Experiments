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

class MainClass{
	void prFile(FileInfo fl){
		Console.WriteLine(fl.Name);
	}
	
	static void Main(string[] args)
	{
		/*var myDirStat = dirstat.Create();
		if (args.Length != dirstat.numArgs){
			Console.WriteLine("Usage: {0} dir", myDirStat.ExeName);
		}*/
		
		DirectoryInfo di = new DirectoryInfo("testdir");
		//IEnumerable<DirectoryInfo> en = di.EnumerateDirectories();
		
		//printoutDirs(ref di, di.Name);

		di = new DirectoryInfo("./");
		//IEnumerable<DirectoryInfo> en = di.EnumerateDirectories();
	
		var fr = new FilesRunner(di, prFile);
	}
}