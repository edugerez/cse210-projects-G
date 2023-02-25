using System;

class Program
{
    static void Main(string[] args)
    {
        Entry myentry = new Entry();
        Journal myJournal = new Journal();
        
        List<string> _options = new List<string>();
        _options.Add("1-To write in journal!");
        _options.Add("2-Display your Journal");
        _options.Add("3-Load");
        _options.Add("4-Save");
        _options.Add("5-Quit");
        
        string userOption = "";
        int optionNumber = 0;

        while (optionNumber != 5)
        {   Console.WriteLine();
            foreach (var option in _options)
            {
                
                Console.WriteLine(option);
            }
            Console.Write("choose an option to continue\n");
            userOption = Console.ReadLine();
            optionNumber = int.Parse(userOption);

            if (optionNumber == 1)
            {
                myJournal.addEntry();
            }
            else if (optionNumber == 2)
            {
                myJournal.displayAllEntries();
            }
            else if (optionNumber == 3)
            {
                myJournal.displayEntriesFromFile();
            }
            else if (optionNumber == 4)
            {
                myJournal.saveEntriesToFile();
            }
        }
        Console.WriteLine("Thanks");
    }
}