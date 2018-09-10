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
	static void prFile(FileInfo fl){
		Console.WriteLine(fl.Name);
	}
	
	static void Main(string[] args)
	{
		DirectoryInfo di = new DirectoryInfo(@"./");
		var fr = new DirUtil.FilesRunner(ref di, prFile);
	}
}