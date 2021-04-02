using System.Collections.Generic;
using pizzabox.Domain.Abstracts;
using pizzabox.Domain.Models;

namespace pizzabox.Domain.Singletons
{
   public class StoreSingleton
   {
      private static StoreSingleton _instance;
      public List<A_Store> Stores { get; set; }

      public static StoreSingleton Instance
      {
         get
         {
            if (_instance == null)
               _instance = new StoreSingleton();

            return _instance;
         }
      }

      private StoreSingleton()
      {
         Stores = new List<A_Store>()
         {
            new NewYorkStore(),
            new ChicagoStore()
         };
      }

   }

}