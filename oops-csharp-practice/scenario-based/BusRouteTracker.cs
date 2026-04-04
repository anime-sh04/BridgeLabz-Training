using System;

class Route{
    private static float[] Distance;

    public Route(){
        Distance = new float[]{120.0f,175.5f,200.0f,155.7f,90.4f,110.8f};
    }

    public float StartJourney(){
        float totalDistance = 0;

        while(true){
            Console.WriteLine("1. Start Journey");
            Console.WriteLine("2. Exit");
            Console.Write("Enter choice: ");
			
            int n = int.Parse(Console.ReadLine());

            switch(n){
                case 1:
                    Console.Write("Enter number of passengers: ");
                    int numberOfPassenger = int.Parse(Console.ReadLine());

                    int end = 1;
                    while(numberOfPassenger > 0 && end <= Distance.Length){
                        Console.WriteLine("Currently at end " + end);
                        Console.WriteLine("1. Passengers get off");
                        Console.WriteLine("2. No one gets off");
                        Console.Write("Enter choice: ");

                        int n2 = int.Parse(Console.ReadLine());

                        if(n2 == 1){
                            Console.Write("Passengers getting off: ");
                            int num = int.Parse(Console.ReadLine());

                            if(num > numberOfPassenger){
                                Console.WriteLine("Not that many passengers!");
                                continue;
                            }
                            numberOfPassenger -= num;
                        }

                        totalDistance += Distance[end-1];
                        end++;
                    }

                    Console.WriteLine("Journey ended.");
                    break;
                case 2:
                    return totalDistance;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
                
            }
        }
    }
}

class BusRouteTracker{
    static void Main(string[] args){
        Route start = new Route();
        Console.WriteLine("Total distance travelled: " + start.StartJourney());
    }
}
