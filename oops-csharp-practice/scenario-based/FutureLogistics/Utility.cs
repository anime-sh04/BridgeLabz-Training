using System.Text.RegularExpressions;

class Utility
{
    public GoodsTransport parseDetails(string input)
    {
        string[] data = input.Split(':');

        if (data[3].Equals("BrickTransport"))
        {
            string id = data[0];
            string date = data[1];
            int rating = int.Parse(data[2]);
            int distance = int.Parse(data[4]);
            int quantity = int.Parse(data[5]);
            float price = float.Parse(data[6]);

            GoodsTransport transport =new BrickTransport(id, date, rating, distance, quantity, price);
            return transport;
        }
        else
        {
            string id = data[0];
            string date = data[1];
            int rating = int.Parse(data[2]);
            float length = float.Parse(data[4]);
            float radius = float.Parse(data[5]);
            string type = data[6];
            float price = float.Parse(data[7]);

            GoodsTransport transport =
                new TimberTransport(id, date, rating, length, radius, type, price);

            return transport;
        }

    }
    public bool validateTransportId(string transportId)
    {
        string pattern = @"^(RTS)[0-9]{3}[A-Z]$";
        return Regex.IsMatch(transportId, pattern);
    }

    public string findObjectType(GoodsTransport goodsTransport)
    {
        if(goodsTransport is TimberTransport)
        {
            return "TimberTransport";
        }
        else
        {
            return "BrickTransport";
        }
    }
}