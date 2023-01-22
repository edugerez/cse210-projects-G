using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator= new Random();
        int magicNumber= randomGenerator.Next(1,100);
        Console.WriteLine("choose form 1 to 10");      
        string userInput= Console.ReadLine();
        int number= int.Parse(userInput);

        while (number!= magicNumber)
        {
             if (number>magicNumber)
                {
                  Console.WriteLine("try lower");
                  userInput=Console.ReadLine();
                }
                  
             else
                {
                  Console.WriteLine("try higer");
                  userInput=Console.ReadLine();
                  
                }
        }
        if (number==magicNumber)
            {
                Console.WriteLine("you did it");

            }
        
    }
}