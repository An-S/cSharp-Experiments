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
	static void emptyFnc(FileInfo f){

	}

	public FilesRunner(ref DirectoryInfo di, fileDelegate dg, fileDelegate before, fileDelegate after){
		if (di.Exists)
		{
			//Console.WriteLine(path);
			if (before) before(di);
			foreach (FileInfo f in di.EnumerateFiles())
			{
				//path2 = Path.Combine(path,f.Name);
				//Console.WriteLine(path2);
				dg(f);
			}
			if (after) after(di);
		}else
		{
			Console.WriteLine("Dir -{0}- does not exist.", di.Name);
		}
	}


}


