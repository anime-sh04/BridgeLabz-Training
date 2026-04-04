using System;

class TravelComputation {
    static void Main(string[] args) {
		
	  //Taking inputs
	  string name = Console.ReadLine();
      string fromCity = Console.ReadLine();
	  string viaCity = Console.ReadLine();
	  string toCity = Console.ReadLine();

      double distanceFromToVia = Convert.ToDouble(Console.ReadLine());
      double timeFromToVia = Convert.ToDouble(Console.ReadLine());
      double distanceViaToFinalCity = Convert.ToDouble(Console.ReadLine());
      double timeViaToFinalCity = Convert.ToDouble(Console.ReadLine());

      double totalDistance = distanceFromToVia + distanceViaToFinalCity;
      double totalTime = timeFromToVia + timeViaToFinalCity;

      Console.WriteLine("The results of the trip are: totalDistance "+totalDistance+", totalTime "+ totalTime+ "hr" );
   }
}