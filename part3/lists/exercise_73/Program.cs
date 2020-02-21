<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;

namespace exercise_73
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();
      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == -1)
        {
          break;
        }
        list.Add(input);
      }

    }
  }
}
=======
﻿using System;
using System.Collections.Generic;

namespace exercise_73
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();
      int sum = 0;
      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == -1)
        {
          break;
        }
        list.Add(input);
      
      
        sum += input;
        Console.WriteLine("sum " + sum);
      }
              
    
    }
  }
}
>>>>>>> 88973343e8c79c90bd5caa4532095132873f9374
