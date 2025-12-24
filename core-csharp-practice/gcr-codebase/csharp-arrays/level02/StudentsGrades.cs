using System;

class StudentsGrades
{
    static void Main(string[] args)
    {
        int numberOfStudents = int.Parse(Console.ReadLine());

        int[] physics = new int[numberOfStudents];
        int[] chemistry = new int[numberOfStudents];
        int[] maths = new int[numberOfStudents];
        double[] percentage = new double[numberOfStudents];
        char[] grade = new char[numberOfStudents];

        for (int i=0; i<numberOfStudents; i++)
        {
            Console.WriteLine("Student " + (i+1));
            Console.Write("Enter Phy marks: ");
            int p = int.Parse(Console.ReadLine());

            Console.Write("Enter Chem marks: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("Enter Maths marks: ");
            int m = int.Parse(Console.ReadLine());

            if (p <0|| c<0 || m<0){
                Console.WriteLine("Marks must be positive. Re-enter this student.");
                i--;
                continue;
            }
            physics[i] = p;
            chemistry[i] = c;
            maths[i] = m;
			
            int total = p + c + m;
            percentage[i] = total/3;

            if(percentage[i] >=80)
                grade[i] = 'A';
            else if(percentage[i] >=70 && percentage[i] <=79)
                grade[i] = 'B';
            else if(percentage[i] >=60 && percentage[i] <=69)
                grade[i] = 'C';
            else if(percentage[i] >=50 && percentage[i] <=59)
                grade[i] = 'D';
            else if(percentage[i] >=40 && percentage[i] <=49)
                grade[i] = 'E';
			else
				grade[i] = 'R';
        }

        for(int i=0;i< numberOfStudents;i++){
            Console.WriteLine((i+1)+"," +physics[i] +"," +chemistry[i]+ "," +maths[i]+ "," +percentage[i] + "%,"+grade[i]);
        }
    }
}
