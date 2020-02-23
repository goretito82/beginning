using System;

namespace exercise_41
{
  class Program
  {
    public static void Main(string[] args)
    {
            
         int sum = 0;
            while (true)
            {
              //input integer convert it
        

        int intvalue=Convert.ToInt32(Console.ReadLine());

                if (intvalue == 0)
                {
                    break;
                }

                if (intvalue>1)
                {
                    sum=intvalue*2;
                }

                Console.WriteLine(sum);

            }

     }
  }
}
