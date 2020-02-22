<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;

namespace exercise_66
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

    }
  }
}
=======
﻿using System;
using System.Collections.Generic;

namespace exercise_66
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

                 Console.WriteLine(list[list.Count - 1]);
                 break;
                }
                list.Add(input);
            }
    }
  }
}
>>>>>>> 88973343e8c79c90bd5caa4532095132873f9374
