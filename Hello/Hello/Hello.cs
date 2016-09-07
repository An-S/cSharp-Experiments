/*
 * Created by SharpDevelop.
 * User: User
 * Date: 05.09.2016
 * Time: 21:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Hello
{
	class Program
	{
		public static void Main(string[] args)
		{
			string[][] str = new string[3][];
			str[0] = new string[] {"1", "2", "3"};
			str[1] = new string[] {"1", "2", "3", "4","5"};
			str[2] = new string[] {"1", "2", "3", "4"};
				
			Console.WriteLine("Hello World!");
			
			Console.Write("You gave following args to the program: ");
			foreach (string s in args) {
				Console.Write(s+" ");
			}
			Console.WriteLine();
			int j = 0;
			
			foreach (string[] strrow in str){
				int i = 0;
				foreach (string s in strrow) {
					
					Console.Write(j.ToString()+"/"+i.ToString()+" "+s+" ");
					++i;
				}
				Console.WriteLine();
				++j;
			}
			Console.WriteLine();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}