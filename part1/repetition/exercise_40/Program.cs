using System;

namespace exercise_40
{
  class Program
  {
    public static void Main(string[] args)
    {
            int sum = 0;
            int sum2 = 0;
            //readNumbers = readNumbers + 0;
            while (true)
            {
                Console.WriteLine("Give a number 0 quits");

                int number = Convert.ToInt32(Console.ReadLine());



                if (number == 0)
                {
                    break;
                }
                if (number > 1)
                {
                    // Increase the value of numbers by 1
                    sum2 += 1;
                }    
                    //add numbera
                    sum = number + sum;



            }
            //print total sum
            Console.WriteLine("the total sum is " + sum);
            //print total number
            Console.WriteLine("Amount of numbers: " + sum2);

        }
  }
}
