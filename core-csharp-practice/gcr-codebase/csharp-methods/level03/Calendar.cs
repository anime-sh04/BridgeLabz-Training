using System;

class CalendarProgram{
	public static string GetMonthName(int m){
		string[] months={"Jan","Feb","March","April","May","June","July","August","Sept","Oct","Nov","Dec"};
		
		return months[m-1];
	}

	public static bool IsLeapYear(int y){
		if(y%400==0)
			return true;
		if(y%100==0)
			return false;
		if(y%4==0)
			return true;
		return false;
	}

	public static int GetDaysInMonth(int m,int y){
		int[] days={31,28,31,30,31,30,31,31,30,31,30,31};
		if(m==2 && IsLeapYear(y))
			return 29;
		return days[m-1];
	}

	public static int GetFirstDay(int m,int y){
		int d=1;
		int y0=y-(14-m)/12;
		int x=y0+y0/4-y0/100+y0/400;
		int m0=m+12*((14-m)/12)-2;
		int d0=(d+x+(31*m0)/12)%7;
		return d0;
	}

	static void Main(string[] args){
		int month=int.Parse(Console.ReadLine());
		int year=int.Parse(Console.ReadLine());

		string monthName=GetMonthName(month);
		int days=GetDaysInMonth(month,year);
		int firstDay=GetFirstDay(month,year);

		Console.WriteLine("\n"+monthName+" "+year);
		Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

		for(int i=0;i<firstDay;i++){
			Console.Write("    ");
		}

		for(int day=1;day<=days;day++){
			Console.Write(day + "   ");
			if((day+firstDay)%7==0)
				Console.WriteLine();
		}
		Console.WriteLine();
	}
}
