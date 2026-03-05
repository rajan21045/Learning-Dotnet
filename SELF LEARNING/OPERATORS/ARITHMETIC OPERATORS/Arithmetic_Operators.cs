using System;

namespace MyProgram {
class Program {
static void Main(string[] args){

	int sum1 = 20+30;
	int sub = sum1 - 20;
	int mul = sum1*sub;
	int div = mul / sub;
	int mod = div % sum1;
	
	int a = 12;
	Console.WriteLine("Before Incrementing The Value of a Is {0}", a);

	a++;
	Console.WriteLine("After Incrementing The Value of a Is {0}", a);


	double b = 10.1;
	Console.WriteLine("Before Decrementing The Value of b Is {0}", b);

	b--;
	Console.WriteLine("After Decrementing The Value of b Is {0}", b);

	Console.WriteLine("Sum of 20 And 30 Is {0}", sum1);
	Console.WriteLine("After Subtraction, The Value Is {0}", sub);
	Console.WriteLine("After Multiplication of {0} And {1} Is {2}.", sum1, sub, mul);
	Console.WriteLine("After Division of {0} And {1} Is {2}.", mul, sub, div);
	Console.WriteLine("After Modulus of {0} And {1} Is {2}.", div, sum1, mod);
}
}
}