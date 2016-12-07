/*
 * Created by SharpDevelop.
 * User: MyAcer
 * Date: 04.12.2016
 * Time: 13:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;


public class FilesRunner:dirstat
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	
	public FilesRunner(ref DirectoryInfo di, fileDelegate dg){
		if (di.Exists)
		{
			foreach (FileInfo f in di.EnumerateFiles())
			{
				//path2 = Path.Combine(path,f.Name);
				//Console.WriteLine(path2);
				dg(f);
			}
		}else
		{
			Console.WriteLine("Dir -{0}- does not exist.", di.Name);
		}
	}
	
}


