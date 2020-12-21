using System;
using System.Collections.Generic;

using System.Linq;


namespace LINQ
{
    class Program
    {
        

        static void Main()
        {
           subscriberrepository __subscriberrepository;
           List<subscriber> __subscribers;
        __subscriberrepository = new subscriberrepository();
         
            __subscribers = __subscriberrepository.Retrieve();
            
           var sub = __subscriberrepository.Find(__subscribers, 2);

        Console.WriteLine($"subscriber: id={2} name={sub.FirstName} {sub.LastName}");


     
        }
        
    }
}
