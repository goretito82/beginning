<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;


namespace exercise_63
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();
      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == 0)
        {
          break;
        }

        list.Add(input);
      }
      Console.WriteLine(list[0]);
    }

  }
}
=======
﻿using System;
using System.Collections.Generic;


namespace exercise_63
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();
      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == 0)
        {
          break;
        }

        list.Add(input);
      }
      Console.WriteLine(list[1+2]);
    }

  }
}
>>>>>>> 88973343e8c79c90bd5caa4532095132873f9374
