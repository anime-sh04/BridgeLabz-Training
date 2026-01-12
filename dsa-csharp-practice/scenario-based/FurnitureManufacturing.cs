using System;

namespace FurnitureManufacturing
{
    internal class WoodRod
    {
        internal int RodLength = 12;

        internal double[,] PriceList =
        {
            { 1, 3 },
            { 2, 7 },
            { 3, 12 },
            { 4, 19 }
        };

    }

    internal class CarpenterUtility
    {
        private WoodRod w = new WoodRod();

        // Scenario A: Best cut for maximum earnings
        public void BestRevenue()
        {
            double maxRevenue = 0;

            for (int i = 0; i < w.PriceList.GetLength(0); i++)
            {
                int piece = (int)w.PriceList[i, 0];
                double price = w.PriceList[i, 1];

                int remaining = w.RodLength;
                double revenue = 0;

                while (remaining >= piece)
                {
                    revenue += price;
                    remaining -= piece;
                }

                if (revenue > maxRevenue)
                    maxRevenue = revenue;
            }

            Console.WriteLine("Best Revenue = " + maxRevenue);
        }

        // Scenario B: With fixed waste constraint
        public void RevenueWithWasteLimit(int allowedWaste)
        {
            double maxRevenue = 0;

            for (int i = 0; i < w.PriceList.GetLength(0); i++)
            {
                int piece = (int)w.PriceList[i, 0];
                double price = w.PriceList[i, 1];

                int remaining = w.RodLength;
                double revenue = 0;

                while (remaining >= piece)
                {
                    revenue += price;
                    remaining -= piece;
                }

                if (remaining <= allowedWaste && revenue > maxRevenue)
                {
                    maxRevenue = revenue;
                }
            }

            Console.WriteLine("Best Revenue with Waste Constraint = " + maxRevenue);
        }

        // Scenario C: Max revenue + minimal waste
        public void BestCutWithMinimalWaste()
        {
            double bestRevenue = 0;
            int bestWaste = w.RodLength;

            for (int i = 0; i < w.PriceList.GetLength(0); i++)
            {
                int piece = (int)w.PriceList[i, 0];
                double price = w.PriceList[i, 1];

                int remaining = w.RodLength;
                double revenue = 0;

                while (remaining >= piece)
                {
                    revenue += price;
                    remaining -= piece;
                }

                if (revenue > bestRevenue ||
                   (revenue == bestRevenue && remaining < bestWaste))
                {
                    bestRevenue = revenue;
                    bestWaste = remaining;
                }
            }

            Console.WriteLine("Best Revenue = " + bestRevenue);
            Console.WriteLine("Minimal Waste = " + bestWaste + " ft");
        }
    }

    internal class FurnitureCutting
    {
        static void Main(string[] args)
        {
            CarpenterUtility carpenter = new CarpenterUtility();

            Console.WriteLine("-Scenario A-");
            carpenter.BestRevenue();

            Console.WriteLine("\n-Scenario B-");
            Console.WriteLine("Enter Fixed Waste Constraint : ");
            int fixedWaste = int.Parse(Console.ReadLine());
            carpenter.RevenueWithWasteLimit(fixedWaste);

            Console.WriteLine("\n-Scenario C-");
            carpenter.BestCutWithMinimalWaste();
        }
    }
}
