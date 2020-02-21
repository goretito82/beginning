<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;

namespace exercise_71
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

namespace exercise_71
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
            Console.WriteLine("Search for");
            int search = Convert.ToInt32(Console.ReadLine());

           
            int index = list.IndexOf(search);

            Console.WriteLine("is at index " + index);
        }
  }
}
>>>>>>> 88973343e8c79c90bd5caa4532095132873f9374
