<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;

namespace exercise_77
{
  class Program
  {
    public static void Main(string[] args)
    {
      
    //You can try your method here if you want
     
      List<string> strings = new List<string>();
          
        //if (strings.Count > 0)  
      strings.Add ("First");
      strings.Add ("second");
      strings.Add ("Third");
       
    
      RemoveLast(strings);
      strings.ForEach(Console.WriteLine);
      
     }
    public static void RemoveLast(List<string> strings)
   
    {
        strings.RemoveAt(strings.Count - 1); 
       

    }
  }
}


=======
﻿using System;
using System.Collections.Generic;

namespace exercise_77
{
  class Program
  {
    public static void Main(string[] args)
    {
      // You can try your method here if you want
    }

  }
}


>>>>>>> 88973343e8c79c90bd5caa4532095132873f9374
