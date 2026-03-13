using System;
class ArrayQuestionPractice
{
    static void Main()
    {
        //Basic Array Practice (Beginner)
        // 1. Create an array of 5 integers and print all elements using a for loop.
        var num = new[] { 1, 2, 3, 4, 5, 6 };
        for (int i = 0; i < num.Length; i++)
        {
            Console.Write(num[i] + " ");
        }

        // 2. Create an array and calculate the sum of all elements.
        Console.WriteLine();
        var num2 = new[] { 7, 2, 5, 1, 6, 21 };
        int sum = 0;
        for(int j=0; j<num2.Length; j++)
        {
            sum+=num2[j];
        }
        Console.WriteLine("The Sum of Array Is: {0}", sum);

        // 3. Find the largest number in an array.
        Console.WriteLine();
        int maxNum1 = num2[0];
        for(int k= 1; k<num2.Length; k++)
        {
            if (num2[k]> maxNum1)
            {
                maxNum1 = num2[k];   
            }
        }
        Console.WriteLine("The Largest Element In num2 (using loop) Is {0}.", maxNum1);

        // 4. Find the smallest number in an array.
        Console.WriteLine();
        int minNum = num2[0];
        for(int l= 0; l<num2.Length; l++)
        {
            if (minNum > num2[l])
            {
                minNum = num2[l];   
            }
        }
        Console.WriteLine("The Smallest Element In num2 (using loop) Is {0}.", minNum);

        //5. Count the total number of elements in an array.
        Console.WriteLine();
        int count = num.Length;
        int count1 = num2.Length;
        Console.WriteLine("The Total Number of Element in array named \'num\' Is: "+ count);
        Console.WriteLine("The Total Number of Element in array named \'num2\' Is: "+ count1);

        //6. Reverse the elements of an array.
        Console.WriteLine();
        Array.Reverse(num);
        for (int m = 0; m < num.Length; m++)
        {
            Console.Write(num[m] + " ");
        }


        // Intermediate Array Questions
        // 7. Take 5 numbers from the user and store them in an array, then print them.
        Console.WriteLine();
        int[] userNum = new int[5];
        for (int n = 0; n < userNum.Length; n++)
        {
            Console.Write("Enter a number: ");
            userNum[n] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("The numbers you entered are:");
        for (int o = 0; o < userNum.Length; o++)
        {
            Console.Write(userNum[o] + " ");
        }

        // 8. Count even and odd numbers in an array.
        Console.WriteLine();
        int evenCount = 0;
        int oddCount = 0;
        for (int p = 0; p < userNum.Length; p++)
        {
            if (userNum[p] % 2 == 0)
            {
                evenCount++;
            }
            else
            {
                oddCount++;
            }
        }
        Console.WriteLine("Even numbers count: " + evenCount);
        Console.WriteLine("Odd numbers count: " + oddCount);

        // 9. Calculate the average of array elements.
        Console.WriteLine();
        int total = 0;
        for (int q = 0; q < userNum.Length; q++)
        {
            total += userNum[q];
        }
        double average = (double)total / userNum.Length;
        Console.WriteLine("The Average of the numbers you entered is: " + average);

        // 10. Copy elements from one array to another array.
        Console.WriteLine();
        int[] copyArray = new int[userNum.Length];
        for (int r = 0; r < userNum.Length; r++)
        {
            copyArray[r] = userNum[r];
        }
        // 11. Sort an array in ascending order.
        Array.Sort(userNum);
        Console.WriteLine("The numbers you entered, sorted in ascending order, are:");
        for (int s = 0; s < userNum.Length; s++)
        {
            Console.Write(userNum[s] + " ");
        }

        // 12. Sort an array in descending order.
        Array.Sort(userNum);
        Array.Reverse(userNum);
        Console.WriteLine("\nThe numbers you entered, sorted in descending order, are:");
        for (int t = 0; t < userNum.Length; t++)
        {
            Console.Write(userNum[t] + " ");
        }

        // 2D Array Practice (Multidimensional)
        // 13. Create a 2×3 array and print all elements.
        int[,] numArray = { { 1, 2, 3 }, { 4, 5, 6 } };
        Console.WriteLine();
        for (int u = 0; u < numArray.GetLength(0); u++)
        {
            for (int v = 0; v < numArray.GetLength(1); v++)
            {
                Console.Write(numArray[u, v] + " ");
            }
            Console.WriteLine();
        }
    }
}