using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_74
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        list.Add(input);
      
      }
    Console.WriteLine("Search for " );
    string look = Convert.ToString(Console.ReadLine());  
    var found = list.Contains(look, StringComparer.OrdinalIgnoreCase); 
    Console.WriteLine(found ? "found " + look : "Not found");  
    
    
    }
  }
}

