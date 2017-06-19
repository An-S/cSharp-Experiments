using System;

namespace TryCatchTest
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string lineStr;
			bool exit = false;

			while (!exit) {
				Console.Write ("Input Integer: ");
				lineStr = Console.ReadLine();
				lineStr.Trim('\n','\t','\r');
				if (lineStr.Equals ("exit")) {
					exit = true;
					continue;
				}	
				try{
					int val = Convert.ToInt32(lineStr);
					Console.WriteLine("Value: {0}",val); 
				}
				catch (OverflowException){
					Console.WriteLine("Input {0} is outside range.", lineStr);
				}
				catch (FormatException){
					Console.WriteLine ("Input {0} has wrong format.", lineStr);
				}
				catch{
					Console.WriteLine ("Other exception!");
				}
			}

		}
	}
}
