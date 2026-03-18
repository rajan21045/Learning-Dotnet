using System;
class swtichStatementPractice
{
    static void Main()
    {
        // 1. Write a C# program that takes a number (1–7) and prints the corresponding day of the week using a switch statement.
        Console.Write("Enter A Number Between 1 - 7: ");
        int day = Convert.ToInt32(Console.ReadLine());
        switch (day)
        {
            case 1:
                Console.WriteLine("Sunday");
                break;

            case 2:
                Console.WriteLine("Monday");
                break;

            case 3:
                Console.WriteLine("Tuesday");
                break;

            case 4:
                Console.WriteLine("Wednesday");
                break;

            case 5:
                Console.WriteLine("Thursday");
                break;

            case 6:
                Console.WriteLine("Friday");
                break;

            case 7:
                Console.WriteLine("Saturday");
                break;

            default:
                Console.WriteLine("Invalid Input. Please Enter A Number Between 1 - 7");
                break;
        }

        // 2. Write a program that takes a character grade (A, B, C, D, F) and prints a message like "Excellent", "Good", "Average", etc.
        Console.Write("Enter A Character Grade (A, B, C, D, F): ");
        char grade = Convert.ToChar(Console.ReadLine().ToUpper());
        switch (grade)
        {
            case 'A':
                Console.WriteLine("Excellent");
                break;

            case 'B':
                Console.WriteLine("Good");
                break;

            case 'C':
                Console.WriteLine("Average");
                break;

            case 'D':
                Console.WriteLine("Below Average");
                break;

            case 'F':
                Console.WriteLine("Failing");
                break;

            default:
                Console.WriteLine("Invalid Input. Please Enter A Character Grade (A, B, C, D, F)");
                break;
        }

        //3. Using switch, write a simple calculator that takes two numbers and an operator (+, -, *, /) and performs the operation.
        Console.Write("Enter Operator (+, -, *, /): ");
        char operator1 = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter First Number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        switch (operator1)
        {
            case '+':
                int sum = num1 + num2;
                Console.WriteLine("The Sum of {0} And {1} Is {2}.", num1, num2, sum);
                break;

            case '-':
                if (num1 > 0 && num2 > 0)
                {
                    int diff = num2 - num1;
                    Console.WriteLine("The Difference of {0} And {1} Is {2}.", num2, num1, diff);
                }
                break;

            case '*':
                int mul = num1 * num2;
                Console.WriteLine("The Multification of {0} And {1} Is {2}.", num1, num2, mul);
                break;

            case '/':
                int div = num1 / num2;
                Console.WriteLine("The Division of {0} And {1} Is {2}.", num1, num2, div);
                break;

            default:
                Console.WriteLine("Please Entered Between This Operator (+, -, *, /).");
                break;
        }

        // 4. Write a program using switch that takes a month number (1–12) and prints the number of days in that month. Handle February as 28 days.
        Console.Write("Enter month number (1-12): ");
        int month = int.Parse(Console.ReadLine());

        switch (month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Console.WriteLine("Days: 31");
                break;

            case 4:
            case 6:
            case 9:
            case 11:
                Console.WriteLine("Days: 30");
                break;

            case 2:
                Console.WriteLine("Days: 28");
                break;

            default:
                Console.WriteLine("Invalid month number!");
                break;
        }

    }
}