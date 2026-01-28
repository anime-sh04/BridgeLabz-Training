using System;
using System.Text.RegularExpressions;

class UserInterface
{
    static void Main()
    {
        FlightUtil u = new FlightUtil();

        Console.WriteLine("Enter Flight Details : ");
        string details = Console.ReadLine();

        Regex regex = new Regex(@"^([^:]+):([^:]+):(\d+):(\d+)$");
        Match match = regex.Match(details);

        try
        {
            if (!match.Success)
            {
                throw new InvalidFlightException("Give a Valid Input");
            }

            string flightNumber = match.Groups[1].Value;
            string flightName = match.Groups[2].Value;
            int passengerCount = int.Parse(match.Groups[3].Value);
            long currentFuelLevel = long.Parse(match.Groups[4].Value);

            if (u.ValidateFlightNumber(flightNumber))
            {
                Console.WriteLine("Flight details are valid");
                if (u.ValidateFlightName(flightName))
                {
                    Console.WriteLine("Flight Name is valid");
                    if (u.ValidatePassengerCount(passengerCount,flightName))
                    {
                        Console.WriteLine("Passenger Count is valid");
                        Console.WriteLine("Required Fuel to fill the tank : " + u.CalculateFuelToFillTank(flightName,currentFuelLevel));
                    }
                }
            }
        }
        catch (InvalidFlightException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
