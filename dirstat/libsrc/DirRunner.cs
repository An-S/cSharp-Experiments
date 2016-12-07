/*
 * Created by SharpDevelop.
 * User: MyAcer
 * Date: 06.12.2016
 * Time: 15:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
//using System;

/// <summary>
/// Description of Class1.
/// </summary>
//public class DirRunner
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


public class DirRunner:dirstat
{
    /// <summary>
    /// Description of Class1.
    /// </summary>
    static void recurseDirs(ref DirectoryInfo BaseDI, ref dirDelegate dg)
    {
       
        if (BaseDI.Exists)
        {
            String path;

            Console.WriteLine(BaseDI.Name);
            foreach (DirectoryInfo relDI in BaseDI.EnumerateDirectories())
            {
                //path = Path.Combine(BaseDI.Name, relDI.Name);
                //Console.WriteLine(path2);
                DirectoryInfo combinedDI = new DirectoryInfo(BaseDI.FullName);
                //d2 = d;
                if (combinedDI.Exists)
                {
                    recurseDirs(ref combinedDI, ref dg);
                }
                else Console.WriteLine("Dir -{0}- exists not", combinedDI.FullName);
                //else Console.WriteLine(di2.Name);
            }
        }
        else
        {
            Console.WriteLine("Dir -{0}- does not exist.", BaseDI.Name);
        }
    }


    public DirRunner(ref DirectoryInfo di, dirDelegate dg){
		if (di.Exists)
		{
            //Console.WriteLine(path);
            recurseDirs(ref di, ref dg);
            /*foreach (DirectoryInfo d in di.EnumerateDirectories())
			{
				//path2 = Path.Combine(path,f.Name);
				//Console.WriteLine(path2);
				dg(d);
                (ref new DirectoryInfo(di.Name), dg);
			}*/
		}else
		{
			Console.WriteLine("Dir -{0}- does not exist.", di.Name);
		}
	}


}