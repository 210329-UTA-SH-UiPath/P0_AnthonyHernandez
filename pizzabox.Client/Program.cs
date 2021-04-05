using System;
using System.Collections.Generic;
using pizzabox.Domain.Abstracts;
using pizzabox.Domain.Models;

namespace pizzabox.Client.Singletons
{
   class Program
   {
      static void Main(string[] args)
      {
         Run();
      }

      private static void Run()
      {
         System.Console.WriteLine("Pizza Mozarella. Pizza Mozarella. Rella Rella Rella");

         var stores = new List<A_Store>()
         {
             new NewYorkStore(),
             new ChicagoStore()
         };

         foreach (var item in stores)
         {
            System.Console.WriteLine(item.Name);
         }
      }
   }
}
