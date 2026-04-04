namespace Sorting
{
    class AadharUtilityImpl:ICard
    {
        int getMax(long[] card,int len) 
        { 
            int count =0; 
            int max =0; 
            foreach(long i in card) 
            { 
                string temp = i.ToString();
                foreach(char j in temp) 
                { 
                    count++;
                }

                if (count > max) 
                {
                    max = count;
                }
                count =0;
            }
            return max;
        } 

        void CountSort(long[] card, int len, long exp)
        {
            long[] output = new long[len];
            int[] count = new int[10];

            for (int i = 0; i < len; i++)
            {
                int index = (int)((card[i] / exp) % 10);
                count[index]++;
            }
            
            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }
            for (int i = len - 1; i >= 0; i--)
            {
                int index = (int)((card[i] / exp) % 10);
                output[count[index] - 1] = card[i];
                count[index]--;
            }

            for (int i = 0; i < len; i++)
            {
                card[i] = output[i];
            }
        }

        public void SortAadhar(long[] card, int len)
        {
            int maxDigits = getMax(card, len);

            long exp = 1;
            for (int i = 0; i < maxDigits; i++)
            {
                CountSort(card, len, exp);
                exp *= 10;
            }

            Console.WriteLine("Sorted Aadhar Card Numbers:");
            foreach (long i in card)
            {
                Console.WriteLine(i);
            }
        }

        public void FindAadhar(long[] card,int n)
        {
            int low = 0;
            int high = n;
            Console.WriteLine("Enter Aadhar Card to search");
            long key = long.Parse(Console.ReadLine());
            while(low<=high){
                int mid = (low+high)/2;

                if (key == card[mid])
                {
                    Console.WriteLine($"Found at {mid}");
                    return;
                }
                else if(key > card[mid])
                {
                    low = mid+1;
                }
                else if (key < card[mid])
                {
                    high = mid+1;
                }
            }
            Console.WriteLine("Not Found");
        }

    }
}