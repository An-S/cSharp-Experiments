using System;
public class readnum{
	public static int input(string text){
		int num = 0;
		do{
			Console.WriteLine(text);

			try{
				num = int.Parse( Console.ReadLine() );
				break;
			}

			catch(Exception e){
				Console.WriteLine ("Wrong input format. Probably not a number.");
			}
		}while(true);
		return num;
	}

	public static void Main(){
		int number1, number2;

		number1 = input("Please enter a number:");
		Console.WriteLine ("Thank you.");
		number2 = input("Enter one more number:");
		
		Console.WriteLine ("Adding the two numbers: " + (number1 + number2));

		Console.ReadKey(true);
	}
}
