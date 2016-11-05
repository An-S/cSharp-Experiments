/*
 * Created by SharpDevelop.
 * User: MyAcer
 * Date: 22.09.2016
 * Time: 08:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace scanCFunctionPrototypes
{
	class Program
	{
		public static void Main(string[] args)
		{
			string filename = "testfile.c";
			FileStream s = new FileStream(filename, FileMode.Open);
			/*System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
			startInfo.FileName = @"C:\MinGW\bin\cpp.exe ";
			startInfo.Arguments = filename+" -o "+filename+".p";
			//string exename = @"C:\MinGW\bin\cpp.exe "+filename+" -o "+filename+".p";
			System.Diagnostics.Process.Start(startInfo);
			*/
			
			StreamReader r = new StreamReader(s);
		
			string line = r.ReadLine();
			Regex rx = new Regex(@"^(\w+\s*){1,}(\*)*\(.*\)\s*{");
			Match mt;
			string res;
		
			while( line != null){
				
				mt = rx.Match(line);
				res = mt.ToString();
				
				Console.WriteLine(line);
				if (mt.Success){
					Console.WriteLine(res);
				}else{
					Console.WriteLine("not match!");
				}
				line = r.ReadLine();
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}