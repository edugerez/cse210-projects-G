using System;


class Entry
{
    private List<string> promptList;
    public string journalInput;
    private Random random;
    public DateTime currentDate;
    public string randomQuestion;

    public Entry()
    {
        promptList = new List<string>();
        random = new Random();
       

        promptList.Add("Who was the most interesting person I interacted with today?");
        promptList.Add("What was the best part of my day?");
        promptList.Add("How did I see the hand of the Lord in my life today?");
        promptList.Add("What was the strongest emotion I felt today?");
        promptList.Add("If I had one thing I could do over today, what would it be?");
        promptList.Add("Something for which you feel grateful today?");
       
    }

    public void DisplayQuestion()
    {
        randomQuestion = promptList[random.Next(5)];
        Console.WriteLine(randomQuestion);
        journalInput = Console.ReadLine();
        currentDate = DateTime.Now;
    }

    
}



   