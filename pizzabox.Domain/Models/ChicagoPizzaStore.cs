using pizzabox.Domain.Abstracts;

namespace pizzabox.Domain.Models
{
   public class ChicagoStore : A_Store
   {
      public ChicagoStore()
      {
         Name = "Chikagi Pizzeria";
      }

      public override string ToString()
      {
         return $"{Name}";
      }
   }

}