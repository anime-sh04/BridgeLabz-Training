using System;

class Menu{
	public static string[] items;
	
	public Menu(){
		items = new string[]{"Burger","Pizza","Sandwich","Pasta","Noodles","Fried Rice","Idli","Dosa","Samosa","Coffee"};
	}
	public void DisplayMenu(){
		int i=1;
		Console.WriteLine("---Items Today---");
		foreach(string s in items){
			Console.WriteLine(i+". "+ s);
			i++;
		}
	}
	
	public void GetItemByIndex(int[] arr){
		for(int i =0;i<arr.Length;i++)
			Console.WriteLine(items[arr[i]-1] + " - Ordered");
		Console.WriteLine("Have a Nice Day!");
	}
}
class CafeteriaApp{
	
	static void Main(string[] args){
		CafeteriaApp app = new CafeteriaApp();
		app.input();
	}
	
	void input(){
		Menu obj = new Menu();
		
		while(true){
			Console.WriteLine("----------------");
			Console.WriteLine("1. Display Menu");
			Console.WriteLine("2. Order by Index");
			Console.WriteLine("3. Exit");
			int n = int.Parse(Console.ReadLine());
			if(n == 1)
				obj.DisplayMenu();
			else if(n==2){
				Console.WriteLine("Enter the amount of items you want to order : ");
				int amount = int.Parse(Console.ReadLine());
				int[] toOrder = new int[amount];
				Console.WriteLine("Enter the indexes : ");
				for(int i=0;i<amount;i++)
					toOrder[i] = int.Parse(Console.ReadLine());
					
				obj.GetItemByIndex(toOrder);
			}
			else if(n==3)
				return;
			else
				Console.WriteLine("Invalid Choice");
		}
	}
}
	