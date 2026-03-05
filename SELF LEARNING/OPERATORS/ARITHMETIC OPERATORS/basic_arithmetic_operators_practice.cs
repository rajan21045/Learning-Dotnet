using System;
namespace MyProgram{
	class Program{
		static void Main(string[] args){
			/*
			1. Basic Arithmetic Practice
			Question 1. Write a program to add two numbers and display the result.
			*/
			Console.Write("Doing Sum of Two Numbers.");
			Console.WriteLine();
			Console.Write("Enter The First Number: ");
			int num1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter The Second Number: ");
			int num2 = Convert.ToInt32(Console.ReadLine());
			int sum = num1 + num2;
			Console.WriteLine();
			Console.WriteLine("The Sum of {0} And {1} Is {2}.", num1, num2, sum);


			// Question 2: Write a program to subtract two numbers.
			Console.WriteLine();
			Console.WriteLine("Doing Substraction of Two Numbers.");
			int sub = num1 - num2;
			Console.WriteLine("The Substraction of {0} And {1} Is {2}.", num1, num2, sub);
			
			//Question 3 Write a program to multiply two numbers.
			Console.WriteLine();
			Console.WriteLine("Doing Multiply of Two Numbers.");
			int mul = num1 * num2;
			Console.WriteLine("The Multiply of {0} And {1} Is {2}.", num1, num2, mul);

			// Question 4 Write a program to divide two numbers and print the result.
			Console.WriteLine();
			Console.WriteLine("Doing Divide of Two Numbers.");
			int div = num1 / num2;
			Console.WriteLine("The Divide of {0} And {1} Is {2}.", num1, num2, div);

			// Question 5 Write a program to find the remainder when one number is divided by another using %.
			Console.WriteLine();
			Console.WriteLine("Doing Program To Find The Remainder When One Number Is Divided By Another Using %.");
			int mod = num1 % num2;
			if(mod == 0){
			Console.WriteLine("One Number Is Divided By Another Using %.");
			}else{
			Console.WriteLine("One Number Is Not Divided By Another Using %.");
			}

		}
	}
}
