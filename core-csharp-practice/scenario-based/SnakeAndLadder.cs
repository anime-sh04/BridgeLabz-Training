using System;

class SnakeAndLadder{
	static Random rnd = new Random();
	public static int RollDice(){
		int dice = rnd.Next(1,7);
		
		return dice;
	}
	
	public static int[] MovePlayer(int[] players){
		int temp =0;
		int apply =0;
		int t =0;
		for(int i=0;i<players.Length;i++){
			temp =0;
			apply =0;
			t=0;
			temp = RollDice();
			Console.WriteLine("Player "+(i+1)+" rolled dice and got :" + temp);
			apply = temp + ApplySnakeOrLadder(players[i], temp);
			t = players[i] + apply;
			if(CheckWin(t)){
				players[i] = -1;
				break;
			}
			
			if(t>100)
				continue;
			else
				players[i] = t;
			/* Console.WriteLine(temp);
			Console.WriteLine(apply);
			Console.WriteLine(t); */
		}
		return players;
	}
	
	public static int ApplySnakeOrLadder(int move, int n){
		int temp = move+n;
		if(temp == 9)
			return 18;
		else if(temp == 25)
			return 29;
		else if(temp == 56)
			return 8;
		else if(temp == 76)
			return 21;
		else if(temp == 16)
			return -9;
		else if(temp == 63)
			return -44;
		else if(temp == 99)
			return -72;
		else if(temp == 59)
			return -42;
		else
			return 0;
	}
	
	public static bool CheckWin(int i){
		if(i == 100)
			return true;
		else
			return false;
	}
	
	
	static void Main(string[] args){		
		Console.WriteLine("Enter Number Of Players");
		int numberOfPlayers = int.Parse(Console.ReadLine());
		
		int[] players = new int[numberOfPlayers];
		
		bool f= true;
		
		
		while(f){
			Console.WriteLine("==========================================");
			Console.WriteLine("1. Play Moves");
			Console.WriteLine("2. Exit");
			Console.WriteLine("==========================================");
			int choose = int.Parse(Console.ReadLine());
			switch(choose){
				case 1:
					players = MovePlayer(players);
					for(int i=0;i<numberOfPlayers;i++){
						if(players[i] == -1){
							Console.WriteLine("PLAYER "+(i+1)+" WON THE GAME");
							f = false;
							break;
						}
						Console.WriteLine("Player "+(i+1)+" at "+ players[i]);
					}
					break;
				case 2:
					f = false;
					break;
					
				default:
					Console.WriteLine("Enter A Valid Choice");
					break;
			}
		}
	}
}
				
				