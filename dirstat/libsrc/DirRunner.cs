/*
 * Created by SharpDevelop.
 * User: MyAcer
 * Date: 06.12.2016
 * Time: 15:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

/// <summary>
/// Description of Class1.
/// </summary>
public class DirRunner/*
 * Created by SharpDevelop.
 * User: MyAcer
 * Date: 04.12.2016
 * Time: 13:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;


public class DirRunner:dirstat
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	static void emptyFnc(FileInfo f){

	}

	public DirRunner(ref DirectoryInfo di, dirDelegate dg, dirDelegate before, dirDelegate after){
		if (di.Exists)
		{
			//Console.WriteLine(path);
			if (before) before(di);
			foreach (DirectoryInfo d in di.EnumerateDirectories())
			{
				//path2 = Path.Combine(path,f.Name);
				//Console.WriteLine(path2);
				dg(d);
			}
			if (after) after(di);
		}else
		{
			Console.WriteLine("Dir -{0}- does not exist.", di.Name);
		}
	}


}



{
	public Class1()
	{
	}
}
