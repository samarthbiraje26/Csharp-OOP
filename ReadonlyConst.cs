using System;

class Program {
	const float PI = 3.14f;
	static void Main (string[] args) {
		//Const variables are static in nature
		//so we can access them by using class name 
		Console.WriteLine(Program.PI);
		//We can also access them directly within the same class
		Console.WriteLine(PI);
		//We can also declare a constant variable within a function
		const int Number = 10;
		Console.WriteLine(Number);
		//Once after declaration we cannot change the value 
		//of a constant variable. So, the below line gives an error
		//Number = 20;
		Console.ReadLine();
	}
}
}
