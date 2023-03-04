using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the memorizer scripture!");

        List<string> _options = new List<string>();
        _options.Add("1-List of scripture already memorized");
        _options.Add("2-practice mermorizing");
        _options.Add("3-quit");
       
        string userOption = "";
        int optionNumber = 0;

        while (optionNumber !=3){
            Console.WriteLine();
            foreach(var option in _options){
                Console.WriteLine(option);
            }
            Console.WriteLine();
            Console.Write("choose an option to continue");
            userOption=Console.ReadLine();
            optionNumber= int.Parse(userOption);
            if (optionNumber==1){
                Console.WriteLine("your has choosen option 1");}
            else if (optionNumber==2){
                Console.WriteLine("you choosed option 2");}
            else{
                Console.WriteLine("you quited");
            }
            }
            }
    
    }
