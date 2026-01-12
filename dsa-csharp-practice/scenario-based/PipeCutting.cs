using System;

namespace MetalFactoryPipeCutting
{
    internal class Pipe
    {
        internal int PipeLength = 8;
        internal double[,] PriceAndSize =
        {
            { 1, 5 },
            { 2, 9 },
            { 3, 18 },
            { 4, 29 }
        };
    }

    internal class PipeUtility
    {
        private Pipe p = new Pipe();

        // Scenario A: Optimized Revenue
        public void MaxRevenue()
        {
            double maxRevenue = 0;

            for (int i = 0; i < p.PriceAndSize.GetLength(0); i++)
            {
                int cutLength = (int)p.PriceAndSize[i, 0];
                double price = p.PriceAndSize[i, 1];

                int remaining = p.PipeLength;
                double revenue = 0;

                while (remaining >= cutLength)
                {
                    revenue += price;
                    remaining -= cutLength;
                }

                if (revenue > maxRevenue)
                {
                    maxRevenue = revenue;
                }
            }

            Console.WriteLine("Optimized Revenue = " + maxRevenue);
        }

        // Scenario C: Non-Optimized Revenue
        public void NonOptimizedRevenue()
        {
            double revenue = 0;

            for (int i = 0; i < p.PriceAndSize.GetLength(0); i++)
            {
                int cutLength = (int)p.PriceAndSize[i, 0];
                double price = p.PriceAndSize[i, 1];

                if (cutLength <= p.PipeLength)
                {
                    revenue = price;
                    break;
                }
            }

            Console.WriteLine("Non-Optimized Revenue = " + revenue);
        }

        // Scenario B: Custom Order
        public void CustomOrder(int[] order)
        {
            double revenue = 0;

            for (int i = 0; i < order.Length; i++)
            {
                for (int j = 0; j < p.PriceAndSize.GetLength(0); j++)
                {
                    if (order[i] == p.PriceAndSize[j, 0])
                    {
                        revenue += p.PriceAndSize[j, 1];
                        break;
                    }
                }
            }

            Console.WriteLine("Custom Order Revenue = " + revenue);
        }
    }

    internal class PipeCutting
    {
        static void Main(string[] args)
        {
            PipeUtility pipe = new PipeUtility();

            Console.WriteLine("-Optimized Cutting-\n");
            pipe.MaxRevenue();

            Console.WriteLine("-Non-Optimized Cutting-\n");
            pipe.NonOptimizedRevenue();

            Console.WriteLine("-Custom Order-\n");

            Console.Write("Enter number of pieces: ");
            int num = int.Parse(Console.ReadLine());

            int[] order = new int[num];

            Console.WriteLine("Enter lengths of pieces:");
            for (int i = 0; i < num; i++)
            {
                order[i] = int.Parse(Console.ReadLine());
            }

            pipe.CustomOrder(order);
        }
    }
}
