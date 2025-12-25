using System;

class OTPGenerator{
	
	static Random rnd =new Random();
	public static int GenerateOTP(){
		int otp = rnd.Next(100000,1000000);
		return otp;
	}

	public static bool IsUnique(int[] a){
		for(int i=0;i<a.Length;i++){
			for(int j=i+1;j<a.Length;j++){
				if(a[i] == a[j])
					return false;
			}
		}
		return true;
	}

	static void Main(string[] args){
		int[] otps=new int[10];

		for(int i=0;i<10;i++){
			otps[i] = GenerateOTP();
		}

		for(int i=0;i<10;i++){
			Console.WriteLine(otps[i]);
		}

		if(IsUnique(otps))
			Console.WriteLine("Unique OTPs");
		else
			Console.WriteLine("Duplicate OTPs");
	}
}
