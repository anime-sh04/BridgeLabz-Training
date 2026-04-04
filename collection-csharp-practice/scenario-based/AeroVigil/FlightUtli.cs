using System.Text.RegularExpressions;

class FlightUtil
{
    private Dictionary<string, int> data = new Dictionary<string, int> { { "SpiceJet", 396 }, { "Vistara", 615 }, { "IndiGo", 230 }, { "Air Arabia", 130 } };
    public bool ValidateFlightNumber(string flightNumber)
    {
        string pattern = @"^FL-[1-9]\d{3}$";
        if(Regex.IsMatch(flightNumber,pattern))
        {
            return true;
        }
        else
        {
            throw new InvalidFlightException($"The flight number {flightNumber} is invalid");
        }
    }
    public bool ValidateFlightName(string flightName)
    {
        if(data.ContainsKey(flightName))
        {
            return true;
        }
        throw new InvalidFlightException($"The flight name {flightName} is invalid");
    }
    public bool ValidatePassengerCount(int passengerCount,string flightName)
    {
        foreach(var kvp in data)
        {
            if(kvp.Key == flightName)
            {
                if(passengerCount >kvp.Value || passengerCount <=0)
                {
                    throw new InvalidFlightException($"The passenger {passengerCount} is invalid for {flightName}");
                }
            }
        }
        return true;
    }
    public double CalculateFuelToFillTank(string flightName,double currentFuelLevel)
    {
        Dictionary<string, int> fueldata = new Dictionary<string, int> { { "SpiceJet", 200000 }, { "Vistara", 300000 }, { "IndiGo", 250000 }, { "Air Arabia", 150000 } };

        foreach(var kvp in fueldata)
        {
            if(kvp.Key == flightName)
            {
                if(currentFuelLevel >kvp.Value || currentFuelLevel <0)
                {
                    throw new InvalidFlightException($"The passenger {currentFuelLevel} is invalid for {flightName}");
                }
                else
                {
                    return kvp.Value - currentFuelLevel;
                }
            }
        }
        return 0;
    }
}