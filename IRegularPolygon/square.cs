using System;

public class Square:IRegularPolygon{
	double sidelen;
	public Square(double len=1){	
		Sidelen = len;
		Console.WriteLine("Created square with len: {0}", Sidelen);
	}
	
	public int Edges{
		get {return 4;}
	}
	public int Sides{
		get {return 4;}
	}
	public double Area{
		get {return Sidelen*Sidelen;}
	}
	public double Sidelen{
		get {return sidelen;}
		set {
			if (value > 0){
				sidelen = value;
			}else{
				Console.WriteLine("Error: Sidelen <= 0");
			}
		}
	}
}

