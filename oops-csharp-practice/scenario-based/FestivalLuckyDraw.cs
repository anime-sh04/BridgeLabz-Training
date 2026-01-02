using System;
class Draw{
	public void CheckWinner(int chosenNumber){
		if(chosenNumber%3 == 0 && chosenNumber%5 == 0)
			Console.WriteLine("Congratulations you won!");
		else
			Console.WriteLine("Better luck next time");
	}
}

class FestivalLuckyDraw{
	static void Main(string[] args){
		
		Draw winnerChecker=new Draw();
		
		while(true){
			Console.WriteLine("Enter Choice");
			Console.WriteLine("1. Play");
			Console.WriteLine("2. Exit");
			int choice =int.Parse(Console.ReadLine());
			switch(choice){
				case 1:
					Console.WriteLine("Choose a number :");
					int chose=int.Parse(Console.ReadLine());
					if(chose<=0){
						Console.WriteLine("Enter number > 0");
						continue;
					}
					winnerChecker.CheckWinner(chose);
					break;
				case 2:
					return;
				default:
					Console.WriteLine("Invalid Choice");
					break;
			}
		}
	}
}