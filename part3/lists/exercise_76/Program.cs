<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_76
{
  class Program
  {
   public static void Main(string[] args)
    {
      List<int> numbers = new List<int>();
      int result = Sum(numbers);
      Console.WriteLine("sum of all numbers {0}", Convert.ToString(result));
      
    }
     public static int Sum(List<int> numbers)
     
      {
      
        numbers.Add(3);
        numbers.Add(2);
        numbers.Add(6);
        numbers.Add(-1);
        numbers.Add(5);
        numbers.Add(1);

      return numbers.Sum();
        
    }
  }
}

  

=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace exercise_76
{
  class Program
  {
     
    public static void Main(string[] args)
    {
     List<int> numbers = new List<int>();
     int result = Sum(numbers);
     Console.WriteLine("sum of all numbers {0}", Convert.ToString(result));
    }


   public static int Sum(List<int> numbers) 
    {
        
            numbers.Add(23);  
            numbers.Add(206);  
            numbers.Add(69);  
            numbers.Add(-1);  
            numbers.Add(58); 
            numbers.Add(177);  
            return numbers.Sum();  
    }
 
  }
    }
 



>>>>>>> 88973343e8c79c90bd5caa4532095132873f9374
