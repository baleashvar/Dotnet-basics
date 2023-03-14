using System;

class Program1
{
    static void Main()
    {
        int pizza=200;
        int puff=40;
        int pepsi=120;

        Console.WriteLine("Enter the numer of pizzas bought:");
        double n_pizza=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the numer of puffs bought:");
        double n_puff=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the numer of pepsis bought:");
        double n_pepsi=Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Cost of pizzas:"+(pizza*n_pizza));
        Console.WriteLine("Cost of puffs:"+(puff*n_puff));
        Console.WriteLine("Cost of pepsis:"+(pepsi*n_pepsi));

        double total=((pizza*n_pizza)+(puff*n_puff)+(pepsi*n_pepsi));
        double gst=(12*total/100);
        double cess=(5*total/100);

        Console.WriteLine("Gst 12% :"+gst);
        Console.WriteLine("cess 5% :"+cess);

        Console.WriteLine("Total Price"+total);



    }

}

    
