/*
 * Created by SharpDevelop.
 * User: MyAcer
 * Date: 15.11.2016
 * Time: 12:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Windows.Forms;


class dirstat
{
	static int numArgs = 1;
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public String WorkingDir { get; set;}
	public String InterestDir { get; set;}
	public String ExeName { get; set;}

	public dirstat(){
		WorkingDir = Path.GetDirectoryName(Application.ExecutablePath);
		ExeName = Path.GetFileName(WorkingDir);
	}
	
	static public dirstat Create(){
		return new dirstat();
	}
	
	static void printoutFiles(ref DirectoryInfo di){
		String path = di.Name;
		String path2;

		if (di.Exists)
		{
			//Console.WriteLine(path);
			foreach (FileInfo f in di.EnumerateFiles())
			{
				path2 = Path.Combine(path,f.Name);
				Console.WriteLine(path2);
			}
			
		}else
		{
			Console.WriteLine("Dir -{0}- does not exist.", di.Name);
		}
	}

	static void printoutDirs(ref DirectoryInfo di, String path){
		String path2;
		
		if (di.Exists)
		{
			Console.WriteLine(path);
			foreach (DirectoryInfo d in di.EnumerateDirectories())
			{
				path2 = Path.Combine(path,d.Name);
				//Console.WriteLine(path2);
				DirectoryInfo d2 = new DirectoryInfo(path2);
				printoutFiles(ref d2);
				//d2 = d;
				if (d2.Exists) 
				{
					printoutDirs(ref d2, path2);
				}
				else Console.WriteLine("Dir -{0}- exists not", d2.Name);
				//else Console.WriteLine(di2.Name);
			}
			
		}else
		{
			Console.WriteLine("Dir -{0}- does not exist.", di.Name);
		}
	}

	static void Main(string[] args)
	{
		var myDirStat = dirstat.Create();
		if (args.Length != dirstat.numArgs){
			Console.WriteLine("Usage: {0} dir", myDirStat.ExeName);
		}
		
		DirectoryInfo di = new DirectoryInfo("testdir");
		//IEnumerable<DirectoryInfo> en = di.EnumerateDirectories();
		
		printoutDirs(ref di, di.Name);
	}
}
