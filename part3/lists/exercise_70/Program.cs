<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;

namespace exercise_70
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
     
// assume we have a list that contains integers
int smallest = list[0];

for(int i = 0; i < list.Count; i++) 
{
    int number = list[i];
    if (smallest > number) 
    {
        smallest = number;
    }
}

Console.WriteLine("The smallest number: " + smallest);
      }
    }
  }
}
=======
﻿using System;
using System.Collections.Generic;

namespace exercise_70
{
    internal class Program
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

                // assume we have a list that contains integers

                int greatest = list[0];

                for (int i = 0; i < list.Count; i++)
                {
                    int number = list[i];
                    if (greatest < number)
                    {
                        greatest = number;
                    }
                }

                Console.WriteLine("The Greatest number: " + greatest);
            }
        }
    }
}
>>>>>>> 88973343e8c79c90bd5caa4532095132873f9374
