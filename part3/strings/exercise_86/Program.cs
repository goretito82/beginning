using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_86
{
  class Program
  {
    public static void Main(string[] args)
   {  
            while (true)  
            {  
                var str = Console.ReadLine();  
                if (!string.IsNullOrEmpty(str))  
                {  
                    str.Split(' ').ToList().ForEach(x => Console.WriteLine(x));  
                }  
                else  
                {  
                    break;  
                }  
            }  
            Console.ReadKey();  

    }
  }
}
    
