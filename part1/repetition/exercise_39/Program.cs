using System;

namespace exercise_39
{
  class Program
  {
    public static void Main(string[] args)
    {
          

            int sum = 0;
            //readNumbers = readNumbers + 0;
            while (true)
                {
                Console.WriteLine("Give a number 0 quits");

                int number = Convert.ToInt32(Console.ReadLine());

        

                if (number == 0)
                {
                    break;
                }

                
                    //add numbera
                    sum = number + sum ;
                

                }

                Console.WriteLine("the total sum is " + sum);
        }
  }
}
