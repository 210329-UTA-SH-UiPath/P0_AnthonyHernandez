using System.Collections.Generic;
using pizzabox.Domain.Abstracts;
using pizzabox.Domain.Models;
using pizzabox.Storing.Repositories;

namespace pizzabox.Client.Singletons
{
   public class StoreSingleton
   {
      private static StoreSingleton _instance;
      private static readonly FileRepository fr = new FileRepository();
      private const string _path = @"store.xml";
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
         Stores = fr.ReadFromFile<A_Store>(_path);
      }

   }

}