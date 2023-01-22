using System;
//Eduardo Gerez edition program
class Program
{
    static void Main(string[] args)
    {  
        Console.WriteLine("What grade number did you get?");
        string userImput = Console.ReadLine();
        int grade= int.Parse(userImput);
        string letter = "";
        if (grade >= 90 )
           {
            letter="A";
           }
        else if (grade >=80)
            {
            letter = "B" ;  
            }  
        else if (grade >=70)
            {
            letter = "C" ;  
            }  
        else if (grade >=60)
            {
            letter = "D" ;  
            }  
        else 
            {
            letter = "F" ;  
            }  
           
        Console.WriteLine($"you got {letter} grade");

        if (grade >=60)
           {
            Console.WriteLine("congrats, you passed the course");
           }
        else
           {
            Console.WriteLine("You failed passing the course but keep trying and dont give up");
           }
    }
}