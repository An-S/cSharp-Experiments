/*
 * Created by SharpDevelop.
 * User: MyAcer
 * Date: 30.11.2016
 * Time: 22:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

/*
using System;
using System.IO;

class dirstat
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	static void printoutFiles(ref DirectoryInfo di){
		String path = di.Name;
		String path2;

		if (di.Exists)
		{
			Console.WriteLine(path);
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

	static void Main()
	{
		DirectoryInfo di = new DirectoryInfo("./");
		//IEnumerable<DirectoryInfo> en = di.EnumerateDirectories();
	
		printoutFiles(ref di);
	}
}
*/