using System;

class Program
{
    static void Main(string[] args)
    { 
      List<string> _options = new List<string>();
        _options.Add("1-To write in journal");
        _options.Add("2-Display Jounal");
        _options.Add("2-Load");
        _options.Add("3-save");
        _options.Add("4-Quit");

      string userOption=("0");
      int v = int.Parse(userOption);
        int optionNumber= v;
      List<string> _userInput = new List<string>();
      while(v!=4){
      foreach(var option in _options){
      Console.WriteLine(option);}
      Console.Write("choose an option to continue");
      userOption=Console.ReadLine();
      
      if (v == 1){
        
        Console.Write("Que fue lo mas lindo de tu dia");
        _userInput.Add(Console.ReadLine());
      }
      else if(v == 2){
        Console.WriteLine($"Esto es lo que escribiste hoy: {_userInput}");
      }
      
      }
      Console.WriteLine("Gracias");
    }
}
