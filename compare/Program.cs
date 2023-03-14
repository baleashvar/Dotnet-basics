using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the Value for x");
        int x=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Value for y");
        int y=Convert.ToInt32(Console.ReadLine());

        bool result;
        result=x<y;
        Console.WriteLine($"The result of weather Xis less than y is "+result);
    }
}