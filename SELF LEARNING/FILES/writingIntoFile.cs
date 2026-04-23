using System.IO;
class Program
{
    static void Main(string[] args)
    {
        File.WriteAllText("notes.txt", " Hello, I Am Rajan Poudel");
        File.AppendAllText("notes.txt", "\nThis Is note.txt");
    }
}