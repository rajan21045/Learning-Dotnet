using System;
namespace MyProgram{
	class Program{
		static void Main(string[] args){
			int i = 0;
			while(i<=5){
				Console.WriteLine(i);
				i++;
			}
			Console.WriteLine();
			int j =1;
			while(j<=5){
				Console.WriteLine(j*2);
				j++;
			}
		}
	}
}