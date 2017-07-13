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
	}
	
	
	
}
	