using System;

class Program1
{
    static void Main()
    {
        Console.WriteLine("Enter your name:");
        string name=Convert.ToString(Console.ReadLine());
        
        Console.WriteLine("Enter your age:");
        int age=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter your country:");
        string country=Convert.ToString(Console.ReadLine());

        Console.WriteLine($"Welcome "+name+". Your age is "+age+" and you are from "+country);

    }
}