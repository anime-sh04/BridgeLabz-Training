using System;

class YoungestAndTallest
{
    public static int Youngest(int[] age){
        int minAge = age[0];

        for (int i=1;i<age.Length;i++){
            if (age[i]< minAge)
                minAge = age[i];
        }
        return minAge;
    }

    public static double Tallest(double[] height){
        double maxHeight = height[0];

        for (int i=1;i<height.Length;i++)
        {
            if (height[i]> maxHeight)
                maxHeight = height[i];
        }

        return maxHeight;
    }

    static void Main(string[] args){
        string[] names = {"Amar","Akbar","Anthony"};

        int[] age = new int[3];
        double[] height = new double[3];

        for (int i=0;i<3;i++){
            Console.WriteLine("Enter age :" + names[i]);
            age[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter height :" + names[i]);
            height[i] = double.Parse(Console.ReadLine());
        }

        int youngestAge = Youngest(age);
        double tallestHeight = Tallest(height);

        Console.WriteLine("Youngest Age: " + youngestAge);
        Console.WriteLine("Tallest Height: " + tallestHeight);
    }
}
