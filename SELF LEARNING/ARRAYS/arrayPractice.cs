// C# Arrays
// Arrays are used to store multiple values in a single variable, instead of declaring separate variables for each value.

/*
To declare an array, define the variable type with square brackets:
string[] cars;
*/
 
// We have now declared a variable that holds an array of strings.
// To insert values to it, we can use an array literal - place the values in a comma-separated list, inside curly braces:
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
for(int i = 0; i < cars.Length; i++)
{
    Console.Write(cars[i] + " ");
}

Console.WriteLine("\n");
// To create an array of integers, you could write:
int[] myNum = {10, 20, 30, 40};
for(int i = 0; i < myNum.Length; i++)
{
    Console.Write(myNum[i] + " ");
}
Console.WriteLine("\n");

//Access the Elements of an Array
// You can access an array element by referring to the index number. Array indexes start with 0:
Console.WriteLine(cars[0]); // Outputs Volvo

//Change an Array Element
// To change the value of a specific element, refer to the index number:
cars[0] = "Opel";
Console.WriteLine(cars[0]); // Outputs Opel

// Other Ways to Create an Array
string[] cars2 = new string[4];

// Create an array of four elements and add values right away 
string[] cars3 = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};
Console.WriteLine(cars2[0]);