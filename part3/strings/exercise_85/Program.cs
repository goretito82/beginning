using System;
using System.Collections.Generic;

namespace exercise_85
{
  class Program
  {
    public static void Main(string[] args)
    {
    string username = "alex";
    string password = "sunshine";
    string username2 = "emma";
    string password2= "haskell";
    Console.WriteLine("Enter username:");
    string input = Console.ReadLine();
    Console.WriteLine("Enter password:");
    string input2 = Console.ReadLine();

if ((username == input && password == input2) ||(username2==input && password2==input2)) 
        {
             Console.WriteLine("You have successfully logged in!");        
             }
            else
            {
            Console.WriteLine("Incorrect username or password!");
            }
             
               
    }
  }
}

