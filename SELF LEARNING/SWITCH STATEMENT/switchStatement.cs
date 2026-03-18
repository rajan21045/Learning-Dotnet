/* C# Switch
C# Switch Statements
Use the switch statement to select one of many code blocks to be executed.

Syntax
switch(expression) 
{
  case x:
    // code block
    break;
  case y:
    // code block
    break;
  default:
    // code block
    break;
}

This is how it works:
    1. The switch expression is evaluated once
    2. The value of the expression is compared with the values of each case
    3. If there is a match, the associated block of code is executed
    4. The break and default keywords will be described later in this chapter

The example below uses the weekday number to calculate the weekday name:
*/
using System;
class switchStatement
{
    static void Main()
    {
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

    }
}