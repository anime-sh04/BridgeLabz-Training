class UserInterface
{
    static void Main()
    {
        Console.WriteLine("Enter the Goods Transport details");
        string input = Console.ReadLine();

        Utility utility = new Utility();
        GoodsTransport transport = utility.parseDetails(input);

        string type = utility.findObjectType(transport);

        if (!utility.validateTransportId(transport.transportId))
        {
            Console.WriteLine($"Transport id {transport.transportId} is invalid\nPlease provide a valid record");
            return;
        }
        Console.WriteLine("Transporter id : " + transport.transportId);
        Console.WriteLine("Date of transport : " + transport.transportDate);
        Console.WriteLine("Rating of the transport : " + transport.transportRating);

        if (type.Equals("BrickTransport"))
        {
            BrickTransport bt = (BrickTransport)transport;
            Console.WriteLine("Quantity of bricks : " + bt.brickQuantity);
            Console.WriteLine("Brick price : " + bt.brickPrice);
        }
        else
        {
            TimberTransport tt = (TimberTransport)transport;
            Console.WriteLine("Type of the timber : " + tt.timberType);
            Console.WriteLine("Timber price per kilo : " + tt.timberPrice);
        }

        Console.WriteLine("Vehicle for transport : " + transport.vehicleSelection());
        Console.WriteLine("Total charge : " + transport.calculateTotalCharge());
    }
}
