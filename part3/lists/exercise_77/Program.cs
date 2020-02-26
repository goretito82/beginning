using System;
using System.Collections.Generic;
using System.Linq;
namespace exercise_77
{
  class Program
  {
    public static void Main(string[] args)
    {
     // You can try your method here if you want
       List<string> strings = new List<string>();
       strings.Add("First");
       strings.Add("Second");
       strings.Add("Third");      
          
        RemoveLast(strings);
      strings.ForEach(Console.WriteLine);
      
    }
    
   public static void RemoveLast(List<string> strings)
     {   
      strings.RemoveAt(strings.Count - 1); 

   }
    }
 }