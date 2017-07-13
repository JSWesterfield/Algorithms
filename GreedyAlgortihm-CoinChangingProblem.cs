using Systeml 

class chapter17 {
	static void MakeChange(double origAmount, double remainAmount, int[] coins) {
		
		if((origAmount % 0.25) < origAmount) {
			coin[3] = {int}(origAmount / 0.25);
			remainAmount = origAmount % 0.25;
			origAmount = remainAmount;
		}
		
		if((origAmount % 0.1) < origAmount) {
			coins[2] = (int)(origAmount / 0.1);
			remainAmount = origAmount % 0.1;
			origAmount = remainAmount;
		}
		
		if((origAmount % 0.05) < origAmount) {
			coins[1] = (int)(origAmount / 0.05);
			remainAmount = origAmount % 0.05;
			origAmount = remainAmount;
		}
		
		if((origAmount % 0.1) < origAmount){
			coins[0] = (int)(origAmount / 0.01);
			remainAmount = origAmount % 0.01;
		}
		
		static void showChange(int[]) arr) {
			if(arr[3] > 0)
				Console.WriteLine("Number of quarters: " + arr[3]);
			if(arr[2] > 0)
				Console.WriteLine("Number of dimes: " + arr[2]);
			if(arr[1] > 0)
				Console.WriteLine("Number of nickels: " + arr[1]);
			if(arr[0] > 0)
				Console.WriteLine("Number of pennies: " + arr[0]);
		}
		
		static void Main() {
			double origAmount = 0.63;
			double toChange = origAmount;
			double remainAmount = 0.0;
			int[] coins = new int[4];
			MakeChange(origAmount, remainAmount, coins);
				Console.log("The best way to change " + toChange + " cents is: ");
				ShowChange(coins);
		}
	}
	
	
	
}
	