using System;

class program2{

public static void Main1(string[] args){

        string sentence , reverse="" ;
        Console.WriteLine("Enter a string");
        sentence=Console.ReadLine();

        string [] temp=sentence.Split();


        for(int i=temp.Length-1;i >=0;i--)
        {
            reverse+=temp[i]+" ";
        }
        Console.WriteLine(reverse);
                
    }
}