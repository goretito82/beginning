using System;
using System.Collections.Generic;

namespace exercise_77
{
  class Program
  {
    public static void Main(string[] args)
    {
      // You can try your method here if you want
      List<string> strings = new List<string>();
          
        RemoveLast(strings);
             
    }
    public static void RemoveLast(List<string> strings)
    {
      
       strings.Add("First");
       strings.Add("second");
       strings.Add("Third");

       strings.ForEach(Console.WriteLine);

    }
  }
}


