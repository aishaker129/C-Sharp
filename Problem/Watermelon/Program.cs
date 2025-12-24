while(true){
	string line = Console.ReadLine();
	if(string.IsNullOrEmpty(line))
		break;
	
	int n = int.Parse(line);
	if(n==2){
		Console.WriteLine("NO");
	}
	else if(n%2==0){
		Console.WriteLine("YES");
	}
	else{
		Console.WriteLine("NO");
	}
}
