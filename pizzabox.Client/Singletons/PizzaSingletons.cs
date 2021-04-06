using pizzabox.Domain.Models;
using System.Collections.Generic;
using pizzabox.Domain.Abstracts;

namespace pizzabox.Client.Singletons
{
   public class PizzaSingleton
   {
      private static PizzaSingleton _instance;

      public List<A_Pizza> Pizzas { get; set; }
      public static PizzaSingleton Instance
      {
         get
         {
            if (_instance == null)
               _instance = new PizzaSingleton();

            return _instance;
         }
      }

      private PizzaSingleton()
      {
         Pizzas = new List<A_Pizza>();
      }
   }
}


