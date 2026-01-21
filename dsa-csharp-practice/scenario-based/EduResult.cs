namespace EduResults
{
    class EduResult
    {
        static void Main(string[] args)
        {
            int[] district1 = {15,62,90,92,99};
            int[] district2 = {25,32,70,82,95};
            int[] district3 = {5,12,20,89,100};

            // List<int> mainServer = [.. district1, .. district2, .. district3];

            
            List<int> mainServer = new List<int>();

            mainServer.AddRange(district1);
            mainServer.AddRange(district2);
            mainServer.AddRange(district3);         

            int[] merged = mainServer.ToArray();
            EduResult p = new EduResult();
            p.MergeSort(merged,0,merged.Length-1);
            foreach(int i in merged)
            {
                Console.Write(i +",");
            }
        }

        void MergeSort(int[] merge,int left,int right)
        {
        if (left< right)
            {
                int mid = (left + right)/2;

                MergeSort(merge,left, mid);
                MergeSort(merge,mid +1, right);

                Merge(merge,left, mid, right);
            }
        }

        static void Merge(int[] arr,int left, int mid, int right)
        {
            int n1 = mid -left + 1;
            int n2 = right -mid;

            int[] L = new int[n1];
            int[] R = new int[n2];

            for (int i = 0; i <n1; i++)
                L[i] = arr[left +i];

            for (int j = 0; j < n2; j++)
                R[j] = arr[mid + 1 + j];

            int iIndex = 0, jIndex = 0, k = left;

            while (iIndex<n1 && jIndex < n2)
            {
                if (L[iIndex] <= R[jIndex])
                    arr[k++] = L[iIndex++];
                else
                    arr[k++] = R[jIndex++];
            }

            while (iIndex < n1)
                arr[k++] = L[iIndex++];

            while (jIndex < n2)
                arr[k++] = R[jIndex++];
        }
    }
}