using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("fractions!");

    Fraction myf = new Fraction();
  
    Console.WriteLine(myf.GetFractionString);
    Console.WriteLine(myf.GetDecimalValue());

    Fraction myf2 = new Fraction(5);

    Console.WriteLine(myf2.GetFractionString);
    Console.WriteLine(myf2.GetDecimalValue());

    Fraction myf3 = new Fraction(5,12);

    Console.WriteLine(myf3.GetFractionString);
    Console.WriteLine(myf3.GetDecimalValue());

    








    }

}