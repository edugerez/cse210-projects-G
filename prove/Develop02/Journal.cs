using System;
using System.Collections.Generic;
using System.IO; 



class Journal
{
    private List<string> entries = new List<string>();
    public string fileName;
    public string file;
    
 public void addEntry()
    {
    Entry myEntry= new Entry();

    myEntry.DisplayQuestion();
    entries.Add($"{myEntry.randomQuestion}\n{myEntry.currentDate}: {myEntry.journalInput}");
    
      }

    

    public void displayAllEntries(){
        foreach (string write in entries)
        {
            Console.WriteLine(write);
            
        }
        
    }

    public void saveEntriesToFile(){
        Console.Write("Write the name of the file to save the entries");
        fileName=Console.ReadLine();
        
            using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (string write in entries)
            {
                outputFile.WriteLine(write);
            }
        }
    }

    public void displayEntriesFromFile(){

        Console.Write("Write the name of the file you want to read");
        file=Console.ReadLine();
       
        string[] lines = System.IO.File.ReadAllLines(file);

             foreach (string line in lines)
             {
               Console.WriteLine(line);
             }
    }

}
