using System;

class Datatypes{
	static void Main(string[] args){
		
		// Primitive Datatypes
		int a = 10; //Can store Integer Value like 2,3,345 etc
		long b = 100000000000000000; // Can store Integer Value like 2,3,345 etc
		float c = 12.4f; // Can store Decimal Value like 0.2,1.44,4.02 etc
		double d = 12.4444444444444444444; // Can store Decimal Value like 1.122,3.242,20.345 etc
		char e = 'a'; // Can store a Character Value like 'a', 'w' , 't' etc
		bool f = true; // Can store Boolean Value like true , false 
		
		// Datatype Conversion
		
		// Implicit Conversion
		int i = 12;
		double j = i;

		int o = 15;
		long k = o;
		
		Console.WriteLine(j);
		Console.WriteLine(k);
		
		// Explicit Conversion
		
		double q = 122.23;
		int r = (int)q; // r = 122
		
		Console.WriteLine(r);
	}
}

		