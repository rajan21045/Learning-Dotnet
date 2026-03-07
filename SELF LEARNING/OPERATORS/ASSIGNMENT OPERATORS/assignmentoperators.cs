using System;
namespace MyProgram{
		class Program{
			static void Main(string[] args){
				// 1. = (Simple Assignment)
				// Assigns a value to a variable.
				int x = 20;
				Console.WriteLine("Value of x: " + x);

				// 2. += (Add and Assign)
				// Adds a value to the variable and assigns the result.
				int e = 10;
				e += 5;   // e = e + 5
				Console.WriteLine(e);

				// 3. -= (Subtract and Assign)
				// Subtracts a value from the variable and assigns the result.
				int f = 10;
				f -= 3;   // f = f - 3
				Console.WriteLine(f);

				// 4. *= (Multiply and Assign)
				int g = 5;
				g *= 4;   // g = g * 4
				Console.WriteLine(g);

				// 5. /= (Divide and Assign)
				int h = 20;
				h /= 5;   // h = h / 5
				Console.WriteLine(h);

				//6. %= (Modulus and Assign)
				int y = 10;
				y %= 3;   // y = y % 3
				Console.WriteLine(y);

				// 7. <<= (Left Shift and Assign)
				// Shifts bits to the left.
				int z = 5;   // Binary: 0101
				z <<= 2;     // Shift left by 2
				Console.WriteLine(z);
				// Explanation:
				// 5 << 2 = 20

				// 8. >>= (Right Shift and Assign)
				int a = 20;  // Binary: 10100
				a >>= 2;     // Shift right by 2
				Console.WriteLine(a);

				// 9. &= (Bitwise AND and Assign)
				int b = 6;   // 110
				b &= 3;      // 011
				Console.WriteLine(b);

				// 10. |= (Bitwise OR and Assign)
				int c = 4;   // 100
				c |= 2;      // 010
				Console.WriteLine(c);

				// 11. ^= (Bitwise XOR and Assign)
				int d = 5;   // 101
				d ^= 3;      // 011
				Console.WriteLine(d);
		}
	}
}