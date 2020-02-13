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