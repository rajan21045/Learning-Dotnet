//making an enumerator 'month'
enum month
{
    //following are the data members
    Jan,
    Feb,
    Mar,
    Apr,
    May
}

class Program
{
    //Main Method
    static void Main(string[] args)
    {
        //getting the integer values of data members..
        Console.WriteLine("The Value of Jan In month" + " enum is "+ (int)month.Jan);
        Console.WriteLine("The Value of Feb In month" + " enum is "+ (int)month.Feb);
        Console.WriteLine("The Value of Mar In month" + " enum is "+ (int)month.Mar);
        Console.WriteLine("The Value of Apr In month" + " enum is "+ (int)month.Apr);
        Console.WriteLine("The Value of May In month" + " enum is "+ (int)month.May);
    }
}