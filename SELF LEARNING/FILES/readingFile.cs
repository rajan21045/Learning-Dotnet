using System.IO;
class Program
{
    static void Main()
    {
        string content = File.ReadAllText("notes.txt");
        Console.WriteLine(content);
        Console.WriteLine();

        string[] lines = File.ReadAllLines("notes.txt");
        foreach(string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}