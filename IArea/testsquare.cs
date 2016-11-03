using System;

class Mainclass{

public static void Main(){
	Console.WriteLine("Square:");
	Square sqr = new Square(5);
	Console.WriteLine("Area:{0}", sqr.Area);
	Console.WriteLine("Edges:{0}", sqr.Edges);
	Console.WriteLine("Sides:{0}", sqr.Sides);
	Console.WriteLine();
	sqr.Sidelen = 10;
	Console.WriteLine("Sidelen:{0}", sqr.Sidelen);
	Console.WriteLine("Area:{0}", sqr.Area);
	Console.WriteLine("Edges:{0}", sqr.Edges);
	Console.WriteLine("Sides:{0}", sqr.Sides);
	Console.WriteLine();
	sqr.Sidelen = -10;
	Console.WriteLine("Sidelen:{0}", sqr.Sidelen);
	Console.WriteLine("Area:{0}", sqr.Area);
	Console.WriteLine("Edges:{0}", sqr.Edges);
	Console.WriteLine("Sides:{0}", sqr.Sides);
	
}

}
