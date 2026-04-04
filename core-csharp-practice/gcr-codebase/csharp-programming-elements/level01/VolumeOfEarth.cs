using System;

class VolumeOfEarth{
	static void Main(string[] args){
		int earthRadius = 6378;
		double volumeOfEarth = (4/3) * Math.PI * Math.Pow(earthRadius,3);
		double volumeOfEarthInMiles = volumeOfEarth*1.6;
		
		Console.WriteLine("The volume of earth in cubic kilometers is " + volumeOfEarth+ " and cubic miles is "+ volumeOfEarthInMiles);
	}
}
